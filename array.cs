using System;
class array {
    static void Main(){
        var score = new [] {10, 20, 30};

        // for(int i = 0; i < score.Length; i++){
        //     Console.WriteLine(score[i]);
        // }
        foreach(int i in score){
            Console.WriteLine(i);
        }
    }
}