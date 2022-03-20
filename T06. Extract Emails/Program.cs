using System;

namespace T06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Look and understand the following patter:
            string pattern =
                @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-\_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";
        }
    }
}
