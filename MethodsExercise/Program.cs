
namespace MethodsExercise
{
    public class Program
    {
        public static IEnumerable<int> ListNumbers { get; private set; }

        static void Main(string[] args)
        {

            //GreetPerson("Philip");
            //GreetPerson("Jeff");

            //GreetTypedName();

            //Conversation();


            int y = Add(1,1,1,1,1);

            // Displaying result 
            Console.WriteLine(y);


            int addingNum = Sum(2,4);
            Console.WriteLine(addingNum);

            int times = Multiply(2, 10);
            Console.WriteLine(times);
        }

        public static void GreetPerson(string name)
        { Console.WriteLine($"Hi,{name}."); }

        public static void GreetTypedName() 
        {
          Console.WriteLine("Enter your name and press enter:");

          string name = Console.ReadLine();

          Console.WriteLine($"Hey, {name}, Nice to meet you!");
        }

        public static void Conversation()
        {
            Console.WriteLine("Enter your name and press enter:\n");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}, Nice to meet you! \nHey {name}, what is your favorite color?\n");

            string color = Console.ReadLine();

            if (color == "purple")
            { Console.WriteLine($"{color}? I like {color} too! \n{name}, what is your favotie animal?\n"); }
            else if (color=="Purple")
            { Console.WriteLine($"{color}? I like {color} too! \n{name}, what is your favotie animal?\n"); }
            else { Console.WriteLine($"{color}? That's a nice color. \n{name}, what is your favotie animal?\n"); }

            string animal = Console.ReadLine();

            if (animal == "dog" || animal == "Dog" || animal == "dogs" || animal == "Dogs")
            { Console.WriteLine($"Really? I like {animal} too? \nWhat is your favotie band or musician?? \n");}
            else { Console.WriteLine("Really? That's awsome!! \nWhat is your favotie band or musician?? \n"); }

            string band = Console.ReadLine();

            Console.WriteLine($"{band}? That is so cool.\n \nHey {name}, It was nice meeting you!");
        }

        public static int Sum(int num1, int num2)
        { 
            return num1 + num2; 
        }

        public static int Multiply(int num1, int num2)
        { return num1 * num2; }

        public static int Add(params int[] listNumbers)
        {
            int total = 0;

            foreach (int i in listNumbers)
            {
                total += i;
            }
            return total;
        }


    

    }
}
