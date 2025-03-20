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

