using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Post your message: ");
    string postMessage = Console.ReadLine();

    if (postMessage.Length <= 140)
    
    {Console.WriteLine("Posted");
      
    }
    else
    {Console.WriteLine("Rejected");
      
    }
  }
}
