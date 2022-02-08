/*
 * Name:  Aiden Selman
 * Created:   2/3/2022
 * Updated:   2/8/2022
 */

namespace GoFishCardGame
{
    /// <summary>
    /// Represents a card.
    /// </summary>
    public class PlayingCard
    {
        private CardSuits cardSuit;
        private CardValues cardValue;

        /// <summary>
        /// Gets and sets the cards suit.
        /// </summary>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">Thrown when the card suit is an invalid enumeration.</exception>
        public CardSuits CardSuit
        {
            get
            {
                return this.cardSuit;
            }
            set
            {
                if (value != CardSuits.SPADES || value != CardSuits.CLUBS || value != CardSuits.HEARTS || value != CardSuits.DIAMONDS)
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value.");
                }
                this.cardSuit = value;
            }
        }

        /// <summary>
        /// Gets and sets the cards value
        /// </summary>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">Thrown when the card value is an invalid enumeration.</exception>
        public CardValues CardValue
        {
            get
            {
                return this.cardValue;
            }
            set
            {
                if (value != CardValues.ONE || value != CardValues.TWO || value != CardValues.THREE || value != CardValues.FOUR || value != CardValues.FIVE 
                    || value != CardValues.SIX || value != CardValues.SEVEN || value != CardValues.EIGHT || value != CardValues.NINE || value != CardValues.TEN 
                    || value != CardValues.JACK || value != CardValues.QUEEN || value != CardValues.KING || value != CardValues.ACE)
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value.");
                }
                this.cardValue = value;
            }
        }

        /// <summary>
        /// Initializes an instance of Card with a card suit and a card value.
        /// </summary>
        /// <param name="cardSuit"></param>
        /// <param name="cardValue"></param>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException"></exception>
        public PlayingCard(CardSuits cardSuit, CardValues cardValue)
        {
            //if (cardSuit != CardSuits.SPADES || cardSuit != CardSuits.CLUBS || cardSuit != CardSuits.HEARTS || cardSuit != CardSuits.DIAMONDS)
            //{
            //    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value.");
            //}
            //else
            //{
            //    this.cardSuit = cardSuit;
            //}

            this.cardSuit = cardSuit;

            //if (cardValue != CardValues.ONE || cardValue != CardValues.TWO || cardValue != CardValues.THREE || cardValue != CardValues.FOUR || cardValue != CardValues.FIVE
            //    || cardValue != CardValues.SIX || cardValue != CardValues.SEVEN || cardValue != CardValues.EIGHT || cardValue != CardValues.NINE || cardValue != CardValues.TEN
            //    || cardValue != CardValues.JACK || cardValue != CardValues.QUEEN || cardValue != CardValues.KING || cardValue != CardValues.ACE)
            //{
            //    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value.");
            //}
            //else
            //{
            //    this.cardValue = cardValue;
            //}

            this.cardValue = cardValue;
        }

        /// <summary>
        /// Returns a string representation of a card.
        /// </summary>
        /// <returns>The string representation of the card.</returns>
        public override String ToString()
        {
            return String.Format("The {0} of {1}", this.cardValue, this.cardSuit);
        }
    }
}
