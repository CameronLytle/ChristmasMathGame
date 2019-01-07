using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    class clsUser
    {
        /// <summary>
        /// Private variable that holds the users name
        /// </summary>
        private string sName = "";

        /// <summary>
        /// Private variable that holds the users age.
        /// </summary>
        private int iAge = 0;

        /// <summary>
        /// Public method that sets the users name.
        /// </summary>
        /// <param name="name"></param>
        public void setName(string name)
        {
            try
            {
                sName = name;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Public method that returns the users name.
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            try
            {
                return sName;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Public method that sets the users age.
        /// </summary>
        /// <param name="age"></param>
        public void setAge(int age)
        {
            try
            {
                iAge = age;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Public method that returns the users age.
        /// </summary>
        /// <returns></returns>
        public int getAge()
        {
            try
            {
                return iAge;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

    }// end class
}
