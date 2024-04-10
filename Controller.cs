using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace mediatr_test
{
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IMediator _mediator;
        public Controller(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet("")]
        public async Task<string> Get()
        {
            await this._mediator.Send(new NormalCommand());
            return "Hello World!";
        }
    }
}
