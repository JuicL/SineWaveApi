using System.ComponentModel.DataAnnotations;

namespace SineWaveApi.DTO
{
    public class SinusoidGraphicsParamenersDTO
    {
        /// <summary>
        /// Амплитуда
        /// </summary>
        [Range(float.Epsilon, float.MaxValue, ErrorMessage = "Amplitude must be positive")]
        public float A { get; set; }
        /// <summary>
        /// Частота дискретизации сигнала в точках за секунду
        /// </summary>
        [Range(float.Epsilon, float.MaxValue, ErrorMessage = "Sampling frequency must be positive")]
        public float Fd { get; set; }
        /// <summary>
        /// Частота сигнала в Гц
        /// </summary>
        [Range(float.Epsilon, float.MaxValue, ErrorMessage = "Signal frequency must be positive")]
        public float Fs { get; set; }
        /// <summary>
        /// Количество периодов
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "Number of periods must be positive")]
        public int N { get; set; }
        /// <summary>
        /// Ширина
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "Width must be positive")]
        public int Width { get; set; }
        /// <summary>
        /// Высота
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "Height must be positive")]
        public int Height { get; set; }
    }
}
