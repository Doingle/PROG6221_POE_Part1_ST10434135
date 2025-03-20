using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part1_ST10434135
{
    //This class is the main flow of the chatbot, and is responsible for displaying the welcome message and getting user input
    class CyberBotMainFlow
    {
        //class level boolean variable to keep track of the chatbot's state
        bool BotIsRunning = true;
        public ResponseGenerator responseGenerator;

        public CyberBotMainFlow()
        {
            responseGenerator = new ResponseGenerator();
            responseGenerator.ResponseCreation();
        }

        public void ChatBot()
        {

            BotIsRunning = true;

        }

        //main entry point for the chatbot
        public void Start()
        {

            UIElements ui = new UIElements();
            ProgramMethods pm = new ProgramMethods();
            pm.PlayGreeting();
            ui.DisplayWelcomePage();
            

            while (BotIsRunning)
            {
                string userInput = ui.GetUserInput();
                ui.ThinkingAnimation();
               
                if (userInput.ToLower() == "exit")
                {
                    BotIsRunning = false;
                    ui.ExitMessage();
                    break;
                }
                string CyberBotResponses = responseGenerator.FindResponse(userInput);
                ui.DisplayResponse(CyberBotResponses);



            }



        }



    }
}
