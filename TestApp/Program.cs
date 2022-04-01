using System;
using Bibi.ViewModel;
using Bibi.Model;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                ;
            }

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
