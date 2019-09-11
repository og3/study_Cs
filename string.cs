using System;

class MyApp {

  static void Main() {
    //   文字列結合
    Console.WriteLine("hello " + "world");

    // \n, \t（TAB）
    Console.WriteLine("hell\no wo\trld");

    var name = "taguchi";
    var score = 52.3;

    Console.WriteLine(string.Format("{0} [{1}]", name, score)); // taguchi [52.3]
    // 重要！文字列中の式展開
    Console.WriteLine($"{name} [{score}]");
    // 文字幅を設定する。マイナスは左詰
    Console.WriteLine($"{name, -10} [{score, 10}]");
    Console.WriteLine($"{name, -10} [{score, 10:0.00}]");
    Console.WriteLine($"{name, -10} [{score + 25, 10:0.00}]");
  }

}
