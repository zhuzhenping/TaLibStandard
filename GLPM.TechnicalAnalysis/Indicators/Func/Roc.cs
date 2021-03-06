﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Roc.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines Roc.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static Roc Roc(int startIdx, int endIdx, double[] real, int timePeriod = 10)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Roc(startIdx, endIdx, real, timePeriod, ref outBegIdx, ref outNBElement, outReal);
            return new Roc(retCode, outBegIdx, outNBElement, outReal);
        }

        public static Roc Roc(int startIdx, int endIdx, float[] real, int timePeriod = 10)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Roc(startIdx, endIdx, real, timePeriod, ref outBegIdx, ref outNBElement, outReal);
            return new Roc(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class Roc : IndicatorBase
    {
        public Roc(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}