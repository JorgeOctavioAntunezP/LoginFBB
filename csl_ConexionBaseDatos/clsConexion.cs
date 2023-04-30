using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csl_ConexionBaseDatos
{
    public class clsConexion
    {
        public string conexion = "server=DESKTOP-ID4NAM3\\SQLEXPRESS; initial catalog=empresa;integrated security=true";

        // Agregar Valores
        public int AgregarDatos(string userName, string password, string name, string firstName, string lastName,
            byte age, DateTime birthdate, string phoneNumber)
        {
            SqlConnection cnn = new SqlConnection(conexion);

            cnn.Open();

            string query = "insert into usuario values(@userName_user, @password_user, @name_user, @firstName_user," +
                " @lastName_user, @age_user, @birthdate_user, @phoneNumber_user)";

            SqlCommand comando = new SqlCommand(query, cnn);

            comando.Parameters.AddWithValue("@userName_user", userName);
            comando.Parameters.AddWithValue("@password_user", password);

            comando.Parameters.AddWithValue("@name_user", name);
            comando.Parameters.AddWithValue("@firstName_user", firstName);
            comando.Parameters.AddWithValue("@lastName_user", lastName);
            comando.Parameters.AddWithValue("@age_user", age);
            comando.Parameters.AddWithValue("@birthdate_user", birthdate);
            comando.Parameters.AddWithValue("@phoneNumber_user", phoneNumber);

            int valor = comando.ExecuteNonQuery();

            cnn.Close();

            return valor;
        }

        public int Login(string userName, string password)
        {
            SqlConnection cnn = new SqlConnection(conexion);

            try
            {
                cnn.Open();

                SqlCommand comando = new SqlCommand("spLogin", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@userName", userName);
                comando.Parameters.AddWithValue("@password", password);

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                cnn.Close();
            }
            return -1;
        }
    }
}