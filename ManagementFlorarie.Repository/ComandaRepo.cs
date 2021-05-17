using ManagementFlorarie.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ManagementFlorarie.Repository
{
    public class ComandaRepo : BaseRepo
    {
        #region Constante
        private const string COMANDA_INSERT = "dbo.Comanda_Insert";
        private const string COMANDA_UPDATE = "dbo.Comanda_Update";
        private const string COMANDA_DELETE = "dbo.Comanda_Delete";
        private const string COMANDA_READCOMENZI = "dbo.Comanda_ReadComenzi";
        private const string COMANDA_READCOMANDADUPAID = "dbo.Comanda_ReadComandaDupaId";
        private const string COMANDA_READCOMANDADUPANUME = "dbo.Comanda_ReadComandaDupaNume";
        private const string COMANDA_READCOMENZI_IEFTINE = "dbo.Comanda_Ieftina";
        private const string COMANDA_READCOMENZI_SCUMPE = "dbo.Comanda_Scumpa";
        private const string COMANDA_READCOMENZI_CEAMAIIEFTINAFLOARE = "dbo.Comanda_CeaMaiIeftinaFloare";
        private const string COMANDA_READCOMENZI_CEAMAIVANDUTAFLOARE = "dbo.Comanda_CeaMaiVandutaFloare";
        private const string COMANDA_READCOMENZI_CEAMAISCUMPAFLOARE = "dbo.Comanda_CeaMaiScumpaFloare";
        #endregion

        #region Metode
        public ComandaAngajatFloare ReadComandaDupaID(Guid ID_Comanda)
        {
            ComandaAngajatFloare comandaAngajatFloare = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(COMANDA_READCOMANDADUPAID))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@ID_Comanda", ID_Comanda);

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            comandaAngajatFloare = new ComandaAngajatFloare
                            {
                                ID_Comanda = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Comanda")),
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                NumeFloare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeFloare")),
                                PretFloare = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretFloare")),
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                NumeAngajat = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeAngajat")),
                                NumeComanda = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                DataComenzii = Convert.ToDateTime(sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataComanda"))),
                                DataRidicariiComenzii = Convert.ToDateTime(sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataRidicare"))),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Observatii = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Observatii")),
                                Status = (StatusComanda)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                                PretTotal = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretTotal")),
                            };
                        }
                    }
                }
            }
            return comandaAngajatFloare;
        }

        public ComandaAngajatFloare ReadComandaDupaNume(string numeComanda)
        {
            ComandaAngajatFloare comandaAngajatFloare = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(COMANDA_READCOMANDADUPANUME))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@Nume", numeComanda);

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            comandaAngajatFloare = new ComandaAngajatFloare
                            {
                                ID_Comanda = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Comanda")),
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                NumeFloare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeFloare")),
                                PretFloare = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretFloare")),
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                NumeAngajat = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeAngajat")),
                                NumeComanda = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                DataComenzii = Convert.ToDateTime(sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataComanda"))),
                                DataRidicariiComenzii = Convert.ToDateTime(sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataRidicare"))),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Observatii = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Observatii")),
                                Status = (StatusComanda)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                                PretTotal = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretTotal")),
                            };
                        }
                    }
                }
            }
            return comandaAngajatFloare;
        }

        public List<ComandaAngajatFloare> ReadComenzi()
        {
            List<ComandaAngajatFloare> comenzi = new List<ComandaAngajatFloare>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(COMANDA_READCOMENZI))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ComandaAngajatFloare comanda = new ComandaAngajatFloare
                            {
                                ID_Comanda = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Comanda")),
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                NumeFloare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeFloare")),
                                PretFloare = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretFloare")),
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                NumeAngajat = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeAngajat")),
                                NumeComanda = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                DataComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataComanda")),
                                DataRidicariiComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataRidicare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Observatii = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Observatii")),
                                Status = (StatusComanda)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                                PretTotal = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretTotal")),
                            };
                            comenzi.Add(comanda);
                        }
                    }
                }
            }
            return comenzi;
        }

        public List<ComandaAngajatFloare> ReadComenziIeftine()
        {
            List<ComandaAngajatFloare> comenzi = new List<ComandaAngajatFloare>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(COMANDA_READCOMENZI_IEFTINE))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ComandaAngajatFloare comanda = new ComandaAngajatFloare
                            {
                                ID_Comanda = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Comanda")),
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                NumeFloare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeFloare")),
                                PretFloare = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretFloare")),
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                NumeAngajat = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeAngajat")),
                                NumeComanda = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                DataComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataComanda")),
                                DataRidicariiComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataRidicare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Observatii = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Observatii")),
                                Status = (StatusComanda)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                                PretTotal = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretTotal")),
                            };
                            comenzi.Add(comanda);
                        }
                    }
                }
            }
            return comenzi;
        }

        public List<ComandaAngajatFloare> ReadComenziScumpe()
        {
            List<ComandaAngajatFloare> comenzi = new List<ComandaAngajatFloare>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(COMANDA_READCOMENZI_SCUMPE))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ComandaAngajatFloare comanda = new ComandaAngajatFloare
                            {
                                ID_Comanda = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Comanda")),
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                NumeFloare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeFloare")),
                                PretFloare = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretFloare")),
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                NumeAngajat = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeAngajat")),
                                NumeComanda = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                DataComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataComanda")),
                                DataRidicariiComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataRidicare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Observatii = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Observatii")),
                                Status = (StatusComanda)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                                PretTotal = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretTotal")),
                            };
                            comenzi.Add(comanda);
                        }
                    }
                }
            }
            return comenzi;
        }

        public List<ComandaAngajatFloare> ReadComenziDupaFloareScumpa()
        {
            List<ComandaAngajatFloare> comenzi = new List<ComandaAngajatFloare>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(COMANDA_READCOMENZI_CEAMAISCUMPAFLOARE))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ComandaAngajatFloare comanda = new ComandaAngajatFloare
                            {
                                ID_Comanda = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Comanda")),
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                NumeFloare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeFloare")),
                                PretFloare = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretFloare")),
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                NumeAngajat = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeAngajat")),
                                NumeComanda = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                DataComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataComanda")),
                                DataRidicariiComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataRidicare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Observatii = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Observatii")),
                                Status = (StatusComanda)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                                PretTotal = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretTotal")),
                            };
                            comenzi.Add(comanda);
                        }
                    }
                }
            }
            return comenzi;
        }

        public List<ComandaAngajatFloare> ReadComenziDupaCeaMaiScumpaFloare()
        {
            List<ComandaAngajatFloare> comenzi = new List<ComandaAngajatFloare>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(COMANDA_READCOMENZI_CEAMAIVANDUTAFLOARE))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ComandaAngajatFloare comanda = new ComandaAngajatFloare
                            {
                                ID_Comanda = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Comanda")),
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                NumeFloare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeFloare")),
                                PretFloare = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretFloare")),
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                NumeAngajat = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeAngajat")),
                                NumeComanda = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                DataComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataComanda")),
                                DataRidicariiComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataRidicare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Observatii = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Observatii")),
                                Status = (StatusComanda)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                                PretTotal = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretTotal")),
                            };
                            comenzi.Add(comanda);
                        }
                    }
                }
            }
            return comenzi;
        }

        public List<ComandaAngajatFloare> ReadComenziDupaCeaMaiIeftinaFloare()
        {
            List<ComandaAngajatFloare> comenzi = new List<ComandaAngajatFloare>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(COMANDA_READCOMENZI_CEAMAIIEFTINAFLOARE))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    connection.Open();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            ComandaAngajatFloare comanda = new ComandaAngajatFloare
                            {
                                ID_Comanda = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Comanda")),
                                ID_Floare = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Floare")),
                                NumeFloare = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeFloare")),
                                PretFloare = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretFloare")),
                                ID_Angajat = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID_Angajat")),
                                NumeAngajat = sqlDataReader.GetString(sqlDataReader.GetOrdinal("NumeAngajat")),
                                NumeComanda = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Nume")),
                                DataComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataComanda")),
                                DataRidicariiComenzii = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("DataRidicare")),
                                Cantitate = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Cantitate")),
                                Observatii = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Observatii")),
                                Status = (StatusComanda)sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                                PretTotal = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("PretTotal")),
                            };
                            comenzi.Add(comanda);
                        }
                    }
                }
            }
            return comenzi;
        }
        
        public void InsertComanda(ComandaAngajatFloare comanda)
        {
            ExecuteNonQuery(COMANDA_INSERT, new SqlParameter("@ID_Comanda", comanda.ID_Comanda),
                                            new SqlParameter("@ID_Floare", comanda.ID_Floare),
                                            new SqlParameter("@ID_Angajat", comanda.ID_Angajat),
                                            new SqlParameter("@Nume", comanda.NumeComanda),
                                            new SqlParameter("@DataComanda", comanda.DataComenzii),
                                            new SqlParameter("@DataRidicare", comanda.DataRidicariiComenzii),
                                            new SqlParameter("@Cantitate", comanda.Cantitate),
                                            new SqlParameter("@Observatii", comanda.Observatii),
                                            new SqlParameter("@Status", comanda.Status),
                                            new SqlParameter("@PretTotal", comanda.PretTotal));
        }

        public void UpdateComanda(ComandaAngajatFloare comanda)
        {
            ExecuteNonQuery(COMANDA_UPDATE, new SqlParameter("@ID_Comanda", comanda.ID_Comanda),
                                            new SqlParameter("@ID_Floare", comanda.ID_Floare),
                                            new SqlParameter("@ID_Angajat", comanda.ID_Angajat),
                                            new SqlParameter("@Nume", comanda.NumeComanda),
                                            new SqlParameter("@DataComanda", comanda.DataComenzii),
                                            new SqlParameter("@DataRidicare", comanda.DataRidicariiComenzii),
                                            new SqlParameter("@Cantitate", comanda.Cantitate),
                                            new SqlParameter("@Observatii", comanda.Observatii),
                                            new SqlParameter("@Status", comanda.Status),
                                            new SqlParameter("@PretTotal", comanda.PretTotal));
        }

        public void DeleteComanda(Guid ID_Comanda)
        {
            ExecuteNonQuery(COMANDA_DELETE, new SqlParameter("@ID_Comanda", ID_Comanda));
        } 
        #endregion
    }
}
