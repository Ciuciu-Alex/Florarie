using ManagementFlorarie.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace ManagementFlorarie.Repository
{
    public class AngajatRepo : BaseRepo
    {
        private const string ANGAJAT_INSERT = "dbo.Angajat_Insert";
        private const string ANGAJAT_UPDATE = "dbo.Angajat_Update";
        private const string ANGAJAT_DELETE = "dbo.Angajat_Delete";
        private const string ANGAJAT_READANGAJATI = "dbo.Angajat_ReadAngajati";
        private const string ANGAJAT_READANGAJATDUPAID = "dbo.Angajat_ReadAngajatDupaID";

        public UserAngajat ReadAnagajatDupaID(Guid ID_Angajat)
        {
            UserAngajat userAngajat = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(ANGAJAT_READANGAJATDUPAID))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ID_Angajat", ID_Angajat);

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            userAngajat = new UserAngajat
                            {
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                Nume = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                Email = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Email")),
                                NumarTelefon = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumarTelefon")),
                                Adresa = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Adresa")),
                                Username = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Username")),
                                Parola = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Parola")),
                                Rol = (Rol)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Rol"))
                            };
                        }
                    }
                }
            }
            return userAngajat;
        }

        public List<Angajat> ReadAngajati()
        {
            List<Angajat> angajati = new List<Angajat>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(ANGAJAT_READANGAJATI))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            Angajat angajat = new Angajat
                            {
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                Nume = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                Email = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Email")),
                                NumarTelefon = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumarTelefon")),
                                Adresa = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Adresa"))
                            };
                            angajati.Add(angajat);
                        }
                    }
                }
            }
            return angajati;
        }

        public void InsertAngajat(Angajat angajat)
        {
            ExecuteNonQuery(ANGAJAT_INSERT, new SqlParameter("@ID_Angajat", angajat.ID_Angajat),
                                           new SqlParameter("@Nume", angajat.Nume),
                                           new SqlParameter("@Email", angajat.Email),
                                           new SqlParameter("@NumarTelefon", angajat.NumarTelefon),
                                           new SqlParameter("@Adresa", angajat.Adresa));
        }

        public void UpdateAngajat(Angajat angajat)
        {
            ExecuteNonQuery(ANGAJAT_UPDATE, new SqlParameter("@ID_Angajat", angajat.ID_Angajat),
                                            new SqlParameter("@Nume", angajat.Nume),
                                            new SqlParameter("@Email", angajat.Email),
                                            new SqlParameter("@NumarTelefon", angajat.NumarTelefon),
                                            new SqlParameter("@Adresa", angajat.Adresa));
        }

        public void DeleteAngajat(Guid idAngajat)
        {
            ExecuteNonQuery(ANGAJAT_DELETE, new SqlParameter("@ID_Angajat",idAngajat));
        }
    }
}
