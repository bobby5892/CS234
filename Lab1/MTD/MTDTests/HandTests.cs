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
    public class HandTests
    {

        Hand hand1;
        Train train = new Train(6);

        [SetUp]
        public void SetUpAllTests()
        {
            this.hand1 = new Hand();


        }
        [Test]
        public void HandDefault()
        {
            int answer = 1 + 2;
            Assert.AreEqual(3, answer);
        }
        [Test]
        public void AddDomToHand()
        {
            // Check if the hand is empty
            Assert.AreEqual(0, hand1.Count);
            // make some dominos
            Domino d1n6 = new Domino(1, 6);
            Domino d6n3 = new Domino(6, 3);
            // Put the domino in the hand
            hand1.Add(d1n6);
            hand1.Add(d6n3);

            Assert.AreEqual(2, hand1.Count);
        }
        [Test]
        public void GrabFromBoneyard()
        {
            BoneYard by = new BoneYard();

            for (int i = 0; i < 10; i++)
            {
                hand1.Add(by.Draw());
            }

            Assert.AreEqual(hand1.Count, 10);
        }
        [Test]
        public void CheckForHighDouble()
        {
            // Check if the hand is empty
            Assert.AreEqual(0, hand1.Count);
            // make some dominos
            Domino d1n6 = new Domino(1, 6);
            Domino d6n3 = new Domino(6, 3);
            Domino d7n7 = new Domino(7, 7);
            // Put the domino in the hand
            hand1.Add(d1n6);
            hand1.Add(d6n3);
            hand1.Add(d7n7);
            Assert.AreEqual(hand1[hand1.GetDoubleDomino(7)], d7n7);
        }
        [Test]
        public void CheckIndexer()
        {
            Domino d1n6 = new Domino(1, 6);
            hand1.Add(d1n6);
            Assert.AreEqual(d1n6, this.hand1[0]);
        }
        [Test]
        public void CheckCount()
        {
            Assert.AreEqual(0, this.hand1.Count);
        }
        [Test]
        public void GetDomino()
        {
            Domino d1n6 = new Domino(1, 6);
            hand1.Add(d1n6);
            // Domino is not 
            Assert.AreEqual(d1n6, this.hand1.GetDomino(1));
            Assert.AreEqual(d1n6, this.hand1.GetDomino(6));
        }

        [Test]
        public void PlayDominoOnTrain()
        {
            Domino d1n6 = new Domino(1, 6);
            hand1.Add(d1n6);
            train.Play(hand1.GetDomino(1));
            Assert.AreEqual(train.LastDomino, hand1.GetDomino(1));
        }

    }
}
