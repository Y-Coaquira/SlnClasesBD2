using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Solid._2_OCP
{
    public class DatabaseFileManager : FileManager
    {
        public override void SaveImage(byte[] imageBytes, string name)
        {
            //guarda en base de datos
        }
    }
}
