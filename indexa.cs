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
