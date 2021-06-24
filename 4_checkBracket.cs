using System;

public class Program
{
    //4.     მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან. 
    //       დაწერეთ ფუნქცია რომელიც აბრუნებს ფრჩხილები არის თუ არა 
    //       მათემატიკურად სწორად დასმული.

    public static bool isProperly(string sequence)
    {
        int l = 0, r = 0;
        foreach (Char i in sequence)
        {
            if (i == '(') l++;
            if (i == ')') r++;
        }
        return true ? l == r : false;
    }

    public static void Main()
    {
        string seq = "((()))";
        System.Console.WriteLine(isProperly(seq));
    }
}