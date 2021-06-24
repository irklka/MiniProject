using System;

public class Program
{
    //1.     დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი
    //       და აბრუნებს პალინდრომია თუ არა. (პალინდრომი 
    //       არის ტექსტი რომელიც ერთნაირად იკითხება ორივე მხრიდან). 


    static bool isPalindrome(string text)
    {
        string invStr = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            invStr += text[i];
        }
        if (text == invStr) return true;
        return false;
    }

    public static void Main()
    {


        string text = "rogor";
        if (text.Length > 0)
        {
            if (isPalindrome(text))
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");

        }
    }




}