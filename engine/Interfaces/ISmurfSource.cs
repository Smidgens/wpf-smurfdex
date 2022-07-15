

namespace Engine.Interfaces
{
	using Models.Data;
	using System.Collections.Generic;

	interface ISmurfSource
	{
		IEnumerable<SmurfDM> GetSmurfs();
	}
}
