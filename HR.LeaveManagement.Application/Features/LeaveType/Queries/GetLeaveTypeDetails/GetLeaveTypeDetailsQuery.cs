using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;
}
