using System;

public class Program
{
    //2.		 გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, 
    //  		 რომელსაც გადაეცემა თანხა (თეთრებში) და აბრუნებს მონეტების 
    //  		 მინიმალურ რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.

    
    public static int minSplitGreedy(int[] arr,int amount)
    {
        int sum = 0;
        int a = 4;
        for (int i = amount; i > 0; i = i % arr[a], a--)
        {

            sum = sum + (i / arr[a]);
        }

        return sum;
    }
    public static int minSplitDp(int[] coins,int amount){

        Array.Sort(coins);
        int[] dp = new int[amount+1];
        int smallest = coins[0];
        for(int i = 0; i <= amount; i++){
            if(i == 0){
                dp[i] = 0;
                continue;
            }
            if(i < smallest){
                dp[i] = -1;
                continue;
            }

            int Min = Int32.MaxValue;

            foreach(var coin in coins){
                if(i-coin >= 0 && dp[i-coin] >= 0)
                    Min = Math.Min(Min,dp[i-coin]);
            }
            if(Min != Int32.MaxValue && Min >= 0){
                dp[i] = Min+1;
            }else{
                dp[i] = -1;
            }
        }
        return dp[amount];
    }

    public static void Main()
    {
        int[] coins = new int[] { 1, 5,6, 10, 20, 50 };
        int kaloda = 12;

        Console.WriteLine(minSplitGreedy(coins,kaloda));
        Console.WriteLine(minSplitDp(coins,kaloda));


    }
}