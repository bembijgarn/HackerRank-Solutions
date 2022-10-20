using System;
using System.Net.Http.Headers;

namespace TimeConversation
{
    internal class Program
    {
        static void Main()
        {
            bool done = DateTime.TryParse(s,out DateTime time);
            if (done)
            {
                return time.ToString(HH:mm:ss);
            }
            return "abcde";
        }
    }
}
