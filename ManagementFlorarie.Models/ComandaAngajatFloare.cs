using System;

namespace ManagementFlorarie.Models
{
    public class ComandaAngajatFloare
    {
        public Guid ID_Comanda { get; set; }
        public Guid ID_Floare { get; set; }
        public string NumeComanda { get; set; }
        public string NumeFloare { get; set; }
        public Guid ID_Angajat { get; set; }
        public string NumeAngajat { get; set; }
        public int PretFloare { get; set; }
        public DateTime DataComenzii { get; set; }
        public DateTime DataRidicariiComenzii { get; set; }
        public int Cantitate { get; set; }
        public StatusComanda Status { get; set; }
        public string Observatii { get; set; }
        public int PretTotal { get; set; }
    }
}
