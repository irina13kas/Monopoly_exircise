using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace StorageWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController: ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        internal int PalletId => !User.Identity.IsAuthenticated
            ? 0
            : int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

        internal int BoxId => !User.Identity.IsAuthenticated
            ? 0
            : int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
    }
}
