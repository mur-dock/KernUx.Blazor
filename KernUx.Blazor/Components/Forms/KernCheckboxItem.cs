namespace KernUx.Blazor.Components.Forms;

/// <summary>Ein einzelner Eintrag für <see cref="KernCheckboxList"/>.</summary>
public sealed record KernCheckboxItem(string Value, string Label, bool Disabled = false);

