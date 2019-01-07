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
    /// Interaction logic for wndUser.xaml
    /// </summary>
    public partial class wndUser : Window
    {
        /// <summary>
        /// This class will hold all of the user information
        /// </summary>
        private clsUser clsUserClass;

        /// <summary>
        /// This Variable will determine if the buttons on the main menu should be unlocked
        /// </summary>
        private bool bUnlockButtons = false;

        public wndUser()
        {
            try
            {
                InitializeComponent();

                clsUserClass = new clsUser();
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method is called when the 'Submit' button is pressed in the User Information window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bUnlockButtons = false;
                int iAge = 0;
                
                //Checks to see if any of the input fields are blank
                if (txtUserName.Text == "" && txtUserAge.Text == "")
                {
                    lblUserInfo.Content = "Missing name and age!";
                }
                else if (txtUserName.Text == "")
                {
                    lblUserInfo.Content = "Don't forget your name!";
                }
                else if (txtUserAge.Text == "")
                {
                    lblUserInfo.Content = "Don't forget your age!";
                }
                else
                {
                    //sets the name
                    clsUserClass.setName(txtUserName.Text);

                    //checks to see if the input for age is a number
                    if (Int32.TryParse(txtUserAge.Text, out iAge))
                    {
                        clsUserClass.setAge(iAge);

                        lblUserInfo.Content = "Succefully Submitted.";
                        
                        bUnlockButtons = true;
                        unlockButtons();
                    }
                    else
                    {
                        lblUserInfo.Content = "Age wasn't a number.";
                    }
                }// end else if string
            }
            catch (Exception ex)
            {
                // Top level method to handle the error.
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }// end button

        /// <summary>
        /// This Method returns a boolean determined by user inpud data
        /// </summary>
        /// <returns></returns>
        public bool unlockButtons()
        {
            try
            {
                return bUnlockButtons;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method calls the clsUserClass get name method so pull it up.
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            try
            {
                return clsUserClass.getName();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method calls the clsUserClass get age method so pull it up.
        /// </summary>
        /// <returns></returns>
        public int getAge()
        {
            try
            {
                return clsUserClass.getAge();
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
                lblUserInfo.Content = "Edit Name or Age.";
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
        private void btnUserReturn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                lblUserInfo.Content = "Edit Name or Age.";
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
