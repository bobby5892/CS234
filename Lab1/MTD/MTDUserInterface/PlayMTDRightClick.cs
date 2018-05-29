using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTDClasses;
namespace MTDUserInterface
{
    public struct DominoOnTable
    {
        public Domino domino;
        public PictureBox picture;
    }

    public partial class PlayMTDRightClick : Form
    {

        /// <summary>
        /// Boneyard Instance
        /// </summary>
        private BoneYard pack;

        /// <summary>
        /// Hand Object - Users
        /// </summary>
        private Hand userHand;
        /// <summary>
        /// List of Dominos in the UserHand
        /// </summary>
        private List<PictureBox> userHandPBs;

        /// <summary>
        /// Private Train Users
        /// </summary>
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
        private const int NUMBEROFPLAYERS = 2;
        private const int COMPUTER = 0;
        private const int USER = 1;

        // User click handlers enabled
        private bool userClickHandlersEnabled;
        // Create the dominos for the user to be able to interact with.
        List<DominoOnTable> tableDominos = new List<DominoOnTable>();


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
            this.userClickHandlersEnabled = true;
            InitializeComponent();
            this.SetUp();
            
        }
        private void SetUp()
        {
            // BoneYard
            this.pack = new BoneYard(9); // The TileSets in the current UI only go up to 9

            //user Hand
            this.userHand = new Hand(this.pack, NUMBEROFPLAYERS); // 2 players
            this.computerHand = new Hand(this.pack, NUMBEROFPLAYERS);

            //Pictures
            this.userHandPBs = new List<PictureBox>();
            this.mexicanTrainPBs = new List<PictureBox>();
            this.userTrainPBs = new List<PictureBox>();
            this.computerTrainPBs = new List<PictureBox>();

            // Trains
            this.userTrain = new PrivateTrain();
            this.computerTrain = new PrivateTrain();
            this.mexicanTrain = new Train();
            

            // Draw the initial PictureBoxes
            this.fillPictureBoxes();


            // Create the Draggable Player Hand
            this.buildDraggable();
            this.drawDraggable();

            // Figure out who has the highest double
            this.playHighestDouble();
            // Play that in the corner

            // Test from ME PC
            whosTurn = 1;
        }
        /// <summary>
        /// Private - Play the highest double
        /// </summary>
        private void playHighestDouble()
        {
            Domino highest = null;
            int foundHighestIn = 0; // 0 - noboy , 1 computer, 2, player
            
            // Determine highest
            for(int i=0; i < computerHand.Count; i++)
            {
                if (computerHand[i].IsDouble())
                {
                    if ((highest == null) || (highest.Score < computerHand[i].Score))
                    {
                        highest = computerHand[i];
                        foundHighestIn = 1;
                    }
                }

            }
            // Look in the uer hand
            for(int i=0; i < tableDominos.Count; i++)
            {
                if (tableDominos[i].domino.IsDouble()){
                    if ((highest == null) || (highest.Score < tableDominos[i].domino.Score))
                    {
                        highest = tableDominos[i].domino;
                        foundHighestIn = 2;
                    }
                }
            }
            // Found in computer
            if (foundHighestIn == 1)
            {
                int toRemove = computerHand.IndexOfDomino(highest.Side1);
                Domino dom = computerHand.GetDomino(highest.Side1);
                computerHand.RemoveAt(toRemove);
                // Computer goes first
                this.whosTurn = 0;
            }
            // Found in player
            else if (foundHighestIn == 2)
            {

                for (int i = 0; i < tableDominos.Count; i++) {
                    if (tableDominos[i].domino == highest)
                    {
                        Domino dom = tableDominos[i].domino;
                        tableDominos.RemoveAt(i);
                        // Player goes first
                        this.whosTurn = 1;
                        break;
                    }
                }
                
            }
            else
            {
                throw new System.ArgumentException("Not implemented - should redo teardown / setup - but this is academic...");
            }

            // Now that highest domino has been found and removed from either a player or computer - lets put it where it goes and set the trains
            enginePB.ImageLocation = "Images/" + highest.Filename;
            // Now lets set the trains up
            this.userTrain.EngineValue = highest.Side1;
            this.computerTrain.EngineValue = highest.Side1;
            this.mexicanTrain.EngineValue = highest.Side1;
        }
        /// <summary>
        /// This is for the player hand and will allow the dominos to be moved around. It uses the domios that are tied to a picture box.
        /// 
        /// </summary>
        private void buildDraggable()
        {
            int startingX = 10;
            int startingY = 375;
            int columns = 5;
            int columnWidth = 70;
            // Lets Populate Our List
            for(int i=0; i < this.userHand.Count; i++)
            {
                DominoOnTable tableDom = new DominoOnTable();
                tableDom.domino = this.userHand[i];
                tableDom.picture = this.userHandPBs[i];

                // Now Lets give the picturebox render dimensions
              
                tableDom.picture.BorderStyle = System.Windows.Forms.BorderStyle.None;
                tableDom.picture.Location = new System.Drawing.Point(startingX, startingY);
                
                tableDom.picture.Name = tableDom.domino.ToString();
                tableDom.picture.Size = new System.Drawing.Size(65, 45);
                tableDom.picture.Visible = true;
                tableDom.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                tableDom.picture.Anchor = AnchorStyles.None;
                tableDom.picture.BackColor = Color.Transparent;
                tableDom.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.handPB_MouseDown);
                

                // Add it to form
                this.Controls.Add(tableDom.picture);
                
                startingX += columnWidth;

                // If the number of tiles is more than the # of columns then go down a row
                if(startingX >= columns* columnWidth)
                {
                    startingX = 10;
                    startingY += 50;
                }
                // List of Dominos on the TAble for hand
                this.tableDominos.Add(tableDom);
            }
          
        }
        public void drawDraggable()
        {

        }
        // removes all of the mouse down event handlers from the picture boxes in the users hand pb list
        private void DisableUserHandPBs()
        {
          
          //  tableDom.picture.Click += new System.EventHandler(this.passButton_Click);
        }

        // enable the hand pbs, buttons and update labels on the UI
        public void EnableUserMove()
        {

        }
        private void TearDown()
        {
            // Remove all Dominos from the board
            //  CAnt just clear this - have to iterate and remove from board the PB's in it. 
            for(int i = 0; i < this.tableDominos.Count; i++)
            {
                this.Controls.Remove(tableDominos[i].picture);
            }
            this.tableDominos.Clear();
            // Dont have to worry - setup will reinstatiate this.userHand
            // Same with computerHand

            this.clearPictureBoxList(this.userHandPBs);
            this.userHandPBs.Clear();

            this.clearPictureBoxList(this.mexicanTrainPBs);
            this.mexicanTrainPBs.Clear();

            this.clearPictureBoxList(this.userTrainPBs);
            this.userTrainPBs.Clear();

            this.clearPictureBoxList(this.computerTrainPBs);
            this.computerTrainPBs.Clear();

            this.enginePB.ImageLocation = null;
            // trains get wiped - no biggy
            this.disposeTableDoms();

            indexOfDominoInPlay = -1;
            whosTurn = -1;
            nextDrawIndex = 15;
        }
        private void disposeTableDoms()
        {
            for(int i=0; i < tableDominos.Count; i++)
            {
                tableDominos[i].picture.Dispose();
            }
        }
        private void clearPictureBoxList(List<PictureBox> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i].ImageLocation = null;
            }
        }
        
        #region event handlers



        // when the user left clicks on a domino, a context sensitive menu appears that
        // let's the user know which train is playable.  Green means playable.  Red means not playable.
        // the event handler for the menu item is enabled and disabled appropriately.

        private void whichTrainMenu_Opening(object sender, CancelEventArgs e)
        {
            
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
                
               if (computerTrain.IsPlayable(userDominoInPlay, out mustFlip))
                {
                    computerTrainItem.ForeColor = Color.Green;
                    computerTrainItem.Click += new System.EventHandler(this.computerTrainItem_Click);
                }
                else
                {
                    computerTrainItem.ForeColor = Color.Red;
                }
                if (userTrain.IsPlayable(userDominoInPlay, out mustFlip))
                {
                    myTrainItem.ForeColor = Color.Green;
                    myTrainItem.Click += new System.EventHandler(this.myTrainItem_Click);
                }
                else
                {
                    myTrainItem.ForeColor = Color.Red;
                }
               
                

            }
           
        }

        // displays the context sensitve menu with the list of trains
        // sets the instance variables indexOfDominoInPlay and userDominoInPlay
        private void handPB_MouseDown(object sender, MouseEventArgs e)
        {
           
            PictureBox handPB = (PictureBox)sender;
            
            for(int i = 0; i < tableDominos.Count; i++)
            {
                if(handPB == tableDominos[i].picture)
                {
                    indexOfDominoInPlay = i;
                    break;
                }
            }
            
            if (indexOfDominoInPlay != -1)
            {
                userDominoInPlay = tableDominos[indexOfDominoInPlay].domino;
                PictureBox pb = tableDominos[indexOfDominoInPlay].picture;
                if (e.Button == MouseButtons.Right)
                {
                    whichTrainMenu.Show(pb, 
                        pb.Size.Width - 20, pb.Size.Height - 20);
                }
            }
           
        }

        // play on the mexican train, lets the computer take a move and then enables
        // hand pbs so the user can make the next move.
        // userDominoInPlay contains the domino that was clicked
        private void mexicanTrainItem_Click(object sender, EventArgs e)
        {
            
            Domino d = tableDominos[indexOfDominoInPlay].domino;
            tableDominos[indexOfDominoInPlay].picture.Visible = false;
            tableDominos.RemoveAt(indexOfDominoInPlay);
            mexicanTrain.Play(d);
            redraw();
        }

        // play on the computer train, lets the computer take a move and then enables
        // hand pbs so the user can make the next move.
        private void computerTrainItem_Click(object sender, EventArgs e)
        {
            Domino d = tableDominos[indexOfDominoInPlay].domino;
            tableDominos[indexOfDominoInPlay].picture.Visible = false;
            tableDominos.RemoveAt(indexOfDominoInPlay);
            computerTrain.Play(d);
            redraw();
        }

        // play on the user train, lets the computer take a move and then enables
        // hand pbs so the user can make the next move.
        private void myTrainItem_Click(object sender, EventArgs e)
        {
            Domino d = tableDominos[indexOfDominoInPlay].domino;
            tableDominos[indexOfDominoInPlay].picture.Visible = false;
            tableDominos.RemoveAt(indexOfDominoInPlay);
            userTrain.Play(d);
            redraw();
        }

        // tear down and then set up
        private void newHandButton_Click(object sender, EventArgs e)
        {
            TearDown();
            SetUp();
        }

        // draw a domino, add it to the hand, create a new pb and enable the new pb
        private void drawButton_Click(object sender, EventArgs e)
        {
            bool hasPlayableDomino = false;
            if(this.whosTurn == 1)
            {
                string playWhere = "";
                // Check to see if player can play
                for(int i = 0; i < this.tableDominos.Count; i++)
                {
                    if(this.mexicanTrain.IsPlayable(this.tableDominos[i].domino, out bool flip)){
                        hasPlayableDomino = true;
                        playWhere = " Mexican Train";
                    }
                    if (this.computerTrain.IsPlayable(this.tableDominos[i].domino, out bool flip2))
                    {
                        hasPlayableDomino = true;
                        playWhere = " Computer Train";
                    }
                    if (this.userTrain.IsPlayable(this.tableDominos[i].domino, out bool flip3))
                    {
                        hasPlayableDomino = true;
                        playWhere = " Your Train";
                    }
                }

                if (hasPlayableDomino)
                {
                    MessageBox.Show("You can't draw, you have a playable domino on the " + playWhere);
                }
                else
                {
                    // Draw a tile

                }
            }
        }

        // open the user's train, update the ui and let the computer make a move
        // enable the hand pbs so the user can make a move
        private void passButton_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private void redraw()
        {
            // Clear all PB's
            this.clearPictureBoxList(this.userHandPBs);
            this.mexicanTrainPBs.Clear();
            this.userTrainPBs.Clear();
            this.computerTrainPBs.Clear();
            this.disposeTableDoms();
            this.fillPictureBoxes();
            // Create the Draggable Player Hand
            this.buildDraggable();
            this.drawDraggable();
        }
        private void PlayMTDRightClick_Load(object sender, EventArgs e)
        {

        }
        private void fillPictureBoxes()
        {
            // Build List of Picture Box for Hand
            this.fillPictureBoxFromHand(this.userHand, this.userHandPBs);
            // Build List of Picture Box for Trains
            this.fillPictureBoxFromTrain(this.userTrain,ref this.userTrainPBs);
            this.fillPictureBoxFromTrain(this.computerTrain,ref this.computerTrainPBs);
            this.fillPictureBoxFromTrain(this.mexicanTrain,ref this.mexicanTrainPBs);

            // Now lets grab the last 5 from each for the trains
            this.showLastFive(ref this.mexicanTrainPBs,ref mexTrainPB1,ref mexTrainPB2,ref mexTrainPB3,ref mexTrainPB4,ref mexTrainPB5);
            this.showLastFive(ref this.computerTrainPBs, ref compTrainPB1, ref compTrainPB2,ref  compTrainPB3, ref compTrainPB4,ref compTrainPB5);
            this.showLastFive(ref this.mexicanTrainPBs,ref mexTrainPB1,ref mexTrainPB2,ref mexTrainPB3, ref mexTrainPB4,ref mexTrainPB5);

        }
        private void showLastFive(ref List<PictureBox> boxes,ref PictureBox pb1,ref PictureBox pb2, ref PictureBox pb3,ref PictureBox pb4,
           ref PictureBox pb5)
        {
            // The order of this may need ADJUSTEd
           if(boxes.Count >= 5) { pb5 = boxes[boxes.Count - 5]; }
           if(boxes.Count >= 4) { pb4 = boxes[boxes.Count - 4]; }
           if(boxes.Count >= 3) { pb3 = boxes[boxes.Count - 3]; }
           if (boxes.Count >= 2) { pb2 = boxes[boxes.Count - 2]; }
           if (boxes.Count >= 1) { pb1 = boxes[boxes.Count - 1]; }
        }
        private void fillPictureBoxFromHand(Hand hand, List<PictureBox> box)
        {
            // empty the list
            box.Clear();
            // Add the dominos from hand
            for (int i =0; i < hand.Count; i++)
            {
                // Create the domino
                PictureBox newPic = new PictureBox();
                
                newPic.Name = "pic" + i;
               
                // newPic.ImageLocation = "dominos/d" + hand[i].Side1 + hand[i].Side2 + ".png";
                newPic.ImageLocation = "Images/" + hand[i].Filename;
                this.Controls.Add(newPic);

                // add it to the list
                box.Add(newPic);
                
            }
        }
        private void fillPictureBoxFromTrain(Train train,ref List<PictureBox> box)
        {
            // empty the list
            box.Clear();
            // Add the dominos from train
            for (int i = 0; i < train.Count; i++)
            {
                // Create the domino
                PictureBox newPic = new PictureBox();
                newPic.ImageLocation = "Images/" + train[i].Filename;

                // add it to the list
                box.Add(newPic);

            }
        }

  
    }
}

