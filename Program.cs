using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeekFourClosingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Global variable defining ▼
            string greetingNote = "Welcome to producer Sir/Madam!\nWhich product you want produce?\n1- Telephone\n2- Computer\nPlease select '1' or '2' -> ";
            bool repeating = true;
            bool formatCheck = true;

            while (repeating) // -> Repeating until user says no to repeat yes/no question
            {

            GreetingAndTakingChoice: // -> For managing format error with goto in this part
                Console.Write(greetingNote);
                string produceAnswer = Console.ReadLine();
                if (produceAnswer == "1") // ->Answer for telephone
                {
                    // ▼ Getting features of product from user ▼
                    Console.WriteLine("\nOkey! ▼ Write your choices please below ▼ ");
                    Console.Write("Product name:");
                    string productName = Console.ReadLine();
                    Console.Write("Product explanation:");
                    string productExplanation = Console.ReadLine();
                    Console.Write("Operational system:");
                    string opsystem = Console.ReadLine();
                    Console.Write("TR License? (Yes or No) please:");
                    string licenseAnswer = Console.ReadLine().ToLower();
                    bool trlicensecheck = (licenseAnswer == "yes") ? true : false;

                    // ▼ Creating instance from Telephone with user answers ▼
                    BaseMachine telephone = new Telephone(productName, productExplanation, opsystem,trlicensecheck);
                    
                    // ▼ Information about finishing
                    Console.WriteLine("******************\nCong! Your product is manufacturing ...");
                    telephone.DisplayInfo();
                }
                else if (produceAnswer == "2") // -> Answer for computer
                {
                    // ▼ Getting features of product from user ▼
                    Console.WriteLine("\nOkey! ▼ Write your choices please below ▼ ");
                    Console.Write("Product name:");
                    string productName = Console.ReadLine();
                    Console.Write("Product explanation:");
                    string productExplanation = Console.ReadLine();
                    Console.Write("Operational system:");
                    string opsystem = Console.ReadLine();
                    Console.Write("Usb por count?:");
                    int usbCount =Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bluetooth? (Yes or No) please:");
                    string bluetothAnswer = Console.ReadLine().ToLower();
                    bool bluetoothCheck = (bluetothAnswer == "yes") ? true : false;

                    // ▼ Creating instance from Telephone with user answers ▼
                    BaseMachine computer = new Computer(productName, productExplanation, opsystem,usbCount,bluetoothCheck);

                    // ▼ Information about finishing
                    Console.WriteLine("******************\nCong! Your product is manufacturing ...");
                    computer.DisplayInfo();
                }
                else
                {
                    // ▼ Checking user input out of scope 1 or 2, managing this error with goto.
                    Console.WriteLine("Wrong format.Please try again and select '1' or '2'.\n");
                    goto GreetingAndTakingChoice;
                }

                // ▼ Checking part that user wants produce more item or not with do while ▼
                do
                {
                    Console.Write("Do you want produce another product? Yes/No please ->");
                    string repeatAnswer = Console.ReadLine().ToLower();
                    if (repeatAnswer == "yes")
                    {
                        repeating = true; // -> repeating answer for above of code 'while (repeating)' block
                        formatCheck = true; // -> formatCheck for this do while loop
                    }
                    else if (repeatAnswer == "no")
                    {
                        repeating = false; // -> repeating answer for above of code 'while (repeating)' block
                        formatCheck = true; // -> formatCheck for this do while loop
                    }
                    else
                    {
                        // ▼ If answer out of scope yes or no, format error and loop with do while for right format.
                        formatCheck = false; // -> formatCheck for this do while loop
                        Console.WriteLine("Wrong format. Please write 'Yes' or 'No'");
                    }
                }
                while (!formatCheck);
            }
            Console.WriteLine("\nYour produce process is finished! Thanks for cooperation.");
        }
    }
}
