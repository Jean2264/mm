using E_9.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace E_9.DAL
{
    public class Consultas
    {

        public void Alta(Props Colum)
        {
            string consulta = @"Insert into Alumno(DNI, Apellido, Nombre, Edad, EsRegular, Mail, Telefono) values (@DNI, @Apellido, @Nombre, @Edad, @EsRegular, @Mail, @Telefono)";

            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@DNI", Colum.DNI);
                    cmd.Parameters.AddWithValue("@Apellido", Colum.Apellido);
                    cmd.Parameters.AddWithValue("@Nombre", Colum.Nombre);
                    cmd.Parameters.AddWithValue("@Edad", Colum.Edad);
                    cmd.Parameters.AddWithValue("@EsRegular", Colum.Condicion);
                    cmd.Parameters.AddWithValue("@Mail", Colum.Mail);
                    cmd.Parameters.AddWithValue("@Telefono", Colum.Telefono);

                    cmd.ExecuteNonQuery();

                }
            }

        }

        public void Modi(Props Colum)
        {
            string consulta = @"UPDATE Alumno SET  EsRegular=@EsRegular, Mail=@Mail, Telefono=@Telefono WHERE DNI=@DNI AND Estado=1";

            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@DNI", Colum.DNI);
                    cmd.Parameters.AddWithValue("@EsRegular", Colum.Condicion);
                    cmd.Parameters.AddWithValue("@Mail", Colum.Mail);
                    cmd.Parameters.AddWithValue("@Telefono", Colum.Telefono);

                    cmd.ExecuteNonQuery();

                }
            }

        }

        public void Baja(string dni)
        {
            string consulta = @"UPDATE Alumno SET  Estado=0 WHERE DNI=@DNI";

            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni);

                    cmd.ExecuteNonQuery();

                }
            }

        }

        public PagedResult<Props> Cargar(int pagina, int limite)
        {

            if (pagina < 1) pagina = 1;
            if (pagina <= 0) pagina = 10;
            int Total = 0;
            int offset = (pagina - 1) * limite;
            var list = new List<Props>();

            using (SqlConnection con = new SqlConnection(Decla.ConnectionString))
            {
                con.Open();
                //total
                string queryTotal = "SELECT COUNT(IdAlumno) FROM Alumno WHERE Estado=1";

                using (SqlCommand cmd = new SqlCommand(queryTotal, con))
                {
                    Total = (int)cmd.ExecuteScalar();
                }

                /* string queryData = @"select  DNI, Apellido, Nombre,
                                   Telefono, Mail, Sector from Empleado
                                    where Estado=1 ORDER BY Apellido OFFSET 
                                      @offset ROWS FETCH NEXT @limite ROWS ONLY";*/

                //data
                string queryData = @"SELECT DNI, Apellido, Nombre, Edad, EsRegular, Mail, Telefono FROM Alumno Where Estado=1 
                                    ORDER BY Apellido 
                                    OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";

                using (SqlCommand cmd = new SqlCommand(queryData, con))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Props
                            {
                                DNI = reader["DNI"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Edad = Convert.ToInt32(reader["Edad"]),
                                Condicion = reader["EsRegular"].ToString(),
                                Mail = reader["Mail"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                            });
                        }
                    }
                }
            }
            return new PagedResult<Props>
            {
                Data = list,
                Total = Total
            };
        }

        public PagedResult<Props> CargarFiltro(int pagina, int limite, string filtro)
        {

            if (pagina < 1) pagina = 1;
            if (pagina <= 0) pagina = 10;
            int Total = 0;
            int offset = (pagina - 1) * limite;
            var list = new List<Props>();

            using (SqlConnection con = new SqlConnection(Decla.ConnectionString))
            {
                con.Open();
                //total
                string queryTotal = @"SELECT COUNT(IdAlumno) FROM Alumno WHERE 
                                        (Apellido LIKE @filtro OR Nombre LIKE @filtro OR DNI LIKE @filtro OR EsRegular LIKe @filtro)
                                            AND Estado=1 ";

                using (SqlCommand cmd = new SqlCommand(queryTotal, con))
                {
                    cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                    Total = (int)cmd.ExecuteScalar();
                }

                //data
                string queryData = @"SELECT DNI, Apellido, Nombre, Edad, EsRegular, Mail FROM Alumno Where 
                                    (Apellido LIKE @filtro OR Nombre LIKE @filtro OR DNI LIKE @filtro OR EsRegular LIKe @filtro) 
                                    AND Estado=1 
                                    ORDER BY Apellido 
                                    OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";

                using (SqlCommand cmd = new SqlCommand(queryData, con))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                    cmd.Parameters.AddWithValue("@limite", limite);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Props
                            {
                                DNI = reader["DNI"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Edad = Convert.ToInt32(reader["Edad"]),
                                Condicion = reader["EsRegular"].ToString(),
                                Mail = reader["Mail"].ToString(),
                            });
                        }
                    }
                }
            }
            return new PagedResult<Props>
            {
                Data = list,
                Total = Total
            };
        }

        public Props TraerInfo(string dni)
        {
            Props p = null;
           

            using (SqlConnection con= new SqlConnection(Decla.ConnectionString))
            {
                con.Open();
                string queryData = @"SELECT DNI, Apellido, Nombre, Edad, EsRegular, Mail, Telefono FROM Alumno Where DNI=@DNI AND Estado=1";

                using (SqlCommand cmd= new SqlCommand(queryData, con))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            p = new Props()
                            {
                                DNI = reader["DNI"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Edad = Convert.ToInt32(reader["Edad"]),
                                Condicion = reader["EsRegular"].ToString(),
                                Mail = reader["Mail"].ToString(),
                                Telefono = reader["Telefono"].ToString()
                            };
                        }
                    }
                }

            }
            return p;
        }
    }
}