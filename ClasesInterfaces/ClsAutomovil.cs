using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInterfaces
{
    class ClsAutomovil : ClsTransporte, IComparable // obliga a tener a la clase automovil a tener propiedades iguales que la clase tranporte
    {
        public string marca { get; set; }
        public string tipo { get; set; }

        //Creamos el constructor
        public ClsAutomovil(string marca,string tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
        }
        //Fin del constructor
        public void acelerar()
        {
            Console.WriteLine("Incrementando velociada");
        }
        public void frenar()
        {
            Console.WriteLine("Disminuyendo velocidad");
        }
        public void girar()
        {
            Console.WriteLine("Girando");
        }

        public int CompareTo(object obj)
        {
            ClsAutomovil C = (ClsAutomovil)obj;
            return string.Compare(this.marca, C.marca); //sirve para comprar basado en la propiedad marca
            //return string.Compare(this.tipo, C.tipo); //sirve para comprar basado en la propiedad tipo
        }
    }
}
