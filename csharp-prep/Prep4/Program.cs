using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numlist = new List<int>();
        int usernum;

        do{
        Console.WriteLine("Input a number; 0 ends the program: ");
        usernum = int.Parse(Console.ReadLine());
        numlist.Add(usernum);
        } while(usernum != 0);

        Console.WriteLine("The numbers you have inputted are:");
        int sum = 0;
        int maxValue = 0;
        foreach (int num in numlist){
            Console.WriteLine(num);
            sum += num;
            if (num > maxValue){
                maxValue = num;
            }
        }
        double average = (double)sum / numlist.Count;

        Console.WriteLine($"Max value is {maxValue}, and the sum of all numbers is {sum} with an average of {average}.");
    }
}