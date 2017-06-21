﻿// <copyright file="IccCurveSegmentSignature.cs" company="Six Labors">
// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace SixLabors.ImageSharp
{
    /// <summary>
    /// Curve Segment Signature
    /// </summary>
    internal enum IccCurveSegmentSignature : uint
    {
        /// <summary>
        /// Curve defined by a formula
        /// </summary>
        FormulaCurve = 0x70617266,      // parf

        /// <summary>
        /// Curve defined by multiple segments
        /// </summary>
        SampledCurve = 0x73616D66,      // samf
    }
}