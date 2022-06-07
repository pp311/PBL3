

namespace Do_An
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new F_QuanLy());
            // Application.Run(new Form_HoaDon());
            //Application.Run(new F_NhanVienBH());
            //Application.Run(new F_NhanVienSC());
            // Application.Run(new Form2());
            Application.Run(new F_DangNhap());

            //   Application.Run(new F_Quanly());

        }
    }
}