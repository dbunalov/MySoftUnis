﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main()
        {
            Dictionary<string, List<string>> playersCards = new Dictionary<string, List<string>>();

            string commandLine = Console.ReadLine();

            while (commandLine.Equals("JOKER"))
            {
                string[] commandArgs = commandLine.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string playerName = commandArgs[0];
                string[] cards = commandArgs[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (!playersCards.ContainsKey(playerName))
                {
                    playersCards.Add(playerName, new List<string>());
                }

                playersCards[playerName].AddRange(cards);

                commandLine = Console.ReadLine();
            }
            PrintPlayersScores(playersCards);
        }

        private static void PrintPlayersScores(Dictionary<string, List<string>> playersCards)
        {
            foreach (var playerEntry in playersCards)
            {
                string playerName = playerEntry.Key;
                List<string> cards = playerEntry.Value.Distinct().ToList();//Distinct == unique

                int playerScore = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0,card.Length - 1);
                    string suite = card.Substring(card.Length - 1);

                    int rankPower = GetRank(rank);
                    int suitePower = GetSuite(suite);

                    playerScore += rankPower * suitePower;
                }
                Console.WriteLine($"{playerName}: {playerScore}");

            }
        }

        private static int GetSuite(string rank)
        {
            switch (rank)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
                    break;
            }
        }

        private static int GetRank(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;

                default:
                    //       throw new ArgumentException("No such suite");
                    return 1;
            }
        }
    }
}
