namespace KernUx.Blazor.Components.Forms;

/// <summary>Ein einzelner Eintrag für <see cref="KernRadioGroup"/>.</summary>
public sealed record KernRadioItem(string Value, string Label, bool Disabled = false);

