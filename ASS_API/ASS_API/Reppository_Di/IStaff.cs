using ASS_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASS_API.Reppository_Di
{
    interface IStaff
    {
        Task<int> AddStaff(StaffModel staff);
    }
}
