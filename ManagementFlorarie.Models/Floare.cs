using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementFlorarie.Models
{
    public class Floare
    {
        public Guid ID_Floare { get; set; }
        public string Nume { get; set; }
        public string Tip { get; set; }
        public string Culoare { get; set; }
        public int Cantitate { get; set; }
        public int Pret { get; set; }
    }
}
