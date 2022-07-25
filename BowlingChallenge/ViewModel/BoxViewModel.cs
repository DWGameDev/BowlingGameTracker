using BowlingChallenge.View;
using BowlingChallenge.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingChallenge.ViewModel
{
	internal class BoxViewModel
	{
		public BoxViewModel()
		{
            boxes = new ScoreBox[10];

		}

        #region Frames
        private ScoreBox[] boxes;
        public ScoreBox FrameOne => boxes[0];
        public ScoreBox FrameTwo => boxes[1];
        public ScoreBox FrameThree => boxes[2];
        public ScoreBox FrameFour => boxes[3];
        public ScoreBox FrameFive => boxes[4];
        public ScoreBox FrameSix => boxes[5];
        public ScoreBox FrameSeven => boxes[6];
        public ScoreBox FrameEight => boxes[7];
        public ScoreBox FrameNine => boxes[8];
        public ScoreBox FrameTen => boxes[9];
        #endregion

        private void BowlingFrame_RollScoreEntered(object sender, EventArgs e)
        {
           // new ScoreKeeper().ScoreGame(_frames);
        }
    }
}
