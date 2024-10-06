 
 int[] newArray = { 8, 4, 6, 7, 1, 2 };
mySort(newArray);
 
 
 static void mySort(int[] array)
{



    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {

                int yer = array[j];
                array[j] = array[j + 1];
                array[j + 1] = yer;
            }
        }
    }


    Console.WriteLine("Sorted Array:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "-");
    }


}



