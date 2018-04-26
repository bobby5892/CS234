using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDClasses
{
    /// <summary>
    /// PrivateTrain - This is a derived class from Train that includes additional methods and a Hand
    /// </summary>
    public class PrivateTrain : Train
    {
        /// <summary>
        /// // Hand - Create from Hand Class
        /// </summary>
        Hand hand;
        /// <summary>
        /// //isOpen - bool - whether the the train can be played on by others
        /// </summary>
        bool isOpen;

      /// <summary>
      /// IsOpen - Property - get only - This returns a boolean that tells if the train is open 
      /// </summary>
        public bool IsOpen { get; }

        /// <summary>
        /// Close - No return - this closes the train so it can't be played on by other users
        /// </summary>
        public void Close()
        {
            this.isOpen = false;
        }

        /// <summary>
        /// IsPlayable - Returns a boolean - checks if train is open or its your train, and then looks to see if you can play this
        /// domino on the train
        /// </summary>
        /// <param name="d">Domino - The one its checking</param>
        /// <param name="mustFlip">Bool - Does it need flipped to play</param>
        /// <param name="h">Hand - Passes in a hand to check if its yours or not</param>
        /// <returns></returns>
        public bool IsPlayable (Domino d, out bool mustFlip, Hand h)
        {
            mustFlip = false;
            if (h == this.hand || this.IsOpen) // this is our hand
            {
                if (this.PlayableValue == d.Side1)
                {
                    return true;
                }
                else if(this.PlayableValue == d.Side2)
                {
                    mustFlip = true;
                    return true;
                }
            }
             return false; 
         }
       /// <summary>
       /// Open - No Return - this opens the train to be playable b others
       /// </summary>
        public void Open()
        {
            this.isOpen = true;
        }


        public void Play(Domino d, Hand h)
        {
             if (h == this.hand || this.IsOpen) // this is our hand
            {
                if (this.PlayableValue == d.Side1)
                {
                    this.Play(d);
                 }
                else if (this.PlayableValue == d.Side2)
                {
                    d.Flip();
                    this.Play(d);
                }
            }
        }
       /// <summary>
       /// Private Train - Default Constructor
       /// </summary>
        public PrivateTrain()
        {

        }
        /// <summary>
        /// PrivateTrain Constructor - Takes a hand object and stores in the PrivateTrain
        /// </summary>
        /// <param name="h">Hand</param>
        public PrivateTrain(Hand h)
        {
            this.hand = h;
        }
        /// <summary>
        /// PrivateTrain Constructor - Takes a hand object and stores in the PrivateTrain Class, and stores the int engineValue
        /// </summary>
        /// <param name="h">Hand - stores the hand</param>
        /// <param name="engineValue">int - sets the engine value</param>
        public PrivateTrain(Hand h, int engineValue)
        {
            this.hand = h;
            this.engineValue = engineValue;
        }
        //PrivateTrain(int engineVale) overloaded with score
        public PrivateTrain(int engineValue)
        {
            this.engineValue = engineValue;
            
        }
        //ToString - override method to create string of what dominos are in the train
        public override string ToString()
        {
            // TODO AFTER HAND 

            return base.ToString();
        }




    }
}
