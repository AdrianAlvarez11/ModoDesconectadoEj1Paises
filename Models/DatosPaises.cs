using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banderas.Models
{
    public class DatosPaises
    {
        public string Codigo { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string? Continente { get; set; }

        public string Region { get; set; } = null!;

        public float AreaSuperficie { get; set; }

        public short? IndepYear { get; set; }

        public int NumeroHabitantes { get; set; }


        public string Bandera
        {
            get { return string.Format("https://www.mapsofworld.com/images/world-countries-flags/{0}-flag.gif", Nombre.ToLower().TrimEnd()); }
        }
    }
}
