public class Fraction{
    private int _topnum;
    private int _bottomnum;

    public Fraction(){
        _topnum = 1;
        _bottomnum = 1;
    }

    public Fraction(int top){
        _topnum = top;
        _bottomnum = 1;
    }

    public Fraction(int top, int bottom){
        _topnum = top;
        _bottomnum = bottom;
    }

    public int GetTopNum(){
        return _topnum;
    }

    public int GetBottomNum(){
        return _bottomnum;
    }

    public void SetTopNum(int top){
        _topnum = top;
    }

    public void SetBottomNum(int bottom){
        _bottomnum = bottom;
    }

    public string GetFractionString(){
        string _fractionString = $"{_topnum}/{_bottomnum}";
        return _fractionString;
    }

    public double GetDecimalValue(){
        return (double)_topnum / _bottomnum;
    }
}
