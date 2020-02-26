using System;

namespace textFileApp {
  class Program {
  	static void Main(string[] args){
       string text = System.IO.File.ReadAllText(@"/home/maveryk/Desktop/code/hello.txt");

			 System.Console.WriteLine("Text file contains: {0}", text);
    }
  }
}
