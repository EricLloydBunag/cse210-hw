public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country){
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public bool LivesInUSA(){
        if(_address.IsUSAddress()){
            return true;
        }
        else{
            return false;
        }
    }

    public string GetCustomerDetails(){
        return $"{_name}\n{_address.GetAddress()}";
    }
}