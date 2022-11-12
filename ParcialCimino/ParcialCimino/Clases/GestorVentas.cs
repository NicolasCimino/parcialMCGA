using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParcialCimino.Clases
{
    public class GestorVentas : ISubject
    {
       private List<IObserver> observers = new List<IObserver>();
       public Venta ventaRealizada;

        public void Agregar(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notificar()
        {
            foreach(var obs in observers)
            {
                obs.Actualizar(this);
            }
        }

        public void Quitar(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void GenerarVenta()
        {
            Random random = new Random();
            int index = random.Next(0, 4);
            Thread.Sleep(10);
            string SO="";
            if(index == 0) { SO = "Android"; }
            if (index == 1) { SO = "Windows"; }
            if (index == 2) { SO = "Mac"; }
            if (index == 3) { SO = "Linux"; }
            index = random.Next(0, 3);
            Thread.Sleep(11);
            string tipo="";
            if (index == 0) { tipo = "Arcade"; }
            if (index == 1) { tipo = "Deportes"; }
            if (index == 2) { tipo = "Estrategia"; }
            Venta venta = new Venta(SO,random.Next(18,99),random.Next(1,99),tipo);
            ventaRealizada = venta;
            Notificar();
        }
    }
}
