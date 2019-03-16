using System;
using System.Collections.Generic;

/*
    Every email consists of a local name and a domain name, separated by the @ sign.

    For example, in alice@leetcode.com, alice is the local name, and leetcode.com is the domain name.

    Besides lowercase letters, these emails may contain '.'s or '+'s.

    If you add periods ('.') between some characters in the local name part of an email address,
    mail sent there will be forwarded to the same address without dots in the local name.
    
    For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.
    (Note that this rule does not apply for domain names.)

    If you add a plus ('+') in the local name, everything after the first plus sign will be ignored.
    This allows certain emails to be filtered, for example m.y+name@email.com will be forwarded to my@email.com.
    (Again, this rule does not apply for domain names.)

    It is possible to use both of these rules at the same time.

    Given a list of emails, we send one email to each address in the list.  How many different addresses actually receive mails?


    Input: ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]
    Output: 2
    Explanation: "testemail@leetcode.com" and "testemail@lee.tcode.com" actually receive mails
 
    Results: Runtime: 112 ms, faster than 95.74% of C# online submissions for Unique Email Addresses.
             Memory Usage: 26.2 MB, less than 48.87% of C# online submissions for Unique Email Addresses.

 */

namespace Unique_Email_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unique Emails: " + NumUniqueEmails(new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" }));
            Console.ReadLine();
        }

        public static int NumUniqueEmails(string[] emails)
        {
            int emailCount = 0;

            string[] splitA, splitB;
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < emails.Length; i++)
            {
                splitA = emails[i].Split("@"); // Split two halfs of email
                splitB = splitA[0].Split("+"); // Split and ignore anything after +

                string key = splitB[0].Replace(".", "") + "@" + splitA[1]; // Append formatted email, removing any .
                if (!map.ContainsKey(key)) // Only incriment unique email count if this isn't in the hashmap
                {
                    map.Add(key, i);
                    emailCount++;
                }
            }

            return emailCount;
        }
    }
}
