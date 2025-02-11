using CommunityToolkit.WinUI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Linq;

namespace LayeredFontIconsSampleApp;

public partial class NetworkOnlineFontIcon : FontIcon
{
    public NetworkOnlineFontIcon()
    {
        Loaded += NetworkConnectedFontIcon_Loaded;
    }

    private void NetworkConnectedFontIcon_Loaded(object sender, RoutedEventArgs e)
    {
        if (this.FindDescendants().OfType<Grid>().FirstOrDefault() is not Grid grid)
        {
            return;
        }

        grid.Children.Add(new FontIcon { Glyph = "\uF385" });
        grid.Children.Add(new FontIcon { Glyph = "\uF386" });
    }
}