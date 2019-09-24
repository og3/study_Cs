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
