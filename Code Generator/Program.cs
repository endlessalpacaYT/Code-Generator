using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Code_Generator
{
    internal class Program
    {

        public string ProgrammingLanguage;

        static void Main(string[] args)
        {
            Console.Title = "Code Generator";
            Program program = new Program();
            program.SetUpGenerator();
            Console.Clear();
            Console.WriteLine("You Have Chosen To Generate Code In " + program.ProgrammingLanguage + "!");
            Console.WriteLine("Please Make Sure To Open Your Ide And Press Enter");
            Console.ReadLine();
            program.GotoChosenLang();
        }

        public void GotoChosenLang()
        {
            if (ProgrammingLanguage == "Python")
            {
                Python.Python.StartGenerator();
            }
            else
            {
                Console.WriteLine("Error: Variable [ProgrammingLanguage] Did Not Update To Have A Value!");
                Thread.Sleep(2000);
            }
        }

        public void SetUpGenerator() 
        {
            Console.WriteLine("Welcome To The Code Generator Configurator!");
            Console.WriteLine();
            Console.WriteLine("Please Pick A Programming Language To Generate The Code In:");
            Console.WriteLine("[1] Python");
            Console.Write("-> ");
            int LanguageChoice = Convert.ToInt32(Console.ReadLine());
            SetUpChoice(LanguageChoice);
        }

        public void SetUpChoice(int LanguageChoice) 
        {
            if (LanguageChoice == 1)
            {
                ProgrammingLanguage = "Python";
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }
    }
}
