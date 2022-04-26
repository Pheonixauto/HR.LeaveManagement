﻿using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Feature.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest:  IRequest<List<LeaveAllocationDto>>
    {
    }
}
