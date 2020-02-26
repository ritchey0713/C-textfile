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

			string[] highScores = {"5000", "2200", "1800"};

			

			File.WriteAllLines(@"/home/maveryk/Desktop/code/hello2.txt", highScores);

			// System.Console.WriteLine("Please name the file");
			// string fileName = Console.ReadLine();
			
			// System.Console.WriteLine("Enter text to save:");
			// string input = Console.ReadLine();
			
			// File.WriteAllText(@"/home/maveryk/Desktop/code/" + fileName + ".txt",input);

			using(StreamWriter file = new StreamWriter(@"/home/maveryk/Desktop/code/myfile.txt")){
				foreach(string line in lines){
					if(line.Contains("Third")){
						file.WriteLine(line);
					}
				}
			}

			using(StreamWriter file = new StreamWriter(@"/home/maveryk/Desktop/code/myfile.txt", true)){
				file.WriteLine("Additional line");
			}

    }
  }
}
