using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Data.Models
{
    public class Especialidad : Registry
    {
        public int IdEspecialidad { get; set; }
        public string Nombre { get; set; }
    }
}
