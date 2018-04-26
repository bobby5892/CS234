using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MTDClasses;

namespace MTDTests
{
    [TestFixture]
    public class TrainTests
    {

     
        public Train train,trainWithEngine;
        public Domino d1n1, d3n6, d6n3;
        

        [SetUp]
        public void SetUpAllTests()
        {
           
            // Default
            this.train = new Train();
            this.trainWithEngine = new Train(6);
            // Some Dominos
            this.d1n1 = new Domino(1, 1);
            this.d3n6 = new Domino(3, 6);
            this.d6n3 = new Domino(6, 3);

          

        }
        [Test]
        public void TrainTestsDefault()
        {
            int answer = 1 + 2;
            Assert.AreEqual(3, answer);
        }
        [Test]
        public void EngineSets()
        {
            // Setting and Getting Engine Value
           
            this.train.EngineValue = 5;
            Assert.AreEqual(5, this.train.EngineValue);
        }
        [Test]
        public void IsEmpty()
        {
            Assert.AreEqual(true, this.trainWithEngine.IsEmpty);
        }
        [Test]
        public void Count()
        {
            Assert.AreEqual(0, this.train.Count);
        }
        [Test]
        public void PlayingOnTrain()
        {
            //Set the train
            this.trainWithEngine.EngineValue = 6;
            // Play a 6 that needs flipped
            this.trainWithEngine.Play(this.d3n6);
            // Assuming Tile was played and flipped
            Assert.AreEqual(3, this.trainWithEngine.PlayableValue);
            // Train isn't empty
            Assert.AreEqual(false, this.trainWithEngine.IsEmpty);
            // Now play again
            this.trainWithEngine.Play(this.d3n6);
            // now its opposite
            Assert.AreEqual(6, this.trainWithEngine.PlayableValue);

            // Check the Count
            Assert.AreEqual(2, this.trainWithEngine.Count);

            // Check Last Domino
            Assert.AreEqual(3, this.trainWithEngine.LastDomino.Side1);
            // Check Indexer
            Assert.AreEqual(3, this.trainWithEngine[1].Side1);

        }
        [Test]
        public void ExceptionIllegalPlay()
        {
            
            this.d1n1 = new Domino(1, 1);
            Assert.Throws<ArgumentException>(delegate { this.trainWithEngine.Play(d1n1); });
        }
    }
}
