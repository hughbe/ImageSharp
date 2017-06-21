﻿// <copyright file="IccClutDataType.cs" company="Six Labors">
// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace SixLabors.ImageSharp
{
    /// <summary>
    /// Formula curve segment type
    /// </summary>
    internal enum IccFormulaCurveType : ushort
    {
        /// <summary>
        /// Type 1: Y = (a * X + b)^γ + c
        /// </summary>
        Type1 = 0,

        /// <summary>
        /// Type 1: Y = a * log10 (b * X^γ + c) + d
        /// </summary>
        Type2 = 1,

        /// <summary>
        /// Type 3: Y = a * b^(c * X + d) + e
        /// </summary>
        Type3 = 2
    }
}