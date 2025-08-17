using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    
    private static void Main(string[] args)
    {
        //Check the number is power of 2 or not 
        Console.WriteLine("==============Power of 2 for number===================");
        int  inputnumber=int.Parse(Console.ReadLine());
        if(IspowerOfTwo(inputnumber))
        {
            Console.WriteLine("this is power of two");
        }
        else
        {
            Console.WriteLine("this is not power of two");
        }
        //set a bit 
        Console.WriteLine("=====set bits in an integer.1101->1000====");
        Console.WriteLine("Enter a number");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            int setBits = CountSetBits(number);
            Console.WriteLine($" Number of Set{number} is {setBits}");
        }
        else
        {
            Console.WriteLine("invalid number");
        }

        Console.WriteLine("======FindDuplicatelistofstrings=======");
        string[] input = { "apple", "banana", "apple", "cherry", "banana", "date" };
        var result = FindDuplicatelistofstrings(input);
        Console.WriteLine(string.Join(" ,",result));

        Console.WriteLine("======FindDuplicatestrings=========");
        FindStringDuplicate();

        Console.WriteLine("=====StringReverse=================");
        StringReverse();
        

    }

    private static bool IspowerOfTwo(int input)
    {
        if (input <=0) return false;
        return (input & (input - 1)) == 0;
        
    }

    private static int CountSetBits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number = number & number - 1;
            count++;
        }
        return count;
    }

    //Reverse a string without Array.Reverse (iterative & recursive)
    static void StringReverse()
    {
        Console.WriteLine("--Reverse a string without.");
        string Input = Console.ReadLine();
        // Input = "Hello";
        string result = "";

        for (int i = Input.Length - 1; i >= 0; i--)
        {

            result = result + Input[i];
        }
        Console.WriteLine("current :{0}", Input);
        Console.WriteLine("resvese : {0}", result);
        Console.ReadLine();
    }
    static void FindStringDuplicate()
    {
        Console.WriteLine("---Please Add String---");
        string input = Console.ReadLine();
        
        var dictonary = new Dictionary<char, int>();
         if (input == null) return;
        
        foreach ( char C in input)
        {
            if(dictonary.ContainsKey(C))
                { dictonary[C]++ ; }
            else { dictonary[C] =1; }
        }

        Console.WriteLine("Duplicate characters:");
            foreach ( var duplicateValue in dictonary)
            { 
                if(duplicateValue.Value>1)
                {                   
                 Console.WriteLine( $"{duplicateValue.Key}: {duplicateValue.Value}");                    
                }
                    
            }
        

    }

    static List<string> FindDuplicatelistofstrings( string[] inputs)
    {

        var dictonary= new Dictionary<string, int>();
        var duplicate= new List<string>();
        foreach (var input in inputs)
        {
            if (dictonary.ContainsKey(input))
            { 
                dictonary[input]++; 
            }

            else { dictonary[input] = 1; }
        }
        Console.WriteLine("duplicate in list---");
        foreach (var dupcount in dictonary)
        {
            if (dupcount.Value > 1)
            {
                duplicate.Add(dupcount.Key);
            }
        }

        return duplicate;


    }
}