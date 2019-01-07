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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MathGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Class that holds the Game communication with the UserForm and the clsUser
        /// </summary>
        private wndUser wndUserForm;
        /// <summary>
        /// Class that holds the Game communication with the GameForm and the clsGame 
        /// </summary>
        private wndGame wndGameForm;
        /// <summary>
        /// Class that holds the Game communication with the ScoresForm and the clsScores 
        /// </summary>
        private wndScores wndScoresForm;

        /// <summary>
        /// This sound player plays the main menu music
        /// </summary>
        private SoundPlayer sndMainMenu; // sound player object to play main menu music

        /// <summary>
        /// This boolean checks to see if any info has been entered.
        /// </summary>
        private bool bIsInfoEntered = false;


        public MainWindow()
        {
            try
            {
                InitializeComponent();

                //This is needed to shut down the application after closing the main window.
                Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

                wndUserForm = new wndUser();
                wndGameForm = new wndGame();
                wndScoresForm = new wndScores();

                btnAddition.IsEnabled = false;
                btnSubtraction.IsEnabled = false;
                btnDivision.IsEnabled = false;
                btnMultiplication.IsEnabled = false;
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This Method plays the main menu music when the checkbox is checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuMusicOn(object sender, RoutedEventArgs e)
        {
            sndMainMenu = new SoundPlayer("MainMenuMusic.wav");
            sndMainMenu.PlayLooping();
        }

        /// <summary>
        /// This method stops the music when the "Music" checkbox is unchecked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuMusicOff(object sender, RoutedEventArgs e)
        {
            sndMainMenu.Stop();
        }


        /// <summary>
        /// This method Hides the main window and shows the User window, it also updates info label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserInfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = "";
                this.Hide();
                wndUserForm.ShowDialog();

                //Grabs the users name for display
                name = wndUserForm.getName();
                lblInfo.Content = "Hello " + name + ", pick a game to play!";

                // unlocks the buttons to be used if the info was entered
                bIsInfoEntered = wndUserForm.unlockButtons();
                if (bIsInfoEntered == true)
                {
                    btnAddition.IsEnabled = true;
                    btnSubtraction.IsEnabled = true;
                    btnDivision.IsEnabled = true;
                    btnMultiplication.IsEnabled = true;
                }

                this.Show();
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }


        /// <summary>
        /// This method controls each of the different math games that the user can select from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MathGame(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bIsInfoEntered == true)
                {
                    Button clickedButton = sender as Button;

                    this.Hide();

                    //Converts the object's content to a string, then sends it to set the game type
                    // I felt pretty clever coming up with this stack path and reading the button itself
                    wndGameForm.SetGameType(clickedButton.Content.ToString());

                    wndGameForm.ShowDialog();

                    // Checks to see if the game was finished before sending data to scores;
                    if (wndGameForm.GameCompleted())
                    {
                        //Transfer all the data scores needs
                        HighScoresTransfer(clickedButton.Content.ToString());
                        wndScoresForm.ShowDialog();
                    }

                    //RUN CLEANUP
                    wndGameForm.Cleanup();

                    this.Show();
                }
                else
                {
                    lblInfo.Content = "Input user info before playing.";
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
        /// This method sends the scores form all the information it needs
        /// </summary>
        /// <param name="type"></param>
        public void HighScoresTransfer(string type)
        {
            wndScoresForm.GatherInformation(wndGameForm.getScore(), wndGameForm.getTimeString(), wndUserForm.getName(), wndUserForm.getAge(), type, wndGameForm.getTimeDouble());
        }


        /// <summary>
        /// This method opens up the high scores form from the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHighScores_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                wndScoresForm.ShowDialog();
                this.Show();
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
    }// end class
}
