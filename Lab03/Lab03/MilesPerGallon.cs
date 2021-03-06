﻿using System;

namespace Lab03
{
    public class MilesPerGallon
    {
        private double _gallons;
        private double _miles;

        public double Mpg
        {
            get { return Miles / Gallons; }
        }

        public double Miles
        {
            get => _miles;
            set
            {
                ValidateNonNegative(value);
                _miles = value;
            }
        }

        public double Gallons
        {
            get => _gallons;
            set
            {
                ValidateNonNegative(value);
                ValidateNonZero(value);
                _gallons = value;
            }
        }

        private void ValidateNonNegative(double value)
        {
            if (value < 0) throw new NegativeNumberException();
        }

        private void ValidateNonZero(double value)
        {
            if (value == 0) throw new ArgumentOutOfRangeException($"Value for {nameof(Gallons)} can not be zero.");
        }
    }
}