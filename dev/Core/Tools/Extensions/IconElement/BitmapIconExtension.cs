﻿namespace WinUICommunity;

/// <summary>
/// Custom <see cref="MarkupExtension"/> which can provide <see cref="BitmapIcon"/> values.
/// </summary>
[MarkupExtensionReturnType(ReturnType = typeof(BitmapIcon))]
public sealed class BitmapIconExtension : MarkupExtension
{
    /// <summary>
    /// Gets or sets the <see cref="Uri"/> representing the image to display.
    /// </summary>
    public Uri Source { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to display the icon as monochrome.
    /// </summary>
    public bool ShowAsMonochrome { get; set; }

    /// <inheritdoc/>
    protected override object ProvideValue()
    {
        return new BitmapIcon
        {
            ShowAsMonochrome = ShowAsMonochrome,
            UriSource = Source
        };
    }
}
