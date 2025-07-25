﻿using System.Diagnostics;

namespace ConsoleAppChatMCP.Tracing;

public static class OpenTelemetryExtensions
{
    public static string ServiceName { get; }
    public static string ServiceVersion { get; }
    public static ActivitySource ActivitySource { get; }

    static OpenTelemetryExtensions()
    {
        ServiceName = "ConsoleAppChatAIMCP";
        ServiceVersion = typeof(OpenTelemetryExtensions).Assembly.GetName().Version!.ToString();
        ActivitySource = new ActivitySource(ServiceName, ServiceVersion);
    }
}