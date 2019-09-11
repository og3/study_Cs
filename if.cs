using System;

class MyApp {

  static void Main() {
    // if
    var score = int.Parse(Console.ReadLine());

    // > >= < <= == !=
    // if (score > 80) {
    //   Console.WriteLine("Great!");
    // } else if (score > 60) {
    //   Console.WriteLine("Good!");
    // } else {
    //   Console.WriteLine("so so ...!");
    // }

    Console.WriteLine((score > 80) ? "Great" : "so so ...");
  }

}