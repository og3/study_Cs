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
