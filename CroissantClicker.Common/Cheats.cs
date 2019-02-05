using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroissantClicker.Common
{
    public static class Cheats
    {
        public static string[] cheatCodes =
        {
            "penis",
            "69"
        };

        private static bool CheckCheatCode(string cheatInput)
        {
            if (cheatCodes.Contains(cheatInput))
            {
                return true;
            }
            return false;
        }

        public static bool ApplyCheatCode(string cheatCode)
        {
            if (CheckCheatCode(cheatCode)) // if the cheat code entered is valid
            {
                if (cheatCode == "penis")
                {
                    GameData.Croissants += 10000;
                    return true;
                }
                else if (cheatCode == "69")
                {
                    GameData.CroissantRate += 100;
                    return true;
                }
            }
            return false;
        }
    }
}
