using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Principio_Solid._4_ISP
{
    public class DatabaseFileManager : IImageRecorder
    {
        string connectionString = string.Empty;

        public DatabaseFileManager()
        {
            var cs = System.Configuration.ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            this.SetConnectionString(cs);
        }

        public void SetConnectionString(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void SaveImage(byte[] imageBytes, string name)
        {
            //guarda en base de datos
        }
    }
}
