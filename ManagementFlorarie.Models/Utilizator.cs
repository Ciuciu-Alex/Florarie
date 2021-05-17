using System;

namespace ManagementFlorarie.Models
{
    public class Utilizator
    {
        public string Username { get; set; }
        public Guid ID_Angajat { get; set; }
        public string Parola { get; set; }
        public Rol Rol { get; set; }
    }
}
