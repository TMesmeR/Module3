
    internal static class Module_3_7_Final
    {
          internal static  void Start()
           {
                Console.Write("Enter your name: ");
                var name = Console.ReadLine();
                Console.WriteLine();
                
                Console.Write("Enter your age: ");
                var age = checked((byte)int.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.WriteLine("Your name is {0} and age is {1} ", name, age);
                
                Console.WriteLine();

                Console.Write("What is your favorite day of week? ");
                var day = (DayOfWeek)int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Your favorite day is {0}", day);
                
                Console.WriteLine();

                Console.Write("Enter your birthday: ");
                var birthDay = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Your birthday: {0}", birthDay);

                Console.ReadLine();
           }
    }

