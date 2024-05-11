using System;

class Program
{
    static void Main(string[] args)
    {
        Car car= new Car(300);
        Console.WriteLine(car.Speed);

        car.Speed = 250;
        Console.WriteLine(car.Speed);        

    }
}

class Car{
    private int _speed;

    public Car(int speed){
        Speed = speed;
    }

    public int Speed { 
        get {return _speed; } 
        
        set
        {
            _speed = value;
        } 
    }
}


