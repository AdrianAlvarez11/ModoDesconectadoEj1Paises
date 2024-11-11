using Banderas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banderas.Repositories
{
    public class PaisRepository
    {
        MundoContext context = new();

        public IEnumerable<DatosPaises> GetDatosPaises()
        {
            return context.Paises.Select(x => new DatosPaises
            {
                AreaSuperficie = x.AreaSuperficie,
                Codigo = x.Codigo,
                Continente = x.Continente,
                IndepYear = x.IndepYear,
                Nombre = x.Nombre,
                NumeroHabitantes = x.NumeroHabitantes,
                Region = x.Region
            });
        }
        //metodo que recupere toda la informacion de los paises
        public IEnumerable<Paises> GetAllPaises()
        {
            return context.Paises.OrderBy(x => x.Nombre);
        }

    }
}
