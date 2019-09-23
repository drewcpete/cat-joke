using System;

class Sphinx
{
  static void Main()
  {
      Console.WriteLine("What do you call a cat that\'s a fan of happiness and cleanlieness?");
      string lookupAnswer = Console.ReadLine();
      if(lookupAnswer == "Purrell" || lookupAnswer == "purrell" || lookupAnswer == "phurell" || lookupAnswer == "Phurell")
      {
        Console.WriteLine("You\'re a god damn genius!");
      }
      else{
        Console.WriteLine("It's Purrell, you a god damn fool!");
      }
  }

}
