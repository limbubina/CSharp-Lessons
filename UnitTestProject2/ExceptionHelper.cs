using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject2;

namespace Section13
{
    static class ExceptionHelper
    {
        [TestMethod]
        public static void DivisionTest()
        {
            try//everything that can go wrong or that can cause excpetion
               //if something goes wrong here, catch the error in 'Catch()'
            {
                int totalScores = 10;
                int countofScore = 0;

                double average = totalScores / countofScore;
            }

            catch (Exception ex) //can do multipple catch block
            {
                Console.WriteLine(ex.Message);// display exception message

            }
            finally//optional
                   //is going to be executed no matter what
            {
                Console.WriteLine("Division Operation");
            }
        }

        public static string state;
        public static void CheckStateOk(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                case "SC":
                case "VA":
                    state = st.ToUpper();
                    break;
                default:
                    CustomException ex = new CustomException("State not part of Atalandtic ICW");
                    throw ex;
            }
        }
    }
}
