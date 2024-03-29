# study_Cs
C#のお勉強
参考：https://dotinstall.com/lessons/basic_csharp
# 開発環境構築
- monoをインストールする
```
brew install mono

結果：
$ mono --version
Mono JIT compiler version 6.0.0.327 (2019-02/f8ea05bddcb Sat Aug 10 18:47:12 EDT 2019)
Copyright (C) 2002-2014 Novell, Inc, Xamarin Inc and Contributors. www.mono-project.com
	TLS:           
	SIGSEGV:       altstack
	Notification:  kqueue
	Architecture:  amd64
	Disabled:      none
	Misc:          softdebug 
	Interpreter:   yes
	LLVM:          yes(600)
	Suspend:       hybrid
	GC:            sgen (concurrent by default)
```
参考：https://qiita.com/matsuda_sinsuke/items/76068f4c396887459803  

# VScodeのインストール
- コードの補完がないといろいろ書くC#はきつい  
- 実行も手元でできたほうが勉強は捗る
- VScodeとC#パッケージを入れてみる  
参考：https://qiita.com/shuhey/items/38ce475b3c0c90862d2c

# コンパイルと実行
- コンパイル
```
msc .csのファイル名
＝＞これでexeファイルが作られる
mono .exeのファイル名
＝＞これで結果が返ってくる
```

