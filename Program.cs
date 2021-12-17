using System;

namespace LAB_ACT_2_25058_MARXEL_ABOGADO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numC, numB, numF, numSun, numSoft;
            double C, B, F, Sun, Soft, total, tVAT, payment, change;

            // Title screen
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(54, 2);
            Console.WriteLine("WELCOME TO");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(18, 4);
            Console.WriteLine(" ███╗   ███╗ ██████╗     ██╗ ██████╗ ██╗     ██╗     ██╗██████╗ ███████╗███████╗");
            Console.SetCursorPosition(18, 5);
            Console.WriteLine(" ████╗ ████║██╔════╝     ██║██╔═══██╗██║     ██║     ██║██╔══██╗██╔════╝██╔════╝");
            Console.SetCursorPosition(18, 6);
            Console.WriteLine(" ██╔████╔██║██║          ██║██║   ██║██║     ██║     ██║██████╔╝█████╗  █████╗  ");
            Console.SetCursorPosition(18, 7);
            Console.WriteLine(" ██║╚██╔╝██║██║     ██   ██║██║   ██║██║     ██║     ██║██╔══██╗██╔══╝  ██╔══╝  ");
            Console.SetCursorPosition(18, 8);
            Console.WriteLine(" ██║ ╚═╝ ██║╚██████╗╚█████╔╝╚██████╔╝███████╗███████╗██║██████╔╝███████╗███████╗");
            Console.SetCursorPosition(18, 9);
            Console.WriteLine(" ╚═╝     ╚═╝ ╚═════╝ ╚════╝  ╚═════╝ ╚══════╝╚══════╝╚═╝╚═════╝ ╚══════╝╚══════╝ \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------- ENTER YOUR ORDER ---------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            // Menu and Prices
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 15);
            Console.Write("MENU");
            Console.SetCursorPosition(5, 17);
            Console.Write("Chicken w/ rice");
            Console.SetCursorPosition(5, 18);
            Console.Write("Burger");
            Console.SetCursorPosition(5, 19);
            Console.Write("Fries");
            Console.SetCursorPosition(5, 20);
            Console.Write("Sundae");
            Console.SetCursorPosition(5, 21);
            Console.Write("Softdrinks");

            // Prices
            Console.SetCursorPosition(25, 15);
            Console.Write("PRICE");
            Console.SetCursorPosition(25, 17);
            Console.Write("P 100");
            Console.SetCursorPosition(25, 18);
            Console.Write("P 50");
            Console.SetCursorPosition(25, 19);
            Console.Write("P 45");
            Console.SetCursorPosition(25, 20);
            Console.Write("P 30");
            Console.SetCursorPosition(25, 21);
            Console.Write("P 25");

            // Input Quantity
            Console.SetCursorPosition(37, 15);
            Console.Write("ENTER QUANTITY");
            Console.SetCursorPosition(37, 17);
            numC = Int32.Parse(Console.ReadLine());
            Console.SetCursorPosition(37, 18);
            numB = Int32.Parse(Console.ReadLine());
            Console.SetCursorPosition(37, 19);
            numF = Int32.Parse(Console.ReadLine());
            Console.SetCursorPosition(37, 20);
            numSun = Int32.Parse(Console.ReadLine());
            Console.SetCursorPosition(37, 21);
            numSoft = Int32.Parse(Console.ReadLine());
            Console.SetCursorPosition(37, 15);
            Console.Write("QUANTITY      ");


            // Column 4 (Total)
            C = numC * 100;
            B = numB * 50;
            F = numF * 45;
            Sun = numSun * 30;
            Soft = numSoft * 20;

            Console.SetCursorPosition(50, 15);
            Console.Write("TOTAL");
            Console.SetCursorPosition(50, 17);
            Console.Write("P "+ C);
            Console.SetCursorPosition(50, 18);
            Console.Write("P " + B);
            Console.SetCursorPosition(50, 19);
            Console.Write("P " + F);
            Console.SetCursorPosition(50, 20);
            Console.Write("P " + Sun);
            Console.SetCursorPosition(50, 21);
            Console.Write("P " + Soft);

            // Total1
            total = C + B + F + Sun + Soft;

            Console.SetCursorPosition(4, 23);
            Console.Write("┌────────────────────────┐");
            Console.SetCursorPosition(4, 24);
            Console.Write("│                        │");
            Console.SetCursorPosition(4, 25);
            Console.Write("└────────────────────────┘");
            Console.SetCursorPosition(6, 24);
            Console.Write("Total Amount: P " + total);

            // Total w/ VAT
            tVAT = total + total * 0.10;
            Console.SetCursorPosition(32, 23);
            Console.Write("┌────────────────────────┐");
            Console.SetCursorPosition(32, 24);
            Console.Write("│                        │");
            Console.SetCursorPosition(32, 25);
            Console.Write("└────────────────────────┘");
            Console.SetCursorPosition(34, 24);
            Console.Write("Total w/ VAT: P " + tVAT);

            // Input Payment
            Console.SetCursorPosition(75, 16);
            Console.Write("┌────────────────────────────────┐");
            Console.SetCursorPosition(75, 17);
            Console.Write("│                                │");
            Console.SetCursorPosition(75, 18);
            Console.Write("└────────────────────────────────┘");
            Console.SetCursorPosition(80, 17);
            Console.Write("Enter payment: P ");
            payment = Double.Parse(Console.ReadLine());

            // Change
            change = payment - tVAT;
            Console.SetCursorPosition(75, 21);
            Console.Write("┌────────────────────────────────┐");
            Console.SetCursorPosition(75, 22);
            Console.Write("│                                │");
            Console.SetCursorPosition(75, 23);
            Console.Write("└────────────────────────────────┘");
            Console.SetCursorPosition(81, 22);
            Console.Write("Change: P " + change);

            // End
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(0, 27);
            Console.WriteLine("---------------------------------------- THANK YOU FOR ORDERING AT MCJOLLIBEE! -----------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.ReadLine();












        }
    }
}
