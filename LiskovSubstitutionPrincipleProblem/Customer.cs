/**
    Scenario:
        -There is a new Enquiry type customer added to your system. The issue here is enquiry customers should not be saved to the database.
        This breaks the LSP because you can no longer create a generic list of customers and have all functionality working ok if the list includes enquiry customers.

        Refactor this code so that it conforms to LSP.
 */

class Customer {
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
}

class GoldCustomer : Customer {
    public override double GetCustomerDiscount(double productPrice) {
        return (productPrice / 100) * 25;
    }
}
 
class Enquiry : Customer {
    public override double GetCustomerDiscount(double productPrice) {
        return (productPrice / 100) * 5;
    }

    public void AddToDatabase() {
        throw new Exception("Not allowed");
    }
}