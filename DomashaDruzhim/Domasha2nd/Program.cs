namespace Domasha2nd
{
    internal class Program
    {

        static void TicketOffice(string productName, double price, double count, bool onSale, int count4sale=5, double totalSale = 0)
        {
            if (count >= count4sale) totalSale += 0.1;
            if (onSale == true) totalSale += 0.15;

            double totalPrice = price * count - price * totalSale * count;

            Console.WriteLine($"ИП Максем\r\n{productName} {count}шт цена за шт {price}руб\r\nИтого: {totalPrice}руб" );

        }
        static void RestoTables(int clientsCount)
        {
            int varTable = 0;

            if (clientsCount > 0 & clientsCount <= 2) varTable = 1;
            else if (clientsCount > 2 & clientsCount <= 4) varTable = 2;
            else if (clientsCount > 4 & clientsCount <= 8) varTable = 3;

            Console.WriteLine($"Тип вашего посадочного места: {varTable}. (если там нолик петляйте отсюда, мы словарь не подгрузили просто)");
        }

        static void SalesManager(string name, int age, int ordersCount, double totalExpense, int age4sale = 60, double expense4sale = 5000, double orders4sale = 4 )
        {
            bool sale = false;

            if (age > 60 || ordersCount >= orders4sale & totalExpense >= expense4sale) sale = true;

            Console.WriteLine($"Получит ли {name} скидку?\r\n{sale}");
        }
        static void CourierValidator(double length, double width, double heigth, double distance, double validateGabaritesSum = 150, double maxMeasure = 100, double minDistance = 3, double maxDistance = 10 )
        {
            if (length+width+heigth>validateGabaritesSum)
            {
                Console.WriteLine("Не прохожу по габаритам");
                return;
            }
            if (length>maxMeasure || width > maxMeasure || heigth > maxMeasure)
            {
                Console.WriteLine("Слишком большой у тебя он");
                return;
            }
            if (distance>maxDistance || distance<minDistance)
            {
                Console.WriteLine("Плохо с расстоянием");
                return;
            }

            Console.WriteLine("Все ок)");
        }
        static void Main(string[] args)
        {
            TicketOffice("Ипотека", 100, 5, true);
            RestoTables(9);
            SalesManager("Алиса", 16, 4, 5000);
            CourierValidator(10, 10, 10, 5); ;
        }
    }
}
