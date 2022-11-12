using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCimino.Clases
{
    public class ObsJoven : IObserver
    {
        public List<Venta> listaVentas = new List<Venta>();
        public void Actualizar(ISubject subject)
        {
            if ((subject as GestorVentas).ventaRealizada.edad < 27)
            {
                listaVentas.Add((subject as GestorVentas).ventaRealizada);
            }
        }
    }
}
