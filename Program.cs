namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        string[] colors = new string[3];
        string[] animals = {"Cat", "Dog", "Bird", "Giraffe", "Lizard"};
        int[] array;
        array = new int[5];

        colors[0] = "Yellow";
        colors[1] = "Blue";

        array[0] = 13;

        Console.WriteLine(animals[3]);  // Giraffe
        Console.WriteLine(colors[1]);   // Blue
        Console.WriteLine(array[0]);    // 13


        // Using loops with arrays

        Console.Write("Please enter the number of elements of the array : ");
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] numbers = new int[lengthOfArray];

        for (int i = 0; i < lengthOfArray; i++)
        {
            Console.Write($"Please enter the {i+1}. element of the array : ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Avarege is : " + sum/lengthOfArray);
    }
}
