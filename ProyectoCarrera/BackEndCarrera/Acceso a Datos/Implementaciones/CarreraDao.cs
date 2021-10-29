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
    }
}

