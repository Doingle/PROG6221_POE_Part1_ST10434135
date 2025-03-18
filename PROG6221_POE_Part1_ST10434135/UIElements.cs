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

        public void ThinkingAnimation()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;// enable for all spec.console

            AnsiConsole.Status()

            .Start("[yellow]CyberBot is thinking...[/]", ctx =>

            {

                ctx.Spinner(Spinner.Known.Dots2);
                ctx.SpinnerStyle(Style.Parse("yellow"));

                Thread.Sleep(1000);

            });
        }

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
