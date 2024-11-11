using Banderas.Models;
using Banderas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banderas.Viewmodels
{
    public class PaisViewModel
    {
        PaisRepository repos = new();
        public List<DatosPaises> ListaPaises { get; set; } = new();

        public PaisViewModel()
        {
            
            ListaPaises= repos.GetDatosPaises().ToList();
        }

    }
}
