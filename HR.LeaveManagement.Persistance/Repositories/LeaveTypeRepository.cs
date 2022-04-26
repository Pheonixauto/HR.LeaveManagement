using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistance.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly HrLeaveManagementDbContext _context;
        public LeaveTypeRepository(HrLeaveManagementDbContext context): base(context)
        {
            _context = context;
        }
        public Task<LeaveType> GetLeaveTypeDetail(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveType>> GetLeaveTypesDetails()
        {
            throw new NotImplementedException();
        }
    }
}
