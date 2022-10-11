using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigracjaDanych
{
    public class ModuleLoader
    {
        public static bool Load()
        {
            try
            {
                var loader = new Soneta.Start.Loader
                {
                    WithExtensions = false,
                    WithUI = false
                };

                loader.Load();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
