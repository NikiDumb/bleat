namespace Domasha2nd
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine(Domashek3.GenerateCheck( 100, 5, true));
            Console.WriteLine(Domashek3.ChooseSeat(9));
            Console.WriteLine(Domashek3.CheckSales( 16, 4, 5000));
            Console.WriteLine(Domashek3.ValidatePost(10, 10, 10, 5)); ;
        }
    }
}
