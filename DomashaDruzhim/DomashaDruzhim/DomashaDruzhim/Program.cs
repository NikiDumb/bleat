namespace DomashaDruzhim
{
    internal class Program
    {
        
        static void Main(string[] args)
        { 
            Console.WriteLine(Domashek3.CalculateSalary(100,500));
            Console.WriteLine(string.Join(' ', Domashek3.CalculateBank(100000)));
            Console.WriteLine(Domashek3.CalculateCourierPrice(5));
        }
    }
}
