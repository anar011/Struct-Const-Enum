

using DomainLayer.Models;
using ServiceLayer.Interface;

Customer customer1 = new Customer()
{

    Name = "Hesen",
    Surname = "Hesenov",
    Age = 20,
    Position = "Teacher"

};

Customer customer2 = new Customer()
{

    Name = "Hesen",
    Surname = "Hesenov",
    Age = 26,
    Position = "Teacher"

};


Customer customer3 = new Customer()
{

    Name = "Hesen",
    Surname = "Hesenov",
    Age = 28,
    Position = "Teacher"

};

Customer customer4 = new Customer()
{

    Name = "Hesen",
    Surname = "Hesenov",
    Age = 20,
    Position = "Teacher"

};

Customer customer5 = new Customer()
{

    Name = "Hesen",
    Surname = "Hesenov",
    Age = 20,
    Position = "Teacher"

};

Customer[] people = { customer1, customer2, customer3, customer4};



  double ICustomer.GetCustomerAge(int[] people)
{
    int count = 0;

    foreach (var item in people)

        if (item.Age < 30)
        {
            count++;


        }

    Console.WriteLine(count);

}