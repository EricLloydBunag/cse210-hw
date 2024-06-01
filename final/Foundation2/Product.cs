public class Product{
    private string _prodName {get;}
    private int _prodID {get;}
    private float _price;
    private int _quantity;

    public Product(string prodName, int prodID, float price){
        _prodName = prodName;
        _prodID = prodID;
        _price = price;
    }

    public Product(string prodName, int prodID, float price, int quantity){
        _prodName = prodName;
        _prodID = prodID;
        _price = price;
        _quantity = quantity;
    }

    public void SetQuantity(int quantity) {
        _quantity = quantity;
    }
    public float TotalCost(){
        return _price * _quantity;
    }

    public string GetProductDetails()
    {
        return $"{_prodName} x{_quantity} - {TotalCost()}\n{_prodID} - {_price}";
    }
}