using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Windows.Threading; // for timer

namespace MathGame
{
    /// <summary>
    /// Interaction logic for wndGame.xaml
    /// </summary>
    public partial class wndGame : Window
    {
        /// <summary>
        /// Game class that will handle all of the game logic
        /// </summary>
        private clsGame clsGameClass;

        /// <summary>
        /// This timer is used for the game
        /// </summary>
        private DispatcherTimer GameTimer;

        /// <summary>
        /// This stopwatch helps keep track of the elapsed time in the game
        /// </summary>
        private System.Diagnostics.Stopwatch GameStopwatch;

        /// <summary>
        /// This TimeSpan will keep track of how long the game has been going on
        /// </summary>
        private TimeSpan GameTime;

        /// <summary>
        /// Sound player for playing the correct or incorrect sound files
        /// </summary>
        private SoundPlayer sndAnswer;

        /// <summary>
        /// This variable holds the time that it took to complete the game. used for passing to mainwindow.
        /// </summary>
        private string sFinalTime;

        /// <summary>
        /// This variable holds the time in total seconds for comparison later
        /// </summary>
        private double dFinalTime;

        /// <summary>
        /// This boolean checks to see if the game was played all the way through
        /// </summary>
        private bool bGameFinished;

        public wndGame()
        {
            try
            {
                InitializeComponent();
                clsGameClass = new clsGame();
                btnGameSubmit.IsEnabled = false;
                brdrScore.Visibility = Visibility.Hidden;
                txtAnswer.Text = "";

                //Needed to trigger the stopwatch label update
                GameTimer = new DispatcherTimer();
                GameTimer.Interval = TimeSpan.FromSeconds(1);
                GameTimer.Tick += new EventHandler(GameTimer_Tick);

                //creates a stopwatch to handle the game label timer
                GameStopwatch = new System.Diagnostics.Stopwatch();
                lblGameTimer.Content = "Timer: 00:00";

                //Makes sure the score starts at 0
                clsGameClass.ClearScore();

                bGameFinished = false;

            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method makes a game tick to update any feilds that need it. In this case, the game timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GameTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                GameTime = GameStopwatch.Elapsed;
                string sTime = String.Format("{0:00}:{1:00}", GameTime.Minutes, GameTime.Seconds);
                lblGameTimer.Content = "Timer: " + sTime;

                //Grabs the final time when this method is called for the last time.
                sFinalTime = sTime;
                dFinalTime = GameTime.TotalSeconds;
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method forward the game type to the game class for processing
        /// </summary>
        /// <param name="game"></param>
        public void SetGameType(string game)
        {
            try
            {
                clsGameClass.SetGameType(game);
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }




        /// <summary>
        /// This button submits the answer to the question and sends it to the game class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGameSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int iAnswer;
                Int32.TryParse(txtAnswer.Text, out iAnswer);
                clsGameClass.SetAnswer(iAnswer);
                txtAnswer.Text = "";

                //DISPLAY PROPER PICTURE AND PLAY PROPER SOUND
                if (clsGameClass.Correct())
                {
                    imgBag.Visibility = Visibility.Hidden;
                    imgCoal.Visibility = Visibility.Hidden;
                    imgGift.Visibility = Visibility.Visible;

                    sndAnswer = new SoundPlayer("Correct.wav");
                    sndAnswer.Play();
                }
                else
                {
                    imgBag.Visibility = Visibility.Hidden;
                    imgCoal.Visibility = Visibility.Visible;
                    imgGift.Visibility = Visibility.Hidden;

                    sndAnswer = new SoundPlayer("Incorrect.wav");
                    sndAnswer.Play();
                }

                //POPULATE NEXT QUESTION
                txtQuestion.Text = clsGameClass.Question();
                lblGameInfo.Content = "Question " + clsGameClass.QuestionNumber() + ":";


                //checks to see if it's the last question
                if (clsGameClass.IsLastQuestion())
                {

                    //SEND INFO TO SCORES CLASS THROUGH SCORES WINDOW

                    //This block cleans up the game board after the last question
                    btnGameSubmit.IsEnabled = false;
                    btnGameStart.IsEnabled = false;
                    txtQuestion.Text = "";
                    txtAnswer.IsEnabled = false;
                    lblGameInfo.Content = "Question 10:";
                    brdrScore.Visibility = Visibility.Visible;
                    lblScoreNumber.Content = clsGameClass.GetScore() + "/10";

                    //Stops the timer
                    GameTimer.Stop();
                    GameStopwatch.Stop();

                    bGameFinished = true;
                }
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method starts the game by populating the first question and starting the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGameStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                //REQUEST POPULATION OF QUESTION
                txtQuestion.Text = clsGameClass.Question();
                lblGameInfo.Content = "Question " + clsGameClass.QuestionNumber() + ":";
                btnGameSubmit.IsEnabled = true;
                btnGameStart.IsEnabled = false;

                //Starts the timer
                GameTimer.Start();
                GameStopwatch.Start();

            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method holds all of the cleanup that should be donw after the game.
        /// </summary>
        public void Cleanup()
        {
            try
            {
                //This runs and cleaning up needed on the class side of the game
                clsGameClass.CleanUp();

                //This block of code cleans up the game board for the next round
                txtQuestion.Text = "";
                lblGameInfo.Content = "Question 1:";
                imgBag.Visibility = Visibility.Visible;
                imgCoal.Visibility = Visibility.Hidden;
                imgGift.Visibility = Visibility.Hidden;
                btnGameStart.IsEnabled = true;
                btnGameSubmit.IsEnabled = false;
                txtAnswer.IsEnabled = true;
                brdrScore.Visibility = Visibility.Hidden;

                //reset the timer
                GameStopwatch.Reset();
                lblGameTimer.Content = "Timer: 00:00";

                //Clears the score
                clsGameClass.ClearScore();

                bGameFinished = false;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method returns the final time that was on the game board
        /// </summary>
        /// <returns></returns>
        public string getTimeString()
        {
            try
            {
                return sFinalTime;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This mehtod returns the game time as a double in total seconds
        /// </summary>
        /// <returns></returns>
        public double getTimeDouble()
        {
            try
            {
                return dFinalTime;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method returns the final score of the game board
        /// </summary>
        /// <returns></returns>
        public int getScore()
        {
            try
            {
                return clsGameClass.GetScore();
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
        private void btnGameQuit_Click(object sender, RoutedEventArgs e)
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


        private void btnGameToScores_Click(object sender, RoutedEventArgs e)
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

        public bool GameCompleted()
        {
            try
            {
                if (bGameFinished)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

    }// end class
}