# 文法
- hello world
```
using System;

class Myapp
{
    static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
```
- 変数と定数
```
宣言：
変数の型　変数名
string msg;
ex:
string msg = "Hello World";
定数はconstをつけるし、値は入った状態でないとダメ
ex:
const string msg = "Hello World";
```
- 型について
```
文字列　文字
string s = "文字列";
char c = '文字';
数値
int i = 151;
浮動小数点数
double d = 123.1;
float f = 12.1f;
真偽値
bool flag = true;
勝手に判断してくれるやつ（型推論）
var i = 5; <=intと解釈してくれる
```
- 文字列中の式展開
```
var name = "taguchi";
var score = 52.3;
// 文字列中の式展開
Console.WriteLine($"{name} [{score}]");
```
- ユーザーの入力受付
```
ユーザーの入力を文字列で受け取る
var score = Console.ReadLine();
```
- 型変更
```
var score = int.Parse(Console.ReadLine());
```
- if
```
// if
var score = int.Parse(Console.ReadLine());
  // > >= < <= == !=
  if (score > 80) {
  Console.WriteLine("Great!");
  } else if (score > 60) {
  Console.WriteLine("Good!");
  } else {
  Console.WriteLine("so so ...!");
  }
```
- 三項演算子
```
Console.WriteLine((score > 80) ? "Great" : "so so ...");
```
- switch
```
// 文字列の入力受付
var signal = Console.ReadLine();

switch(signal) {
    case "red":
        Console.WriteLine("止まれ");
        // 処理の終了
        break;
    // 条件が２つある場合（演算子でできないのか？）
    case "blue":
    case "green":
        Console.WriteLine("進め");
        break;
    case "yellow":
        Console.WriteLine("注意");
        break;
    // 上記に該当しない場合
    default:
        Console.WriteLine("入力ミス");
        break;
```
- whileとdo while
```
var i = 1;

while(i < 10){
    Console.WriteLine(i);
    i++;
}
---
var i = 100;
do {
    Console.WriteLine(i);
    i++;
} while(i < 10);
こちらはdoの処理を実行した後でwhileの条件判定を行う
```
- for 
```
for(int i = 0; i < 10; i++){
    Console.WriteLine(i);
}
// continue それ以降の処理を中止して次のループへ
// break ループ自体を抜ける
```
- 配列
```
var score = new [] {10, 20, 30};

for(int i = 0; i < score.Length; i++){
  Console.WriteLine(score[i]);
}
---
foreach(int i in score){
  Console.WriteLine(i);
}
```
- メソッド
```
返り値を文字列で返すメソッド
static string Sayhi() {
	"hi";
}
処理が１行しかない場合はこう書ける
static string Sayhi() => "hi";

引数を持つ場合
static void SayHi(string name, int age = 20 ) => Console.WriteLine($"hi {name} {age}");
static void Main() {
    SayHi("Tom", 30); // tom 30
    SayHi("Bob"); // bob 23
    SayHi(age: 26, name: "Steve"); // steve 26
}
```
- クラスとインスタンスとクラスメソッド
```

class User {
    public string name = "name";
    public void SayHi() {
        // 変数が自明の場合はthisは省略して良い
        // Console.WriteLine($"hi {this.name}");
        Console.WriteLine($"hi {name}");
    }
}
呼び出し：
class MyApp {

  static void Main() {
    User user = new User(); // インスタンス
    Console.WriteLine(user.name); // me
    user.SayHi(); // hi! me
    user.name = "おれ";
    user.SayHi(); // hi! taguchi
  }

}
```
- クラスの継承
```
- 基本
子クラスは親クラスのメソッドを自由に使える
コンストラクタは自動的には継承されないのでbaseを使う必要がある
- base
子クラスのコンストラクタに値を渡す
- override
子クラスのメソッドを上書きする
- virtual
親クラスの上書きを許可する
```
```
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
```
- アクセス修飾子
```
- public
どのクラスからでも使える
- protected
そのクラスとサブクラスのみ使える
- private
そのクラスのみ使える
```
- プロパティ
外部のクラスからのアクセスを制限する
```
using System;

class User {
    private string name = "me!";
    // プロパティ
    // name変数に対してプロパティを使ってアクセスする
    // public string Name {　get; set;} = "me!";
    public string Name {　
        get { return this.name; } 
        set { 
            if(value != "") {
                this.name = value;
            }
        }
    }
}

class Prop {
    static void Main(){
        User user = new User();
        Console.WriteLine(user.Name);
        // Main関数からUserクラスのname変数を変更する
        user.Name = "tanaka";
        Console.WriteLine(user.Name);
    }
}
```
- インデクサ
クラスで作成した配列を呼びだすことができる
```
using System;

class Team {
    // 文字列型の配列をprivateで作成
    private string[] member = new string[3];
    // 外からアクセス可能な変数
    public string this[int i] {
        // 呼び出しはこのクラスのmember変数の添字の値を返す
        get { return this.member[i];}
        // 書き込みはこのクラスのmember変数の添字の値にvalueを入れる
        set { this.member[i] = value;}
    } 
}
class Indexa {
    static void Main() {
        Team giants = new Team();
        giants[0] = "ojison";
        giants[1] = "その辺の人";
        giants[2] = "おっさん";
        Console.WriteLine(giants[2]);
    }
}
* getで呼び出し方を規定しているので、この時配列は「配列名[添字]」でしか呼び出すことはできないので注意！
```
- static
インスタンスを作成しなくても、staticが付いている変数やメソッドはクラスから直接呼び出すことができる
```
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
        User.GetCount(); // 0
        User taro = new User();
        User jiro = new User();
        User.GetCount(); // 2
    }
}
```
- 抽象クラスと具象クラス
抽象クラス：継承されることを前提とするクラスでインスタンスは作れない  
具象クラス：一般的なクラス  
```
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
```
- interface
継承したクラスに対してinterface内のメソッドを実装することを約束させるメソッド
```
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
```
- generic
そのメソッドに渡された値を汎用化する（例：数値を渡せばintもfloatもdoubleも型指定しなくても自動で判別してくれる）
```

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
```
結局は型の指定は都度都度するのでわからなくなることはないか
- namespace
役割：クラスをまとめるもの
```
// Systemというnamespaceを使うことを宣言している
using System;
using Orenonamespace;

namespace Orenonamespace {
    class User {
        public void SayHi(){
            Console.WriteLine("hi hi hi!");
        }
    }
}

class Namespace {
    static void Main() {
        // Orenonamespace.User user = new Orenonamespace.User();
        // usingで宣言することでnamespace.の形で呼ばなくて済む
        User user = new User();
        user.SayHi();
    }
}
```
- 構造体
classのようなもの  
ただし、継承ができない
```
struct Point {
    // クラスの外からは値の読み出しのみできる
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y){
        X = x;
        Y = y;
    }
    public void GetInfo(){
        Console.WriteLine($"{X}:{Y}");
    }
}

class Struct {
    static void Main() {
        Point p1 = new Point(5, 3);
        Point p2 = new Point(2, 7);
        p1.GetInfo();
        p2.GetInfo();
    }
}
```
- 列挙型
定数をまとめて配列のように管理する機能
```
enum Direction {
    Stay = 0,
    Left = 1,
    Right = 2,
}

class Enum {
    static void Main(){
        switch(dir) {
            case Direction.Stay:
                Console.WriteLine("そのまま";)
                break;
            case Direction.Left:
                Console.WriteLine("左へ";)
                break;
            case Direction.Right:
                Console.WriteLine("右へ";)
                break;
        }
    }
}
```
- 例外処理
```
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
```
# メモ
- class名、メソッド名の頭文字は大文字にする
- Main関数は必要
