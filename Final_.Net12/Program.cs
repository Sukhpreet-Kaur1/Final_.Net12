using System;

namespace Final_.Net12
{
    class Program
    {
       
        static void Main(string[] args)
        {
            child obj = new child();
            obj.First_Name = "preet";
            obj.Last_Name = "kaur";
        }
        public class Adult
        {
         public string First_Name;
            public string Last_Name;

        }
        public class child : Adult
        { 
        }
    }
}
