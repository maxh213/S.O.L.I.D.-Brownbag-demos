interface IDiscount
{
    double GetCustomerDiscount(double productPrice);
}

//could also be called IDiscountV2 if this is going to be common
interface IDiscountWithXmasExtension : IDiscount 
{
    double GetCustomerDiscount(double productPrice);
    double GetXmasCustomerDiscount(double productPrice);
}

class CustomerUK : IDiscountWithXmasExtension {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
    public double GetXmasCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerUSA : IDiscountWithXmasExtension {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
    public double GetXmasCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerChina : IDiscount {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerGermany : IDiscountWithXmasExtension {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
    public double GetXmasCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerIndia : IDiscount {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
}

class CustomerIreland : IDiscountWithXmasExtension {
    public double GetCustomerDiscount(double productPrice) {
        return 0;
    }
    public double GetXmasCustomerDiscount(double productPrice) {
        return 0;
    }
}