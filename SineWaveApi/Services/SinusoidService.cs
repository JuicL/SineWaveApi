using ScottPlot;
using SineWaveApi.Models;

namespace SineWaveApi.Services
{
    public class SinusoidService : ISinusoidService
    {
        public Task<Plot> GenerateSinusoidGraphicsAsync(SinusoidParameners parameners) => Task.Run(() =>
        {
            Plot myPlot = new();
            myPlot.Axes.SetLimitsX(0, parameners.N);
            List<double> xs = new();
            List<double> ys = new();

            // Относительная круговая частота
            var w = 2 * Math.PI * parameners.Fs / parameners.Fd;

            for (int i = 0; i <= parameners.N; i++)
            {
                var y = parameners.A * Math.Sin(w * i);
                xs.Add(i);
                ys.Add(y);
            }

            var sp = myPlot.Add.Scatter(xs, ys);
            sp.MarkerSize = 0;
            sp.LineWidth = 2;
            sp.Color = Colors.Red;

            return myPlot;

        });
    }
}
