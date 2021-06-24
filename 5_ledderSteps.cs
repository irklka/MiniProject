
using System;

public class Program
{
    //5.     გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია
    //       ავიდეთ 1 ან 2 საფეხურით. დაწერეთ ფუნქცია რომელიც
    //       დაითვლის n სართულზე ასვლის ვარიანტების რაოდენობას.
    //       1 1 2 3 5 8 13 21 34 ...
    //       | | | |  
    //       1 1 1 1
    //       1  2  1
    //       1 1  2
    //        2  1 1
    //        2  2  
   


    public static int countVariants(int stearsCount)
    {
        int f1=0,f2=1,fn=0;
        if(stearsCount<0){System.Console.WriteLine("Error, Enter correct number");return 0;}
        for(int i=1;i<=stearsCount;i++){
            fn=f1+f2;
            f1=f2;
            f2=fn;
        }
        return fn;
    }

    public static void Main()
    {
        int stairs = 11;//answer 144
        System.Console.WriteLine(countVariants(stairs));
    }
}