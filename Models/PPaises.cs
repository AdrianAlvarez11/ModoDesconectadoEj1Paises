using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banderas.Models
{
    public partial class Paises
    {

        public string Bandera
        {
            get { return string.Format("https://www.mapsofworld.com/images/world-countries-flags/{0}-flag.gif", Nombre.ToLower().TrimEnd()); }
        }
    }
}
