using System;

// 慣例として名前の先頭にIをつける
interface ISharable {
    // 抽象メソッドだが、abstractは必要ない
    void Share();
}

// interfaceを継承する
class User: ISharable{
    // 抽象メソッドだがoverrideはいらない
    public void Share() {
        Console.WriteLine("now sharing...");
    }
}

class Interface {
    static void Main() {
        User user = new User();
        user.Share();
    }
}
