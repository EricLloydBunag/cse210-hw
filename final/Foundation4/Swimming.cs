public class Swimming : Activity{
    private int _laps;

    public Swimming(DateTime date, int length, int lap) : base(date, length){
        _laps = lap;
    }

    public override double GetDistance(){
         return ((_laps * 50) / 1000.0) * 0.62;
    }
    public override double GetSpeed(){
        return GetDistance() / GetActivityLength();
    }

    public override double GetPace(){
        return GetActivityLength() / GetDistance();
    }
}