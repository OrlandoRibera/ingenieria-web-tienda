using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Soporte.Web.ViewModel
{
    public class CitaViewModel
    {
        public Guid SoporteId { get; set; }
        public DateTime FechaPrevista { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
    }
}
