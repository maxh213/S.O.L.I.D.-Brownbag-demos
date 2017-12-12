interface IDiscount
{
    double GetCustomerDiscount(double productPrice);
}

interface IDatabase
{
    void AddToDatabase();
}

class Customer : IDiscount, IDatabase {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }

    public void AddToDatabase() {
        //database stuff
    }
}

class SilverCustomer : Customer {
    public override double GetCustomerDiscount(double productPrice) {
        return (productPrice / 100) * 10;
    }

    //Should you ever want to overwrite the add method you can
    public override void AddToDatabase() {
        //database stuff
    }

}
 
class Enquiry : IDiscount {
    public override double GetCustomerDiscount(double productPrice) {
        return (productPrice / 100) * 5;
    }
}

List<IDatabase> Customers = new list<IDatabase>();
Customers.add(new SilverCustomer());
Customers.add(new Enquiry());//In an IDE this line would have a red squigle underneath it!

foreach (IDatabase customer in Customers) {
    customer.AddToDatabase();
}