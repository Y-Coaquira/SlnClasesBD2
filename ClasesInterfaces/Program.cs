using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsAutomovil[] arreglocarros = new ClsAutomovil[6]
            {
                new ClsAutomovil("Ford","Agricola"),
                new ClsAutomovil("Audi","Sedan"),
                new ClsAutomovil("Buick","Camioneta"),
                new ClsAutomovil("Toyota","Sedan"),
                new ClsAutomovil("Dodge","Camioneta"),
                new ClsAutomovil("Honda","Sedan")
            };
            Console.WriteLine("*****Arreglo Vehiculos*****");
            foreach(ClsAutomovil c in arreglocarros)
            {
                Console.WriteLine("La marca es {0} y el tipo es {1}", c.marca, c.tipo);               
            }
            Console.WriteLine("\n\r");
            Console.WriteLine("*****Arreglo Vehiculos Ordenado*****");
            Array.Sort(arreglocarros);
            foreach (ClsAutomovil c in arreglocarros)
            {
                Console.WriteLine("La marca es {0} y el tipo es {1}", c.marca, c.tipo);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Presione cualquier tecla para continuar...");            
            Console.ReadKey();
        }
        /*En concliusion la clase INTERFACES es una plantilla que le indica a la clase que metodos,propiedades,
        enumerables y eventos debe de tener*/
    }
}
