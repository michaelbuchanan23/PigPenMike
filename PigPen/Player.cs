using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigPen {
	class Player {
		public int PlayerNumber { get; set; }
		public int PlayerScore { get; set; }

		public Player(int PlayerNumber, int PlayerScore) {
			this.PlayerNumber = PlayerNumber;
			this.PlayerScore = PlayerScore;
		}

		public Player() { }
	}
}
