// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using System;
using JetBrains.Annotations;
using Mimer.Data.Client;

namespace Pomelo.EntityFrameworkCore.MySql.Storage.Internal
{
    /// <summary>
    ///     Detects the exceptions caused by SQL Server transient failures.
    /// </summary>
    public class MySqlTransientExceptionDetector
    {
        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public static bool ShouldRetryOn([NotNull] Exception ex)
        {
            if (ex is MimerException MimerException)
            {
                // Retry in all cases above
                return true;

            }

            return ex is TimeoutException;
        }
    }
}
