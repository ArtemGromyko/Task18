using System;
using System.Collections.Generic;
using System.Text;

namespace Task18
{
    static class MathStatistics
    {
        public static double RoundTo(double number, int digits)
        {
            double factor = Math.Pow(10, digits);
            return Math.Round(number * factor) / factor;
        }

        public static double CalcSum(params double[] nums)
        {
            double sum = 0;

            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];

            return sum;
        }

        public static double CalcAverage(params double[] nums) => CalcSum(nums) / nums.Length;

        public static double CalcDispercion(params double[] nums)
        {
            double avg = CalcAverage(nums);
            double sum = 0;

            for (int i = 0; i < nums.Length; i++)
                sum += nums[i] * nums[i];

            return sum / nums.Length - avg * avg;
        }

        public static double CalcStandardDeviation(params double[] nums)
        {
            return Math.Sqrt(CalcDispercion(nums));
        }

        public static double CalcCoefficientOfVariation(params double[] nums) => CalcStandardDeviation(nums) / CalcAverage(nums) * 100;
    }
}

