namespace Aula01.Console.Estruturada
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
            System.Console.WriteLine(args[0]);
            if(args[0] == "soma") {
                System.Console.WriteLine( "Vamos Somar");
            }
        }
    }
}