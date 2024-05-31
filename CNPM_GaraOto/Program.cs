using CNPM_GaraOto.UI.ChucNang.LapPhieuSuaChua;
using CNPM_GaraOto.UI.ChucNang.TiepNhanXe;
using CNPM_GaraOto.UI.DangNhap;

namespace CNPM_GaraOto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DangNhap());
        }
    }
}