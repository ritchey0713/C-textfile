using System;
using System.IO;

namespace textFileApp {
  class Program {
  	static void Main(string[] args){

		// 	// ex 1 read text
    //    string text = System.IO.File.ReadAllText(@"/home/maveryk/Desktop/code/hello.txt");

		// 	 System.Console.WriteLine("Text file contains: {0}", text);

		// 	// get array of lines
		// 	 string[] lines = System.IO.File.ReadAllLines(@"/home/maveryk/Desktop/code/hello.txt");

		// 	 foreach(string line in lines){
		// 		 System.Console.WriteLine(line);
		// 	 }

			string[] lines = {"First line", "Second Line", "Third line!"};

			

			File.WriteAllLines(@"/home/maveryk/Desktop/code/hello2.txt", lines);

    }
  }
}
