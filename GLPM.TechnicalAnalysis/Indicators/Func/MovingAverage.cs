﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MovingAverage.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines MovingAverage.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static MovingAverage MovingAverage(
            int startIdx,
            int endIdx,
            double[] real,
            int timePeriod = 30,
            MAType mAType = MAType.Sma)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.MovingAverage(
                startIdx,
                endIdx,
                real,
                timePeriod,
                mAType,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new MovingAverage(retCode, outBegIdx, outNBElement, outReal);
        }

        public static MovingAverage MovingAverage(
            int startIdx,
            int endIdx,
            float[] real,
            int timePeriod = 30,
            MAType mAType = MAType.Sma)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.MovingAverage(
                startIdx,
                endIdx,
                real,
                timePeriod,
                mAType,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new MovingAverage(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class MovingAverage : IndicatorBase
    {
        public MovingAverage(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}