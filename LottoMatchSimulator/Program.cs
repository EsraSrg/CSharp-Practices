// from today, we bet with same 6 numbers till it matches random 6 number.


int [] ourNums={22,13,67,2,8,25};

int[] randomNums=new int[6];
Random rnd=new Random();

DateTime time=new DateTime();
int week=0;
// infinite loop because we dont when they'll match
for(;;){

    week+=7;
    System.Threading.Thread.Sleep(500); // Adding a delay for slower execution
    System.Console.WriteLine("{0} result",DateTime.Now.AddDays(week).ToLongDateString());
    int matched=0;
// we get random numbers here
for(int i=0;i<randomNums.Length;i++){

    
    randomNums[i]=rnd.Next(1,49);

}
// comparing random nums with our nums
 for(int i=0;i<randomNums.Length;i++){

    for(int j=0;j<randomNums.Length;j++){

        if(randomNums[i]==ourNums[j]){

            matched++;
            if(matched==5){
                System.Console.WriteLine("5 nums matched");
            }
            else if(matched==6){
                System.Console.WriteLine("6 nums matched..Congrats!!");
                break;
            }

        }
    }
 }
 System.Console.WriteLine("{0} nums matched this week:",matched);
}