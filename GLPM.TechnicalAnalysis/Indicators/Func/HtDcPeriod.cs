﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HtDcPeriod.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines HtDcPeriod.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static HtDcPeriod HtDcPeriod(int startIdx, int endIdx, double[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.HtDcPeriod(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outReal);
            return new HtDcPeriod(retCode, outBegIdx, outNBElement, outReal);
        }

        public static HtDcPeriod HtDcPeriod(int startIdx, int endIdx, float[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.HtDcPeriod(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outReal);
            return new HtDcPeriod(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class HtDcPeriod : IndicatorBase
    {
        public HtDcPeriod(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}