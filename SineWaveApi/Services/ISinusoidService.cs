using ScottPlot;
using SineWaveApi.Models;

namespace SineWaveApi.Services
{
    public interface ISinusoidService
    {
        Task<Plot> GenerateSinusoidGraphicsAsync(SinusoidParameners parameners);
    }
}