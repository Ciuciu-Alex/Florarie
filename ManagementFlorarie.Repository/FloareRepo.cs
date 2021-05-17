using ManagementFlorarie.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ManagementFlorarie.Repository
{
    public class FloareRepo : BaseRepo
    {
        private const string FLOARE_INSERT = "dbo.Floare_Insert";
        private const string FLOARE_UPDATE = "dbo.Floare_Update";
        private const string FLOARE_DELETE = "dbo.Floare_Delete";
        private const string FLOARE_READFLORI = "dbo.Floare_ReadFlori";
        private const string FLOARE_READFLOAREDUPAID = "dbo.Floare_ReadFloareDupaID";
        private const string FLOARE_READFLOAREDUPANUME = "dbo.Floare_ReadFloareDupaNume";
        private const string FLOARE_CANTITATE = "dbo.Floare_Cantitate";
        private const string FLOARE_UPDATECANTITATE = "dbo.Floare_UpdateCantitate";

        public Floare ReadFloareDupaID(Guid ID_Floare)
        {
            Floare floare = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(FLOARE_READFLOAREDUPAID))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ID_Floare", ID_Floare);

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            floare = new Floare
                            {
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                Nume = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                Tip = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Tip")),
                                Culoare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Culoare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Pret = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Pret")),
                            };
                        }
                    }
                }
            }
            return floare;
        }

        public Floare ReadFloareDupaNume(string numeFloare)
        {
            Floare floare = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(FLOARE_READFLOAREDUPANUME))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddRange(new SqlParameter[] { new SqlParameter("@Nume", numeFloare) });

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            floare = new Floare
                            {
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                Nume = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                Tip = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Tip")),
                                Culoare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Culoare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Pret = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Pret")),
                            };
                        }
                    }
                }
            }
            return floare;
        }

        public void UpdateCantitateFloare(int cantitateFloare, Guid idFloare)
        {
            ExecuteNonQuery(FLOARE_UPDATECANTITATE, new SqlParameter("@ID_Floare", idFloare),
                                                    new SqlParameter("@Cantitate", cantitateFloare));
        }

        public List<Floare> ReadFlori()
        {
            List<Floare> flori = new List<Floare>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(FLOARE_READFLORI))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            Floare floare = new Floare
                            {
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                Nume = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                Tip = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Tip")),
                                Culoare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Culoare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Pret = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Pret"))
                            };
                            flori.Add(floare);
                        }
                    }
                }
            }
            return flori;
        }

        public Floare FloareCantitate()
        {
            Floare floare = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(FLOARE_CANTITATE))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            floare = new Floare
                            {
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate"))
                            };
                        }
                    }
                }
            }
            return floare;
        }

        public void InsertFloare(Floare floare)
        {
            ExecuteNonQuery(FLOARE_INSERT, new SqlParameter("@ID_Floare", floare.ID_Floare),
                                           new SqlParameter("@Nume", floare.Nume),
                                           new SqlParameter("@Tip", floare.Tip),
                                           new SqlParameter("@Culoare", floare.Culoare),
                                           new SqlParameter("@Cantitate", floare.Cantitate),
                                           new SqlParameter("@Pret", floare.Pret));
        }

        public void UpdateFloare(Floare floare)
        {
            ExecuteNonQuery(FLOARE_UPDATE, new SqlParameter("@ID_Floare", floare.ID_Floare),
                                           new SqlParameter("@Nume", floare.Nume),
                                           new SqlParameter("@Tip", floare.Tip),
                                           new SqlParameter("@Culoare", floare.Culoare),
                                           new SqlParameter("@Cantitate", floare.Cantitate),
                                           new SqlParameter("@Pret", floare.Pret));
        }

        public void DeleteFloare(Guid idFloare)
        {
            ExecuteNonQuery(FLOARE_DELETE, new SqlParameter("@ID_Floare", idFloare));
        }

       
    }
}
