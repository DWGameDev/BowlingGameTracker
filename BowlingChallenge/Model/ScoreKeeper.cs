using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingChallenge.View;

namespace BowlingChallenge.Model
{
	public enum GameState
	{
		First,
		Second,
		Strike,
		Spare,
		End,
	}

	internal class ScoreKeeper 
	{
		public ScoreKeeper() { }
		public GameState keeperState { get; set; } = GameState.First; //The local state
		private static int maxScore = 300;
		private int calcMaxScore = 300;
		private int totalGameScore = 0;
		public int MaxPossible
		{
			get { return calcMaxScore; }
			set { calcMaxScore = maxScore - totalGameScore; }
		}

		public DataHolder MainMethod(ScoreBox box, string input)
		{
			DataHolder myInfo = new DataHolder();
			myInfo.Heiros = input;
			myInfo.Number = ConvertText(input);
			string output = input; //If nothing else, it should return what was sent in
			if (keeperState == GameState.First) //Check if this is the first time this obj has been ran
			{
				//Setup obj for first pass
				box.firstPass = false;
				keeperState = GameState.First;
				box.TotalScore = myInfo.Number.ToString(); //Set local score for total calc

				if (myInfo.Number == 10)//Check if strike
				{
					if (keeperState == GameState.Strike)
					{

					}
				}
			}
			else //If not first time, perform as second or third input
			{
				//Check if second or third shot

				box.TotalScore += myInfo.Number.ToString(); //Add to local score for total calc
			}
			return myInfo;
		}


		public void IsStrike(ScoreBox frame)
		{

		}

		//private bool IsSpare(BoxVM frame)
		//{
		//	return frame.FirstRollScore + frame.SecondRollScore == strikeValue;
		//}

		//private void EnteredScore(object sender, EventArgs e)
		//{
		//	//new ScoreKeeper().ScoreGame();
		//}



		public int ConvertText(string input)
		{
			bool isGood = int.TryParse(input, out int scoreNum);
			if (isGood)
			{
				if (scoreNum < 10 && scoreNum >= 0)
					return scoreNum;

				if (scoreNum >= 10) //If score is 10 or greater, return 10 which is max
				{
					keeperState = GameState.Strike;
					return 10;
				}
			}
			else if (input.Contains("x") || input.Contains("X")) //Check if strike
			{
				keeperState = GameState.Strike;
				return 10; //Return 11 as code for strike
			}
			else if (input.Contains("/")) //check if spare
			{
				keeperState = GameState.Spare;
				return 10; //Return -1 as code for spare
			}
			return 0;
		}

	}
	public class DataHolder
	{
		public int Number { get; set; }
		public string Heiros { get; set; }

	}
}
