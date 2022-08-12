using System;

namespace Hurricane {
	public class Program {
		public static void Main( string[] args ) {
			// Keep the following lines intact 
			Console.WriteLine( "===========================" );

			const string PROMPT = "Please enter the wind speed (km/h):";
			const string OUT_FORMAT = "If the wind speed is {0} then {1}.";

			Console.WriteLine( PROMPT );
			string userInput = Console.ReadLine();
			int windSpeed = int.Parse( userInput );

			string message = "";

			//if (windSpeed >= 119 && windSpeed <= 153) { message = "very dangerous winds will produce some damage"; }
			//if (windSpeed >= 178 && windSpeed <= 208) { message = "devastating damage will occur"; }
			//if (windSpeed >= 209 && windSpeed <= 251) { message = "catastrophic damage will occur"; }
			//if (windSpeed >= 154 && windSpeed <= 177) { message = "extremely dangerous winds cause extensive damage"; }
			//if (windSpeed >= 252 && windSpeed <= int.MaxValue) { message = "cataclysmic damage will occur"; }
			//if (windSpeed >= 0 && windSpeed <= 118) { message = "the damage from winds is minimal"; }

			//if (windSpeed <= 118) { message = "the damage from winds is minimal"; }
			//else if (windSpeed <= 153) { message = "very dangerous winds will produce some damage"; }
			//else if (windSpeed <= 177) { message = "extremely dangerous winds cause extensive damage"; }
			//else if (windSpeed <= 208) { message = "devastating damage will occur"; }
			//else if (windSpeed <= 251) { message = "catastrophic damage will occur"; }
			//else { message = "cataclysmic damage will occur"; }

			message =
						(windSpeed <= 118) ? "the damage from winds is minimal" :
						(windSpeed <= 153) ? "very dangerous winds will produce some damage" :
						(windSpeed <= 177) ? "extremely dangerous winds cause extensive damage" :
						(windSpeed <= 208) ? "devastating damage will occur" :
						(windSpeed <= 251) ? "catastrophic damage will occur" :
						"cataclysmic damage will occur";

			// Keep the following lines intact
			Console.WriteLine( OUT_FORMAT, windSpeed, message );
			Console.WriteLine( "===========================" );
		}
	}
}