using System;
using System.IO;
using static System.Array;
using static System.Console;

namespace LotteryFun
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter lotHistory = new StreamWriter("c:\\Users\\Nash\\Desktop\\LotHistory.txt", true);
            Random lotRandom = new Random();
            int[] lotPull = new int[6];

            lotPull[0] = lotRandom.Next(1, 69);
            lotPull[1] = lotRandom.Next(1, 69);
            lotPull[2] = lotRandom.Next(1, 69);
            lotPull[3] = lotRandom.Next(1, 69);
            lotPull[4] = lotRandom.Next(1, 69);
            lotPull[5] = lotRandom.Next(1, 26);

            Sort(lotPull, 0, 4);

            lotHistory.WriteLine(lotPull[0].ToString("00") + " " +
                                 lotPull[1].ToString("00") + " " +
                                 lotPull[2].ToString("00") + " " +
                                 lotPull[3].ToString("00") + " " +
                                 lotPull[4].ToString("00") + " " +
                                 lotPull[5].ToString("00") + " ");

            lotHistory.Close();

            FGColorGreen();

            Write(lotPull[0].ToString("00") + " " +
                  lotPull[1].ToString("00") + " " +
                  lotPull[2].ToString("00") + " " +
                  lotPull[3].ToString("00") + " " +
                  lotPull[4].ToString("00") + " ");

            FGColorRed();

            Write(lotPull[5].ToString("00"));
            ResetColors();
            Read();
        }

        //method to change the color of the PowerBall
        public static void FGColorRed()
        {
            ForegroundColor = ConsoleColor.Red;
        }

        public static void FGColorGreen()
        {
            ForegroundColor = ConsoleColor.Green;
        }

        public static void ResetColors()
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
        }
    }
}

//factor location of winners, frequency of how often each powerball pull number wins i.e. 1- 26,
//sets up numbers winning multiple times.  
