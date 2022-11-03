using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASS_API.DbModels;
using ASS_API.Models;



namespace ASS_API.Reppository_Di
{
    public interface ICustomer
    {
        Task<CustomerModel> Login(string eMail, string password);
        Task<int> AddCustomer(CustomerModel registration);

        Task<List<CustomerModel>> ShowCustomers();

        Task<CustomerModel> GetCustomerById(int userId);

        Task<int> UpdateCustomer(int userId, CustomerModel registration);
        Task<int> DeleteCustomer(int userId);
    }

    
}
