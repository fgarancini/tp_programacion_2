using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
namespace ServerDAO
{
    public class SqlServer
    {
        private SqlConnection conexionABase;

        string connectionString;
        public SqlServer()
        {
            this.connectionString = "Data Source=.\\SQLEXPRESS;Database=ServerTp4;Trusted_Connection=True;";
            this.conexionABase = new SqlConnection(connectionString);
        }
        /// <summary>
        /// La insercion de datos en sql
        /// </summary>
        /// <param name="server"></param>
        /// <param name="usuario"></param>
        /// <param name="personaje"></param>
        public void InsertarDatos(Server server,Usuario usuario,Personaje personaje)
        {
            string command = "INSERT INTO ServerInfo(NombreServer,FechaCreacion) VALUES(@nombreServer,@fechaCreacion) INSERT INTO Usuarios(Usuario,Password) VALUES(@usuario, @password) INSERT INTO Personajes(Nombre,Clase,Reino,Nivel,Descripcion) VALUES(@nombre, @clase, @reino, @nivel, @descripcion)";
            try
            {
                using (SqlCommand sql = new SqlCommand(command,this.conexionABase))
                {
                    if (!object.ReferenceEquals(personaje,null))
                    {
                        sql.Parameters.AddWithValue("@nombreServer", server.Nombre);
                        sql.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                        sql.Parameters.AddWithValue("@usuario", usuario.Nombre);
                        sql.Parameters.AddWithValue("@password", usuario.Password);
                        sql.Parameters.AddWithValue("@nombre", personaje.Nombre);
                        sql.Parameters.AddWithValue("@nivel", personaje.Nivel);
                        sql.Parameters.AddWithValue("@clase", personaje.Clase.ToString());
                        sql.Parameters.AddWithValue("@reino", personaje.Reino.ToString());

                        if(!object.ReferenceEquals(personaje.JefesMuertos,null))
                        {
                            sql.Parameters.AddWithValue("@descripcion", personaje.JefesMuertos);
                        }
                        else
                        {
                            sql.Parameters.AddWithValue("@descripcion", "None");
                        }

                        this.conexionABase.Open();
                        sql.ExecuteNonQuery(); 
                    }
                }
            }
            catch(ErrorAlConectarException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (this.conexionABase != null && this.conexionABase.State == System.Data.ConnectionState.Open)
                {
                    this.conexionABase.Close();
                }
            }
        }
        public void EliminarPersonaje(string nombre)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
                {
                    sqlConnection.Open();
                    string command = $"DELETE FROM Personajes WHERE Nombre='{nombre}' ";
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (ErrorAlConectarException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public List<Personaje> Listar()
        {

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
                {
                    sqlConnection.Open();
                    string command = "SELECT * FROM Personajes";
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);


                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    List<Personaje> personajes = new List<Personaje>();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            Amazona Amazona;
                            Asesina Asesina;
                            Barbaro Barbaro;
                            Hechicera Hechicera;
                            Druida Druida;
                            Paladin Paladin;
                            Nigromante Nigromante;

                            string nombre = (string)reader["Nombre"];
                            int nivel = (int)reader["Nivel"];
                            Enum.TryParse<Personaje.EClase>((string)reader["Clase"], out Personaje.EClase clase);
                            Enum.TryParse<Personaje.EReino>((string)reader["Reino"], out Personaje.EReino reino);
                            string descripcion = (string)reader["Descripcion"];
                            switch (clase)
                            {
                                case Personaje.EClase.Amazona:
                                    Amazona = new Amazona(nivel, nombre, reino);
                                    Amazona.JefesMuertos = descripcion;
                                    personajes.Add(Amazona);
                                    break;
                                case Personaje.EClase.Asesina:
                                    Asesina = new Asesina(nivel, nombre, reino);
                                    Asesina.JefesMuertos = descripcion;
                                    personajes.Add(Asesina);
                                    break;
                                case Personaje.EClase.Barbaro:
                                    Barbaro = new Barbaro(nivel, nombre, reino);
                                    Barbaro.JefesMuertos = descripcion;
                                    personajes.Add(Barbaro);
                                    break;
                                case Personaje.EClase.Druida:
                                    Druida = new Druida(nivel, nombre, reino);
                                    Druida.JefesMuertos = descripcion;
                                    personajes.Add(Druida);
                                    break;
                                case Personaje.EClase.Hechicera:
                                    Hechicera = new Hechicera(nivel, nombre, reino);
                                    Hechicera.JefesMuertos = descripcion;
                                    personajes.Add(Hechicera);
                                    break;
                                case Personaje.EClase.Paladin:
                                    Paladin = new Paladin(nivel, nombre, reino);
                                    Paladin.JefesMuertos = descripcion;
                                    personajes.Add(Paladin);
                                    break;
                                case Personaje.EClase.Nigromante:
                                    Nigromante = new Nigromante(nivel, nombre, reino);
                                    Nigromante.JefesMuertos = descripcion;
                                    personajes.Add(Nigromante);
                                    break;
                            }
                        }
                    }
                    sqlConnection.Close();
                    return personajes;
                }
            }
            catch (ErrorAlConectarException ex)
            {

                throw new ErrorAlConectarException(ex);
            }

        }
    }
}
