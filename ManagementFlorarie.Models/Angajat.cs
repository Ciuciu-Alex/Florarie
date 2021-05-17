using System;

namespace ManagementFlorarie.Models
{
    public class Angajat
    {
        public Guid ID_Angajat { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public string NumarTelefon { get; set; }
        public string Adresa { get; set; }
    }
}
