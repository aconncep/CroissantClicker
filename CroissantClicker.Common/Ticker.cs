using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CroissantClicker.Common
{
    public static class Ticker
    {
        private static Timer timer1 = new Timer(200);
        public static void TickerStart()
        {
            timer1.Elapsed += timer1_Tick;
            timer1.Start();
        }

        private static void timer1_Tick(object sender, EventArgs e)
        {
            GameData.IncreaseCroissantsCount(GameData.CroissantRate);
        }
    }
}
