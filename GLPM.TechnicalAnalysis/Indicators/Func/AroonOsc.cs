﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AroonOsc.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines AroonOsc.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static AroonOsc AroonOsc(
            int startIdx,
            int endIdx,
            double[] high,
            double[] low,
            int timePeriod = 14)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.AroonOsc(
                startIdx,
                endIdx,
                high,
                low,
                timePeriod,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new AroonOsc(retCode, outBegIdx, outNBElement, outReal);
        }

        public static AroonOsc AroonOsc(int startIdx, int endIdx, float[] high, float[] low, int timePeriod = 14)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.AroonOsc(
                startIdx,
                endIdx,
                high,
                low,
                timePeriod,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new AroonOsc(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class AroonOsc : IndicatorBase
    {
        public AroonOsc(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}