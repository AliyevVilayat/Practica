/*#region task1
int countOdd = 0;
int getCountOdd(params int[] arr){

    int countOdd = 0;

    foreach (var item in arr)
    {

        if (item % 2 != 0 && item>0)
        {

            countOdd++;
        }
    }

    return countOdd;

}

countOdd = getCountOdd(1,2,3,4,5);
Console.WriteLine(countOdd);
#endregion
*/

/*#region task2
string getStr(string str)
{

    string newStr = "";

    for(int i = str.Length-1; i >= 0; i--)
    {

        newStr += str[i];
    }

    return newStr;
}

Console.WriteLine(getStr("salam"));
#endregion*/


/*#region task3

int[] arr = new int[] { 10,11,12,13,14};
Console.Write("Zehmet olmasa yeni arrayin olcusunu daxil edin: ");
int newArrLength =int.Parse( Console.ReadLine());

if (newArrLength < 0)
{

    Console.WriteLine("Arrayin olcusu menfi ola bilmez");
    return;
}

resizeArr(ref arr, newArrLength);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
    if (i < newArrLength - 1)
    {
        Console.Write(",");
    }
}

void resizeArr(ref int[] arr,int newArrLength)
{
    int[] resizeArr = new int[newArrLength];
    if(arr.Length < newArrLength)
    {

        newArrLength = arr.Length;
    }
    for (int i = 0; i < newArrLength; i++)
    {

        resizeArr[i] = arr[i];
    }
    arr = resizeArr;
}

#endregion*/


#region task4

int[] arr = new int[] { 10, 11, 12, 13, 14 };
Console.Write("Zehmet olmasa  arraye yeni element daxi edin: ");
int newElm = int.Parse(Console.ReadLine());


resizeArr(ref arr, newElm);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
    if (i < arr.Length - 1)
    {
        Console.Write(",");
    }
}

void resizeArr(ref int[] arr, int newElm)
{
    int[] resizeArr = new int[arr.Length+1];

    for (int i = 0; i < arr.Length; i++)
    {

        resizeArr[i] = arr[i];
    }
    resizeArr[arr.Length] = newElm;
    arr = resizeArr;
}

#endregion