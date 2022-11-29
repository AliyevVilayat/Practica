namespace Practica8;

public class Method<T>
{

    public int FindElement<T>(T[] arr, DelegateMethod<T> method)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            if (method(arr[i]))
            {
                return i;

            }
        }      

        return -1;
    }

    public delegate bool DelegateMethod<T>(T value);

   
}
