
namespace IntroProject
{
    internal class Program
    {
        string myDisplayName;
        int myAge;
        static void Main(string[] args)
        {
            Program myProgram= new Program();
            myProgram.Run();
             
        }

        internal Program()
        {
            myDisplayName = "Duncan";
            myAge = 16;
        }

        private void Run()
        {
            Console.WriteLine("hello!, let me introduce myself");
            Console.WriteLine("i'm "+ "Duncan");

            
            string myAgeSentance = "i'm " + "16" +" years old";
            Console.WriteLine(myAgeSentance);

        }
    }
}
