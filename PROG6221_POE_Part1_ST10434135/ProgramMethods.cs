using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Spectre.Console;
using System.Threading;

namespace PROG6221_POE_Part1_ST10434135
{
    class ProgramMethods
    {

        //---------------------------------------------------------------------------------------------------------------------------------------------------------// 
        public void Startup()
        {

            //Display the welcome message and ASCII art
            UIElements uiElements = new UIElements();
            uiElements.ASCIIArt();
            //Console.WriteLine("Hi, I'm CyberBot, the no.1 South African Cyber awareness chatbot");
            //Console.WriteLine("Please feel free to ask me any questions regarding cyber security below!");
            AnsiConsole.MarkupLine("[bold yellow]Hi, I'm [bold red]CyberBot[/], your ultimate Cyber Security information companion :)\nfrom phishing, to configuring your home network, I've got you covered.[/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[bold yellow]Feel free to [bold white]ask me any questions[/] regarding [bold red]cyber security[/] below!\nJust type a question and press enter.[/]");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------//
        //This method plays the greeting WAV file to welcome the user to the chatbot
        public void PlayGreeting()
        {
            try
            {

                SoundPlayer VoiceGreeting = new SoundPlayer(@"C:\Users\dylan\OneDrive\Desktop\University\2\C PROJECTS\PROG6221_POE_Part1_ST10434135\WAVS\CyberBotWelcome.wav");
                VoiceGreeting.Play();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }

        

        }
    }

