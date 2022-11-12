﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCimino.Clases
{
    public interface ISubject
    {
        void Agregar(IObserver observer);
        void Quitar(IObserver observer);
        void Notificar();
    }
}
