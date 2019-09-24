using System;

// 継承
// Userクラスを継承してAdminUserクラスを作成する

class AdminUser :User {
  public AdminUser(string name): base(name){
  }
  // 親クラスのメソッド
  public void SayHello() {
    Console.WriteLine($"hello {name}");
  }
  // UserクラスのSayHiメソッドを上書きする
  public override void SayHi() {
    Console.WriteLine($"[admin] hi {name}");
  }
}
    
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
    // 子クラスにオーバーライドされるメソッド
    public virtual void SayHi() {
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
    AdminUser bob = new AdminUser("BOB");
    bob.SayHi();
    bob.SayHello();
  }

}