namespace C_ProblemSet.Solutions;

public class BuyAndSellSolution
{
    public static int MaxProfit(int[] prices)
    {
        int profit = 0;
        int maxProfit = 0;
        int i = 0;
        int j = 1;

        while(j < prices.Length)
        {
            //Console.WriteLine("Left pointer is " + prices[i]);
            //Console.WriteLine("Right pointer is " + prices[j]);
            if (prices[j] > prices[i])
            {
                profit = prices[j] - prices[i];
                //Console.WriteLine("Profit is: "+profit);
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                i = j;
            }
            j++;
        }
        return maxProfit;
    }

}
