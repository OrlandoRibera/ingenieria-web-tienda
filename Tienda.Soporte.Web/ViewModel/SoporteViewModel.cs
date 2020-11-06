using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Soporte.Web.ViewModel
{
    public class SoporteViewModel
    {
        public int Estado { get; set; }
        public decimal Costo { get; set; }
        public Guid Soporte { get; set; }
        public Guid Cliente { get; set; }
        public List<Guid> Productos { get; set; }
    }
}
