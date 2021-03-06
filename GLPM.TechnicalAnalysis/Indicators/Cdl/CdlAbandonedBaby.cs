﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CdlAbandonedBaby.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines CdlAbandonedBaby.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static CdlAbandonedBaby CdlAbandonedBaby(
            int startIdx,
            int endIdx,
            double[] open,
            double[] high,
            double[] low,
            double[] close,
            double penetration = 0.3)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            int[] outInteger = new int[endIdx - startIdx + 1];

            var retCode = TACore.CdlAbandonedBaby(
                startIdx,
                endIdx,
                open,
                high,
                low,
                close,
                penetration,
                ref outBegIdx,
                ref outNBElement,
                outInteger);
            return new CdlAbandonedBaby(retCode, outBegIdx, outNBElement, outInteger);
        }

        public static CdlAbandonedBaby CdlAbandonedBaby(
            int startIdx,
            int endIdx,
            float[] open,
            float[] high,
            float[] low,
            float[] close,
            double penetration = 0.3)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            int[] outInteger = new int[endIdx - startIdx + 1];

            var retCode = TACore.CdlAbandonedBaby(
                startIdx,
                endIdx,
                open,
                high,
                low,
                close,
                penetration,
                ref outBegIdx,
                ref outNBElement,
                outInteger);
            return new CdlAbandonedBaby(retCode, outBegIdx, outNBElement, outInteger);
        }
    }

    public class CdlAbandonedBaby : IndicatorBase
    {
        public CdlAbandonedBaby(RetCode retCode, int begIdx, int nbElement, int[] integer)
            : base(retCode, begIdx, nbElement)
        {
            this.Integer = integer;
        }

        public int[] Integer { get; }
    }
}