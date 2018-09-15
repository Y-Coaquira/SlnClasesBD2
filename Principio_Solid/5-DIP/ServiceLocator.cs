using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_Solid._5_DIP
{
    public class ServiceLocator
    {
        public static IImageRecorder GetImageRecorder()
        {
            return new DatabaseFileManager(System.Configuration.ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        }
    }
}
