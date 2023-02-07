using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.COMMON.Entidades
{
    public class Entrega:Base
    {
        public DateTime FechaHoraSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime? FechaEntregaReal { get; set; }
        public List<Material>
            MaterialesPrestados      { get; set; }
        public Trabajador Solicitante { get; set; }
        public Trabajador EncargadoDeAlmacen { get; set; }
                    
    }
}
