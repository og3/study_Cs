using System;

// <T>は汎用化する値
class MyData<T> {
    // メソッド内で汎用型Tとしてxという値を設定する
    public void GetThree(T x) {
        for(int i = 0; i < 3; i++){
            Console.WriteLine(x);
        }
    }
}

class Generic {
    static void Main() {
        // MyDataクラスのインスタンスを文字列型で生成する
        MyData<string> s = new MyData<string>();
        s.GetThree("hello generic!");
        // double型で生成
        MyData<double> d = new MyData<double>();
        d.GetThree(22.2);
    }
}
