using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApplication
{
    internal class Rate
    {
        private float dailyRate;
        private float weeklyRate;
        private float monthlyRate;

        public Rate(float dailyRate, float weeklyRate, float monthlyRate)
        {
            this.dailyRate = dailyRate;
            this.weeklyRate = weeklyRate;
            this.monthlyRate = monthlyRate;
        }
        public float DailyRate { get { return this.dailyRate; } }
        public float WeeklyRate { get {return this.weeklyRate; } }
        public float MonthlyRate { get {return this.monthlyRate; } }

        public float calculateCost(int days)
        {
            if (days / 31 >= 1)
            {
                return monthlyRate * (int) (days / 31);
            }
            if (days / 7 >= 1)
            {
                return weeklyRate * (int) (days / 7);
            }
            return dailyRate * days;
        }

        public string getCalculationFormula(int days)
        {
            float rate;
            string unit; // Days, Weeks or Months
            int length; // # of units

            if (days / 31 >= 1)
            {
                rate = monthlyRate;
                unit = "Month(s)";
                length = (int)(days / 31);
            }
            else if (days / 7 >= 1)
            {
                rate = weeklyRate;
                unit = "Week(s)";
                length = (int) (days / 7);
            }
            else {
                rate = dailyRate;
                unit = "Day(s)";
                length = days;

            }

            return String.Format("${0} X {1} {2}", rate, length, unit);
        }
    }
}
