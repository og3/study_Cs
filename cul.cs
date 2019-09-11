// 計算系の学習
using System;

class MyApp {

  static void Main() {
    // + - * / %
    var x = 10; // intになる
    Console.WriteLine(x / 3); // 3
    Console.WriteLine(x % 3); // 1
    Console.WriteLine(x / 3.0); // 3.333....
    // 型を変更して計算する
    Console.WriteLine(x / (double)3); // 3.333....

    // ++ --
    var y = 5;
    y++;
    Console.WriteLine(y); // 6
    y--;
    Console.WriteLine(y); // 5

    var z = 6;
    // z = z + 10;
    z += 10;

    // AND OR NOT
    // && || !
    var flag = true;
    Console.WriteLine(!flag);
  }

}
