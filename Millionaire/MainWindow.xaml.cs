using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace Millionaire
{
    public partial class MainWindow : Window
    {
        private Question question = new Question();
        private int questionStep = 0;
        private const string fileNameFormat = "Questions/question{0}.json";
        private int rightIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            LoadQuestion();
        }

        public void LoadQuestion()
        {
            ++questionStep;

            if (questionStep > 5)
            {
                MessageBox.Show("You won!");
            }
            else
            {
                string path = string.Format(fileNameFormat, questionStep);

                var json = File.ReadAllText(path);

                DataContext = question = JsonSerializer.Deserialize<Question>(json)!;
                rightIndex = question.RightIndex;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string? text = null;
            if (sender is Button content)
            {
                text = content.Content.ToString();
            }

            if (text == question.Answer?[rightIndex])
            {
                LoadQuestion();
            }
            else
            {
                if (questionStep > 1)
                {
                    questionStep = 0;
                    MessageBox.Show($"You lose! Right answer is {question.Answer?[rightIndex]}");
                    LoadQuestion();
                }
                else
                {
                    MessageBox.Show($"You lose! Right answer is {question.Answer?[rightIndex]}");  
                }
            }
        }
    }
}
