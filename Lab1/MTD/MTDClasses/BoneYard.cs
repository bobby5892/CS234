using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDClasses
{
    /// <summary>
    /// Bonyard Class - This has a list of dominos that will act as the draw pile of dominos and all methods 
    /// related to that.
    /// </summary>
    public class BoneYard
    {
        // Domino List
        private List<Domino> listOfDominos = new List<Domino>();

        // How many dominos are remaning in the List
        public int DominosRemaining {
            get {
                return this.listOfDominos.Count();
            }
        }

        // Override the Index allow to change positions within stack
        /* Assuming
         * Outside this use
         * Boneyard boneyard = new Boneyard;
         * boneyard[5] -- would pull the position 5 in List<Domino>
         */
        public Domino this[int index] {
            get{
                // Domino from the list
                return this.listOfDominos[index];
            }
            set{
                // Set Domino into the list
                listOfDominos[index] = value;
            }
        }
        // Default Constructor
        //
        public BoneYard() {
            // This needs to fil the List and update the Dominos Remaining
            // 0-12
            this.generateBoneyard(12);

        }
        public BoneYard(int maxDots){
            // This needs to fil the List and update the Dominos Remaining
            this.generateBoneyard(maxDots);
        }
        private void generateBoneyard(int maxDots){
            // For each set
            int i = 0;
            do
            {
                Domino d = new Domino(i, i);
                this.listOfDominos.Add(d); // Takes care of Double
                int j = i;
                do
                {
                    Domino d2 = new Domino(i, j);
                    this.listOfDominos.Add(d2); // Takes care of Adding paired dominos
                                                // the off tiles j until maxDots - but only when J is above I - to avoid dupes and
                                                // doubles 
                    j++;
                } while ((j < maxDots) && (j > i));
                i++;
            } while (i < maxDots);
        }
        public Domino Draw(){
            Domino drawTile = this.listOfDominos[0];
            // Remove it From Stack - Assuming Stack shifts
            this.listOfDominos.RemoveAt(0);
           
            return drawTile;
        }
        
        public bool IsEmpty(){
            // Check if Stack is Empty
            if(this.listOfDominos.Count == 0){
                return true;
            }
            return false;
        }
        // Shuffle Number Generator - fisher yates
        private static Random rng = new Random();

        public void Shuffle(){
            // Fisher Yates Shuffle - https://stackoverflow.com/questions/273313/randomize-a-listt
            int n = this.listOfDominos.Count;
           // Big O(n)
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Domino value = this.listOfDominos[k];
                this.listOfDominos[k] = this.listOfDominos[n];
                this.listOfDominos[n] = value;
            }
        }
        public override string ToString(){
            string output = null;
            foreach (Domino tile in listOfDominos){
                 output +=  tile.ToString();
            }
            return output;
        }
    }
}
