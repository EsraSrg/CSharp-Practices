
using System.Collections;


// Count letters in a text using SortedList Collection.

CountLetters("ccccsshhharpppp");

static void CountLetters(string text)
{

    SortedList list = new SortedList();
    for (int i = 0; i < text.Length; i++)
    {

        string letter = text[i].ToString();
        if (list.ContainsKey(letter)) //are there letters in the collection?
        {

           
// getting value with key
            int value = (int)list[letter];
            value++;
            list[letter] = value;

        }
        else
        {
            list.Add(letter.ToString(), 1);
        }
    }

    foreach (DictionaryEntry item in list)
    {
        Console.WriteLine("{0} > {1}", item.Key, item.Value);

    }

}



