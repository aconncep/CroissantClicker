using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CroissantClicker.Common
{
    public static class GameData
    {
        public static int clicks = 0;
        private static decimal croissants = 0;

        public static decimal Croissants
        {
            get
            {
                return Math.Floor(croissants); // Round down to display croissant count as an int
            }
            set
            {
                croissants = value;
            }
        }

        private static decimal croissantRate = 0; // Croissants per 200 ms

        public static decimal CroissantRate
        {
            get
            {
                return croissantRate;
            }
            set
            {
                croissantRate = value;
            }
        }


        public static decimal croissantsPerClick = 1;


        // Power-ups owned
        public static int basicBakers = 0;

        public static int BasicBakers
        {
            get
            {
                return basicBakers;
            }
            set
            {
                if (croissants >= (basicBakerCost * value))
                {
                    basicBakers += value;
                    CroissantRate += basicBakerIncrease * value;
                    croissants -= basicBakerCost * value;
                }
            }
        }


        // Power-up costs
        public static int basicBakerCost = 20;

        // Power-up increases (will be multiplied by 5)
        public static decimal basicBakerIncrease = 0.4M;

        // Power up tool tips


        public static void IncreaseCroissantsCount(decimal amount = 1)
        {
            croissants += amount;
            UIUpdater.UpdateAllLabels();
        }

        public static void IncreaseClicksCount(int amount = 1)
        {
            clicks += amount;
            UIUpdater.UpdateAllLabels();
        }

        public static void BuyBasicBaker(int amount = 1)
        {
            BasicBakers = amount;

            UIUpdater.UpdateAllLabels();
        }

    }
}
