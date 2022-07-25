using System;
using System.ComponentModel;
using System.Windows.Controls;
using BowlingChallenge.Model;

namespace BowlingChallenge.View
{
	/// <summary>
	/// Interaction logic for ScoreBox.xaml
	/// </summary>
	public partial class ScoreBox : UserControl, INotifyPropertyChanged
	{
		public ScoreBox()
		{
			InitializeComponent();
			this.DataContext = this;
		}

		private int firstScore = 0;
		private string firstString = "";
		private int secondScore = 0;
		private string secondString = "";
		private int thirdScore = 0;
		private string thirdString = "";
		private int totalScore = 0;
		public bool firstPass { get; set; } //Used to show whether this box has been activated before.

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public string FirstScore 
		{
			get { return firstString; } 
			set 
			{
				ProcessInput(value, 1);
				OnPropertyChanged("FirstScore");
			} 
		}
		public string SecondScore 
		{
			get { return secondScore.ToString(); }
			set
			{
				ProcessInput(value, 2);
				OnPropertyChanged("SecondScore");
			}
		}
		public string ThirdScore 
		{
			get { return thirdScore.ToString(); }
			set
			{
				ProcessInput(value, 3);
				OnPropertyChanged("ThirdScore");
			}
		}
		public string TotalScore {
			get { return totalScore.ToString(); }
			set
			{
				bool isValid = int.TryParse(value, out int score);
				if(isValid)
					totalScore = score;
				else
					totalScore = firstScore + secondScore + thirdScore;
				OnPropertyChanged("TotalScore");
			}
		}

		public void ProcessInput(string input, int turn)
		{
			bool isGood = int.TryParse(input, out int scoreNum);
			if (isGood) //If the input is an int
			{
				if (turn == 1) 
				{
					if (scoreNum < 10 && scoreNum >= 0)
					{
						firstScore = scoreNum;
						firstString = input;
					}
					else if (scoreNum >= 10) //If score is 10 or greater, return 10 which is max
					{ 
						firstScore = 10;
						firstString = "X";
					}
					else
					{
						firstScore = 0;
						firstString = firstScore.ToString();
					}
				}
				else if(turn == 2)
				{
					if (scoreNum < 10 && scoreNum >= 0)
					{
						secondScore = scoreNum;
						secondString = secondScore.ToString();
					}
				}
				else if(turn == 3)
				{
					if (scoreNum < 10 && scoreNum >= 0)
					{
						thirdScore = scoreNum;
						thirdString = thirdScore.ToString();
					}
					else if (scoreNum >= 10) //If score is 10 or greater, return 10 which is max
					{
						thirdScore = 10;
						thirdString = "X";
					}
					else
					{
						thirdScore = 0;
						thirdString = thirdScore.ToString();
					}
				}
			}
			else if (input.Contains("x") || input.Contains("X") || input.Contains("/")) //Check if input is a symbol
			{
				if (turn == 1)
				{
					firstScore = 10;
					firstString = "X";
				}
				else if (turn == 2)
				{
					secondScore = (10 - firstScore);
					secondString = "/";
				}
				else if (turn == 3 && input.Contains("/"))
				{
					thirdScore = (10 - secondScore);
					thirdString = "/";
				}
				else if (turn == 3 && (input.Contains("x") || input.Contains("X")))
				{
					thirdScore = 10;
					thirdString = "X";
				}
			}
			totalScore = firstScore + secondScore + thirdScore;
			TotalScore = totalScore.ToString();
		}

		
	}
}
