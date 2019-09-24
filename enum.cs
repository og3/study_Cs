using System;

enum Direction {
    Stay = 0,
    Left = 1,
    Right = -1
}

class Enum {
    static void Main(){
        Direction dir = Direction.Right;
        Console.WriteLine((int)Direction.Right);
        
        switch(dir) {
            case Direction.Stay:
                Console.WriteLine("そのまま");
                break;
            case Direction.Left:
                Console.WriteLine("左へ");
                break;
            case Direction.Right:
                Console.WriteLine("右へ");
                break;
        }
    }
}
