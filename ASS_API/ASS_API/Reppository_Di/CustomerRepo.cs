using ASS_API.DataAccessLayer;
using ASS_API.Models;
using ASS_API.DbModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASS_API.Reppository_Di;

namespace ass_api.reppository_di
{
    public class CustomerRepo : ICustomer
    {

        private readonly EfDbContext efdbcontext = null;
        private readonly IMapper _mapper;
        public CustomerRepo(EfDbContext efdbcontext, IMapper mapper)
        {
            this.efdbcontext = efdbcontext;
            _mapper = mapper;
        }
        public async Task<int> AddCustomer(CustomerModel registration)
        {
            var obj = _mapper.Map<Customer>(registration);
            efdbcontext.Customer.Add(obj);
            await efdbcontext.SaveChangesAsync();
            //return registration.Id;
            return obj.Id;

        }

        public async Task<List<CustomerModel>> ShowCustomers()
        {
            var list = await efdbcontext.Customer.ToListAsync();
            return _mapper.Map<List<CustomerModel>>(list);
        }

        public async Task<CustomerModel> GetCustomerById(int userid)
        {
            var user = await efdbcontext.Customer.Where(x => x.Id == userid).FirstOrDefaultAsync();
            return _mapper.Map<CustomerModel>(user);
        }

        public async Task<int> UpdateCustomer(int userid, CustomerModel registration)
        {
            var user = await efdbcontext.Customer.Where(x => x.Id == userid).FirstOrDefaultAsync();
            if (user != null)
            {
                user.Name = registration.Name;
                user.Email = registration.Email;
                user.Dob = registration.Dob;
                user.Gender = registration.Gender;
            }
            await efdbcontext.SaveChangesAsync();
            return userid;
        }

        public async Task<int> DeleteCustomer(int userid)
        {
            var user = await efdbcontext.Customer.Where(x => x.Id == userid).FirstOrDefaultAsync();
            if (user != null)
            {
                efdbcontext.Customer.Remove(user);
                await efdbcontext.SaveChangesAsync();
            }
            return userid;
        }

        public async Task<CustomerModel> Login(string eMail, string password)
        {
            if(string.IsNullOrEmpty(eMail) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            var customer = await efdbcontext.Customer.FirstOrDefaultAsync(x => x.Email == eMail && x.Password == password);
            if(customer == null)
            {
                return null;
            }
            return _mapper.Map<CustomerModel>(customer) ;
        }
    }
}
