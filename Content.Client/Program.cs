using System;
using Robust.Client;
using Robust.Shared.Utility;

namespace Content.Client
{
    internal static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            if (IsHolidaySeason(DateTime.Now))
            {
                var options = new GameControllerOptions
                {
                    WindowIconSet = new ResPath(@"/Textures/_Lua/Logo/christmas_icon"),
                    SplashLogo = new ResPath(@"/Textures/_Lua/Logo/christmas_logo.png"),
                };
                ContentStart.StartLibrary(args, options);
            }
            else
            {
                ContentStart.Start(args);
            }
        }
        private static bool IsHolidaySeason(DateTime now)
        {
            var month = now.Month;
            var day = now.Day;
            return (month == 12 && day >= 1) || (month == 1 && day <= 15);
        }
    }
}
