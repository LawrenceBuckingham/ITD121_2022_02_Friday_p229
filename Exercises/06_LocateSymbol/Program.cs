using System;

namespace LocateSymbol {
    public class Program {
        const string PROMPT = "Please enter a line of text:";
        const string POSITIONS = "The first and last positions of '{0}' are {1} and {2}, respectively.";
        const char SYMBOL = '^';

        public static void Main( string[] args ) {
            // Keep the following line intact 
            Console.WriteLine( "===========================" );

            Console.WriteLine( PROMPT );
            string searchText = Console.ReadLine();
            
            int firstPos = searchText.IndexOf(SYMBOL);
            int lastPos = searchText.LastIndexOf(SYMBOL);

            Console.WriteLine(POSITIONS, SYMBOL, firstPos, lastPos);

            // Keep the following line intact 
            Console.WriteLine( "===========================" );
        }
    }
}