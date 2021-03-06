﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bop.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines Bop.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static Bop Bop(
            int startIdx,
            int endIdx,
            double[] open,
            double[] high,
            double[] low,
            double[] close)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Bop(
                startIdx,
                endIdx,
                open,
                high,
                low,
                close,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new Bop(retCode, outBegIdx, outNBElement, outReal);
        }

        public static Bop Bop(int startIdx, int endIdx, float[] open, float[] high, float[] low, float[] close)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Bop(
                startIdx,
                endIdx,
                open,
                high,
                low,
                close,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new Bop(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class Bop : IndicatorBase
    {
        public Bop(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}