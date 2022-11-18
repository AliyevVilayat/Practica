using System;
using System.Diagnostics;
using System.Xml.Linq;
public class Book:Product
{
	public string genre;

	public Book(string genre,int no, string name, double price):base(no,name,price)
	{
        this.genre = genre;
    }

    public void getInfo()
    {
        Console.WriteLine($"no:{this.no},name:{name},price:{price},genre:{genre}");

    }
}
