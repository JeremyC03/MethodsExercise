namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 3));
            Console.WriteLine(Subtract(13, 3));
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Divide(9, 3));
            Console.WriteLine(Modulus(8, 3));

            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string? color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string? animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string? band = Console.ReadLine();

            Console.WriteLine($"Hello, my name is {name} and my favorite color is {color} I like listening to {band} with my {animal}.");

        }
        public static int Add(int num1, int num2)
        { 
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

    }
}
