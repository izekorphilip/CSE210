using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2, Philip World!");

        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Othertown", "NY", "USA");
        Customer customer2 = new Customer("Philip Izekor", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Tripod", "P1456", 10.99, 2));
        order1.AddProduct(new Product("Kettle", "P2786", 5.99, 3));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Iphone", "P5075", 7.99, 1));
        order2.AddProduct(new Product("Mac book computers", "P5997", 12.99, 2));

        Console.WriteLine($"Order 1 Total Cost: {order1.GetTotalCost()}");
        Console.WriteLine($"Order 1 Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Order 1 Shipping Label:\n{order1.GetShippingLabel()}\n");

        Console.WriteLine($"Order 2 Total Cost: {order2.GetTotalCost()}");
        Console.WriteLine($"Order 2 Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Order 2 Shipping Label:\n{order2.GetShippingLabel()}\n");
    }


    public class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public string GetFullAddress()
        {
            return $"{streetAddress}\n{city}, {stateProvince}\n{country}";
        }

        public bool IsInUSA()
        {
            return country.ToLower() == "usa";
        }
    }

    public class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public Address GetAddress()
        {
            return address;
        }

        public bool LivesInUSA()
        {
            return address.IsInUSA();
        }
    }

    public class Product
    {
        private string name;
        private string productId;
        private double price;
        private int quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return name;
        }

        public string GetProductId()
        {
            return productId;
        }

        public double GetTotalCost()
        {
            return price * quantity;
        }
    }

    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double GetTotalCost()
        {
            double totalCost = 0;
            foreach (var product in products)
            {
                totalCost += product.GetTotalCost();
            }
            if (customer.LivesInUSA())
            {
                totalCost += 5;
            }
            else
            {
                totalCost += 35;
            }
            return totalCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (var product in products)
            {
                packingLabel += $"Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"Name: {customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        }
    }

}