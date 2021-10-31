using BackEndCarrera.Acceso_a_Datos.Interfaces;
using BackEndCarrera.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndCarrera.Acceso_a_Datos.Implementaciones
{
    class CarreraDao : ICarreraDao
    {
        public Carrera GetCarrerasById()
        {
            Carrera oCarrera = new Carrera();
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-K8CN8ON;Initial Catalog=carreras;Integrated Security=True");


            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_READ_CARRERAS_BY_ID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;



            SqlDataReader reader = cmd.ExecuteReader();
            bool esPrimerRegistro = true;

            while (reader.Read())
            {
                if (esPrimerRegistro)
                {
                    //solo para el primer resultado recuperamos los datos del MAESTRO:
                    oCarrera.Nombre = reader["nombre_carrera"].ToString();
                    oCarrera.Titulo = (reader["titulo_carrera"].ToString());
                    oCarrera.AnioMaximo = Convert.ToInt32(reader["anio_maximo"].ToString());
                    oCarrera.IdCarrera = Convert.ToInt32(reader["id_carrera"].ToString());
                    esPrimerRegistro = false;
                }


                DetalleCarrera oDetalle = new DetalleCarrera();
                oDetalle.IdDetalle = Convert.ToInt32(reader["id_detalle"].ToString());
                oDetalle.AnioDeCursado = Convert.ToInt32(reader["anio_cursado"].ToString());
                oDetalle.Cuatrimestre = (reader["cuatrimestre"].ToString());
                oDetalle.Materia.IdAsignatura = Convert.ToInt32(reader["id_asignatura"].ToString());
                oDetalle.Materia.Nombre = (reader["nombre_asignatura"].ToString());
                oCarrera.AgregarDetalle(oDetalle);
            }

            cnn.Close();
            return oCarrera;

        }
        public bool Save(Carrera oCarrera)
        {
            SqlTransaction transaction = null;
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-K8CN8ON;Initial Catalog=carreras;Integrated Security=True");


            bool flag = true;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();

                //MAESTRO CARRERA
                SqlCommand cmd = new SqlCommand("SP_CREATE_CARRERAS", cnn, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oCarrera.Nombre);
                cmd.Parameters.AddWithValue("@nombre_titulo", oCarrera.Titulo);
                cmd.Parameters.AddWithValue("@anio_maximo", oCarrera.AnioMaximo);
                cmd.Parameters.AddWithValue("@id_carrera", oCarrera.IdCarrera);

                cmd.ExecuteNonQuery();


                //DETALLE CARRERA

                foreach (DetalleCarrera item in oCarrera.Detalles)
                {
                    SqlCommand comandoDetalle = new SqlCommand();
                    comandoDetalle.Connection = cnn;
                    comandoDetalle.Transaction = transaction;
                    comandoDetalle.CommandText = "SP_CREATE_DETALLES";
                    comandoDetalle.CommandType = CommandType.StoredProcedure;
                    comandoDetalle.Parameters.AddWithValue("@id_carrera", oCarrera.IdCarrera);
                    comandoDetalle.Parameters.AddWithValue("@anio_cursado", item.AnioDeCursado);
                    comandoDetalle.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
                    comandoDetalle.Parameters.AddWithValue("@id_asignatura", item.Materia.IdAsignatura);
                    comandoDetalle.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                flag = false;
                throw e;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return flag;
        }

        List<Asignatura> GetAsignaturas()
        {
            List<Asignatura> lst = new List<Asignatura>();
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-K8CN8ON;Initial Catalog=carreras;Integrated Security=True");
                      
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

        bool UpdateCarreras(Carrera oCarrera)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-K8CN8ON;Initial Catalog=carreras;Integrated Security=True");
            SqlTransaction transaction = null;

            bool flag = true;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_CARRERAS",cnn);

                //MAESTRO CARRERA
                cmd.Parameters.AddWithValue("id_carrera", oCarrera.IdCarrera);
                cmd.Parameters.AddWithValue("nombre_carrera", oCarrera.Nombre);
                cmd.Parameters.AddWithValue("titulo_carrera", oCarrera.Titulo);
                cmd.Parameters.AddWithValue("anio_maximo", oCarrera.AnioMaximo);
                cmd.ExecuteNonQuery();



                foreach (DetalleCarrera item in oCarrera.Detalles)
                {
                    SqlCommand comandoDetalle = new SqlCommand();
                    comandoDetalle.Connection = cnn;
                    comandoDetalle.Transaction = transaction;
                    comandoDetalle.CommandText = "SP_UPDATE_DETALLES";
                    comandoDetalle.CommandType = CommandType.StoredProcedure;
                    comandoDetalle.Parameters.AddWithValue("@id_detalle", item.IdDetalle);
                    comandoDetalle.Parameters.AddWithValue("@anio_cursado", item.AnioDeCursado);
                    comandoDetalle.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
                    comandoDetalle.Parameters.AddWithValue("@id_asignatura", item.Materia.IdAsignatura);
                    comandoDetalle.ExecuteNonQuery();
                }

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

        bool DeleteCarreras(Carrera oCarrera)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-K8CN8ON;Initial Catalog=carreras;Integrated Security=True");
            SqlTransaction transaction = null;

            SqlCommand cmd = new SqlCommand("SP_DELETE_DETALLES_BY_CARRERA", cnn, transaction);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommand cmdCarrera = new SqlCommand("SP_DELETE_CARRERAS", cnn, transaction);
            cmdCarrera.CommandType = CommandType.StoredProcedure;

            bool flag = true;
            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                cmd.Parameters.AddWithValue("id_carrera", oCarrera.IdCarrera);
                cmd.ExecuteNonQuery();
                cmdCarrera.Parameters.AddWithValue("id_carrera",oCarrera.IdCarrera);
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


    }
}

