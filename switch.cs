using System;

class Switch {
    static void Main() {
        // 文字列の入力受付
        var signal = Console.ReadLine();

        switch(signal) {
            case "red":
                Console.WriteLine("止まれ");
                break;
            case "blue":
            case "green":
                Console.WriteLine("進め");
                break;
            case "yellow":
                Console.WriteLine("注意");
                break;
            default:
                Console.WriteLine("入力ミス");
                break;
        }
    }
}
