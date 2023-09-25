using System;

class Program {
  static void Main (string[] args) {
    Console.WriteLine ("Enter your message: ");
    Console.WriteLine();
    string myMessage = Console.ReadLine();
    Console.WriteLine();
    if(myMessage.Length <= 140)
    {
      Console.WriteLine("Posted");
    }
    else
    {
      Console.WriteLine("Rejected");
      }
    Console.ReadKey();
  }
}