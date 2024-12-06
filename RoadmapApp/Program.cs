using System;
using System.Windows.Forms;
using RoadmapApp.Repositories;

namespace RoadmapApp
{
    static class Program
    {
        public static UserRepository UserRepo { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserRepo = new UserRepository("users.json");
            UserRepo.Load(); 

            Application.Run(new Forms.FormLogin());
        }
    }
}
