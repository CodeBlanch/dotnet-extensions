﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Extensions.Http.Diagnostics;

/// <summary>
/// Strategy to decide how HTTP request path parameters are redacted.
/// </summary>
public enum HttpRouteParameterRedactionMode
{
    /// <summary>
    /// All parameters are considered as sensitive and are required to be explicitly annotated with a data classification.
    /// </summary>
    Strict,

    /// <summary>
    /// All parameters are considered as non-sensitive and included as-is by default.
    /// </summary>
    Loose,

    /// <summary>
    /// Route parameters are not redacted regardless of the presence of data classification annotations.
    /// </summary>
    None,
}
