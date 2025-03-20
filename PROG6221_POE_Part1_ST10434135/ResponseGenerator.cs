using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part1_ST10434135
{
    class ResponseGenerator
    {

        private Dictionary<string, string> CyberBotResponses;

        public void ResponseCreation()
        {
            CyberBotResponses = new Dictionary<string, string>
            {
                { "Hi","yo" }
            };
            




        }

        public string FindResponse(string userInput)
        {
            foreach (var entry in CyberBotResponses)
            {
                if (userInput.ToLower().Contains(entry.Key))  
                {
                    return entry.Value;
                }
            }
            return "I'm sorry, I'm not sure I understand :(. Please ask me another cyber security question.";
        }

    }
}



