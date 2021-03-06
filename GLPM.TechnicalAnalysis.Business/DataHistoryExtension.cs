﻿namespace GLPM.TechnicalAnalysis.Business
{
    using System;

    public static class DataHistoryExtension
    {
        public static DataHistory ComputeAcos(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Acos, priceDataPoint);

        public static DataHistory ComputeAd(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Ad, priceDataPoint);

        public static DataHistory ComputeAdd(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Add, priceDataPoint);

        public static DataHistory ComputeAdOsc(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.AdOsc, priceDataPoint);

        public static DataHistory ComputeAdx(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Adx, priceDataPoint);

        public static DataHistory ComputeAdxr(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Adxr, priceDataPoint);

        public static DataHistory ComputeApo(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Apo, priceDataPoint);

        public static DataHistory ComputeAroon(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Aroon, priceDataPoint);

        public static DataHistory ComputeAroonOsc(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.AroonOsc, priceDataPoint);

        public static DataHistory ComputeAsin(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Asin, priceDataPoint);

        public static DataHistory ComputeAtan(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Atan, priceDataPoint);

        public static DataHistory ComputeAtr(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Atr, priceDataPoint);

        public static DataHistory ComputeAvgPrice(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.AvgPrice, priceDataPoint);

        public static DataHistory ComputeBbands(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Bbands, priceDataPoint);

        public static DataHistory ComputeBeta(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Beta, priceDataPoint);

        public static DataHistory ComputeBop(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Bop, priceDataPoint);

        public static DataHistory ComputeCci(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cci, priceDataPoint);

        public static DataHistory ComputeCdl2Crows(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cdl2Crows, priceDataPoint);

        public static DataHistory ComputeCdl3BlackCrows(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cdl3BlackCrows, priceDataPoint);

        public static DataHistory ComputeCdl3Inside(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cdl3Inside, priceDataPoint);

        public static DataHistory ComputeCdl3LineStrike(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cdl3LineStrike, priceDataPoint);

        public static DataHistory ComputeCdl3Outside(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cdl3Outside, priceDataPoint);

        public static DataHistory ComputeCdl3StarsInSouth(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cdl3StarsInSouth, priceDataPoint);

        public static DataHistory ComputeCdl3WhiteSoldiers(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cdl3WhiteSoldiers, priceDataPoint);

        public static DataHistory ComputeCdlAbandonedBaby(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlAbandonedBaby, priceDataPoint);

        public static DataHistory ComputeCdlAdvanceBlock(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlAdvanceBlock, priceDataPoint);

        public static DataHistory ComputeCdlBeltHold(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlBeltHold, priceDataPoint);

        public static DataHistory ComputeCdlBreakaway(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlBreakaway, priceDataPoint);

        public static DataHistory ComputeCdlClosingMarubozu(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlClosingMarubozu, priceDataPoint);

        public static DataHistory ComputeCdlConcealBabysWall(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlConcealBabysWall, priceDataPoint);

        public static DataHistory ComputeCdlCounterAttack(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlCounterAttack, priceDataPoint);

        public static DataHistory ComputeCdlDarkCloudCover(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlDarkCloudCover, priceDataPoint);

        public static DataHistory ComputeCdlDoji(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlDoji, priceDataPoint);

        public static DataHistory ComputeCdlDojiStar(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlDojiStar, priceDataPoint);

        public static DataHistory ComputeCdlDragonflyDoji(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlDragonflyDoji, priceDataPoint);

        public static DataHistory ComputeCdlEngulfing(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlEngulfing, priceDataPoint);

        public static DataHistory ComputeCdlEveningDojiStar(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlEveningDojiStar, priceDataPoint);

        public static DataHistory ComputeCdlEveningStar(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlEveningStar, priceDataPoint);

        public static DataHistory ComputeCdlGapSideSideWhite(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlGapSideSideWhite, priceDataPoint);

        public static DataHistory ComputeCdlGravestoneDoji(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlGravestoneDoji, priceDataPoint);

        public static DataHistory ComputeCdlHammer(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlHammer, priceDataPoint);

        public static DataHistory ComputeCdlHangingMan(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlHangingMan, priceDataPoint);

        public static DataHistory ComputeCdlHarami(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlHarami, priceDataPoint);

        public static DataHistory ComputeCdlHaramiCross(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlHaramiCross, priceDataPoint);

        public static DataHistory ComputeCdlHignWave(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlHignWave, priceDataPoint);

        public static DataHistory ComputeCdlHikkake(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlHikkake, priceDataPoint);

        public static DataHistory ComputeCdlHikkakeMod(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlHikkakeMod, priceDataPoint);

        public static DataHistory ComputeCdlHomingPigeon(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlHomingPigeon, priceDataPoint);

        public static DataHistory ComputeCdlIdentical3Crows(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlIdentical3Crows, priceDataPoint);

        public static DataHistory ComputeCdlInNeck(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlInNeck, priceDataPoint);

        public static DataHistory ComputeCdlInvertedHammer(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlInvertedHammer, priceDataPoint);

        public static DataHistory ComputeCdlKicking(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlKicking, priceDataPoint);

        public static DataHistory ComputeCdlKickingByLength(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlKickingByLength, priceDataPoint);

        public static DataHistory ComputeCdlLadderBottom(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlLadderBottom, priceDataPoint);

        public static DataHistory ComputeCdlLongLeggedDoji(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlLongLeggedDoji, priceDataPoint);

        public static DataHistory ComputeCdlLongLine(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlLongLine, priceDataPoint);

        public static DataHistory ComputeCdlMarubozu(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlMarubozu, priceDataPoint);

        public static DataHistory ComputeCdlMatchingLow(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlMatchingLow, priceDataPoint);

        public static DataHistory ComputeCdlMatHold(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlMatHold, priceDataPoint);

        public static DataHistory ComputeCdlMorningDojiStar(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlMorningDojiStar, priceDataPoint);

        public static DataHistory ComputeCdlMorningStar(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlMorningStar, priceDataPoint);

        public static DataHistory ComputeCdlOnNeck(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlOnNeck, priceDataPoint);

        public static DataHistory ComputeCdlPiercing(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlPiercing, priceDataPoint);

        public static DataHistory ComputeCdlRickshawMan(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlRickshawMan, priceDataPoint);

        public static DataHistory ComputeCdlRiseFall3Methods(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlRiseFall3Methods, priceDataPoint);

        public static DataHistory ComputeCdlSeperatingLines(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlSeperatingLines, priceDataPoint);

        public static DataHistory ComputeCdlShootingStar(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlShootingStar, priceDataPoint);

        public static DataHistory ComputeCdlShortLine(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlShortLine, priceDataPoint);

        public static DataHistory ComputeCdlSpinningTop(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlSpinningTop, priceDataPoint);

        public static DataHistory ComputeCdlStalledPattern(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlStalledPattern, priceDataPoint);

        public static DataHistory ComputeCdlStickSandwhich(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlStickSandwhich, priceDataPoint);

        public static DataHistory ComputeCdlTakuri(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlTakuri, priceDataPoint);

        public static DataHistory ComputeCdlTasukiGap(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlTasukiGap, priceDataPoint);

        public static DataHistory ComputeCdlThrusting(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlThrusting, priceDataPoint);

        public static DataHistory ComputeCdlTristar(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlTristar, priceDataPoint);

        public static DataHistory ComputeCdlUnique3River(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlUnique3River, priceDataPoint);

        public static DataHistory ComputeCdlUpsideGap2Crows(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlUpsideGap2Crows, priceDataPoint);

        public static DataHistory ComputeCdlXSideGap3Methods(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.CdlXSideGap3Methods, priceDataPoint);

        public static DataHistory ComputeCeil(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Ceil, priceDataPoint);

        public static DataHistory ComputeCmo(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cmo, priceDataPoint);

        public static DataHistory ComputeCorrel(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Correl, priceDataPoint);

        public static DataHistory ComputeCos(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cos, priceDataPoint);

        public static DataHistory ComputeCosh(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Cosh, priceDataPoint);

        public static DataHistory ComputeDema(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Dema, priceDataPoint);

        public static DataHistory ComputeDiv(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Div, priceDataPoint);

        public static DataHistory ComputeDx(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Dx, priceDataPoint);

        public static DataHistory ComputeEma(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Ema, priceDataPoint);

        public static DataHistory ComputeExp(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Exp, priceDataPoint);

        public static DataHistory ComputeFloor(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Floor, priceDataPoint);

        public static DataHistory ComputeHtDcPeriod(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.HtDcPeriod, priceDataPoint);

        public static DataHistory ComputeHtDcPhase(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.HtDcPhase, priceDataPoint);

        public static DataHistory ComputeHtPhasor(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.HtPhasor, priceDataPoint);

        public static DataHistory ComputeHtSine(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.HtSine, priceDataPoint);

        public static DataHistory ComputeHtTrendline(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.HtTrendline, priceDataPoint);

        public static DataHistory ComputeHtTrendMode(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.HtTrendMode, priceDataPoint);

        public static DataHistory ComputeKama(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Kama, priceDataPoint);

        public static DataHistory ComputeLinearReg(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.LinearReg, priceDataPoint);

        public static DataHistory ComputeLinearRegAngle(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.LinearRegAngle, priceDataPoint);

        public static DataHistory ComputeLinearRegIntercept(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.LinearRegIntercept, priceDataPoint);

        public static DataHistory ComputeLinearRegSlope(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.LinearRegSlope, priceDataPoint);

        public static DataHistory ComputeLn(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Ln, priceDataPoint);

        public static DataHistory ComputeLog10(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Log10, priceDataPoint);

        public static DataHistory ComputeMacd(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Macd, priceDataPoint);

        public static DataHistory ComputeMacdExt(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MacdExt, priceDataPoint);

        public static DataHistory ComputeMacdFix(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MacdFix, priceDataPoint);

        public static DataHistory ComputeMama(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Mama, priceDataPoint);

        public static DataHistory ComputeMax(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Max, priceDataPoint);

        public static DataHistory ComputeMaxIndex(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MaxIndex, priceDataPoint);

        public static DataHistory ComputeMedPrice(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MedPrice, priceDataPoint);

        public static DataHistory ComputeMfi(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Mfi, priceDataPoint);

        public static DataHistory ComputeMidPoint(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MidPoint, priceDataPoint);

        public static DataHistory ComputeMidPrice(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MidPrice, priceDataPoint);

        public static DataHistory ComputeMin(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Min, priceDataPoint);

        public static DataHistory ComputeMinIndex(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MinIndex, priceDataPoint);

        public static DataHistory ComputeMinMax(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MinMax, priceDataPoint);

        public static DataHistory ComputeMinMaxIndex(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MinMaxIndex, priceDataPoint);

        public static DataHistory ComputeMinusDI(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MinusDI, priceDataPoint);

        public static DataHistory ComputeMinusDM(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MinusDM, priceDataPoint);

        public static DataHistory ComputeMom(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Mom, priceDataPoint);

        public static DataHistory ComputeMovingAverage(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MovingAverage, priceDataPoint);

        public static DataHistory ComputeMovingAverageVariablePeriod(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.MovingAverageVariablePeriod, priceDataPoint);

        public static DataHistory ComputeMult(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Mult, priceDataPoint);

        public static DataHistory ComputeNatr(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Natr, priceDataPoint);

        public static DataHistory ComputeObv(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Obv, priceDataPoint);

        public static DataHistory ComputePlusDI(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.PlusDI, priceDataPoint);

        public static DataHistory ComputePlusDM(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.PlusDM, priceDataPoint);

        public static DataHistory ComputePpo(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Ppo, priceDataPoint);

        public static DataHistory ComputeRoc(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Roc, priceDataPoint);

        public static DataHistory ComputeRocP(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.RocP, priceDataPoint);

        public static DataHistory ComputeRocR(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.RocR, priceDataPoint);

        public static DataHistory ComputeRocR100(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.RocR100, priceDataPoint);

        public static DataHistory ComputeRsi(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Rsi, priceDataPoint);

        public static DataHistory ComputeSar(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Sar, priceDataPoint);

        public static DataHistory ComputeSarExt(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.SarExt, priceDataPoint);

        public static DataHistory ComputeSin(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Sin, priceDataPoint);

        public static DataHistory ComputeSinh(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Sinh, priceDataPoint);

        public static DataHistory ComputeSma(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Sma, priceDataPoint);

        public static DataHistory ComputeSqrt(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Sqrt, priceDataPoint);

        public static DataHistory ComputeStdDev(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.StdDev, priceDataPoint);

        public static DataHistory ComputeStoch(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Stoch, priceDataPoint);

        public static DataHistory ComputeStochF(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.StochF, priceDataPoint);

        public static DataHistory ComputeStochRsi(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.StochRsi, priceDataPoint);

        public static DataHistory ComputeSub(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Sub, priceDataPoint);

        public static DataHistory ComputeSum(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Sum, priceDataPoint);

        public static DataHistory ComputeT3(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.T3, priceDataPoint);

        public static DataHistory ComputeTan(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Tan, priceDataPoint);

        public static DataHistory ComputeTanh(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Tanh, priceDataPoint);

        public static DataHistory ComputeTema(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Tema, priceDataPoint);

        public static DataHistory ComputeTrima(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Trima, priceDataPoint);

        public static DataHistory ComputeTrix(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Trix, priceDataPoint);

        public static DataHistory ComputeTrueRange(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.TrueRange, priceDataPoint);

        public static DataHistory ComputeTsf(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Tsf, priceDataPoint);

        public static DataHistory ComputeTypPrice(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.TypPrice, priceDataPoint);

        public static DataHistory ComputeUltOsc(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.UltOsc, priceDataPoint);

        public static DataHistory ComputeVariance(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Variance, priceDataPoint);

        public static DataHistory ComputeWclPrice(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.WclPrice, priceDataPoint);

        public static DataHistory ComputeWillR(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.WillR, priceDataPoint);

        public static DataHistory ComputeWma(
            this DataHistory dataHistory,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close) =>
            dataHistory.ComputeIndicator(Indicator.Wma, priceDataPoint);



        public static DataHistory ComputeIndicator(
            this DataHistory dh,
            Indicator indicator,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close)
        {
            return dh.ComputeIndicator(indicator, 0, dh.Average.Length - 1, priceDataPoint);
        }

        public static DataHistory ComputeIndicator(
            this DataHistory dh,
            Indicator indicator,
            int startIdx,
            int endIdx,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close)
        {
            var result = dh.ComputeIndicatorBase(indicator, priceDataPoint);
            dh.Indicators.Add(indicator, result);
            return dh;
        }



        private static IndicatorBase ComputeIndicatorBase(
            this DataHistory dh,
            Indicator indicator,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close)
        {
            return dh.ComputeIndicatorBase(indicator, 0, dh.Average.Length - 1, priceDataPoint);
        }

        private static IndicatorBase ComputeIndicatorBase(
            this DataHistory dh,
            Indicator indicator,
            int startIdx,
            int endIdx,
            PriceDataPoint priceDataPoint = PriceDataPoint.Close)
        {
            double[] real = dh.GetPriceData(priceDataPoint);

            switch (indicator)
            {
                case Indicator.Acos:
                    return TAMath.Acos(startIdx, endIdx, real);
                case Indicator.Ad:
                    return TAMath.Ad(startIdx, endIdx, dh.High, dh.Low, dh.Close, dh.Volume);

                // case Indicator.Add:
                // return TAMath.Add(startIdx, endIdx, dataHistory.Real0, dataHistory.Real1);
                case Indicator.AdOsc:
                    return TAMath.AdOsc(startIdx, endIdx, dh.High, dh.Low, dh.Close, dh.Volume);
                case Indicator.Adx:
                    return TAMath.Adx(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.Adxr:
                    return TAMath.Adxr(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.Apo:
                    return TAMath.Apo(startIdx, endIdx, real);
                case Indicator.Aroon:
                    return TAMath.Aroon(startIdx, endIdx, dh.High, dh.Low);
                case Indicator.AroonOsc:
                    return TAMath.AroonOsc(startIdx, endIdx, dh.High, dh.Low);
                case Indicator.Asin:
                    return TAMath.Asin(startIdx, endIdx, real);
                case Indicator.Atan:
                    return TAMath.Atan(startIdx, endIdx, real);
                case Indicator.Atr:
                    return TAMath.Atr(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.AvgPrice:
                    return TAMath.AvgPrice(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Bbands:
                    return TAMath.Bbands(startIdx, endIdx, real);

                // case Indicator.Beta:
                // return TAMath.Beta(startIdx, endIdx, dataHistory.Real0, dataHistory.Real1);
                case Indicator.Bop:
                    return TAMath.Bop(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Cci:
                    return TAMath.Cci(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.Cdl2Crows:
                    return TAMath.Cdl2Crows(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Cdl3BlackCrows:
                    return TAMath.Cdl3BlackCrows(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Cdl3Inside:
                    return TAMath.Cdl3Inside(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Cdl3LineStrike:
                    return TAMath.Cdl3LineStrike(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Cdl3Outside:
                    return TAMath.Cdl3Outside(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Cdl3StarsInSouth:
                    return TAMath.Cdl3StarsInSouth(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Cdl3WhiteSoldiers:
                    return TAMath.Cdl3WhiteSoldiers(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlAbandonedBaby:
                    return TAMath.CdlAbandonedBaby(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlAdvanceBlock:
                    return TAMath.CdlAdvanceBlock(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlBeltHold:
                    return TAMath.CdlBeltHold(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlBreakaway:
                    return TAMath.CdlBreakaway(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlClosingMarubozu:
                    return TAMath.CdlClosingMarubozu(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlConcealBabysWall:
                    return TAMath.CdlConcealBabysWall(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlCounterAttack:
                    return TAMath.CdlCounterAttack(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlDarkCloudCover:
                    return TAMath.CdlDarkCloudCover(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlDoji:
                    return TAMath.CdlDoji(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlDojiStar:
                    return TAMath.CdlDojiStar(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlDragonflyDoji:
                    return TAMath.CdlDragonflyDoji(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlEngulfing:
                    return TAMath.CdlEngulfing(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlEveningDojiStar:
                    return TAMath.CdlEveningDojiStar(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlEveningStar:
                    return TAMath.CdlEveningStar(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlGapSideSideWhite:
                    return TAMath.CdlGapSideSideWhite(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlGravestoneDoji:
                    return TAMath.CdlGravestoneDoji(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlHammer:
                    return TAMath.CdlHammer(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlHangingMan:
                    return TAMath.CdlHangingMan(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlHarami:
                    return TAMath.CdlHarami(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlHaramiCross:
                    return TAMath.CdlHaramiCross(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlHignWave:
                    return TAMath.CdlHignWave(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlHikkake:
                    return TAMath.CdlHikkake(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlHikkakeMod:
                    return TAMath.CdlHikkakeMod(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlHomingPigeon:
                    return TAMath.CdlHomingPigeon(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlIdentical3Crows:
                    return TAMath.CdlIdentical3Crows(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlInNeck:
                    return TAMath.CdlInNeck(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlInvertedHammer:
                    return TAMath.CdlInvertedHammer(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlKicking:
                    return TAMath.CdlKicking(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlKickingByLength:
                    return TAMath.CdlKickingByLength(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlLadderBottom:
                    return TAMath.CdlLadderBottom(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlLongLeggedDoji:
                    return TAMath.CdlLongLeggedDoji(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlLongLine:
                    return TAMath.CdlLongLine(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlMarubozu:
                    return TAMath.CdlMarubozu(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlMatchingLow:
                    return TAMath.CdlMatchingLow(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlMatHold:
                    return TAMath.CdlMatHold(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlMorningDojiStar:
                    return TAMath.CdlMorningDojiStar(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlMorningStar:
                    return TAMath.CdlMorningStar(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlOnNeck:
                    return TAMath.CdlOnNeck(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlPiercing:
                    return TAMath.CdlPiercing(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlRickshawMan:
                    return TAMath.CdlRickshawMan(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlRiseFall3Methods:
                    return TAMath.CdlRiseFall3Methods(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlSeperatingLines:
                    return TAMath.CdlSeperatingLines(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlShootingStar:
                    return TAMath.CdlShootingStar(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlShortLine:
                    return TAMath.CdlShortLine(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlSpinningTop:
                    return TAMath.CdlSpinningTop(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlStalledPattern:
                    return TAMath.CdlStalledPattern(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlStickSandwhich:
                    return TAMath.CdlStickSandwhich(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlTakuri:
                    return TAMath.CdlTakuri(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlTasukiGap:
                    return TAMath.CdlTasukiGap(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlThrusting:
                    return TAMath.CdlThrusting(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlTristar:
                    return TAMath.CdlTristar(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlUnique3River:
                    return TAMath.CdlUnique3River(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlUpsideGap2Crows:
                    return TAMath.CdlUpsideGap2Crows(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.CdlXSideGap3Methods:
                    return TAMath.CdlXSideGap3Methods(startIdx, endIdx, dh.Open, dh.High, dh.Low, dh.Close);
                case Indicator.Ceil:
                    return TAMath.Ceil(startIdx, endIdx, real);
                case Indicator.Cmo:
                    return TAMath.Cmo(startIdx, endIdx, real);

                // case Indicator.Correl:
                // return TAMath.Correl(startIdx, endIdx, dataHistory.Real0, dataHistory.Real1);
                case Indicator.Cos:
                    return TAMath.Cos(startIdx, endIdx, real);
                case Indicator.Cosh:
                    return TAMath.Cosh(startIdx, endIdx, real);
                case Indicator.Dema:
                    return TAMath.Dema(startIdx, endIdx, real);

                // case Indicator.Div:
                // return TAMath.Div(startIdx, endIdx, dataHistory.Real0, dataHistory.Real1);
                case Indicator.Dx:
                    return TAMath.Dx(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.Ema:
                    return TAMath.Ema(startIdx, endIdx, real);
                case Indicator.Exp:
                    return TAMath.Exp(startIdx, endIdx, real);
                case Indicator.Floor:
                    return TAMath.Floor(startIdx, endIdx, real);
                case Indicator.HtDcPeriod:
                    return TAMath.HtDcPeriod(startIdx, endIdx, real);
                case Indicator.HtDcPhase:
                    return TAMath.HtDcPhase(startIdx, endIdx, real);
                case Indicator.HtPhasor:
                    return TAMath.HtPhasor(startIdx, endIdx, real);
                case Indicator.HtSine:
                    return TAMath.HtSine(startIdx, endIdx, real);
                case Indicator.HtTrendline:
                    return TAMath.HtTrendline(startIdx, endIdx, real);
                case Indicator.HtTrendMode:
                    return TAMath.HtTrendMode(startIdx, endIdx, real);
                case Indicator.Kama:
                    return TAMath.Kama(startIdx, endIdx, real);
                case Indicator.LinearReg:
                    return TAMath.LinearReg(startIdx, endIdx, real);
                case Indicator.LinearRegAngle:
                    return TAMath.LinearRegAngle(startIdx, endIdx, real);
                case Indicator.LinearRegIntercept:
                    return TAMath.LinearRegIntercept(startIdx, endIdx, real);
                case Indicator.LinearRegSlope:
                    return TAMath.LinearRegSlope(startIdx, endIdx, real);
                case Indicator.Ln:
                    return TAMath.Ln(startIdx, endIdx, real);
                case Indicator.Log10:
                    return TAMath.Log10(startIdx, endIdx, real);
                case Indicator.Macd:
                    return TAMath.Macd(startIdx, endIdx, real);
                case Indicator.MacdExt:
                    return TAMath.MacdExt(startIdx, endIdx, real);
                case Indicator.MacdFix:
                    return TAMath.MacdFix(startIdx, endIdx, real);
                case Indicator.Mama:
                    return TAMath.Mama(startIdx, endIdx, real);
                case Indicator.Max:
                    return TAMath.Max(startIdx, endIdx, real);
                case Indicator.MaxIndex:
                    return TAMath.MaxIndex(startIdx, endIdx, real);
                case Indicator.MedPrice:
                    return TAMath.MedPrice(startIdx, endIdx, dh.High, dh.Low);
                case Indicator.Mfi:
                    return TAMath.Mfi(startIdx, endIdx, dh.High, dh.Low, dh.Close, dh.Volume);
                case Indicator.MidPoint:
                    return TAMath.MidPoint(startIdx, endIdx, real);
                case Indicator.MidPrice:
                    return TAMath.MidPrice(startIdx, endIdx, dh.High, dh.Low);
                case Indicator.Min:
                    return TAMath.Min(startIdx, endIdx, real);
                case Indicator.MinIndex:
                    return TAMath.MinIndex(startIdx, endIdx, real);
                case Indicator.MinMax:
                    return TAMath.MinMax(startIdx, endIdx, real);
                case Indicator.MinMaxIndex:
                    return TAMath.MinMaxIndex(startIdx, endIdx, real);
                case Indicator.MinusDI:
                    return TAMath.MinusDI(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.MinusDM:
                    return TAMath.MinusDM(startIdx, endIdx, dh.High, dh.Low);
                case Indicator.Mom:
                    return TAMath.Mom(startIdx, endIdx, real);
                case Indicator.MovingAverage:
                    return TAMath.MovingAverage(startIdx, endIdx, real);

                // case Indicator.MovingAverageVariablePeriod:
                // return TAMath.MovingAverageVariablePeriod(startIdx, endIdx, real, dataHistory.Periods);
                // case Indicator.Mult:
                // return TAMath.Mult(startIdx, endIdx, dataHistory.Real0, dataHistory.Real1);
                case Indicator.Natr:
                    return TAMath.Natr(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.Obv:
                    return TAMath.Obv(startIdx, endIdx, real, dh.Volume);
                case Indicator.PlusDI:
                    return TAMath.PlusDI(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.PlusDM:
                    return TAMath.PlusDM(startIdx, endIdx, dh.High, dh.Low);
                case Indicator.Ppo:
                    return TAMath.Ppo(startIdx, endIdx, real);
                case Indicator.Roc:
                    return TAMath.Roc(startIdx, endIdx, real);
                case Indicator.RocP:
                    return TAMath.RocP(startIdx, endIdx, real);
                case Indicator.RocR:
                    return TAMath.RocR(startIdx, endIdx, real);
                case Indicator.RocR100:
                    return TAMath.RocR100(startIdx, endIdx, real);
                case Indicator.Rsi:
                    return TAMath.Rsi(startIdx, endIdx, real);
                case Indicator.Sar:
                    return TAMath.Sar(startIdx, endIdx, dh.High, dh.Low);
                case Indicator.SarExt:
                    return TAMath.SarExt(startIdx, endIdx, dh.High, dh.Low);
                case Indicator.Sin:
                    return TAMath.Sin(startIdx, endIdx, real);
                case Indicator.Sinh:
                    return TAMath.Sinh(startIdx, endIdx, real);
                case Indicator.Sma:
                    return TAMath.Sma(startIdx, endIdx, real);
                case Indicator.Sqrt:
                    return TAMath.Sqrt(startIdx, endIdx, real);
                case Indicator.StdDev:
                    return TAMath.StdDev(startIdx, endIdx, real);
                case Indicator.Stoch:
                    return TAMath.Stoch(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.StochF:
                    return TAMath.StochF(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.StochRsi:
                    return TAMath.StochRsi(startIdx, endIdx, real);

                // case Indicator.Sub:
                // return TAMath.Sub(startIdx, endIdx, dataHistory.Real0, dataHistory.Real1);
                case Indicator.Sum:
                    return TAMath.Sum(startIdx, endIdx, real);
                case Indicator.T3:
                    return TAMath.T3(startIdx, endIdx, real);
                case Indicator.Tan:
                    return TAMath.Tan(startIdx, endIdx, real);
                case Indicator.Tanh:
                    return TAMath.Tanh(startIdx, endIdx, real);
                case Indicator.Tema:
                    return TAMath.Tema(startIdx, endIdx, real);
                case Indicator.Trima:
                    return TAMath.Trima(startIdx, endIdx, real);
                case Indicator.Trix:
                    return TAMath.Trix(startIdx, endIdx, real);
                case Indicator.TrueRange:
                    return TAMath.TrueRange(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.Tsf:
                    return TAMath.Tsf(startIdx, endIdx, real);
                case Indicator.TypPrice:
                    return TAMath.TypPrice(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.UltOsc:
                    return TAMath.UltOsc(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.Variance:
                    return TAMath.Variance(startIdx, endIdx, real);
                case Indicator.WclPrice:
                    return TAMath.WclPrice(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.WillR:
                    return TAMath.WillR(startIdx, endIdx, dh.High, dh.Low, dh.Close);
                case Indicator.Wma:
                    return TAMath.Wma(startIdx, endIdx, real);
                default:
                    throw new ArgumentOutOfRangeException(nameof(indicator), indicator, null);
            }
        }

        private static double[] GetPriceData(this DataHistory dataHistory, PriceDataPoint priceDataPoint)
        {
            switch (priceDataPoint)
            {
                case PriceDataPoint.Open:
                    return dataHistory.Open;
                case PriceDataPoint.High:
                    return dataHistory.High;
                case PriceDataPoint.Low:
                    return dataHistory.Low;
                case PriceDataPoint.Close:
                    return dataHistory.Close;
                case PriceDataPoint.Average:
                    return dataHistory.Average;
                default:
                    throw new ArgumentOutOfRangeException(nameof(priceDataPoint), priceDataPoint, null);
            }
        }
    }
}