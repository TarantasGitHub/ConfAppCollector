using ConfAppCollector.Application;
using ConfAppCollector.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConfAppCollector.WebApi.Controllers
{
    [ApiController]
    [Route("api/speakers")]

    public class SpeakerController : Controller
    {
        private readonly ICreateSpeakerAppUseCase createAutorAppUseCase;

        public SpeakerController(ICreateSpeakerAppUseCase createAutorAppUseCase)
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
