using System;
using System.Collections;

public class Program
{
    // 3.     მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან. 
    //        დაწერეთ ფუნქცია რომელსაც გადაეცემა ეს მასივი და აბრუნებს 
    //        მინიმალურ მთელ რიცხვს, რომელიც 0-ზე მეტია და ამ მასივში არ შედის.]
    
    public static int notContains(int[] array)
    {
        Array.Sort(array);
        int a = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (a == array[i]) a++;
        }
        return a;
    }

    
    public static void Main()
    {
        int[] arr = new int[] { 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine(notContains(arr));
    }
}