
// kayak, ece, madam..


using System.Reflection;


Console.WriteLine("Enter a text:");
//  reads input, removes leading/trailing spaces, and converts it to lowercase if necessary
string text=Console.ReadLine().Trim().ToLower(); 

IsPalindrome(text);

static void IsPalindrome(string value){


string rvText="";

// creating the reverse string
for(int i=value.Length-1; i>=0; i--){

 rvText+=value.Substring(i,1);

}

if(rvText==value){
    System.Console.WriteLine("Text is palindrome");
}
else{
    System.Console.WriteLine("not palindrome");
}

}