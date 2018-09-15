using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Principio_Solid._1_SRP
{
    class FileManager
    {
        public void SaveImage(byte[] imageBytes, string name)
        {
            FileStream fs = new FileStream(name, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            try
            {
                bw.Write(imageBytes);
            }
            finally
            {
                fs.Close();
                bw.Close();
            }

        }
    }
}
