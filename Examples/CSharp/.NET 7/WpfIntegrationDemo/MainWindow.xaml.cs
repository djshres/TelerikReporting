﻿namespace CSharp.Net7.WpfIntegrationDemo
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using Telerik.Windows.Controls;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static readonly string[] dictionaries = new[]
                   {
                "/Telerik.ReportViewer.Wpf.Themes;component/Themes/{0}/System.Windows.xaml",
                "/Telerik.ReportViewer.Wpf.Themes;component/Themes/{0}/Telerik.Windows.Controls.xaml",
                "/Telerik.ReportViewer.Wpf.Themes;component/Themes/{0}/Telerik.Windows.Controls.Input.xaml",
                "/Telerik.ReportViewer.Wpf.Themes;component/Themes/{0}/Telerik.Windows.Controls.Navigation.xaml",
                "/Telerik.ReportViewer.Wpf.Themes;component/Themes/{0}/Telerik.ReportViewer.Wpf.xaml"
            };

        public MainWindow()
        {
            this.InitializeComponent();
        }

        void ThemeSelector_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selectedItem = (RadComboBoxItem)((RadComboBox)sender).SelectedItem;
            var themeNameParts = ((string)selectedItem.Content).Split('_');
            var themeName = themeNameParts[0];
            var themeVariation = string.Empty;

            MergeResourceDictionaries(themeName);

            if (themeNameParts.Length > 1)
            {
                switch (themeName)
                {
                    case "Windows11":
                        Windows11ThemeSizeHelper.Helper.IsInCompactMode = themeNameParts[1].Contains("Compact");
                        themeNameParts[1] = themeNameParts[1].Replace("(Compact)", string.Empty).Trim();
                        Windows11Palette.LoadPreset((Windows11Palette.ColorVariation)this.GetPresetEnum(typeof(Windows11Palette.ColorVariation), themeNameParts[1]));
                        break;
                    case "Office2019":
                        Office2019Palette.LoadPreset((Office2019Palette.ColorVariation)this.GetPresetEnum(typeof(Office2019Palette.ColorVariation), themeNameParts[1]));
                        break;
                    case "VisualStudio2019":
                        VisualStudio2019Palette.LoadPreset((VisualStudio2019Palette.ColorVariation)this.GetPresetEnum(typeof(VisualStudio2019Palette.ColorVariation), themeNameParts[1]));
                        break;
                    case "VisualStudio2013":
                        VisualStudio2013Palette.LoadPreset((VisualStudio2013Palette.ColorVariation)this.GetPresetEnum(typeof(VisualStudio2013Palette.ColorVariation), themeNameParts[1]));
                        break;
                    case "Office2013":
                        Office2013Palette.LoadPreset((Office2013Palette.ColorVariation)this.GetPresetEnum(typeof(Office2013Palette.ColorVariation), themeNameParts[1]));
                        break;
                    case "Green":
                        GreenPalette.LoadPreset((GreenPalette.ColorVariation)this.GetPresetEnum(typeof(GreenPalette.ColorVariation), themeNameParts[1]));
                        break;
                    case "Fluent":
                        FluentPalette.LoadPreset((FluentPalette.ColorVariation)this.GetPresetEnum(typeof(FluentPalette.ColorVariation), themeNameParts[1]));
                        break;
                    case "Crystal":
                        CrystalPalette.LoadPreset((CrystalPalette.ColorVariation)this.GetPresetEnum(typeof(CrystalPalette.ColorVariation), themeNameParts[1]));
                        break;
                    case "Material":
                        MaterialPalette.LoadPreset((MaterialPalette.ColorVariation)this.GetPresetEnum(typeof(MaterialPalette.ColorVariation), themeNameParts[1]));
                        break;
                }

                themeVariation = themeNameParts[1];
            }

            this.SetLayoutBackground(themeName, themeVariation);
        }

        void SetLayoutBackground(string themeName, string themeVariation)
        {
            var grid = this.LayoutRoot as Grid;
            if (grid != null)
            {
                grid.Background = new SolidColorBrush(GetLayoutBackground(themeName, themeVariation, grid));
            }
        }

        object GetPresetEnum(Type enumeration, string colorVariation)
        {
            return Enum.Parse(enumeration, colorVariation);
        }

        static Color GetLayoutBackground(string themeName, string themeVariation, System.Windows.Controls.Panel grid)
        {
            switch (themeName)
            {
                case "Office2019":
                    if (themeVariation == "HighContrast")
                    {
                        return Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
                    }
                    else if(themeVariation == "Dark")
                    {
                        return Color.FromArgb(0xFF, 0x15, 0x15, 0x15);
                    }
                    else
                    {
                        return Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
                    }

                case "VisualStudio2019":
                    if (themeVariation == "Dark")
                    {
                        return Color.FromArgb(0xFF, 0x27, 0x28, 0x28);
                    }
                    else
                    {
                        return Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
                    }

                case "VisualStudio2013":
                case "Green":
                case "Fluent":
                case "Crystal":
                case "Windows11":
                    if (themeVariation == "Dark")
                    {
                        return Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
                    }
                    else if (themeVariation == "System")
                    {
                        return Windows11Palette.Palette.OverlayColor;
                    }
                    else
                    {
                        return Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
                    }

                case "Material":
                    if (themeVariation == "Dark")
                    {
                        return Color.FromArgb(0xFF, 0x12, 0x12, 0x12);
                    }
                    else
                    {
                        return Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
                    }

                case "Office2013":
                    if (themeVariation == "White")
                    {
                        return Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
                    }
                    else
                    {
                        return Color.FromArgb(0xFF, 0xD6, 0xD6, 0xD6);
                    }

                case "ExpressionDark":
                    return Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
                case "OfficeBlack":
                    return Color.FromArgb(0xFF, 0xCA, 0xCA, 0xCA);
                case "OfficeBlue":
                    return Color.FromArgb(0xFF, 0xCD, 0xE5, 0xFE);
                case "OfficeSilver":
                    return Color.FromArgb(0xFF, 0xDC, 0xDD, 0xE7);
                default:
                    return Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            }
        }

        static void MergeResourceDictionaries(string theme)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            mergedDictionaries.Clear();
            foreach (var dictionary in dictionaries)
            {
                var uri = string.Format(dictionary, theme);
                mergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri(uri, UriKind.RelativeOrAbsolute)
                });
            }
        }
    }
}
