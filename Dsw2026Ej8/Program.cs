namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Product p = new Product();
            p.SetDescription("Original");

            // llamamos al método
            string resultado = Problema3.CompararCopias(5, p);

            Console.WriteLine(resultado);

            // vemos qué pasó con el producto original
            Console.WriteLine(p.GetDescription());
        }
    }
}
