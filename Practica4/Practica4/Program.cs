Console.Write("Zehmet olmasa sayi daxil edin:");
int count = int.Parse(Console.ReadLine());
Book[] arrBook = new Book[count];

int no;
string name;
double price;
string genre;

for (int i = 0; i < count; i++)
{

    Console.Write("\nZehmet olmasa kitabin nomresini daxil edin:");
    no = int.Parse(Console.ReadLine());

    Console.Write("Zehmet olmasa kitabin adini daxil edin:");
    name = Console.ReadLine();

    Console.Write("Zehmet olmasa kitabin qiymetini daxil edin:");
    price = double.Parse(Console.ReadLine());

    Console.Write("Zehmet olmasa kitabin janrini daxil edin:");
    genre = Console.ReadLine();

    Book book = new Book(genre, no, name, price);
    arrBook[i] = book;
}

Console.WriteLine("Emeliyyatlar\n1.Kitablari qiymete gore filterle\n2.Kitablar icinde axtaris\n3.Butun kitablari goster\n0.Programi bagla ");
int answer = int.Parse(Console.ReadLine());

bool isContinue = true;
while (isContinue)
{
    switch (answer)
    {

        case 0:
            isContinue = false;
            break;
        case 1:


            Console.Write("MinPrice'i daxil edin:");
            int minPrice = int.Parse(Console.ReadLine());
            Console.Write("MaxPrice'i daxil edin:");
            int maxPrice = int.Parse(Console.ReadLine());
            filterPrice(arrBook, minPrice, maxPrice);
            break;

        default:

            Console.WriteLine("Diger emeliyyatlar hazirliq merhelesindedir");
            break;
    }

}

void filterPrice(Book[] bookArr, int minPrice, int maxPrice)
{
    int count = 0;
    Book[] filteredBookArr = new Book[bookArr.Length];
    for (int i = 0, j = 0; i < bookArr.Length; i++)
    {

        if (bookArr[i].price >= minPrice && bookArr[i].price <= maxPrice)
        {

            filteredBookArr[j] = bookArr[i];
            count++;
            j++;
        }

    }

    Book[] filteredBookArrResult = new Book[count];

    for (int i = 0; i < count; i++)
    {
        filteredBookArrResult[i] = filteredBookArr[i];

    }

    printArr(filteredBookArrResult);
}

void printArr(Book[] bookArr)
{

    foreach(Book book in bookArr)
    {

        book.getInfo();
    }
}


