using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using OrderingSystem.Domain;
using OrderingSystem.Wpf.Annotations;
using OrderingSystem.Wpf.Views;

namespace OrderingSystem.Wpf.ViewModels
{
    public static class MainViewModel
    {
        private static MainWindow _mainWindow;

        static MainViewModel()
        {
            _mainWindow = new MainWindow();
        }

        public static void RenderTables(List<Table> tables)
        {
            foreach (var table in tables)
            {
                if (table.WpfInfo.HasValue)
                {
                    var btn = new Button();
                    btn.Margin = new Thickness(table.WpfInfo.Value.PosX, table.WpfInfo.Value.PosY, 0, 0);
                    btn.Height = table.WpfInfo.Value.Height;
                    btn.Width = table.WpfInfo.Value.Width;
                    if (table.WpfInfo.Value.Shape == "Rectangle")
                    {
                        return;
                    }
                    if (table.WpfInfo.Value.Shape == "Ellipse")
                    {
                        return;
                    }
                }
            }
        }
    }
}