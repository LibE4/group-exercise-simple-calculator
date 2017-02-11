using System.Collections.Generic;

namespace SimpleCalculator
{
    public class Storage
    {
        public Storage()
        {
            last = 0;
            lastq = "Not available yet";
        }
        public int last { get; set; }
        public string lastq { get; set; }
        public static Dictionary<string, int> myConstants = new Dictionary<string, int>();
    }
}
