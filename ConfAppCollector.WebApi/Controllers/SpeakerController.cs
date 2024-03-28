using ConfAppCollector.Application;
using ConfAppCollector.Application.Interfaces;
using ConfAppCollector.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace ConfAppCollector.WebApi.Controllers
{
    [ApiController]
    [Route("api/speakers")]

    public class SpeakerController : Controller
    {
        private readonly ICreateSpeakerAppUseCase createAutorAppUseCase;
        private readonly IEditConfApplicationUseCase editConfAppUseCase;

        public SpeakerController(
            ICreateSpeakerAppUseCase createAutorAppUseCase,
            IEditConfApplicationUseCase editConfAppUseCase
            )
        {
            this.createAutorAppUseCase = createAutorAppUseCase;
            this.editConfAppUseCase = editConfAppUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAutor(SpeakerDTO authorDTO)
        {
            return Ok(await createAutorAppUseCase.ExecuteAsync(authorDTO, HttpContext.RequestAborted));
        }

        [HttpPut]
        public async Task<IActionResult> EditApplication(SpeakerDTO authorDTO)
        {
            return Ok(await editConfAppUseCase.ExecuteAsync(authorDTO, HttpContext.RequestAborted));
        }
    }
}
