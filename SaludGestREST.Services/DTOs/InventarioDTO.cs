using SaludGestREST.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.DTOs
{
    public class InventarioDTO : RegistryDTO
    {
        public int InventarioMedId { get; set; }
        public int Cantidad { get; set; }
        public int Minimo { get; set; }
        public int MedicamentoId { get; set; }
        public int CentroId { get; set; }
    }
}
