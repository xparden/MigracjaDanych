using Soneta.Business.App;
using Soneta.Business;
using Soneta.CRM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MigracjaDanych
{
    public class Program
    {
        static void Main(string[] args)
        {
            ModuleLoader.Load();
            AppLogic.MigrateData();
        }
    }
}
