using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace newquizapp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class history : Page
    {
        private List<questionbank> questions;
        private int index;
        private int score = 0;
        string subject = "";
        public history()
        {
            this.InitializeComponent();
            loadHistoryQuestion();
            setHistoryQuestion();

        }
        private void loadHistoryQuestion()
        {
            questions = new List<questionbank>
        {
            new questionbank
            {
                Category = "History",
                Question = "which famous explorer is credited with discovery of America",
                Option1 = "Christopher",
                Option2 = "Vasco",
                Option3 = "Ferdinnad",
                Option4 = "James Cook",
                CorrectOption = 1

            },
             new questionbank
            {
                Category = "History",
                Question = "which famous explorer is credited with discovery of souce of the Nile",
                Option1 = "John the baptist",
                Option2 = "Vasco",
                Option3 = "Ferdinnad",
                Option4 = "James Cook",
                CorrectOption = 2

            }
        };

        }
        private void setHistoryQuestion()
        {
            if(index < questions.Count)
            {
                var currentquestion = questions[index];
                Subject.Text = currentquestion.Category;
                Question.Text = currentquestion.Question;
                Option1.Content = currentquestion.Option1;
                Option2.Content = currentquestion.Option2;
                Option3.Content = currentquestion.Option3;
                Option4.Content = currentquestion.Option4;
                resultbox.Text = score.ToString();

            }

        }
        private void back(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
