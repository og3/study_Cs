using System;

// Class
// - 変数（フィールド）
// - メソッド
class User {
    public string name = "name";
    public void SayHi() {
        // 変数が自明の場合はthisは省略して良い
        // Console.WriteLine($"hi {this.name}");
        Console.WriteLine($"hi {name}");
    }
}

class MyApp {

  static void Main() {
    User user = new User(); // インスタンス
    Console.WriteLine(user.name); // me
    user.SayHi(); // hi! me
    user.name = "おれ";
    user.SayHi(); // hi! taguchi
  }

}