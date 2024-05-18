using System;

class Program
{
    static void Main(string[] args)
    {
        int sec = 5;
        do{
            Console.Write(sec);
            Thread.Sleep(1000);
            Console.Write("\b\b\b \b");
            sec--;
        } while (sec > 0);
    }
}