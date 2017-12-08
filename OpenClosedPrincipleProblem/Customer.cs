class Customer
{

    /**
        Scenario:
            This system was built with two customer types in mind:
                -Gold customers which get a 25% discount
                -Regular customers which get no discount

            Some business guy comes to you and says that he wants to introduct a branch new customer type to the system: 
                -Silver customers which get a 10% discount

            Refactor this code so that you can introduce the silver customer WITHOUT adding another if clause and make this code fall in line with the open closed principle.
        */

    public Customer(int customerType) {
        this.customerType = customerType;
    }

    public int customerType { get; set; }

    public double GetCustomerDiscount(double productPrice)
    {
            if (customerType == 1)
            {
                return (productPrice / 100) * 25;
            }
            else 
            {
                return 0;
            }
    }
}