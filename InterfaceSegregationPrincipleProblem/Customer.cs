/**
    Scenario:
        -IDiscount becomes a very popular interface, it's used accross hundreds of systems who all use it to make their own variations of the Customer class.
        -About half of these clients request you to add an extra GetXmasCustomerDiscount method to the interface. The other half of the clients live in countries where they
        don't celebrate xmas so they'd rather you didn't update the interface and force them to implement a method they'll never use.

        Think of a way to account for this change without ruining the interface for half the clients!
 */

interface IDiscount
{
    double GetCustomerDiscount(double productPrice);
    //double GetXmasCustomerDiscount(double productPrice);
}

class CustomerUK : IDiscount {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerUSA : IDiscount {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerChina : IDiscount {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerGermany : IDiscount {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerIndia : IDiscount {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerIreland : IDiscount {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
}



