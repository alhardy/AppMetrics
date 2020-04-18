﻿// <copyright file="MetricsHostedMetricsOptions.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using System;
using App.Metrics.Formatters.Datadog.Internal;

namespace App.Metrics.Formatters.Datadog
{
    /// <summary>
    ///     Provides programmatic configuration for GrafanfaCloud Hosted Metrics format in the App Metrics framework.
    /// </summary>
    public class MetricsDatadogOptions
    {
        public MetricsDatadogOptions()
        {
            MetricNameFormatter = DatadogFormatterConstants.GraphiteDefaults.MetricPointTextWriter;
        }

        public Func<IDatadogMetricJsonWriter> MetricNameFormatter { get; set; }
    }
}