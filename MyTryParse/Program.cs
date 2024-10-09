
// control if a string value is a number and if it's true, assign it to an int variable.

int s;
Console.WriteLine(MyTryParse("20",out s));
System.Console.WriteLine(s);


static bool IsNum(char karakter){
    
    return char.IsDigit(karakter);  // is char digit
}


static bool MyTryParse(string value, out int result){
   
   
    bool isOk=false;
     result=0;
     string num="";

 for(int i=0;i<value.Length;i++){

    if(IsNum(value[i])){ // if true , convert value to an int and return true.

        isOk=true;
        num+=value[i];
        result=Convert.ToInt32(num);
    } else if (IsNum(value[i])==false){  //if i is not digit "1A23" ,break

        isOk=false;
        result=0;
        break;
        
    }

 }

return isOk;

}

