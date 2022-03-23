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
            PMR466ViewModel vm = new PMR466ViewModel();
            foreach(PMR466Model model in vm.ValueList)
            {
                Console.WriteLine(model.ToString());
            }
            //vm.CreatePDFCTSS();
            //vm.CreatePDFCTSS38();
            vm.CreatePDF();
            Console.ReadLine();
        }
    }
}
