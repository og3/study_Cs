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
# メモ
- class名、メソッド名の頭文字は大文字にする
- Main関数は必要
