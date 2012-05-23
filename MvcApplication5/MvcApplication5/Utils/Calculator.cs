using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication5.Utils
{
    public class Calculator
    {


        public int AddNumbers(int a, int b)
        {
            return a + b;
        }


        public int MultiplyNumbers(int i1, int i2)
        {
            return i1*i2;
        }

        public List<Notes > GetNotes(int i)
        {
            return new List<Notes>(){new Notes(){Name = "test1"}};
        }


        

    }


    public class Notes
    {
        public string Name { get; set; }
    }
}