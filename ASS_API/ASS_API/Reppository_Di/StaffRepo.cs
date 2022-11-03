using ASS_API.DataAccessLayer;
using ASS_API.DbModels;
using ASS_API.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASS_API.Reppository_Di
{
    
    public class StaffRepo : IStaff
    {
        private readonly EfDbContext efDbContext;
        private readonly IMapper mapper;

        public StaffRepo(EfDbContext efDbContext, IMapper mapper)
        {
            this.efDbContext = efDbContext;
            this.mapper = mapper;
        }
        public async Task<int> AddStaff(StaffModel staff)
        {
            var k = efDbContext.Staff.Add(mapper.Map<Staff>(staff));
            efDbContext.SaveChanges();
            return 2;
        }
    }
}
