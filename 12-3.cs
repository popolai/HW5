using System;

namespace UnitConversionApp
{
    class Program
    {
        // 宣告委派
        delegate double ConvertToInches(double value);

        // 方法：英尺轉英吋
        public static double FeetToInches(double feet)
        {
            return feet * 12;
        }

        // 方法：碼轉英吋
        public static double YardsToInches(double yards)
        {
            return yards * 3 * 12;
        }

        static void Main(string[] args)
        {
            Console.Write("請輸入英吋類型 (1=英尺, 2=碼): ");
            string choice = Console.ReadLine();

            Console.Write("請輸入數值：");
            double input = double.Parse(Console.ReadLine());

            // 宣告委派變數
            ConvertToInches converter;

            if (choice == "1")
            {
                converter = new ConvertToInches(FeetToInches);
            }
            else
            {
                converter = new ConvertToInches(YardsToInches);
            }

            double result = converter(input);
            Console.WriteLine($"轉換成英吋：{result}");
        }
    }
}