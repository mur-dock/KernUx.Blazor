namespace KernUxExample.Blazor.Services;

/// <summary>
/// Verwaltet das aktive KernUX-Theme appweit als Blazor-Service.
/// Das Theme wird über <c>data-kern-theme</c> auf dem umschließenden Element gesetzt.
/// </summary>
public sealed class ThemeService
{
    private KernTheme _current = KernTheme.Light;

    /// <summary>Wird ausgelöst, wenn das Theme gewechselt wurde.</summary>
    public event Action<KernTheme>? ThemeChanged;

    /// <summary>Das aktuell aktive Theme.</summary>
    public KernTheme Current
    {
        get => _current;
        private set
        {
            if (_current == value) return;
            _current = value;
            ThemeChanged?.Invoke(_current);
        }
    }

    /// <summary>Der HTML-Attributwert für <c>data-kern-theme</c>.</summary>
    public string AttributeValue => _current == KernTheme.Dark ? "dark" : "light";

    /// <summary>Wechselt zwischen Light und Dark.</summary>
    public void Toggle() => Current = _current == KernTheme.Light ? KernTheme.Dark : KernTheme.Light;

    /// <summary>Setzt das Theme explizit.</summary>
    public void Set(KernTheme theme) => Current = theme;

    /// <summary>
    /// Initialisiert das Theme anhand eines gespeicherten Wertes (z.B. aus einem Cookie).
    /// Wird beim SSR-Prerender aufgerufen.
    /// </summary>
    public void Initialize(string? storedValue)
    {
        _current = storedValue == "dark" ? KernTheme.Dark : KernTheme.Light;
    }
}


