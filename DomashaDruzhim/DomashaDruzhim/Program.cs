namespace DomashaDruzhim
{
    internal class Program
    {
        static void AuchanSalary (double salesCost, double salesPlan, double planFactor = 0.05, double overPlanFactor = 0.1)
            {
                double sellerSalary = salesCost* planFactor;
                if (salesCost >= salesPlan)
                {
                    sellerSalary = salesPlan* planFactor + (salesCost-salesPlan)* overPlanFactor;
                }

                Console.WriteLine($"Зарплата сотрудника: {sellerSalary}руб");
            }

        static void UMenyaTeperIpotekaMaksem(double money, double smallIncome = 1.08, double middleIncome = 1.095, double largeIncome = 1.1)
            {
                double[] finalMoney = [money, money, money];

                for (int i = 0; i<18; i++)
                {
                    if (i<9) finalMoney[0]*=smallIncome;
                    if (i<12) finalMoney[1]*=middleIncome;
                    if (i<18) finalMoney[2]*=largeIncome;
                }

                Console.WriteLine("Прибыль вашего вклада:");
                Console.WriteLine($"через 9 месяцев: {finalMoney[0]}руб");
                Console.WriteLine($"через 12 месяцев: {finalMoney[1]}руб");
                Console.WriteLine($"через 18 месяцев: {finalMoney[2]}руб");
            }
        static void BestBanking(double money, int period, double income)
        {
            double totalMoney = money * Math.Pow(income, period);

            Console.WriteLine($"Денежки через {period} месяцев: {totalMoney}руб");
        }
        static void CourierPrice(double distance, int fixedPrice = 150, int distancePrice = 70)
            {
                int totalCost = fixedPrice + (int)distance * distancePrice;

                Console.WriteLine($"Итоговая стоимость доставки: {totalCost}руб");   
            }
        static void Main(string[] args)
        { 
            CourierPrice(8);
            AuchanSalary(180000, 140000);
            UMenyaTeperIpotekaMaksem(1000000);
            BestBanking(1000000, 9, 1.08);
        }
    }
}
