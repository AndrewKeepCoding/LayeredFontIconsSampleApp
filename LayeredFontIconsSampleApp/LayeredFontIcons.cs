using CommunityToolkit.WinUI;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Linq;

namespace LayeredFontIconsSampleApp;

public partial class LayeredFontIcons : FontIcon
{
    public LayeredFontIcons()
    {
        Loaded += LayeredFontIcons_Loaded;
    }

    public IList<FontIcon> FontIcons { get; } = [];

    private new string Glyph { get; set; } = string.Empty;

    private void LayeredFontIcons_Loaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        if (this.FindDescendants().OfType<Grid>().FirstOrDefault() is not Grid grid)
        {
            return;
        }

        foreach (var fontIcon in FontIcons)
        {
            grid.Children.Add(fontIcon);
        }
    }
}