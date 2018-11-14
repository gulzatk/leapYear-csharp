using System;
using System.Collections.Generic;


namespace Calendar
{
    

   class LeapYear
    {
        //     public static void isLeapYear(int intYear)
        // {
            
        // }    
    public static void Main()
        {
            Console.WriteLine("Please enter a year to check if it is a Leap Year.");
            string stringYear = Console.ReadLine();
            int intYear = int.Parse(stringYear);

           

            if (intYear % 400 == 0)
            {
                Console.WriteLine("This is a Leap Year.");
            }
            else if (intYear%100 == 0)
            {
                Console.WriteLine("This is not a Leap Year.");
            
            }
            else if(intYear % 4 == 0)
             {
            Console.WriteLine("This is a Leap Year.");
             }
             else
             {
                 Console.WriteLine("This is not a Leap Year.");
             }
            
        }
        
    }
}


