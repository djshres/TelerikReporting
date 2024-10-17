namespace CSharp.Net6.WinUIIntegrationDemo
{
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Controls;
    using System;

    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "Telerik Reporting WinUI .NET 6 Demo";
        }

        void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuFlyoutItem;
            if (menuItem != null)
            {
                var selectedTheme = menuItem?.Text;
                if (!string.IsNullOrWhiteSpace(selectedTheme))
                {
                    this.themeChangeDropDown.Content = selectedTheme;
                    this.gridRoot.RequestedTheme = Enum.Parse<ElementTheme>(selectedTheme, true);
                }
            }
        }
    }
}
