using HR.LeaveManagement.Application.Feature.LeaveType.Queries.GetAllLeaveTypes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR.LeaveManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        public IMediator _mediator { get; }

        public LeaveTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<LeaveTypeDto>> Get()
        {
            var leaveTypes = await _mediator.Send(new GetLeaveTypesQuery());
            
            return leaveTypes;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
