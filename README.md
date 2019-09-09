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

- VScodeを入れてみる
ファイルの実行があまりにだるいので。。
参考：https://qiita.com/shuhey/items/38ce475b3c0c90862d2c

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

# メモ
- csファイルの実行手順
```
コンパイル：
mcs ｃｓのファイル名
実行：
mono exeのファイル名
```
めんどくさい。。。
- IDEはvisual studio
便利
- class名、メソッド名の頭文字は大文字にする
