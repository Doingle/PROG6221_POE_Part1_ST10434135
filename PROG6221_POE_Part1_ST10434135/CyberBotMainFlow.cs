using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part1_ST10434135
{
    class CyberBotMainFlow
    {

        public void DisplayWelcomePage()
        {

            ProgramMethods CyberBot = new ProgramMethods(); 
            CyberBot.PlayGreeting();
            CyberBot.Startup();

        }

        public string GetInput()
        {
            Console.WriteLine("Please enter your question: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

    }
}
