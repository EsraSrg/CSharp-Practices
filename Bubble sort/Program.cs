 
 int[] array = { 5, 3, 8, 4, 1 };      

        

        // Bubble Sort algoritması
        for (int i = 0; i < array.Length- 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Elemanları yer değiştir
                    int yer = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = yer;
                }
            }
        }

        
        Console.WriteLine("Sıralanmış dizi:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }