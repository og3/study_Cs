using System;

// 構造体
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
