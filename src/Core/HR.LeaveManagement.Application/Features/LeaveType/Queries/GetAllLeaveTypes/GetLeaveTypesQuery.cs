using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public record GetLeaveTypesQuery(int id) : IRequest<List<LeaveTypeDto>>;
}