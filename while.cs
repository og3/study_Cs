using System;

class While {
    static void Main(){
        var i = 100;

        // while(i < 10){
        //     Console.WriteLine(i);
        //     i++;
        // }
        do {
            Console.WriteLine(i);
            i++;
        } while(i < 10);
    }
}
