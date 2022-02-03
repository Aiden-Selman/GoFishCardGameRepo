using GoFishCardGame;
using System;

/*
 * Name:  Aiden Selman
 * Created:   2/3/2022
 * Updated:   2/3/2022
 */

int numberOfCardsInHand;

Console.WriteLine("How many players will be playing?");
int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("There will be {0} players.", numberOfPlayers);

for(int i = 0; i <= numberOfPlayers; i++)
{
    Random random = new Random();

}