using ConfAppCollector.Application;
using ConfAppCollector.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConfAppCollector.WebAPI.Controllers
{
    [ApiController]
    public class AuthorController : Controller
    {
        private readonly ICreateAutorAppUseCase createAutorAppUseCase;

        public AuthorController(ICreateAutorAppUseCase createAutorAppUseCase)
        {
            this.createAutorAppUseCase = createAutorAppUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAutor(SpeakerDTO authorDTO)
        {
            return Ok(await createAutorAppUseCase.ExecuteAsync(authorDTO, HttpContext.RequestAborted));
        }
    }
}
