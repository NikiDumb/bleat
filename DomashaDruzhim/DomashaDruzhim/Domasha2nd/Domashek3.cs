

namespace Domasha2nd
{
    internal class Domashek3
    {
        public static double GenerateCheck(double price, double count, bool isSale )
        {
            int countForSale = 5;
            double totalSale = 0;

            if (count >= countForSale)
            {
                totalSale += 0.1;
            }
            if (isSale)
            {
                totalSale += 0.15;
            }

            double totalPrice = price * count - price * totalSale * count;

            return totalPrice;
        }

        public static int ChooseSeat(int clientsCount)
        {
            int varTable = 0;
            if (clientsCount > 0 && clientsCount <= 2)
            {
                varTable = 1;
            }
            else if (clientsCount > 2 && clientsCount <= 4)
            {
                varTable = 2;
            }
            else if (clientsCount > 4 && clientsCount <= 8)
            {
                varTable = 3;
            }

            return varTable;
        }

        public static bool CheckSales(int age, int ordersCount, double totalExpense )
        {

            int ageForSale = 60;
            double expenseForSale = 5000;
            double ordersForSale = 4;
            bool isSale = false;

            if (age > ageForSale || ordersCount >= ordersForSale && totalExpense >= expenseForSale)
            {
                isSale = true;
            }

            return isSale;
        }

        public static bool ValidatePost(double length, double width, double heigth, double distance )
        {

            double validateGabaritesSum = 150;
            double maxMeasure = 100;
            double minDistance = 3;
            double maxDistance = 10;
            bool isValid = true;

            if (length + width + heigth > validateGabaritesSum)
            {
                Console.WriteLine("Не прохожу по габаритам");
                isValid = false;
            }
            else if (length > maxMeasure || width > maxMeasure || heigth > maxMeasure)
            {
                Console.WriteLine("Слишком большой у тебя он");
                isValid = false;
            }
            else if (distance > maxDistance || distance < minDistance)
            {
                Console.WriteLine("Плохо с расстоянием");
                isValid = false;
            }

            return isValid;
        }
    }
}
