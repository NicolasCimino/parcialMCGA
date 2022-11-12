using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCimino.Clases
{
    public interface IObserver
    {
        void Actualizar(ISubject subject);
    }
}
