using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryJose
{
    public class Helper
    {
        public static string CnnVal(string name)
        {
            try
            {
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;

            }
            catch (Exception)
            {
                Console.WriteLine("Problemas con el Helper ConnectionString");
                throw;
            }
        }
    }
}
