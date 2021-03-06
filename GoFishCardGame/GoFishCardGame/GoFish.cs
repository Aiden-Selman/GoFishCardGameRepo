using GoFishCardGame;
using System.Collections;

/*
 * Name:  Aiden Selman
 * Created:   2/3/2022
 * Updated:   2/8/2022
 */

int numberOfCardsInHand;
int numberOfCardsOnTheTable = 52;
ArrayList playerHand = new ArrayList();
List<PlayerHand> players;
players = new List<PlayerHand>();


// Receive input from the keyboard as to how many players will be playing.
Console.WriteLine("How many players will be playing?");
int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("There will be {0} players.", numberOfPlayers);

// Assigns the number of cards in each players hand based on how many players are playing.
if(numberOfPlayers <= 3)
{
    numberOfCardsInHand = 7;
}
else
{
    numberOfCardsInHand = 5;
}

// Create each players hands.
do
{
    for (int i = 0; i <= numberOfPlayers; i++)
    {
        for (int j = 0; j < numberOfCardsInHand; j++)
        {
            Random random = new Random();
            PlayingCard playerCard = new PlayingCard((CardSuits)random.Next(1, 5), (CardValues)random.Next(1, 15));
            playerHand.Add(playerCard);
            numberOfCardsOnTheTable--;
        }
        players.Add(new PlayerHand());
    }
}

while (numberOfCardsOnTheTable > 0);
{

}