using MediatR;

namespace mediatr_test
{
    public record NormalCommand : IRequest
    {
    }

    internal class NormalCommandHandler : IRequestHandler<NormalCommand>
    {
        private readonly ScopedService _service;

        public NormalCommandHandler(ScopedService service)
        {
            this._service = service;
        }
        public Task Handle(NormalCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine("NormalCommandHandler");

            this._service.DoSomething();
            return Task.FromResult(Unit.Value);
        }
    }
}
