using System;
using System.Threading.Tasks;

namespace Functions01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        //Program is de variable
        //Type is int
        //Program is type 
        //return type is void
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
        }
        internal void Vraag2() {
            Console.WriteLine("2 days");
            Console.WriteLine("Would you rather have a gay son or thot daughter?");
            string antwoord2 = Console.ReadLine();
        }
        internal void Vraag3() {
            Console.WriteLine("gay son");
            string antwoord3 = Console.ReadLine();
        }
        internal void Vraag4() {
            Console.WriteLine("If you could instantly master any skill, what would it be?");
            string antwoord4 = Console.ReadLine();
            Console.WriteLine("Languages");
        }
        internal void Vraag5()
        {
            Console.WriteLine("If you could live in any fictional universe, which one would you choose?");
            string antwoord5 = Console.ReadLine();
            Console.WriteLine("Monster Musume");
        }
            
          
        
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            Vraag1(); 
        }
    }
}
