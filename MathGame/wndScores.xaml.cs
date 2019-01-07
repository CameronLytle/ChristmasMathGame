using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace MathGame
{
    /// <summary>
    /// Interaction logic for wndScores.xaml
    /// </summary>
    public partial class wndScores : Window
    {
        /// <summary>
        /// This class will handle all of the communication with the Addition scores information
        /// </summary>
        private clsScores clsScoresClass;

        /// <summary>
        /// This class will handle all of the high scores that are used in the subtraction game
        /// </summary>
        private clsScoresSubtraction clsScoresSubtractionClass;

        /// <summary>
        /// This class will handle all of the high scores that are used in the multiplication game
        /// </summary>
        private clsScoresMultiplication clsScoresMultiplicationClass;

        /// <summary>
        /// This class will handle all of the high scores that are used in the division game
        /// </summary>
        private clsScoresDivision clsScoresDivisionClass;

        /// <summary>
        /// so the score board can hold what the game type was.
        /// </summary>
        private string sType;

        public wndScores()
        {
            try
            {
                InitializeComponent();
                clsScoresClass = new clsScores();
                clsScoresSubtractionClass = new clsScoresSubtraction();
                clsScoresMultiplicationClass = new clsScoresMultiplication();
                clsScoresDivisionClass = new clsScoresDivision();
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method gathers all of the informatino needed to manipulate the score boards
        /// </summary>
        /// <param name="score"></param>
        /// <param name="time"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="type"></param>
        /// <param name="timeDouble"></param>
        public void GatherInformation(int score, string time, string name, int age, string type, double timeDouble)
        {
            try
            {
                sType = type;

                switch (type)
                {
                    case "Addition":
                        clsScoresClass.GatherInformation(score, time, name, age, timeDouble);
                        clsScoresClass.SortHighScores();
                        DisplayScoreboard();
                        break;
                    case "Subtraction":
                        clsScoresSubtractionClass.GatherInformation(score, time, name, age, timeDouble);
                        clsScoresSubtractionClass.SortHighScores();
                        DisplayScoreboard();
                        break;
                    case "Multiplication":
                        clsScoresMultiplicationClass.GatherInformation(score, time, name, age, timeDouble);
                        clsScoresMultiplicationClass.SortHighScores();
                        DisplayScoreboard();
                        break;
                    case "Division":
                        clsScoresDivisionClass.GatherInformation(score, time, name, age, timeDouble);
                        clsScoresDivisionClass.SortHighScores();
                        DisplayScoreboard();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method displays the scores
        /// </summary>
        public void DisplayScoreboard()
        {
            try
            {
                switch (sType)
                {
                    case "Addition":
                        lblHighScoresTitle.Content = clsScoresClass.ScoreTitle();
                        lblYourScore.Content = clsScoresClass.ScoreInfo();
                        lblFirstPlace.Content = clsScoresClass.FirstPlace();
                        lblSecondPlace.Content = clsScoresClass.SecondPlace();
                        lblThirdPlace.Content = clsScoresClass.ThirdPlace();
                        lblFourthPlace.Content = clsScoresClass.FourthPlace();
                        lblFifthPlace.Content = clsScoresClass.FifthPlace();
                        lblSixthPlace.Content = clsScoresClass.SixthPlace();
                        lblSeventhPlace.Content = clsScoresClass.SeventhPlace();
                        lblEighthPlace.Content = clsScoresClass.EighthPlace();
                        lblNinthPlace.Content = clsScoresClass.NinthPlace();
                        lblTenthPlace.Content = clsScoresClass.TenthPlace();
                        break;
                    case "Subtraction":
                        lblHighScoresTitle.Content = clsScoresSubtractionClass.ScoreTitle();
                        lblYourScore.Content = clsScoresSubtractionClass.ScoreInfo();
                        lblFirstPlace.Content = clsScoresSubtractionClass.FirstPlace();
                        lblSecondPlace.Content = clsScoresSubtractionClass.SecondPlace();
                        lblThirdPlace.Content = clsScoresSubtractionClass.ThirdPlace();
                        lblFourthPlace.Content = clsScoresSubtractionClass.FourthPlace();
                        lblFifthPlace.Content = clsScoresSubtractionClass.FifthPlace();
                        lblSixthPlace.Content = clsScoresSubtractionClass.SixthPlace();
                        lblSeventhPlace.Content = clsScoresSubtractionClass.SeventhPlace();
                        lblEighthPlace.Content = clsScoresSubtractionClass.EighthPlace();
                        lblNinthPlace.Content = clsScoresSubtractionClass.NinthPlace();
                        lblTenthPlace.Content = clsScoresSubtractionClass.TenthPlace();
                        break;
                    case "Multiplication":
                        lblHighScoresTitle.Content = clsScoresMultiplicationClass.ScoreTitle();
                        lblYourScore.Content = clsScoresMultiplicationClass.ScoreInfo();
                        lblFirstPlace.Content = clsScoresMultiplicationClass.FirstPlace();
                        lblSecondPlace.Content = clsScoresMultiplicationClass.SecondPlace();
                        lblThirdPlace.Content = clsScoresMultiplicationClass.ThirdPlace();
                        lblFourthPlace.Content = clsScoresMultiplicationClass.FourthPlace();
                        lblFifthPlace.Content = clsScoresMultiplicationClass.FifthPlace();
                        lblSixthPlace.Content = clsScoresMultiplicationClass.SixthPlace();
                        lblSeventhPlace.Content = clsScoresMultiplicationClass.SeventhPlace();
                        lblEighthPlace.Content = clsScoresMultiplicationClass.EighthPlace();
                        lblNinthPlace.Content = clsScoresMultiplicationClass.NinthPlace();
                        lblTenthPlace.Content = clsScoresMultiplicationClass.TenthPlace();
                        break;
                    case "Division":
                        lblHighScoresTitle.Content = clsScoresDivisionClass.ScoreTitle();
                        lblYourScore.Content = clsScoresDivisionClass.ScoreInfo();
                        lblFirstPlace.Content = clsScoresDivisionClass.FirstPlace();
                        lblSecondPlace.Content = clsScoresDivisionClass.SecondPlace();
                        lblThirdPlace.Content = clsScoresDivisionClass.ThirdPlace();
                        lblFourthPlace.Content = clsScoresDivisionClass.FourthPlace();
                        lblFifthPlace.Content = clsScoresDivisionClass.FifthPlace();
                        lblSixthPlace.Content = clsScoresDivisionClass.SixthPlace();
                        lblSeventhPlace.Content = clsScoresDivisionClass.SeventhPlace();
                        lblEighthPlace.Content = clsScoresDivisionClass.EighthPlace();
                        lblNinthPlace.Content = clsScoresDivisionClass.NinthPlace();
                        lblTenthPlace.Content = clsScoresDivisionClass.TenthPlace();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        


        /// <summary>
        /// This method hides the window instead of closing it down when the X is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.Hide();
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// This method hides the current window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoresReturn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method handles the top level exceptions
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("Error.txt", Environment.NewLine +
                                             "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// This method displys the addition high scores when used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoresAddition_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sType = "Addition";
                DisplayScoreboard();
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method displays the subtraction high scores when used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoresSubtraction_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sType = "Subtraction";
                DisplayScoreboard();
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method displays the multiplication high scores when used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoresMultiplication_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sType = "Multiplication";
                DisplayScoreboard();
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method displayed the division high scores when used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoresDivision_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sType = "Division";
                DisplayScoreboard();
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }// end class
}
