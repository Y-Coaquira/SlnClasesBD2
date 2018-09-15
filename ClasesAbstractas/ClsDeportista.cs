using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class ClsDeportista //poner entre public y class el abstract para que no se pueda instanciar
    {
        //la clase abstracta es aquella que pueda ser heredada mas no instanciada de forma directa
        public virtual void jugar()
        {
            Console.WriteLine("El deportista juega.");
        }
    }
}
