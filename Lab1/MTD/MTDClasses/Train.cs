using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDClasses
{
    /// <summary>
    /// Train Class - This is a Base Class that has a List of Dominos and all the methods for interacting
    /// with the train.
    /// </summary>
    public class Train {
        /// <summary>
        /// protected - List of Domino - dominos
        /// </summary>
        protected List<Domino> dominos;
        
        /// <summary>
        /// engineValue - int stores the starting pipvalue
        /// </summary>
        protected int engineValue;


        /// <summary>
        /// Count - int - how many dominos on the train
        /// </summary>
        public int Count{
            get{
                return this.dominos.Count;
            }
        }
        /// <summary>
        /// EngineValue - int - Allow Changing of Engine Value
        /// </summary>
        public int EngineValue{
            get{
                return this.engineValue;
            }
            set{
                this.engineValue = value;
            }
        }
        /// <summary>
        /// IsEmpty - bool - Check if train is empty
        /// </summary>
        public bool IsEmpty{
            get{
                // Using our Property calc for count
                if(this.Count == 0) { return true; }
                return false;
            }
        }
        /// <summary>
        /// LastDomino - Returns a domino from the farthest right position on train
        /// </summary>
        public Domino LastDomino{
            // Only should be ran if there is a domino
            get{
                if (this.IsEmpty){
                    return null; // OR THROW - IF ADDING ERROR HANDLER
                }
                return this.dominos[this.Count - 1]; // Return last Domino
            }
        }
        /// <summary>
        /// PlayableValue - Returns an Int of the engine value (if train empty) or the farthest right tiles right side (side2
        /// </summary>
        public int PlayableValue{
            get{
                if(this.LastDomino == null){
                    // If no dominos played - grab engine value
                    return this.engineValue;
                }
                else{
                    // grab the right side of the last domino
                    return this.LastDomino.Side2;
                }

            }
        }
        /// <summary>
        /// Indexer for Train
        /// </summary>
        /// <param name="index">int - index location</param>
        /// <returns></returns>
        public Domino this[int index]{
            get{
                // Domino from the list
                return this.dominos[index];
            }
            set{
                // Set Domino into the list / useful for cheat mode
                this.dominos[index] = value;
            }
        }

        /// <summary>
        /// Train - Default Constructor
        /// </summary>
        public Train(){
            // Create the List
            this.dominos = new List<Domino>();
        }

        /// <summary>
        /// Train - Overloaded Constructor - Accepts an int and sets it as engineValue
        /// </summary>
        /// <param name="engineValue">int - starting engine value</param>
        public Train(int engineValue)
        {
            // Create the List
            this.dominos = new List<Domino>();
            // Set Engine Value
            this.engineValue = engineValue;
        }
        /// <summary>
        /// IsPlayable - Returns a Boolean whether the domino passed to it can be played on the train
        /// </summary>
        /// <param name="d">Domino</param>
        /// <param name="mustFlip">Boolean if it needs flipped</param>
        /// <returns></returns>
        public bool IsPlayable(Domino d, out bool mustFlip)
        {
            mustFlip = false;
            if(this.IsEmpty)
            {
                if(this.PlayableValue == d.Side1 )
                {
                    return true;
                }
                else if(this.PlayableValue == d.Side2)
                {
                    mustFlip = true;
                    return true;
                }
            }
            else if (this.LastDomino.Side2 == d.Side1)
            {
                return true;
            }
            else if(this.LastDomino.Side2 == d.Side2)
            {
                mustFlip = true;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Add - Passes a Domino into the train
        /// </summary>
        /// <param name="d">domino</param>
        public void Add(Domino d){
            this.dominos.Add(d);
        }
        
        /// <summary>
        /// Play - Does not return anything - assumes you have already checked the domino
        /// </summary>
        /// <param name="d">domino</param>
        public void Play(Domino d){
            
            bool mustFlip = false;
            if(this.IsPlayable(d, out mustFlip)){
                if (mustFlip){
                    d.Flip();
                }
                this.Add(d);
            }
            else
            {
                throw new ArgumentException("You just tried to play a Domino that cannot be played");
            }
  
        }
        // This isn't necessary - but why not
        public string Show (int which){
            // using indexer
            return this[which].ToString();
        }
    
    }
}
