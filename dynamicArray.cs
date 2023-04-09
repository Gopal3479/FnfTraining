using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Enter the type of the array (int, double, string):");
        string type = Console.ReadLine();

        
        var arrayType = Type.GetType(type);
        if (arrayType == null)
        {
            Console.WriteLine("Invalid array type!");
            return;
        }

        var array = Array.CreateInstance(arrayType, size);

       
        Console.WriteLine($"Enter {size} values for the array:");
        for (int i = 0; i < size; i++)
        {
            var value = Console.ReadLine();
            array.SetValue(Convert.ChangeType(value, arrayType), i);
        }

       
        Console.WriteLine("Array contents are :");
        foreach (var value in array)
        {
            Console.WriteLine(value);
        }
    }
}
