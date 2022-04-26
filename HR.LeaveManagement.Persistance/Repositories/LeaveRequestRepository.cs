using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistance.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly HrLeaveManagementDbContext _context;
        public LeaveRequestRepository(HrLeaveManagementDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovedStatus)
        {
            leaveRequest.Approved = ApprovedStatus;
            _context.Entry(leaveRequest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<LeaveRequest> GetLeaveRequestDetail(int id)
        {
            var leaveRequest = await _context.LeaveRequests
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id.Equals(id));
            return leaveRequest!;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsDetails()
        {
            var leaveRequests = await _context.LeaveRequests
                .Include(q => q.LeaveType)
                .ToListAsync();
            return leaveRequests;
        }
    }
}
