using System;

class Method {
    // static void Sayhi(){
    //     Console.WriteLine("hi");
    // }
    static void SayHi(string name, int age = 20 ) => Console.WriteLine($"hi {name} {age}");
    static void Main() {
        SayHi("Tom", 30); // tom 30
        SayHi("Bob"); // bob 23
        SayHi(age: 26, name: "Steve"); // steve 26
    }
}
