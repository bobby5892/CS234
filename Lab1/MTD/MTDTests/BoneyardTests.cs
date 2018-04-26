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
    public class BoneyardTests
    {

        BoneYard boneyard;
        BoneYard boneyardOveridden;

        [SetUp]
        public void SetUpAllTests(){
            this.boneyard = new BoneYard();
            this.boneyardOveridden = new BoneYard(8); // To Test with 8 Max Dots
              
        }
        [Test]
        public void BoneyardTestDefault(){
            int answer = 1 + 2;
            Assert.AreEqual(3, answer);
        }
        [Test]
        public void BoneyardOverLoadedConstructor(){
            // For up to 8
            // Multi Tiles 1+2+3+4+5+6+7+8 = 36
            // Doubles 8 = 8
            // Total = 44
            Assert.AreEqual(44, this.boneyardOveridden.DominosRemaining );
        }
        [Test]
        public void BoneyardTestDrawAndShuffle(){
               // Note - in future this will be more seprated to seperate tests.
            // Make a copy of the boneyard
            BoneYard beforeShuffle = boneyardOveridden;
            int beforeShuffleCount = boneyardOveridden.DominosRemaining;
            //shuffle it
            boneyardOveridden.Shuffle();

            Assert.AreEqual(beforeShuffleCount, boneyardOveridden.DominosRemaining);

            // Test is empty + draw + is empty
            int max = this.boneyardOveridden.DominosRemaining;
            for (int i = 0; i < max; i++){
                Assert.AreEqual(false, boneyardOveridden.IsEmpty());
                Domino drawn = boneyardOveridden.Draw();
            }
            Assert.AreEqual(0, boneyardOveridden.DominosRemaining);
            Assert.AreEqual(true, boneyardOveridden.IsEmpty());
        }
    }
 }
