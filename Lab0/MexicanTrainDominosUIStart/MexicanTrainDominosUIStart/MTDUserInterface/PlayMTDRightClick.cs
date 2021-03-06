﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTDUserInterface
{
    public partial class PlayMTDRightClick : Form
    {

        /*
        private BoneYard pack;

        private Hand userHand;
        private List<PictureBox> userHandPBs;
        private PrivateTrain userTrain;
        private List<PictureBox> userTrainPBs;

        private Hand computerHand;
        private PrivateTrain computerTrain;
        private List<PictureBox> computerTrainPBs;

        private Train mexicanTrain;
        private List<PictureBox> mexicanTrainPBs;

        private Domino userDominoInPlay;
        private int indexOfDominoInPlay = -1;

        private int nextDrawIndex = 15;

        private int whosTurn = -1;
        private const int COMPUTER = 0;
        private const int USER = 1;
        */

        #region Methods
        
        /*
        // loads the image of a domino into a picture box
        // verify that the path for the domino files is correct
        private void LoadDomino(PictureBox pb, Domino d)
        {
            pb.Image = Image.FromFile(System.Environment.CurrentDirectory
                        + "\\..\\..\\Dominos\\" + d.Filename);
        }

        // loads all of the dominos in a hand into a list of pictureboxes
        private void LoadHand(List<PictureBox> pbs, Hand h)
        {

        }

        // dynamically creates the "next" picture box for the user's hand
        // the instance variable nextDrawIndex should be passed as a parameter
        // if you change the layout of the form, you'll have to change the math here
        private PictureBox CreateUserHandPB(int index)
        {
            PictureBox pb = new PictureBox();
            pb.Visible = true;
            pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pb.Location = new System.Drawing.Point(24 + (index % 5) * 110, 366 + (index / 5) * 60);
            pb.Size = new System.Drawing.Size(100, 50);
            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Controls.Add(pb);
            return pb;
        }

        // adds the mouse down event handler to a picture box
        private void EnableHandPB(PictureBox pb)
        {
            pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.handPB_MouseDown);
        }

        // adds the mouse down event handler to all of the picture boxes in the users hand pb list
        private void EnableUserHandPBs()
        {

        }

        // removes the mouse down event handler from a picture box
        private void DisableHandPB(PictureBox pb)
        {
            pb.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.handPB_MouseDown);
        }

        // removes all of the mouse down event handlers from the picture boxes in the users hand pb list
        private void DisableUserHandPBs()
        {

        }

        // unloads the domino image from a picture box in a train
        public void RemoveDominoFromTrainPB(int index, List<PictureBox> trainPBs)
        {
            PictureBox trainPB = trainPBs[index];
            trainPB.Image = null;
        }
        
        // unloads the domino image and removes a picture box from a hand
        public void RemoveDominoFromHandPB(int index)
        {
            PictureBox handPB = userHandPBs[index];
            handPB.Image = null;
            handPB.Visible = false;
            userHandPBs.RemoveAt(index);
            this.Controls.Remove(handPB);
            handPB = null;
        }

        // determines the index of the picture box into which a domino should be played
        // in a list of pictureboxes.  Calls ScrollTrain to Scroll the dominos 
        // one picture box to the left if necessary
        public int NextTrainPBIndex(Train train, List<PictureBox> trainPBs)
        {

        }

        // scrolls the dominos one picture box to the left if all of the pbx
        // for a train are filled.  Assumes 5 picture boxes per train
        public void ScrollTrain(Train train, List<PictureBox> trainPBs)
        {

        }

        // plays a domino on a train.  Loads the appropriate train pb, 
        // removes the domino pb from the hand, updates the train status label ,
        // disables the hand pbs and disables appropriate buttons
        public void UserPlayOnTrain(Domino d, Train train, List<PictureBox> trainPBs)
        {

        }

        // adds a domino picture to a train
        public void ComputerPlayOnTrain(Domino d, Train train, List<PictureBox> trainPBs, int pbIndex)
        {

        }

        // ai for computer move.
        // calls play for on the computer's hand for each train, gets the next pb index and 
        // plays the domino on the train.  
        // BECAUSE play throws an exception, tries to first play on one train and
        // in the catch block tries the next and so on
        // when the computer can not play on any train, the computer draws and returns false.
        // if the method is called with canDraw = false, this last step is omitted and the method
        // returns false
        public bool MakeComputerMove(bool canDraw)
        {

        }

        // update labels on the UI and disable the users hand
        // call MakeComputerMove (maybe twice)
        // update the labels on the UI
        // determine if the computer won or if it's now the user's turn
        public void CompleteComputerMove()
        {

        }

        // enable the hand pbs, buttons and update labels on the UI
        public void EnableUserMove()
        {

        }

        // instantiate boneyard and hands
        // find the highest double in each hand
        // determine who should go first, remove the highest double from the appropriate hand
        // and display the highest double in the UI
        // instantiate trains now that you know the engine value
        // create all of the picture boxes for the user's hand and load the dominos for the hand
        // Add the picture boxes for each train to the appropriate list of picture boxes
        // update the labels on the UI
        // if it's the computer's turn, let her play
        // if it's the user's turn, enable the pbs so she can play
        public void SetUp()
        {

        }

        // remove all of the domino pictures for each train
        // remove all of the domino pictures for the user's hand
        // reset the nextDrawIndex to 15
        public void TearDown()
        {

        }
        */
        #endregion

        public PlayMTDRightClick()
        {
            InitializeComponent();
            //SetUp();
        }

        #region event handlers

       
        // when the user right clicks on a domino, a context sensitive menu appears that
        // let's the user know which train is playable.  Green means playable.  Red means not playable.
        // the event handler for the menu item is enabled and disabled appropriately.
        private void whichTrainMenu_Opening(object sender, CancelEventArgs e)
        {
            /*
            bool mustFlip = false;
            if (userDominoInPlay != null)
            {
                mexicanTrainItem.Click -= new System.EventHandler(this.mexicanTrainItem_Click);
                computerTrainItem.Click -= new System.EventHandler(this.computerTrainItem_Click);
                myTrainItem.Click -= new System.EventHandler(this.myTrainItem_Click);

                if (mexicanTrain.IsPlayable(userDominoInPlay, out mustFlip))
                {
                    mexicanTrainItem.ForeColor = Color.Green;
                    mexicanTrainItem.Click += new System.EventHandler(this.mexicanTrainItem_Click);
                }
                else
                {
                    mexicanTrainItem.ForeColor = Color.Red;
                } 
                // check other trains too

            }
            */
        }

        // displays the context sensitve menu with the list of trains
        // sets the instance variables indexOfDominoInPlay and userDominoInPlay
        private void handPB_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            PictureBox handPB = (PictureBox)sender;
            indexOfDominoInPlay = userHandPBs.IndexOf(handPB);
            if (indexOfDominoInPlay != -1)
            {
                userDominoInPlay = userHand[indexOfDominoInPlay];
                if (e.Button == MouseButtons.Right)
                {
                    whichTrainMenu.Show(handPB, 
                        handPB.Size.Width - 20, handPB.Size.Height - 20);
                }
            }
            */
        }

        // play on the mexican train, lets the computer take a move and then enables
        // hand pbs so the user can make the next move.
        // userDominoInPlay contains the domino that was clicked
        private void mexicanTrainItem_Click(object sender, EventArgs e)
        {

        }

        // play on the computer train, lets the computer take a move and then enables
        // hand pbs so the user can make the next move.
        private void computerTrainItem_Click(object sender, EventArgs e)
        {

        }

        // play on the user train, lets the computer take a move and then enables
        // hand pbs so the user can make the next move.
        private void myTrainItem_Click(object sender, EventArgs e)
        {

        }

        // tear down and then set up
        private void newHandButton_Click(object sender, EventArgs e)
        {
            //TearDown();
            //SetUp();
        }

        // draw a domino, add it to the hand, create a new pb and enable the new pb
        private void drawButton_Click(object sender, EventArgs e)
        {

        }

        // open the user's train, update the ui and let the computer make a move
        // enable the hand pbs so the user can make a move
        private void passButton_Click(object sender, EventArgs e)
        {

        }
        
        #endregion
    }
}
