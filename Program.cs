string? choice;
string file = "MarioCharacters.txt";
do
{
 Console.WriteLine("1) Mario Characters list.");
   Console.WriteLine("2) Add a new one .");
   Console.WriteLine("Press any key to exit .");
    
 choice = Console.ReadLine();

    if (choice == "1")
    {

        if (File.Exists(file))
        {
            StreamReader sr = new(file);
            while (!sr.EndOfStream)
            {
                string? line = sr.ReadLine();
            
                string[] arr = String.IsNullOrEmpty(line) ? new string[0] : line.Split('|');
                if (arr.Length == 3)
                {
                   Console.WriteLine("ID: {0}", arr[0]);
                Console.WriteLine("Nombre: {0}", arr[1]);
                Console.WriteLine("Relación: {0}", arr[2]);
                }
            }
            sr.Close();
        }
        else
        {
            Console.WriteLine("No file.");
        }
    }
    else if (choice == "2")
    {
        StreamWriter sw = new(file, true);
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("¿Would you like to add a character? (Y/N)?");
            
            string? resp = Console.ReadLine()?.ToUpper();
        
            if (resp != "Y") { break; }
                    Console.WriteLine("Add an ID number");
            string? id = Console.ReadLine();
        Console.WriteLine("Add the name .");
            string? name = Console.ReadLine();
     Console.WriteLine("Relationship with mario.");
            string? relationship = Console.ReadLine();
            sw.WriteLine("{0}|{1}|{2}", id, name, relationship);
         }
        sw.Close();
    }
} while (choice == "1" || choice == "2");
