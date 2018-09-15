using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClsFutbolista futbolista = new ClsFutbolista();
            //futbolista.jugar(); //por la herencia que tiene futbolista de deportista

            //ClsDeportista deportista = new ClsFutbolista();
            //deportista.jugar(); //este tipo de instanciacion se llama polimorfismo, 
            //es una forma de instacion de la clase hijo sobre la clase padre

            ClsDeportista deportista = new ClsDeportista();
            deportista.jugar();

            Console.ReadLine();
        }
    }
}
