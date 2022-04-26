using HR.LeaveManagement.Application.DTOs.Common;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Feature.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand: IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDto UpdateLeaveRequestDto { get; set; } = new UpdateLeaveRequestDto();
        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApprovalDto { get; set; } = new ChangeLeaveRequestApprovalDto();   
    }
}
