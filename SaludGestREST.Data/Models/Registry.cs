using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Data.Models
{
    //TODOS DEBEN DE HEREDAR DE ESTA CLASE

    public class Registry
    {
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime HighSystem { get; set; } = DateTime.Now;
    }
}
