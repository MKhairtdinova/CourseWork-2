using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Информационная_система_v2
{
    public static class MeasureGenerator
    {
        private static Random rnd = new Random();

        public static string BloodPressureGenerator(int previousHigh, int previousLow)
        {
            int highValue = 0; // полученное верхнее давление
            int lowValue = 0; // полученное нижнее давление
            string measure = string.Empty; // результат
            int diff = 0; // разница от предыдущего или от среднего нормального

            if (previousLow == 0)
            {
                byte okHighValue = 115; // среднее нормальное верхнее давление

                byte okLowValue = 80; // среднее нормальное нижнее давление

                int choice = rnd.Next(1, 100) % 7 % 3; // выбор типа: высокое, нормальное или низкое давление

                switch (choice)
                {
                    case 0: // генерация низкого давления
                        diff = (rnd.Next(15, 30));
                        highValue = okHighValue - diff;
                        lowValue = okLowValue - diff;
                        break;

                    case 1: // генерация нормального давления
                        diff = rnd.Next(0, 7);

                        if (rnd.Next(0, 100) % 2 == 0) // выбор +/- от среднего нормального
                        {
                            highValue = okHighValue - diff;
                            lowValue = okLowValue - diff;
                        }
                        else
                        {
                            highValue = okHighValue + diff;
                            lowValue = okLowValue + diff;
                        }
                        break;

                    case 2: // генерация высокого давления
                        diff = rnd.Next(15, 50);
                        highValue = okHighValue + diff;
                        lowValue = okLowValue + diff;
                        break;
                }
            }
            else
            {
                int choice = rnd.Next(0, 9) % 7 % 3;

                switch (choice)
                {
                    case 0:
                        diff = rnd.Next(5, 10);
                        highValue = previousHigh + diff;
                        lowValue = previousLow + diff;

                        while (highValue > 170)
                        {
                            highValue -= 2;
                            lowValue -= 2;
                        }
                        break;

                    case 1:
                        highValue = previousHigh;
                        lowValue = previousLow;
                        break;

                    case 2:
                        diff = rnd.Next(5, 10);
                        highValue = previousHigh - diff;
                        lowValue = previousLow - diff;

                        while (highValue < 85)
                        {
                            highValue += 2;
                            lowValue += 2;
                        }
                        break;
                }
            }
            measure = highValue + " / " + lowValue;

            return measure;
        }

        public static string HeartRateGenerator(int prevRate)
        {
            string measure = string.Empty; // результат
            int rate = 0;           // текущий пульс
            int diff = 0;           // разница от среднего

            if (prevRate == 0)
            {
                int okRate = 70; // средний нормальный пульс

                int choice = rnd.Next(0, 100) % 7 % 3;

                switch (choice) // выбор пульса : пониженный, нормальный, учащенный
                {
                    case 0: // пониженный
                        diff = rnd.Next(15, 20);

                        rate = okRate - diff;
                        break;

                    case 1: // нормальный
                        diff = rnd.Next(0, 10);

                        if (rnd.Next(0, 10) % 2 == 0)
                            rate = okRate - diff;
                        else
                            rate = okRate + diff;
                        break;

                    case 2: // учащенный
                        diff = rnd.Next(20, 100);

                        rate = okRate + diff;
                        break;
                }
            }
            else
            {
                int choice = rnd.Next(0, 100) % 7 % 3;

                switch (choice)
                {
                    case 0:
                        diff = rnd.Next(5, 10);
                        rate = prevRate + diff;

                        while (rate > 200)
                        {rate -= 2;}
                        break;

                    case 1:
                        rate = prevRate;
                        break;

                    case 2:
                        diff = rnd.Next(5, 10);
                         rate = prevRate - diff;

                        while (rate < 50)
                        { rate += 2;}
                        break;
                }

            }
            measure = rate + " уд/мин.";
            return measure;
        }

        public static string BloodSugarLevelGenerator(double prevLevel)
        {
            string measure = string.Empty;  // результат
            double level = 0;               // текущий уровень
            double diff = 0;                // разница от нормы


            if (prevLevel == 0)
            {
                double okLevel = 4.5; // средний нормальный уровень

                int choice = rnd.Next(0, 100) % 7 % 3;

                switch (choice) // выбор уровня : пониженный, нормальный, повышенный
                {
                    case 0: // пониженный
                        diff = rnd.Next(15, 20)*0.1/0.1 / 10;

                        level = okLevel - diff;
                        break;

                    case 1: // нормальный
                        diff = rnd.Next(0, 10)*0.1/0.1 / 10;

                        if (rnd.Next(0, 10) % 2 == 0)
                            level = okLevel - diff;
                        else
                            level = okLevel + diff;
                        break;

                    case 2: // повышенный
                        diff = rnd.Next(15, 45)*0.1/0.1 / 10;

                        level = okLevel + diff;
                        break;
                }
            }
            else
            {
                int choice = rnd.Next(0, 100) % 7 % 3;

                switch (choice)
                {
                    case 0:
                        diff = ((double)rnd.Next(1, 3))/10 * 0.1/0.1;
                        level = prevLevel + diff;

                        while (level > 9)
                        {  level -= 0.1;}
                        break;

                    case 1:
                        level = prevLevel;
                        break;

                    case 2:
                        diff = ((double)rnd.Next(1, 3)) / 10*0.1/0.1;
                        level = prevLevel - diff;

                        while (level < 2.5)
                        { level += 0.1;}
                        break;
                }
            }

            measure = level + " ммоль/л.";

            return measure;
        }
    }
}
