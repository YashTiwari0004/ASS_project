using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASS_API.DataAccessLayer;
using AutoMapper;
using ASS_API.Models;
using ASS_API.DbModels;

namespace ASS_API.Reppository_Di
{
    public class AppointmentRepo : IAppointment
    {
        EfDbContext efDbContext = null;
        IMapper mapper = null;
        public AppointmentRepo(EfDbContext efDbContext, IMapper mapper)
        {
            this.efDbContext = efDbContext;
            this.mapper = mapper;
        }
        public async Task<bool> BookAppointment(AppointmentSchedulingModel book, char courtId, int custId, int staffId)
        {
            try
            {
                efDbContext.Book.Add(new AppointmentScheduling
                {
                    BookDate = book.BookDate,
                    StartTime = book.StartTime,
                    EndTime = book.EndTime,
                    CustomerId = custId,
                    StaffId = staffId,
                    CourtId = courtId
                });
                await efDbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Task<bool> CancelAppointment()
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetAppointmentDetails()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RescheduleAppointment()
        {
            throw new NotImplementedException();
        }
    }
}
