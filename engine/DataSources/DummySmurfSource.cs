namespace Engine.DataSources
{
	using Engine.Models.Data;
	using Interfaces;
	using System;
	using System.Collections.Generic;
	using System.Text;

	class DummySmurfSource : ISmurfSource
	{
		public IEnumerable<SmurfDM> GetSmurfs()
		{
			List<SmurfDM> items = new List<SmurfDM>()
			{
				CreateSmurf("Papa Smurf", "/Resources/Images/papa.png"),
				CreateSmurf("Smurfette", "/Resources/Images/smurfette.png"),
				CreateSmurf("Brainy", "/Resources/Images/brainy.png"),
				CreateSmurf("Hefty", "/Resources/Images/hefty.png"),
				CreateSmurf("Baker", "/Resources/Images/baker.png"),
				CreateSmurf("Vanity", "/Resources/Images/vanity.png"),
				CreateSmurf("Handy", "/Resources/Images/handy.png"),

				CreateSmurf("Jokey", "/Resources/Images/jokey.png"),
				CreateSmurf("Grouchy", "/Resources/Images/grouchy.png"),
				CreateSmurf("Clumsy", "/Resources/Images/clumsy.png"),

				CreateSmurf("Greedy", "/Resources/Images/greedy.png"),
				CreateSmurf("Tracker", "/Resources/Images/tracker.png")

			};
			return items;
		}

		private static SmurfDM CreateSmurf(string name, string image)
		{
			return new SmurfDM() { Name = name, Image = image };
		}
	}
}
