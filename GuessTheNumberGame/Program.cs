// user has 10 guess, if user fails there will be 3 more games.
// use up and down to navigate user's guess.

Random rnd=new Random();

for(int i=0;i<3;i++){

    System.Console.WriteLine("This is your {0}. game",i+1);
    bool isOk=false;
    int random=rnd.Next(1,100);
    
    for(int j=0;j<10;j++){

        System.Console.WriteLine("{0}. number:",j+1);
        int guess=int.Parse(Console.ReadLine());

        if(guess<random){
            System.Console.WriteLine("Up");
        }
        else if(guess>random){
            System.Console.WriteLine("down");
        }
        else if(guess==random){
            isOk=true;

            break;  // user wins, game over.
        }
    }

    if(isOk){
        System.Console.WriteLine("Congrats!");
    }
    else{
        System.Console.WriteLine("You failed..");
        System.Console.WriteLine("for {0}. game press x key",i+2);
        string key=Console.ReadLine();

        if(key=="x"){
            continue;  
        }
    }
}
