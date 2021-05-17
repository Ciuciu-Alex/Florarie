using System;

namespace ManagementFlorarie.Models
{
    public class UserAngajat
    {
        public Guid ID_Angajat { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public string NumarTelefon { get; set; }
        public string Adresa { get; set; }
        public string Username { get; set; }
        public string Parola { get; set; }
        public Rol Rol { get; set; }
    }
}
