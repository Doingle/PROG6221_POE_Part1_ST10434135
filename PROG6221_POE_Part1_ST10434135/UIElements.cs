using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROG6221_POE_Part1_ST10434135
{
    class UIElements
    {

        public void DisplayWelcomePage()
        {
            //Display the welcome message and ASCII art
            ASCIIArt();
            AnsiConsole.MarkupLine("[bold yellow]Hi, I'm [bold red]CyberBot[/], your ultimate Cyber Security information companion :)\nfrom phishing, to configuring your home network, I've got you covered.[/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[bold yellow]Feel free to [bold white]ask me any questions[/] regarding [bold red]cyber security[/] below!\nPress any key to start[/]");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        public string GetUserInput()
        {
            AnsiConsole.MarkupLine("[bold yellow]Ask me any Cyber Security question:\nTo exit, type [bold red]exit[/][/]");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public void DisplayResponse(string response)
        {
            AnsiConsole.MarkupLine("[bold green]CyberBot:[/] " + response);
        }

        public void ExitMessage()
        {
            AnsiConsole.MarkupLine("[bold red]Goodbye! Thank you for chatting with CyberBot :)[/]");
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------//
        public void ThinkingAnimation()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;// enable for all spec.console

            AnsiConsole.Status()

            .Start("[yellow]CyberBot is thinking.[/]", ctx =>

            {

                ctx.Spinner(Spinner.Known.Dots2);
                ctx.SpinnerStyle(Style.Parse("yellow"));

                Thread.Sleep(1000);

            });
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------//
        public void ASCIIArt()
        {
            string welcomeArt = @"
                                                                             .-''-.
                                                                            / .--. \        
                                                                           / /    \ \                 
                                                                           | |    | |
██████╗██╗   ██╗██████╗ ███████╗██████╗     ██████╗  ██████╗ ████████╗     | |.-''-.|
██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██╔═══██╗╚══██╔══╝   ///`.::::.`\  
██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██████╔╝██║   ██║   ██║     ||| ::/  \:: ;  
██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██╔══██╗██║   ██║   ██║     ||; ::\__/:: ; 
╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ██████╔╝╚██████╔╝   ██║      \\\ '::::' /
 ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═════╝  ╚═════╝    ╚═╝       `=':-..-'`   
                                                                           ";

            Console.WriteLine(welcomeArt);
            Console.WriteLine();

        }

    }
}
