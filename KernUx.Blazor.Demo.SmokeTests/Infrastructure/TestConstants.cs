namespace KernUx.Blazor.Demo.SmokeTests.Infrastructure;

/// <summary>
/// Zentrale Konstanten für alle Smoke-Tests: URLs, Timeouts, Artefaktpfade.
/// Änderungen hier wirken sich automatisch auf alle Tests aus.
/// </summary>
internal static class TestConstants
{
    /// <summary>Basis-URL der lokal laufenden Demo-App (entspricht launchSettings.json).</summary>
    internal const string BaseUrl = "https://localhost:7023";

    /// <summary>Maximale Wartezeit in Millisekunden für Playwright-Assertions.</summary>
    internal const int DefaultTimeoutMs = 10_000;

    /// <summary>Verzeichnis für Test-Artefakte (Screenshots, Traces, Videos).</summary>
    internal const string ArtifactDir = "test-results";

    /// <summary>Alle Routen der Demo-App mit erwartetem PageTitle.</summary>
    internal static readonly IReadOnlyList<(string Route, string ExpectedTitle)> AllRoutes =
    [
        ("/",                        "KernUx.Blazor Showcase"),
        ("/components/typography",   "Typografie - KernUx.Blazor Showcase"),
        ("/components/layout",       "Layout - KernUx.Blazor Showcase"),
        ("/components/buttons",      "Buttons - KernUx.Blazor Showcase"),
        ("/components/forms",        "Formulare - KernUx.Blazor Showcase"),
        ("/components/feedback",     "Feedback - KernUx.Blazor Showcase"),
        ("/components/content",      "Content - KernUx.Blazor Showcase"),
        ("/components/navigation",   "Navigation - KernUx.Blazor Showcase"),
        ("/components/icons",        "Icons - KernUx.Blazor Showcase"),
        ("/examples/antrag",         "Antragsstrecke - KernUx.Blazor Showcase"),
        ("/examples/dashboard",      "Dashboard - KernUx.Blazor Showcase"),
        ("/not-found",               "Seite nicht gefunden - KernUx.Blazor Showcase"),
    ];
}

