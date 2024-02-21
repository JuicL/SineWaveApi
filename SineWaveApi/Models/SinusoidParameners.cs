namespace SineWaveApi.Models
{
    public class SinusoidParameners
    {
        public SinusoidParameners(float a, float fd, float fs, int n)
        {
            A = a;
            Fd = fd;
            Fs = fs;
            N = n;
        }

        /// <summary>
        /// Амплитуда
        /// </summary>
        public float A { get; set; }
        /// <summary>
        /// Частота дискретизации сигнала в точках за секунду
        /// </summary>
        public float Fd { get; set; }
        /// <summary>
        /// Частота сигнала в Гц
        /// </summary>
        public float Fs { get; set; }
        /// <summary>
        /// Количество периодов
        /// </summary>
        public int N { get; set; }
    }

}