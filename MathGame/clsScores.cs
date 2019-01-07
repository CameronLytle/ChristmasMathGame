using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    class clsScores
    {

        private Player pCurrentPlayer;
        private Player pFirst = new Player(0, "00:00", "Player", 00, 0);
        private Player pSecond = new Player(0, "00:00", "Player", 00, 0);
        private Player pThird = new Player(0, "00:00", "Player", 00, 0);
        private Player pFourth = new Player(0, "00:00", "Player", 00, 0);
        private Player pFifth = new Player(0, "00:00", "Player", 00, 0);
        private Player pSixth = new Player(0, "00:00", "Player", 00, 0);
        private Player pSeventh = new Player(0, "00:00", "Player", 00, 0);
        private Player pEighth = new Player(0, "00:00", "Player", 00, 0);
        private Player pNinth = new Player(0, "00:00", "Player", 00, 0);
        private Player pTenth = new Player(0, "00:00", "Player", 00, 0);
        private string sTitle;
        private string sFirstPlace;
        private string sSecondPlace;
        private string sThirdPlace;
        private string sFourthPlace;
        private string sFifthPlace;
        private string sSixthPlace;
        private string sSeventhPlace;
        private string sEighthPlace;
        private string sNinthPlace;
        private string sTenthPlace;

        /// <summary>
        /// This method gathers the information from the scores window for processing.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="time"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="type"></param>
        public void GatherInformation(int score, string time, string name, int age, double timeDouble)
        {
            try
            {
                pCurrentPlayer.iScoreRight = score;
                pCurrentPlayer.iScoreWrong = 10 - score;
                pCurrentPlayer.iAge = age;
                pCurrentPlayer.sName = name;
                pCurrentPlayer.sTime = time;
                pCurrentPlayer.dTime = timeDouble;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }

        /// <summary>
        /// A Structure that will help me compare players on the board
        /// </summary>
        public struct Player
        {
            
            public int iScoreRight;
            public int iScoreWrong;
            public int iAge;
            public string sName;
            public string sTime;
            public double dTime;

            public Player(int score, string time, string name, int age, double timeDouble)
            {
                try
                {
                    iScoreRight = score;
                    iScoreWrong = 10 - score;
                    iAge = age;
                    sName = name;
                    sTime = time;
                    dTime = timeDouble;
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                        MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
            
        }

        /// <summary>
        /// This method will sort the high scores
        /// </summary>
        public void SortHighScores()
        {
            try
            {
                if (pCurrentPlayer.iScoreRight > pFirst.iScoreRight ||
                    pCurrentPlayer.iScoreRight == pFirst.iScoreRight && pCurrentPlayer.dTime < pFirst.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pEighth;
                    pEighth = pSeventh;
                    pSeventh = pSixth;
                    pSixth = pFifth;
                    pFifth = pFourth;
                    pFourth = pThird;
                    pThird = pSecond;
                    pSecond = pFirst;
                    pFirst = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pSecond.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pSecond.iScoreRight && pCurrentPlayer.dTime < pSecond.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pEighth;
                    pEighth = pSeventh;
                    pSeventh = pSixth;
                    pSixth = pFifth;
                    pFifth = pFourth;
                    pFourth = pThird;
                    pThird = pSecond;
                    pSecond = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pThird.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pThird.iScoreRight && pCurrentPlayer.dTime < pThird.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pEighth;
                    pEighth = pSeventh;
                    pSeventh = pSixth;
                    pSixth = pFifth;
                    pFifth = pFourth;
                    pFourth = pThird;
                    pThird = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pFourth.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pFourth.iScoreRight && pCurrentPlayer.dTime < pFourth.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pEighth;
                    pEighth = pSeventh;
                    pSeventh = pSixth;
                    pSixth = pFifth;
                    pFifth = pFourth;
                    pFourth = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pFifth.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pFifth.iScoreRight && pCurrentPlayer.dTime < pFifth.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pEighth;
                    pEighth = pSeventh;
                    pSeventh = pSixth;
                    pSixth = pFifth;
                    pFifth = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pSixth.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pSixth.iScoreRight && pCurrentPlayer.dTime < pSixth.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pEighth;
                    pEighth = pSeventh;
                    pSeventh = pSixth;
                    pSixth = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pSeventh.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pSeventh.iScoreRight && pCurrentPlayer.dTime < pSeventh.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pEighth;
                    pEighth = pSeventh;
                    pSeventh = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pEighth.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pEighth.iScoreRight && pCurrentPlayer.dTime < pEighth.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pEighth;
                    pEighth = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pNinth.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pNinth.iScoreRight && pCurrentPlayer.dTime < pNinth.dTime)
                {
                    pTenth = pNinth;
                    pNinth = pCurrentPlayer;
                }
                else if (pCurrentPlayer.iScoreRight > pTenth.iScoreRight ||
                         pCurrentPlayer.iScoreRight == pTenth.iScoreRight && pCurrentPlayer.dTime < pTenth.dTime)
                {
                    pCurrentPlayer = pTenth;
                }
                else
                {
                    //Can't think of anything that this should default to.
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }




        #region Methods that return display strings

        /// <summary>
        /// Returns score board type string
        /// </summary>
        /// <returns></returns>
        public string ScoreTitle()
        {
            try
            {
                sTitle = "Addition High Scores!";
                return sTitle;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// This method will update the score info when returned
        /// </summary>
        /// <returns></returns>
        public string ScoreInfo()
        {
            try
            {
                return "Your Score: " + pCurrentPlayer.iScoreRight + "/10    " + "Time: " + pCurrentPlayer.sTime;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// Returns first place string
        /// </summary>
        /// <returns></returns>
        public string FirstPlace()
        {
            try
            {
                sFirstPlace = "1.   " + pFirst.sName + "   " + pFirst.iAge + "   " + pFirst.iScoreRight + 
                                "/10   " + pFirst.iScoreWrong + "/10   " + pFirst.sTime;
                return sFirstPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }

        /// <summary>
        /// Returns second place string
        /// </summary>
        /// <returns></returns>
        public string SecondPlace()
        {
            try
            {
                sSecondPlace = "2.   " + pSecond.sName + "   " + pSecond.iAge + "   " + pSecond.iScoreRight +
                                 "/10   " + pSecond.iScoreWrong + "/10   " + pSecond.sTime;
                return sSecondPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Returns third place string
        /// </summary>
        /// <returns></returns>
        public string ThirdPlace()
        {
            try
            {
                sThirdPlace = "3.   " + pThird.sName + "   " + pThird.iAge + "   " + pThird.iScoreRight +
                                "/10   " + pThird.iScoreWrong + "/10   " + pThird.sTime;
                return sThirdPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Returns fourth place string
        /// </summary>
        /// <returns></returns>
        public string FourthPlace()
        {
            try
            {
                sFourthPlace = "4.   " + pFourth.sName + "   " + pFourth.iAge + "   " + pFourth.iScoreRight +
                                "/10   " + pFourth.iScoreWrong + "/10   " + pFourth.sTime;
                return sFourthPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Returns fifth place string
        /// </summary>
        /// <returns></returns>
        public string FifthPlace()
        {
            try
            {
                sFifthPlace = "5.   " + pFifth.sName + "   " + pFifth.iAge + "   " + pFifth.iScoreRight +
                                "/10   " + pFifth.iScoreWrong + "/10   " + pFifth.sTime;
                return sFifthPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Returns sixth place string
        /// </summary>
        /// <returns></returns>
        public string SixthPlace()
        {
            try
            {
                sSixthPlace = "6.   " + pSixth.sName + "   " + pSixth.iAge + "   " + pSixth.iScoreRight +
                                "/10   " + pSixth.iScoreWrong + "/10   " + pSixth.sTime;
                return sSixthPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// returns seventh place string
        /// </summary>
        /// <returns></returns>
        public string SeventhPlace()
        {
            try
            {
                sSeventhPlace = "7.   " + pSeventh.sName + "   " + pSeventh.iAge + "   " + pSeventh.iScoreRight +
                                "/10   " + pSeventh.iScoreWrong + "/10   " + pSeventh.sTime;
                return sSeventhPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// returns eighth place string
        /// </summary>
        /// <returns></returns>
        public string EighthPlace()
        {
            try
            {
                sEighthPlace = "8.   " + pEighth.sName + "   " + pEighth.iAge + "   " + pEighth.iScoreRight +
                                "/10   " + pEighth.iScoreWrong + "/10   " + pEighth.sTime;
                return sEighthPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// returns ninths place string
        /// </summary>
        /// <returns></returns>
        public string NinthPlace()
        {
            try
            {
                sNinthPlace = "9.   " + pNinth.sName + "   " + pNinth.iAge + "   " + pNinth.iScoreRight +
                                "/10   " + pNinth.iScoreWrong + "/10   " + pNinth.sTime;
                return sNinthPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
        
        /// <summary>
        /// returns tenth place string
        /// </summary>
        /// <returns></returns>
        public string TenthPlace()
        {
            try
            {
                sTenthPlace = "10.   " + pTenth.sName + "   " + pTenth.iAge + "   " + pTenth.iScoreRight +
                                "/10   " + pTenth.iScoreWrong + "/10   " + pTenth.sTime;
                return sTenthPlace;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
#endregion
        
    }
}
