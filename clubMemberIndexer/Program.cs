using System;
namespace yuhhh
{
    class Program
    {
        public const int Size = 15;  // global variable
        class clubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public clubMembers()
            {
                for (int  i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }
            //indexer get and set methods
            public string this[int index]
            {
                get
                {
                    string tmp;
                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp="";
                    }
                    return tmp;
                }
                set
                {
                    if (index >=0 && index <= Size - 1)
                    {
                        Members[index]=value;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            clubMembers Members = new clubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while(sub < Size)
                {
                    Console.WriteLine("Which club member you trynna enter gang?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Press 1 - {Size}");
                }
                Console.WriteLine("Enter the club members name");
                Members[sub-1] = Console.ReadLine();
                Console.WriteLine("Press any to continue, press e to stop");
                string stop = Console.ReadLine();
                if (stop == "e")
                    end=true;
            }
            Console.WriteLine("What kind of club is it?");
            Members.ClubType = Console.ReadLine();
            Console.WriteLine("Where's this club located it sounds intriguing.");
            Members.ClubLocation = Console.ReadLine();
            Console.WriteLine("Aight bet what day you trynna go blud?");
            Members.MeetingDate = Console.ReadLine();
            Console.WriteLine($"Okay just so we're clear...");
            Console.WriteLine($"Members");
            for (int i =  0; i < Size; i++)
            {
                if (Members[i] != null)
                    Console.WriteLine(Members[i]);
            }
            Console.WriteLine($"Club Type: {Members.ClubType}");
            Console.WriteLine($"Club Location: {Members.ClubLocation}");
            Console.WriteLine($"Meet up: {Members.MeetingDate}");
        }
    }
}