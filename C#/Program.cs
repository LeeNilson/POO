using helloMundo.Entities;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Profissao prof= new Profissao("Professor", 4000.00);
            prof.Titulo = "Professor";
            Console.WriteLine("Olá Mundo!");
        }
    }
}