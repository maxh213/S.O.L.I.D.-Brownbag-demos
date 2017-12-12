class Customer {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
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
 