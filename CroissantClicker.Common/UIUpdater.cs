using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroissantClicker.Common
{
    public static class UIUpdater
    {
        public delegate void UpdateLabels();
        public delegate void OpenCheatsMenu();
        public static event UpdateLabels UpdateLabelsEvent;
        public static event UpdateLabels UpdatePowerUpPricesEvent;
        public static event OpenCheatsMenu OpenCheatsMenuEvent;
        public static void UpdateAllLabels()
        {
            UpdateLabelsEvent.Invoke();
        }

        public static void InitializePowerUpData()
        {
            UpdatePowerUpPricesEvent.Invoke();
        }

        public static void LaunchCheatsMenu()
        {
            OpenCheatsMenuEvent.Invoke();
        }


    }
}
