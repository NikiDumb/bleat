

namespace DomashaDruzhim
{
    internal class Domashek3
    {
        public static double CalculateSalary(double salesCost, double salesPlan)
        {
            double planFactor = 0.05;
            double overPlanFactor = 0.1;
            double sellerSalary = salesCost * planFactor;

            if (salesCost >= salesPlan)
            {
                sellerSalary = salesPlan * planFactor + (salesCost - salesPlan) * overPlanFactor;
            }

            return sellerSalary;
        }

        public static double[] CalculateBank(double money )
        {
            double smallIncome = 1.08;
            double middleIncome = 1.095;
            double largeIncome = 1.1;
            double[] finalMoney = [money, money, money];

            for (int i = 0; i < 18; i++)
            {
                if (i < 9)
                {
                    finalMoney[0] = smallIncome/12*9*finalMoney[0];
                }
                if (i < 12)
                {
                    finalMoney[1] = middleIncome * finalMoney[1];
                }
                if (i < 18)
                {
                    finalMoney[2] *= largeIncome / 12 * 18 * finalMoney[2];
                }
            }

            return finalMoney;
        }

        public static double CalculateCourierPrice(double distance )
        {

            int fixedPrice = 150;
            int distancePrice = 70;
            double totalCost = fixedPrice + (int)distance * distancePrice;

            return totalCost;
        }
    }
}
