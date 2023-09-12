using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace Bina_Section6
{
    [TestClass]
    public class StringClass
    {
        [TestMethod]
        public void Use_String_Class()
        {
            //string words = "some words"; //calling constructor in the backend

            string str = "Hi I am Bina";
            Console.WriteLine(str);

            int startIndex = 3;
            int length = 9;
            string substr = str.Substring(startIndex,length);
            Console.WriteLine(substr);

            string test = "color1=red";
            string strTest = test.Substring(0, 6);
            Console.WriteLine( strTest );

            String[] pairs = { "Color1=red", "Color2=green", "Color3=blue",
                 "Title=Code Repository" };
            foreach (var pair in pairs)
            {
                int position = pair.IndexOf("=");
                if (position < 0)
                    continue;
                Console.WriteLine("Key: {0}, Value: '{1}'",
                               pair.Substring(0, position),
                               pair.Substring(position + 1));
            }

        }

        [TestMethod]
        public void Join_Strings_together()
        {
            Char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f' };
            string joinAll = new string(chars);
            Console.WriteLine(joinAll);
        }
    }
}
