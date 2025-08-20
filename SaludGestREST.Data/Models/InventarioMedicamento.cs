using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Data.Models
{
    public class InventarioMedicamento : Registry
    {
        [Key]
        public int InventarioMedId { get; set; }
        public int Cantidad { get; set; }
        public int Minimo { get; set; }
        public int MedicamentoId { get; set; }
        public int CentroId { get; set; }
        public Medicamento Medicamento { get; set; }
        public CentroMedico Centro { get; set; }
    }
}
