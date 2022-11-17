/*#region practicaTask1

//array parametri qebul eden method bize arrayin minimum elementini qaytarsin


int[] arr = { 5, 2, 3, 4, 5 };

int min = arrMinOptimal(arr);
Console.WriteLine($"min: {min}");

static int arrMin(int[] arr)
{
    int minElm = int.MaxValue;
    for(int i=0;i<arr.Length; i++)
    {
        if (arr[i] < minElm)
        {
            minElm = arr[i];   
        }
    }
    return minElm;
}

static int arrMinOptimal(int[] arr)
{
    int minElm = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElm)
        {
            minElm = arr[i];
        }
    }
    return minElm;
}
#endregion*/

/*#region practicaTask2

//arrayin elementlerinin cemini qaytaran

using System;

int[] arr = { 5, 2, 3, 4, 5 };
int sum = arrSum(arr);
Console.WriteLine($"sum: {sum}");

int arrSum(int[] arr)
{
    int sumArr = 0;
    foreach (int elm in arr)
    {
        sumArr += elm;
    }
    return sumArr;
}

#endregion

*/

/*#region practicaTask3

//arrayin elementlerini reverse eden method

int[] arr = { 5, 2, 3, 2, 5, 1};

int[] reverseArr = arrReverse(arr);

for(int i = 0; i < reverseArr.Length; i++)
{
    Console.Write(reverseArr[i]);
    if (i < reverseArr.Length - 1)
    {
        Console.Write(",");
    }
}

int[] arrReverse(int [] arr)
{
    int[] reverseArr = new int[arr.Length];

    for(int i = 0; i < arr.Length; i++)
    {
        reverseArr[i] = arr[arr.Length - i - 1];
    }
    return reverseArr;
}
#endregion*/

/*#region practicaTask4

//array ve deyer qebul edir gonderdiyimiz deyer arrayin hansi indexinde yerlesdiyini tapin

int[] arr = { 5, 2, 3, 4, 5 };
int num = 5;
int index = IndexNum(arr,num);
Console.WriteLine($"index: {index}");
static int IndexNum(int[] arr,int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return i;
        }
    }
    return -1;
}
#endregion*/

/*#region practicaTask5

//

//array ve deyer qebul edir gonderdiyimiz deyer arrayin hansi indexinde yerlesdiyini tapin

int[] arr = { 5, 2, 3, 4, 5 };
int val = 5;
int[] newArr = addVal(arr, val);

for (int i = 0; i < newArr.Length; i++)
{
    Console.Write(newArr[i]);
    if (i < newArr.Length - 1)
    {
        Console.Write(",");
    }
}
static int[] addVal(int[] arr, int val)
{
    int[] newArr = new int[arr.Length+1];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    newArr[arr.Length] = val;
    return newArr;
}

#endregion*/

/*#region practicaTask6

//parameter olaraq string ,char(old) ve char(new) gonderilir, gonderdiyimiz yeni charla kohne charlar string deyer daxilinde deyisdirilir


string str = "test";
char oldChar = 't';
char newChar = 'd';

string newStr = replaceCh(str,oldChar, newChar);
Console.WriteLine(newStr);
static string replaceCh(string str, char oldChar, char newChar)
{
    string newStr = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if(str[i] == oldChar)
        {
            newStr += newChar;
        }
        else
        {
            newStr += str[i];
        }     
    }
    return newStr;
}

#endregion*/

/*#region practicaTask7

//parameter olaraq char ve array gonderilir, gonderdiyimiz charla arrayin elementlerini birlesdirir. string deyer daxilinde deyisdirilir

char ch = '-';
int[] arr = new int[] { 1, 2, 3, 4, 5 };

string newStr = joinCh(ch, arr);
Console.WriteLine(newStr);
static string joinCh(char ch, int[] arr)
{
    string newStr = string.Empty;

    for (int i = 0; i < arr.Length-1; i++)
    {
        newStr += arr[i];
        newStr += ch; 
    }
    newStr += arr[arr.Length-1];

    return newStr;
}

#endregion*/

/*#region practicaTaskX

string str = "testString";
string subStr = "Strr";

int index = 0;
int count = 0;
for(int i =0; i < str.Length-subStr.Length; i++)
{
    index = 0;
    while (index < subStr.Length)
    {
        if(subStr[index] == str[index + i])
        {
            index++;
            count++;
            if (count == subStr.Length)
            {
                Console.WriteLine("Daxil etdiyiniz deyer ifade daxilinde movcuddur");
                return;
            }
        }
        else
        {
            count = 0;
            break;
        }
    }
}

Console.WriteLine("Daxil etdiyiniz deyer ifade daxilinde movcud deyil. ");

#endregion
*/