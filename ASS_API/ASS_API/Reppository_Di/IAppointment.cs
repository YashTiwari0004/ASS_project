using ASS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASS_API.Reppository_Di
{
    public interface IAppointment
    {
        Task<bool> BookAppointment(AppointmentSchedulingModel book,char courtId, int custId, int staffId);
        Task<bool> CancelAppointment();
        Task<bool> RescheduleAppointment();
        Task<bool> GetAppointmentDetails();
    }
}
