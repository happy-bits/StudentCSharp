// Usage of dictionaries. 

namespace CSharpCourse.Collections.Demo;

public class Demo2
{
    public static void Run()
    {
        /*
         
        Bookstore 1:

            Pricecategory A costs 35kr
            Pricecategory B costs 45kr
            Pricecategory C costs 68kr
        
        Bookstore 2:

            Pricecategory A costs 35kr
            Pricecategory B costs 35kr
            Pricecategory C costs 77kr
         
        Bookstore 3:

            Pricecategory A costs 35kr
            Pricecategory A costs 45kr
            Pricecategory C costs 68kr

        We can't model Bookstore 3 because no one known how much a book with category A costs

         */

        var p = new Dictionary<char, int>();

        p.Add('A', 35);
        p.Add('B', 45);
        p.Add('C', 68);

        // In a more compact way

        var prices = new Dictionary<char, int>
        {
            { 'A', 35 },
            { 'B', 45 },
            { 'C', 68 }
        };

        // Alternative way

        var prices_alternative = new Dictionary<char, int>
        {
            ['A'] = 35,
            ['B'] = 45,
            ['C'] = 68 
        };

        Console.WriteLine($"The books in price category A costs {prices['A']}kr");
        Console.WriteLine($"The books in price category B costs {prices['B']}kr");
        Console.WriteLine($"The books in price category C costs {prices['C']}kr");

        // Loop over the dictionary

        foreach (KeyValuePair<char, int> item in prices)
        {
            Console.WriteLine($"The books in price category {item.Key} costs {item.Value}kr");
        }

        // Check (and write) if price category B and/or D exist 

        if (prices.ContainsKey('B'))
        {
            Console.WriteLine("Price category B exist");
        }

        if (!prices.ContainsKey('D'))
        {
            Console.WriteLine("Price category D doesn't exist");
        }


        // Add a new price category D (with price 150kr)
        prices.Add('D', 150);

        // Remove price category B
        prices.Remove('B');

        //Change price of pricecategory A
        prices['A'] = 20;       

        Console.WriteLine($"Price category A now costs {prices['A']}kr");
    }
}
