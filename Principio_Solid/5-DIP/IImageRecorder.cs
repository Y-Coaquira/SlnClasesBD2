using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Solid._5_DIP
{
    public interface IImageRecorder
    {
        void SaveImage(byte[] imageBytes, string name);
        void SetConnectionString(string connectionString);
    }
}
