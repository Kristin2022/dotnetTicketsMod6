// See https://aka.ms/new-console-template for more information
using NLog;
string path = Directory.GetCurrentDirectory() + "\\nlog.config";
// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();
/*
// See https://aka.ms/new-console-template for more information
        var resp = "";
        string file = "ticket.csv";
        do
        {
            Console.WriteLine("1) Display tickets");
            Console.WriteLine("2) Enter ticket");
            resp = Console.ReadLine();
            if (resp == "1")
            {
                // display tickets
                if (File.Exists(file))
                {
                    StreamReader sr = new StreamReader(file);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        var arr = line.Split(',');
                        Ticket ticket = new Ticket(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
                        Console.WriteLine(ticket);
                    }
                    sr.Close();
                }
            }
            else if (resp == "2")
            {
                // enter ticket
                Console.WriteLine("Enter ticket id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter ticket summary:");
                string summary = Console.ReadLine();
                Console.WriteLine("Enter ticket status:");
                string status = Console.ReadLine();
                Console.WriteLine("Enter ticket priority:");
                string priority = Console.ReadLine();
                Console.WriteLine("Enter the submitter:");
                string submitter = Console.ReadLine();
                Console.WriteLine("Enter who is assigned:");
                string assigned = Console.ReadLine();
                Console.WriteLine("Enter who is watching: ");
                string watching = Console.ReadLine();

                Ticket newTicket = new Ticket(id, summary, status, priority, submitter, assigned, watching);

                // save ticket to file
                StreamWriter sw = new StreamWriter(file, append: true);
                sw.WriteLine(newTicket);
                sw.Close();
            }
        } while (resp == "1" || resp == "2");
*/