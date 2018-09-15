using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInterfaces
{
    interface ClsTransporte
    {
        string marca { get; set; }
        string tipo { get; set; }
        void acelerar();
        void frenar();
        void girar();
    }
}
