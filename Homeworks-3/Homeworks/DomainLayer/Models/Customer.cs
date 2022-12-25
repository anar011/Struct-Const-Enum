using ServiceLayer.Interface;

namespace DomainLayer.Models
{
    public class Customer : ICustomer

    {   
            public string Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        public int Age { get; set; } = 25;
            public string Position { get; set; }

        public double GetCustomerAge(int[] people)
        {
            throw new NotImplementedException();
        }
    }
}
