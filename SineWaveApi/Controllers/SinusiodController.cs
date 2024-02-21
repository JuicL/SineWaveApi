using Microsoft.AspNetCore.Mvc;
using SineWaveApi.DTO;
using SineWaveApi.Models;
using SineWaveApi.Services;

namespace SineWaveApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SinusiodController : Controller
    {
        private readonly ISinusoidService _sinusoidService;

        public SinusiodController(ISinusoidService sinusoidService)
        {
            _sinusoidService = sinusoidService;
        }

        [HttpPost]
        public async Task<IActionResult> SinusoidGraphicsAsync([FromBody] SinusoidGraphicsParamenersDTO parameters)
        {
            var sinusoidParameners = new SinusoidParameners(
                parameters.A,
                parameters.Fd,
                parameters.Fs,
                parameters.N
            );

            var graphics = await _sinusoidService.GenerateSinusoidGraphicsAsync(sinusoidParameners);
            var imageBytes = graphics.GetImageBytes(parameters.Width, parameters.Height);

            return File(imageBytes, "image/png", "sinusoidImage" + DateTime.Now.ToString());
        }
    }
}
