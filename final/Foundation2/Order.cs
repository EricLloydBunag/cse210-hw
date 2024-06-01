public class Order{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products){
        _customer = customer;
        _products = products;
    }

    public float GetTotalOrderCost()
    {
        float productTotal = 0;
        float shipping;
        if (_customer.LivesInUSA()){
            shipping = 5;
        }
        else{
            shipping = 35;
        }
        foreach (Product product in _products){
            productTotal += product.TotalCost();
        }
        float total = productTotal + shipping;
        return total;
    }

    public void DisplayShippingLabel(){
        Console.WriteLine(_customer.GetCustomerDetails());
    }    

    public void DisplayPackingLabel(){
        foreach (Product product in _products){
            Console.WriteLine(product.GetProductDetails());
        }
    }
}