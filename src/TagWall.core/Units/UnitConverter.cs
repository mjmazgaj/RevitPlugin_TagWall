﻿using System;

namespace TagWall.core
{
    public static class UnitConverter
    {
        /// <summary>
        /// Convert feets to metric units
        /// </summary>
        /// <param name="value">Length in feets</param>
        /// <param name="decimals">Accuracy of returned value</param>
        /// <param name="type">Type of metric unit</param>
        /// <returns>Value in specified format</returns>
        public static double Convert(double value, int decimals, UnitsType type)
        {
            var _feetMetersRatio = 0.3048;

            switch (type)
            {
                case UnitsType.mm:
                    return Math.Round(value * _feetMetersRatio * 1000, decimals);
                case UnitsType.cm:
                    return Math.Round(value * _feetMetersRatio * 100, decimals);
                case UnitsType.dm:
                    return Math.Round(value * _feetMetersRatio * 10, decimals);
                case UnitsType.m:
                    return Math.Round(value * _feetMetersRatio, decimals);
                default:
                    return value;
            }
        }
    }
}