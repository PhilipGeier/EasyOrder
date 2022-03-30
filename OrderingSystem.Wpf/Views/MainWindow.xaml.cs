using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using OrderingSystem.Domain;
using OrderingSystem.Logic;
using OrderingSystem.Wpf.ViewModels;

namespace OrderingSystem.Wpf.Views
{
    public partial class MainWindow : Window
    {
        private List<Table> _tables;


        private Button _graphicButton;
        private Button _tablesButton;
        private Button _guestsButton;

        public MainWindow()
        {
            InitializeComponent();
            
            _graphicButton = GraphicButton;
            _tablesButton = TablesButton;
            _guestsButton = GuestsButton;
            
            var tableLogic = new TableLogic();
            _tables = tableLogic.Tables;
            
            
        }

        private void OnGraphicClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Source = new Uri("/Views/GraphicView.xaml", UriKind.Relative);
        }

        private void OnGuestsClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Source = new Uri("/Views/GuestView.xaml", UriKind.Relative);
        }

        private void OnTablesClick(object sender, RoutedEventArgs e)
        {
            ContentFrame.Source = new Uri("/Views/TableView.xaml", UriKind.Relative);
        }
    }
}