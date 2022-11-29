
using Practica8;

Method<int> method = new();

Console.WriteLine(method.FindElement(new int[] { -1, 2, 3, 4 }, Positive));

bool Positive(int value)
{

    if (value > 0)
    {
        return true;
    }
    return false;
}

bool Negative(int value)
{

    return false;
}


