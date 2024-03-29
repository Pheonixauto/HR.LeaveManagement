﻿using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestDetail(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsDetails();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovedStatus);
    }
}
