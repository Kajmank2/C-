using System;

namespace The_Discount_System
{
    public class DiscountRate
    {

        private static double serviceDiscountPremium = 0.2;
        private static double serviceDiscountGold = 0.15;
        private static double serviceDiscountSilver = 0.1;
        private static double productDiscountPremium = 0.1;
        private static double productDiscountGold = 0.1;
        private static double productDiscountSilver = 0.1;

        public static double getServiceDiscountRate(String type)
        {
            switch (type)
            {
                case "Premium":
                    return serviceDiscountPremium;
                case "Gold":
                    return serviceDiscountGold;
                case "Silver":
                    return serviceDiscountSilver;
                default:
                    throw new IllegalArgumentException("Dont WORK !");
            }
        }

        public static double getProductDiscountRate(string type)
        {
            if (type == "Premium")
                return productDiscountPremium;
            else if (type == "Gold")
                return productDiscountGold;
            else if (type == "Silver")
                return productDiscountSilver;
            else
                throw new IllegalArgumentException("DONT WORK ! ");

        }

        class Program
        {
            //You are asked to write a discount system for a beauty saloon, which provides services and sells beauty products.It offers 3 types of memberships: Premium, Gold and Silver.Premium, gold and silver members receive a discount of 20%, 15%, and 10%, respectively, for all services provided.Customers without membership receive no discount.All members receives a flat 10% discount on products purchased (this might change in future). Your system shall consist of three classes: Customer, Discount and Visit, as shown in the class diagram. It shall compute the total bill if a customer purchases $x of products and $y of services, for a visit.Also write a test program to exercise all the classes.
            static void Main(string[] args)
            {
                Customer customerek = new Customer("Andrzej");
                customerek.SetMembertype("Gold");
                Visit vizyciarz = new Visit(customerek, DateTime.UtcNow);

                Console.WriteLine(vizyciarz.getServiceExpense());
                vizyciarz.setProductExpense(21.00);
                Console.WriteLine(vizyciarz.getTotalExpense());


                Console.ReadKey();
            }
        }
        public class Visit
        {
            public Customer name;
            private DateTime date;
            private double serviceExpense;
            private double productExpense;

            public Visit(Customer name, DateTime date)
            {
                this.name = name;
                this.date = date;
            }

            public String getCustomerName()
            {
                return name.getName();
            }

            public double getServiceExpense()
            {
                return serviceExpense;
            }

            public void setServiceExpense(double serviceExpense)
            {
                this.serviceExpense = this.serviceExpense + serviceExpense;
            }

            public double getProductExpense()
            {
                return productExpense;
            }

            public void setProductExpense(double productExpense)
            {
                this.productExpense = this.productExpense + productExpense;
            }

            public double getTotalExpense()
            {
                return (serviceExpense - (serviceExpense * getServiceDiscountRate(name.getMemberType()))) +
                        (productExpense - (productExpense * getProductDiscountRate(name.getMemberType())));

            }



            public override string ToString()

            {
                return "Visit" + "Name : " + name.getName() + "customer member " + name.isMember() + "member type" 
                    + name.getMemberType() + " date : " + date + "serviceExpense" + serviceExpense 
                    + " productExpense" + productExpense;
            }
        }
        public class Customer
        {
            public string Name { get; set; }
            public bool Member = false;
            public string MemberType { get; set; }
            public Customer(string name = "Januszek")
            {
                this.Name = name;
            }
            public string getName()
            {
                return Name;
            }
            public bool isMember()
            {
                return Member;
            }
            public void SetMember(bool member)
            {
                Console.WriteLine(member);
            }
            public string getMemberType()
            {
                return MemberType;
            }
            public void SetMembertype(string member)
            {
                this.MemberType = member;
                Console.WriteLine(member);
            }
            public override string ToString()
            {
                return this.Name + " " + this.Member + " " + this.MemberType + " ";
            }

        }
    }
}
