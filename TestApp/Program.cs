using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibi.ViewModel;
using Bibi.Model;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CTSSViewModel vm = new CTSSViewModel();
            foreach(CTSSModel model in vm.ValueList)
            {
                Console.WriteLine(model.ToString());
            }
            vm.CreatePDFCTSS();
            vm.CreatePDFCTSS38();
            Console.ReadLine();
        }
    }
}
