using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCimino.Clases
{
    public class ObsAdulto : IObserver
    {
        public List<Venta> listaVentas = new List<Venta>();
        public void Actualizar(ISubject subject)
        {
            if ((subject as GestorVentas).ventaRealizada.edad > 26 && (subject as GestorVentas).ventaRealizada.edad < 60)
            {
                listaVentas.Add((subject as GestorVentas).ventaRealizada);
            }
        }
    }
}
