using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.AccesoDatos.Interfaces;
using Backend.Dominio;
using System.Data;
using System.Data.SqlClient;

namespace Backend.AccesoDatos.Implementaciones
{
    class CarreraDao : ICarreraDao
    {

        private static CarreraDao Instancia;
        private static readonly string cadena = @"Data Source=.\SQLEXPRESS;Initial Catalog=carreras;Integrated Security=True";
        private CarreraDao()
        {
        }

        public static CarreraDao GetInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new CarreraDao();
            }
            return Instancia;
        }
        public bool DeleteCarreras(int id)
        {
            SqlConnection cnn = new SqlConnection(cadena);
            SqlTransaction transaction = null;

            Carrera oCarrera = new Carrera();
            oCarrera = GetCarrerasById(id);

            bool flag = true;
            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();

                if (oCarrera.Detalles.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand("SP_DELETE_DETALLES_BY_CARRERA", cnn, transaction);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_carrera", oCarrera.IdCarrera);
                    cmd.ExecuteNonQuery();
                }

                SqlCommand cmdCarrera = new SqlCommand("SP_DELETE_CARRERAS", cnn, transaction);
                cmdCarrera.CommandType = CommandType.StoredProcedure;
                cmdCarrera.Parameters.AddWithValue("@id_carrera", oCarrera.IdCarrera);
                cmdCarrera.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                flag = false;
                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }

        public bool DeleteDetalle(int id)
        {
            SqlConnection cnn = new SqlConnection(cadena);
            SqlTransaction transaction = null;
            bool flag = true;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();

                SqlCommand cmd = new SqlCommand("SP_DELETE_DETALLES", cnn, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id_detalle", id);
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
            {
                flag = false;
                transaction.Rollback();
                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flag;
        }

        public List<Asignatura> GetAsignaturas()
        {
            List<Asignatura> lst = new List<Asignatura>();
            SqlConnection cnn = new SqlConnection(cadena);

            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_READ_ASIGNATURAS", cnn);
            DataTable tabla = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            foreach (DataRow row in tabla.Rows)
            {
                Asignatura oAsignatura = new Asignatura();
                oAsignatura.IdAsignatura = Convert.ToInt32(row["id_asignatura"].ToString());
                oAsignatura.Nombre = (row["nombre_asignatura"].ToString());
                lst.Add(oAsignatura);
            }

            return lst;
        }

        public Carrera GetCarrerasById(int id)
        {
            Carrera oCarrera = new Carrera();
            SqlConnection cnn = new SqlConnection(cadena);


            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_READ_CARRERAS_BY_ID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_carrera", id);

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            bool esPrimerRegistro = true;

            foreach(DataRow row in tabla.Rows)
            {
                if (esPrimerRegistro)
                {
                    //solo para el primer resultado recuperamos los datos del MAESTRO:
                    oCarrera.Nombre = row["nombre_carrera"].ToString();
                    oCarrera.Titulo = (row["titulo_carrera"].ToString());
                    oCarrera.AnioMaximo = Convert.ToInt32(row["anio_maximo"].ToString());
                    oCarrera.IdCarrera = Convert.ToInt32(row["id_carrera"].ToString());
                    esPrimerRegistro = false;
                }

                DetalleCarrera oDetalle = new DetalleCarrera();

                object value = row["id_detalle"];
                if (value != DBNull.Value)
                { 
                    oDetalle.IdDetalle = Convert.ToInt32(row["id_detalle"].ToString());
                    oDetalle.AnioDeCursado = Convert.ToInt32(row["anio_cursado"].ToString());
                    oDetalle.Cuatrimestre = (row["cuatrimestre"].ToString());
                    oDetalle.Materia.IdAsignatura = Convert.ToInt32(row["id_asignatura"].ToString());
                    oDetalle.Materia.Nombre = (row["nombre_asignatura"].ToString());
                    oCarrera.AgregarDetalle(oDetalle);
                }

            }

            cnn.Close();
            return oCarrera;
        }

        public bool SaveCarrera(Carrera oCarrera)
        {
            SqlTransaction transaction = null;
            SqlConnection cnn = new SqlConnection(cadena);

            cnn.Open();
            SqlCommand cmdId = new SqlCommand("SP_PROXIMO_ID",cnn); 
            cmdId.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@next";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;
             
            cmdId.Parameters.Add(param);
            cmdId.ExecuteNonQuery();
            cnn.Close();

            bool flag = true;
            int id_carrera = (int)param.Value;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                //MAESTRO CARRERA
                SqlCommand cmd = new SqlCommand("SP_CREATE_CARRERAS", cnn, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oCarrera.Nombre);
                cmd.Parameters.AddWithValue("@titulo", oCarrera.Titulo);
                cmd.Parameters.AddWithValue("@anio_maximo", oCarrera.AnioMaximo);

                cmd.ExecuteNonQuery();

                //DETALLE CARRERA
                
                foreach (DetalleCarrera item in oCarrera.Detalles)
                {
                    SqlCommand comandoDetalle = new SqlCommand();
                    comandoDetalle.Connection = cnn;
                    comandoDetalle.Transaction = transaction;
                    comandoDetalle.CommandText = "SP_CREATE_DETALLES";
                    comandoDetalle.CommandType = CommandType.StoredProcedure;
                    comandoDetalle.Parameters.AddWithValue("@id_carrera", id_carrera);
                    comandoDetalle.Parameters.AddWithValue("@anio_cursado", item.AnioDeCursado);
                    comandoDetalle.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
                    comandoDetalle.Parameters.AddWithValue("@id_asignatura", item.Materia.IdAsignatura);
                    comandoDetalle.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                flag = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }

        public bool UpdateCarreras(Carrera oCarrera)
        {
            SqlConnection cnn = new SqlConnection(cadena);
            SqlTransaction transaction = null;

            bool flag = true;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_CARRERAS", cnn, transaction);

                //MAESTRO CARRERA
                cmd.Parameters.AddWithValue("@id_carrera", oCarrera.IdCarrera);
                cmd.Parameters.AddWithValue("@nombre", oCarrera.Nombre);
                cmd.Parameters.AddWithValue("@titulo", oCarrera.Titulo);
                cmd.Parameters.AddWithValue("@anio_maximo", oCarrera.AnioMaximo);
                cmd.ExecuteNonQuery();

                //foreach (DetalleCarrera item in oCarrera.Detalles)
                //{
                //    SqlCommand comandoDetalle = new SqlCommand();
                //    comandoDetalle.Connection = cnn;
                //    comandoDetalle.Transaction = transaction;
                //    comandoDetalle.CommandText = "SP_UPDATE_DETALLES";
                //    comandoDetalle.CommandType = CommandType.StoredProcedure;
                //    comandoDetalle.Parameters.AddWithValue("@id_detalle", item.IdDetalle);
                //    comandoDetalle.Parameters.AddWithValue("@anio_cursado", item.AnioDeCursado);
                //    comandoDetalle.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
                //    comandoDetalle.Parameters.AddWithValue("@id_asignatura", item.Materia.IdAsignatura);
                //    comandoDetalle.ExecuteNonQuery();
                //}

                transaction.Commit();
            }
            catch (Exception)
            {
                flag = false;
                transaction.Rollback();
                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }

        public bool SaveAsignatura(Asignatura oAsignatura)
        {
            SqlConnection cnn = new SqlConnection(cadena);
            SqlTransaction transaction = null;
            bool flag = true;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_CREATE_ASIGNATURAS", cnn, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oAsignatura.Nombre);
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }
        public bool UpdateAsignatura(Asignatura oAsignatura)
        {
            SqlConnection cnn = new SqlConnection(cadena);
            SqlTransaction transaction = null;
            bool flag = true;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_ASIGNATURAS", cnn, transaction);
                transaction = cnn.BeginTransaction();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_asignatura", oAsignatura.IdAsignatura);
                cmd.Parameters.AddWithValue("@nombre_asignatura", oAsignatura.Nombre);
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                flag = false;
                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flag;
        }
        public List<Carrera> GetCarreras()
        {
            List<Carrera> lst = new List<Carrera>();
            SqlConnection cnn = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand("SP_READ_CARRERAS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cnn.Open();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            foreach (DataRow row in tabla.Rows)
            {
                Carrera oCarrera = new Carrera();
                oCarrera.AnioMaximo = Convert.ToInt32(row["anio_maximo"].ToString());
                oCarrera.IdCarrera = Convert.ToInt32(row["id_carrera"].ToString());
                oCarrera.Nombre = row["nombre_carrera"].ToString();
                oCarrera.Titulo = row["titulo_carrera"].ToString();

                lst.Add(oCarrera);
            }
            return lst;
        }

        public bool DeleteAsignatura(int id)
        {
            SqlConnection cnn = new SqlConnection(cadena);
            SqlTransaction transaction = null;
            SqlCommand cmd = new SqlCommand("SP_DELETE_ASIGNATURAS", cnn, transaction);
            cmd.CommandType = CommandType.StoredProcedure;

            bool flag = true;
            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                cmd.Parameters.AddWithValue("id_asignatura", id);
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                flag = false;
                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }

        public bool LoginIn(Credenciales oCredenciales)
        {
            SqlConnection cnn = new SqlConnection(cadena);
            DataTable tabla = new DataTable();
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_LOGIN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom_usuario", oCredenciales.Usuario);
                cmd.Parameters.AddWithValue("contrasenia", oCredenciales.Password);                
                tabla.Load(cmd.ExecuteReader());
                if(tabla.Rows.Count==0||tabla==null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception)
            {              
                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
    }
}
