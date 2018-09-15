using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Principio_Solid._4_ISP
{
    public class FileManager : IImageRecorder
    {
        public virtual void SaveImage(byte[] imageBytes, string name)
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

        public void SetConnectionString(string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
