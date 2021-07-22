using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace AlgorithmProblems
{
    class MessageDemonstration
    {
        public void Demonstrate()
        {
            string message = File.ReadAllText(@"C:\Users\HP1\source\repos\ALGORITHMPROBLEMS\AlgorithmProblems\Message.txt");
            string namePattern = "<<name>>";
            string fullNamePatter = "<<full name>>";
            string number = "xxxxxxxxxx";
            Regex nameMatch = new Regex(namePattern);
            if(nameMatch.IsMatch(message))
            {
                message = message.Replace(namePattern, "Jeba");
            }
            Regex fullnameMatch = new Regex(fullNamePatter);
            if(fullnameMatch.IsMatch(message))
            {
                message = message.Replace(fullNamePatter, "Jebakani Ishwarya");
            }
            Regex numberMatch = new Regex(number);
            if (numberMatch.IsMatch(message))
            {
                message = message.Replace(number, "8680018236");
            }
            Console.WriteLine(message);
        }

    }
}
