using System;
using System.Collections.Generic;

namespace MedianTemperature {
	public class Program {
		const string
			PROMPT = "Please enter a temperature reading, or {0} to finish:",
			EMPTY_LIST = "Median is not defined for an empty list.",
			RESULTS = "The median temperature is {0:f2} degrees.",
			SENTINEL = "99999999"
;

		static void Main( string[] args ) {
			// Keep the following line intact 
			Console.WriteLine( "===========================" );

			List<double> temps = new List<double>();

			while(true) {
				Console.WriteLine(PROMPT, SENTINEL);
				string s = Console.ReadLine().Trim();

				if (s == SENTINEL) break;

				double currentTemp = double.Parse(s);
				temps.Add( currentTemp );
			}

			if (temps.Count == 0) {
				Console.WriteLine( EMPTY_LIST );
			}
			else {
				temps.Sort();

				int n = temps.Count;

				double median = (n % 2 == 1) ? temps[n/2] : (temps[n/2] + temps[n/2-1])/2;

				/*
				 * double median;
				 * if (n%2 == 1) {
				 *		median = temps[n/2];
				 * }
				 * else {
				 *		median = (temps[n/2] + temps[n/2-1])/2;
				 * }
				*/

				Console.WriteLine(RESULTS, median);
			}

			//Console.WriteLine( PROMPT );
			//string s = Console.ReadLine().Trim();

			//if (s.Length == 0) {
			//	Console.WriteLine( EMPTY_LIST );
			//}
			//else {
			//	string [] fields = s.Split(',', StringSplitOptions.RemoveEmptyEntries);
			//	List<double> temps = new List<double>();

			//	foreach (string field in fields) {
			//		temps.Add( double.Parse( field ) );
			//	}
			//}

			// Keep the following line intact
			Console.WriteLine( "===========================" );
		}
	}
}