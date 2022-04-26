using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class ILeaveTypeDtoValidator :  AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
            RuleFor(c => c.DefaultDays)
               .NotEmpty().WithMessage("{PropertyDefaultDays} is required")
               .GreaterThan(0).WithMessage("{PropertyDefaultDays} must be at least 1")
               .LessThan(100).WithMessage("{PropertyDefaultDays}  must be less than 100");
        }
    }
}
