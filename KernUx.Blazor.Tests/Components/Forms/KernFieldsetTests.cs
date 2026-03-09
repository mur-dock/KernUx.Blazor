using Bunit;
using KernUx.Blazor.Components.Forms;
using KernUx.Blazor.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KernUx.Blazor.Tests.Components.Forms;

public sealed class KernFieldsetTests
{
    [Fact(DisplayName = "Fieldset rendert Fehlerzustand und Hint-Verknüpfung")]
    public void KernFieldset_RendertFehlerUndHint()
    {
        // Given
        using var context = new BunitContext();

        // Bunit DI-Container erhält den IdGenerator für automatische IDs.
        context.Services.AddScoped<IdGeneratorService>();

        // When
        var cut = context.Render<KernFieldset>(parameters => parameters
            .Add(p => p.Legend, "Kontakt")
            .Add(p => p.Hint, "Bitte vollständig ausfüllen")
            .Add(p => p.Error, "Fehler vorhanden")
            .AddChildContent("<div>Inhalt</div>"));

        // Then
        Assert.Contains("kern-fieldset--error", cut.Markup);
        Assert.Contains("kern-hint", cut.Markup);
        Assert.Contains("kern-error", cut.Markup);
    }
}

