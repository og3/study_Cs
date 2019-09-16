using System;

class User {
    // 数をカウントするための変数
    private static int count = 0;
    // コンストラクタ。Userインスタンスが作成されるごとに呼ばれるメソッド
    // count変数はstaticが付いているのでクラス.で呼び出せる
    public User() {
        User.count++;
    }
    public static void GetCount() {
        Console.WriteLine($"# of User instances: {count}");
    }
}

class Static {
    static void Main() {
        User.GetCount();
        User taro = new User();
        User jiro = new User();
        User.GetCount();
    }
}
