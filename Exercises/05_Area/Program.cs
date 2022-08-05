using System;

namespace RoomArea {
	public class Program {
		const string PROMPT_WIDTH = "Please enter the width of the room, in metres:";
		const string PROMPT_LENGTH = "Please enter the length of the room, in metres:";
		const string MEASUREMENTS = "The floor area of a {0:f6} by {1:f6} metre room is {2:f6} square metres.";

		public static void Main( string[] args ) {
			// Keep the following line intact 
			Console.WriteLine( "===========================" );

			Console.WriteLine( PROMPT_WIDTH );
			double width = double.Parse(Console.ReadLine());

			Console.WriteLine( PROMPT_LENGTH );
			double length = double.Parse(Console.ReadLine());

			double area = width * length;

			Console.WriteLine( MEASUREMENTS, width, length, area );

			// Keep the following line intact 
			Console.WriteLine( "===========================" );
		}
	}
}