
namespace GUI_QLHT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static User user;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FakeData fakeData = new FakeData();
            //fakeData.CreateFakeData();
            Application.Run(new fStatsDetail(2));
        }
    }
}