using System;

// abstractをつけると抽象クラスになる
abstract class User {
    // 抽象クラスのメソッドにもabstractをつける
    public abstract void SayHi();
}

class Japanese :User {
    public override void SayHi() {
        Console.WriteLine("こんにちは");
    }
}

class American :User {
    public override void SayHi() {
        Console.WriteLine("hello");
    }
}

class Abstract {
    static void Main(){
        Japanese jap = new Japanese();
        jap.SayHi();
        American ap = new American();
        ap.SayHi();
    }
}
