﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CdlConcealBabysWall.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines CdlConcealBabysWall.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static CdlConcealBabysWall CdlConcealBabysWall(
            int startIdx,
            int endIdx,
            double[] open,
            double[] high,
            double[] low,
            double[] close)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            int[] outInteger = new int[endIdx - startIdx + 1];

            var retCode = TACore.CdlConcealBabysWall(
                startIdx,
                endIdx,
                open,
                high,
                low,
                close,
                ref outBegIdx,
                ref outNBElement,
                outInteger);
            return new CdlConcealBabysWall(retCode, outBegIdx, outNBElement, outInteger);
        }

        public static CdlConcealBabysWall CdlConcealBabysWall(
            int startIdx,
            int endIdx,
            float[] open,
            float[] high,
            float[] low,
            float[] close)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            int[] outInteger = new int[endIdx - startIdx + 1];

            var retCode = TACore.CdlConcealBabysWall(
                startIdx,
                endIdx,
                open,
                high,
                low,
                close,
                ref outBegIdx,
                ref outNBElement,
                outInteger);
            return new CdlConcealBabysWall(retCode, outBegIdx, outNBElement, outInteger);
        }
    }

    public class CdlConcealBabysWall : IndicatorBase
    {
        public CdlConcealBabysWall(RetCode retCode, int begIdx, int nbElement, int[] integer)
            : base(retCode, begIdx, nbElement)
        {
            this.Integer = integer;
        }

        public int[] Integer { get; }
    }
}