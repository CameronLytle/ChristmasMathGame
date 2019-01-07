using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{

    class clsGame
    {
        /// <summary>
        /// This string holds the type of game that is being played
        /// </summary>
        private string sGameType;

        /// <summary>
        /// This integer holds the answer that the user inputs
        /// </summary>
        private int iUserAnswer;

        /// <summary>
        /// This interger holds the correct answer to the current question
        /// </summary>
        private int iAnswer;

        /// <summary>
        /// This interger holds the current qustion number
        /// </summary>
        private int iQuestionNumber = 0;

        /// <summary>
        /// This interger holds the users score
        /// </summary>
        private int iScore = 0;

        /// <summary>
        /// This generates the random numbers for the questions
        /// </summary>
        private Random rndNumber = new Random();

        /// <summary>
        /// This method sets the variable game type
        /// </summary>
        /// <param name="game"></param>
        public void SetGameType(string game)
        {
            try
            {
                sGameType = game;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method sets the answer variable equal to the answer given by the user
        /// </summary>
        /// <param name="answer"></param>
        public void SetAnswer(int answer)
        {
            try
            {
                iUserAnswer = answer;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method holds all the logic for the game and returns a string to display the right question.
        /// </summary>
        public string Question()
        {
            try
            {
                int iFirstNumber;
                int iSecondNumber;
                string sQuestion = "";
                double dFirst;
                double dSecond;

                // These check to see which game type it is and changes logic depending on the type given
                if(sGameType == "Addition")
                {
                    iFirstNumber = rndNumber.Next(10);
                    iSecondNumber = rndNumber.Next(10);

                    iAnswer = iFirstNumber + iSecondNumber;

                    sQuestion = iFirstNumber + " + " + iSecondNumber + " =";
                }
                else if (sGameType == "Subtraction")
                {
                    iFirstNumber = rndNumber.Next(10);
                    iSecondNumber = rndNumber.Next(10);

                    if (iFirstNumber > iSecondNumber)
                    {
                        iAnswer = iFirstNumber - iSecondNumber;
                        sQuestion = iFirstNumber + " - " + iSecondNumber + " =";
                    }
                    else
                    {
                        iAnswer = iSecondNumber - iFirstNumber;
                        sQuestion = iSecondNumber + " - " + iFirstNumber + " =";
                    }
                }
                else if (sGameType == "Division")
                {
                    do
                    {
                        dFirst = rndNumber.Next(20);
                        dSecond = rndNumber.Next(10);
                    } while (dFirst % dSecond != 0); // this makes sure that the number turns out whole

                    iFirstNumber = Convert.ToInt32(dFirst);
                    iSecondNumber = Convert.ToInt32(dSecond);

                    iAnswer = iFirstNumber / iSecondNumber;

                    sQuestion = iFirstNumber + " / " + iSecondNumber + " =";

                }
                else if (sGameType == "Multiplication")
                {
                    iFirstNumber = rndNumber.Next(10);
                    iSecondNumber = rndNumber.Next(10);

                    iAnswer = iFirstNumber * iSecondNumber;

                    sQuestion = iFirstNumber + " x " + iSecondNumber + " =";
                }

                return sQuestion;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// This method checks to see if the question that was answered was correct.
        /// </summary>
        /// <returns></returns>
        public bool Correct()
        {
            try
            {
                if(iUserAnswer == iAnswer)
                {
                    iScore++;
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

        /// <summary>
        /// This method returns the score as an int
        /// </summary>
        /// <returns></returns>
        public int GetScore()
        {
            try
            {
                return iScore;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method clears the score by setting it back to 0.
        /// </summary>
        public void ClearScore()
        {
            try
            {
                iScore = 0;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// This method keeps track of the current question number.
        /// </summary>
        /// <returns></returns>
        public int QuestionNumber()
        {
            try
            {
                iQuestionNumber++;

                return iQuestionNumber;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        public bool IsLastQuestion()
        {
            try
            {
                if (iQuestionNumber == 11)
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

        /// <summary>
        /// This method cleans up any information that needs to be reset for the next game.
        /// </summary>
        public void CleanUp()
        {
            iQuestionNumber = 0;
        }

    }
}
