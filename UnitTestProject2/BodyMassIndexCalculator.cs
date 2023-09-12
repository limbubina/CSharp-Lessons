using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13.Quiz
{
    internal class BodyMassIndexCalculator
    {
        private int weight;
        private int heightInFeet;
        private int heightInInches;

        public BodyMassIndexCalculator()
        {

        }
        public BodyMassIndexCalculator(int lbs, int feet, int inches)
        {
            weight = lbs;
            heightInFeet = feet;
            heightInInches = inches;
        }

        public int HeightInFeet
        {
            get => heightInFeet;
            set => heightInFeet = value;
        }
        public int HeightInInches
        {
            get => heightInInches;
            set => heightInInches = value;
        }
        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public double CalculateBMI()
        {
            return (weight * 703)/Math.Pow((heightInFeet*12+heightInInches),2);
        }

        public override string ToString()
        {
            return "BMI: " + CalculateBMI().ToString("F2");
        }
    }
}
