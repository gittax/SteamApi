using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

using SteamKit2;
using SteamKit2.GC.Dota.Internal; // for CMsgDOTAMatch

namespace SteamApi
{
    class Program
    {
        public static CMsgDOTAMatch Match;
        static void Main(string[] args)
        {
            Auth.Authorize(args);
            Console.WriteLine("Зашли в мейн прогу");
            string username = args[0];
            string password = args[1];
            ulong matchid = Match.match_id;
            Client client = new Client(username, password, matchid);
        }
    }
}
