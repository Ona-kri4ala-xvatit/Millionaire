using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Shapes;

namespace Millionaire
{
    public partial class MainWindow : Window
    {
        Data data = new Data();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = data;

            data.Question = "Which of the planets is closest to the sun?";
            data.Answer[0] = "Venus";
            data.Answer[1] = "Earth";
            data.Answer[2] = "Mars";
            data.Answer[3] = "Mercury";
            data.RightIndex = 1;

        }
    }
}
