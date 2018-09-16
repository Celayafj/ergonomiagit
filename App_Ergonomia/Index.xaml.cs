using App_Ergonomia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace App_Ergonomia
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Side menu");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Csv.GetQuestions();
            QuestionLabel.Content = Csv.question[1];
            HintLabel.Content = Csv.hint[1];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Csv.ActualQuestion < Csv.question.Count-1)
            {
                
                Csv.ActualQuestion++;
                CounterLabel.Content = "Pregunta " + Csv.ActualQuestion;
                QuestionLabel.Content = Csv.question[Csv.ActualQuestion];
                HintLabel.Content = Csv.hint[Csv.ActualQuestion];
                TestProgressBar.Value = TestProgressBar.Value + 6;
            }
            else
            {
                if (MessageBox.Show("Deseas enviar la evaluación","Terminar",MessageBoxButton.YesNo)== MessageBoxResult.Yes)
                {
                    MessageBox.Show("Datos guardados");
                }
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Csv.ActualQuestion > 1)
            {
                Csv.ActualQuestion--;
                TestProgressBar.Value = TestProgressBar.Value - 6;
                QuestionLabel.Content = Csv.question[Csv.ActualQuestion];
                HintLabel.Content = Csv.hint[Csv.ActualQuestion];
            }
            else
            {
               MessageBox.Show("Ya estas en la primera pregunta");
            }
        }
    }
}
