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
        public List<DetalleCarrera> GetCarreras()
        {
            List<DetalleCarrera> lst = new List<DetalleCarrera>();
            //DetalleCarrera oDetalle;
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-K8CN8ON;Initial Catalog=carreras;Integrated Security=True");


            cnn.Open();
            SqlCommand cmd = new SqlCommand("NOMBRE DEL SP", cnn);
            DataTable tabla = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            foreach (DataRow row in tabla.Rows)
            {
                //oDetalle = new DetalleCarrera();
                //oDetalle.AnioDeCursado = Convert.ToInt32(row["anio_cursado"].ToString());
                //oDetalle.Cuatrimestre = (row["cuatrimestre"].ToString());

                //lst.Add(oDetalle);

            }
            return lst;
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
                    comandoDetalle.Parameters.AddWithValue("@id_asignatura",item.Materia.IdAsignatura);
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
