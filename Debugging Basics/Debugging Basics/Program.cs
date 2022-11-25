using System;
using System.Collections.Generic;
namespace Debugging_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // debugging tutorial
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelina" };
            var partyFriends = GetPartyFriends(null, 3);
 
            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }
 
 
        }
 
        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("list", "The List is empty");

            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater than elements in the list or lower than 0");


            var buffer = new List<string>(list);
            var partyFriends = new List<string>();
 
            while(partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }
 
        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for(var i = 0; i<list.Count; i++)
            {
                // intentional logical bug here
                if(list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
 
        }
    }
}
