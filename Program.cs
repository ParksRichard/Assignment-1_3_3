namespace Assignment_1_3_3
{
    internal class Program
    {
        //Write a program to read N number of values in an array and display in reverse order.
        //Storing 3 elements?
        //
        static void Main(string[] args)
        {
            
            Console.Write("Please input the how many elements to store in array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine($"Input {n} number of elements in the array :");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element - {i} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The values stored into the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("The values stored into the array in reverse are:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
