using System;

namespace EchoNameTrim {
    class Program {
        const string PROMPT = "Hi, please enter your name:";
        const string GREETING = "Greetings {0}, welcome to ITD121.";

        public static void Main( string[] args ) {
            // Keep the following line intact 
            Console.WriteLine( "===========================" );

            Console.WriteLine( PROMPT );
            string name = Console.ReadLine();
            
            string nameTrimmed = name.Trim();
            Console.WriteLine(GREETING, nameTrimmed );

            // Keep the following line intact 
            Console.WriteLine( "===========================" );
        }
    }
}