using System;

// SystemにあるExceptionを継承する
class MyException: Exception {
  public MyException(string msg): base(msg) {

  }
}

class Ex {
    static void Div(int a, int b) {
        // オリジナルのエラーキャッチをする場合
        try {
            if (b < 0) {
                throw new MyException("not minus");
                } 
            Console.WriteLine(a / b);
        }
        // エラーキャッチの宣言
        catch (DivideByZeroException e) {
            Console.WriteLine(e.Message);
        }
    }

    static void Main() {
        // DivideByZeroExceptionを発生させる
        Div(10, 0);
        // オリジナルを発生させる
        Div(10, -3);
    }
}
