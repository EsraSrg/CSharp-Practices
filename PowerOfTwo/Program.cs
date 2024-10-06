
// if a number is power of two,return true; if not return false..

Console.WriteLine(PowerOfTwo(256));
Console.WriteLine(PowerOfTwo(63));


static bool PowerOfTwo(int num)
{

    bool isOk = false;

    for (int i = 1; i <= num; i++)
    {

        if (num == (int)Math.Pow(2, i))
        {

            isOk = true;
        }

        if (num < (int)Math.Pow(2, i))
        {
            break;
        }

    }

    return isOk;
}
