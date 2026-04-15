using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Avalon.WebApi.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class BooksController : ControllerBase
{
    private readonly IMediator _mediator;

    public BooksController (IMediator mediator)
    {
        _mediator = mediator;
    }
}