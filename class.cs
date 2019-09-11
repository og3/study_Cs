using System;

// Class
// - 変数（フィールド）
// - メソッド
class User {
    // 文字列型の変数を宣言
    public string name; 
    // コンストラクタ（initiarize)
    public User(string name){
        this.name = name;
    }
    // コンストラクタ処理に何も渡らなかったらnobodyを渡す処理
    public User():this("nobody"){
    }
    public void SayHi() {
        // 変数が自明の場合はthisは省略して良い
        // Console.WriteLine($"hi {this.name}");
        Console.WriteLine($"hi {name}");
    }
}

class MyApp {

  static void Main() {
    User tom = new User("tom");
    tom.SayHi();
    User user = new User();
    user.SayHi();
  }

}