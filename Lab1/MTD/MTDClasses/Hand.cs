using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDClasses
{
 /// <summary>
 /// Hand Class - Holds a List of dominos and all methods for interacting with that list.
 /// </summary>
    public class Hand
    {
        
        /// <summary>
        /// handOfDominos - A List containing dominos
        /// <list type="Domino"></list>
        /// </summary>
        public List<Domino> handOfDominos = new List<Domino>();

        /// <summary>
        /// Count - Returns INT of how many dominos in hand
        /// <typeparam name="datatype">Int</typeparam> 
        /// </summary>
        public int Count
        {
            get{
                return this.handOfDominos.Count;
            }
        }
        /// <summary>
        /// IsEmpty - Returns a bool if hand is empty
        /// <typeparam name="datatype">Bool</typeparam>
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                if(this.Count == 0) { return true; }
                return false;
            }
        }
        /// <summary>
        /// Score - Returns an int of the total value of the dominos in hand
        /// </summary>
        public int Score
        {
            get
            {
                int score = 0;
                for (int i = 0; i < this.Count; i++)
                {
                    score +=this.handOfDominos[i].Score;
                }
                return score;
            }
        }
 
        /// <summary>
        /// this[int] -- Returns a Domino or passes a dominio - Maps the index of Hand to allow Hand[0] reference to a domino
        /// </summary>

        public Domino this[int index]
        {
            get
            {
                if(index < this.Count)
                {
                    return this.handOfDominos[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(index <= this.Count)
                {
                    this.handOfDominos[index] = value;
                }
            
            }
        }
      
        /// <summary>
        /// Add (Domino) -- This Adds a Domino to hand
        /// </summary>
        public void Add(Domino d)
        {
            this.handOfDominos.Add(d);
            
        }

        /// <summary>
        /// Draw - This will reach out to the boneyard and grab a domino
        /// </summary>
        public Domino Draw(BoneYard by)
        {
            Domino d = by.Draw();
            this.Add(d);
            return d;
        }

        // IndexOfDomino (int pipValue) -- int
        /// <summary>
        /// IndexOfDomino  - Pass in the # of dots on the domino (pipValue) and return an INT of the index location
        /// </summary>
        
        public int IndexOfDomino( int pipValue)
        {
            bool found = false;
           
            for(int i=0; i< this.handOfDominos.Count; i++)
            {
                if(this.handOfDominos[i].Side1 == pipValue || this.handOfDominos[i].Side2 == pipValue)
                {
                    found = true;
                    return i;
                }
            }
            
            return -1;
        }
        /// <summary>
        /// IndexOfDoubleDomino - Returns the Index of where a double domino with the pipvalue is ,
        ///                      -1 if not found
        /// </summary>
        /// <param name="pipValue">int - Number of dots on domino</param>
        /// <returns></returns>
        public int IndexOfDoubleDomino (int pipValue)
        {
            bool found = false;
            int location = 0;
            for (int i = 0; i < this.handOfDominos.Count; i++)
            {
                if (this.handOfDominos[i].Side1 == this.handOfDominos[i].Side2  && this.handOfDominos[i].Side1 == pipValue)
                {
                    found = true;
                    location = i;
                }
            }
            if (found) { return location; }
            return -1;
        }
        /// <summary>
        /// IndexOfHighDouble -- Return the Index of the highest pair of dominos
        /// </summary>
        /// <returns></returns>

        public int IndexOfHighDouble()
        {
             for(int i = 12; i > 0 ; i--)
            {
                int check = IndexOfDoubleDomino(i);

                if ( check > -1)
                {
                    return i;
                }
            }
            return -1;
        }




        /// <summary>
        /// GetDomino - Returns an Domino of the Index Position of the domino
        /// </summary>
        /// <param name="pipValue">int - the number of dots onthe domino</param>
        /// <returns></returns>
        public Domino GetDomino(int pipValue)
        {
            bool found = false;
            int location = 0;
            for (int i = 0; i < this.handOfDominos.Count; i++)
            {
                if (this.handOfDominos[i].Side1 == pipValue ||  this.handOfDominos[i].Side2 == pipValue)
                {
                    found = true;
                    location = i;
                    break;
                }
            }
            if (found) { return this[location]; }
            return null;
        }
        /// <summary>
        /// GetDoubleDomino - Returns an int of the index of a double domino wit the pipValue
        /// </summary>
        /// <param name="pipValue">int - the # of dots on the domino</param>
        /// <returns></returns>
        public int GetDoubleDomino(int pipValue)
        {
            bool found = false;
            int location = 0;
            for (int i = 0; i < this.handOfDominos.Count; i++)
            {
                if (this.handOfDominos[i].Side1 == pipValue && this.handOfDominos[i].Side2 == pipValue)
                {
                    found = true;
                    location = i;
                    break;
                }
            }
            if (found) { return location; }
            return -1;
        }
        /// <summary>
        /// Hand - Default Constructor
        /// </summary>
        public Hand()
        {

        }
        /// <summary>
        /// Hand - Overloaded Constructor - Passes in a boneyard
        /// </summary>
        /// <param name="by">Boneyard - Pass in a Boneyard Object</param>
        /// <param name="numPlayers">Int - The number of players</param>
        public Hand(BoneYard by, int numPlayers)
        {
            // Players 2  3  4   5  6  7 8
            // Draw    16 16 15 14 12 10 9
            int drawDominos = 0;
            if      (numPlayers >= 8)   { drawDominos = 9;  }
            else if (numPlayers >= 7)   { drawDominos = 10; }
            else if (numPlayers >= 6)   { drawDominos = 12; }
            else if (numPlayers >= 5)   { drawDominos = 14; }
            else if (numPlayers >= 4)   { drawDominos = 15; }
            else if (numPlayers >= 2)   { drawDominos = 16; }
            // Loop thru and draw th cards
            for(int i=0; i< drawDominos; i++)
            {
                if (!by.IsEmpty())
                {
                    this.Draw(by);
                }
            }
        }
       
        /// <summary>
        /// HasDomino - Returns Bool - looks for domino with a pipValue
        /// </summary>
        /// <param name="pipValue">int - how many dots</param>
        /// <returns></returns>
        public bool HasDomino(int pipValue)
        {
            for(int i = 0; i < this.Count; i++)
            {
                if(this.handOfDominos[i].Side1 == pipValue || this.handOfDominos[i].Side2 == pipValue)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Play - Plays a domino on a train
        /// </summary>
        /// <param name="d">Domino </param>
        /// <param name="t">Train</param>
        public void Play(Domino d, Train t)
        {
            t.Play(d);
        }

        /// <summary>
        /// Play - Plays a domino from the hand on a train
        /// </summary>
        /// <param name="index"></param>
        /// <param name="t"></param>
        public void Play(int index, Train t)
        {
            t.Play(this.handOfDominos[index]);
        }
        
        /// <summary>
        /// RemoveAt - Deletes a domino from the hand (Not Recommended)
        /// </summary>
        /// <param name="index">int - the location in hand to delete</param>
        public void RemoveAt(int index)
        {
            this.handOfDominos.RemoveAt(index);
        }

        /// <summary>
        /// Override the ToString Method - Grab all the strings from dominos in the hand
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = null;
            for(int i = 0; i < this.Count; i++)
            {
                output += this[i].ToString();
            }
            return output;
        }
       
    }
}
