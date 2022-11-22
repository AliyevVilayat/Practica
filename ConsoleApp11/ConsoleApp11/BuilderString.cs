using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BuilderString
{
/*
    private char[] _chars;
    private int Capacity { get; set;}

    public BuilderString()
    {

        Capacity = 16;
        _chars = new char[Capacity];
    }*/

    private char[] _arr;
    public int Capacity { get; set; }
    public BuilderString()
    {
        Capacity = 0;
        _arr = new char[Capacity];
    }

    public BuilderString(int capacity)
    {
        Capacity = capacity;
        _arr = new char[Capacity];
    }

    public void Append(char symbol)
    {
        if (Capacity == 0)
        {
            Capacity = 16;
            Array.Resize(ref _arr, Capacity);
        }
        if (_arr[Capacity - 1] != 0)
        {
            Capacity *= 2;
            Array.Resize(ref _arr, Capacity);
            _arr[Capacity / 2] = symbol;
            return;
        }

        for (int i = 0; i < Capacity; i++)
        {
            if (_arr[i] == 0)
            {
                _arr[i] = symbol;
                break;
            }

        }
    }

    public void Append(string str)
    {

        if (Capacity == 0)
        {
            Capacity = str.Length;
            Array.Resize(ref _arr, Capacity);
        }
        if (_arr[Capacity - 1] != 0)
        {
            while (Capacity * 2 < str.Length + Capacity)
            {

                Capacity *= 2;
            }
                
            Array.Resize(ref _arr, Capacity);
            
        }

        for(int i = 0 , j = 0; i < Capacity; i++)
        {

            if(_arr[i] == 0)
            {

                _arr[i] = str[j];
                j++;
            }
        }        
    }

    public BuilderString Replace(char oldVal, char newVal)
    {
        for (int i = 0; i < Capacity; i++)
        {
            if (_arr[i] == 0) break;
            if (_arr[i] == oldVal)
            {
                _arr[i] = newVal;
            }
        }
        return this;
    }

    public override string ToString()
    {
        string result = string.Empty;
        foreach (char item in _arr)
        {
            if (item == 0) break;
            result += item;
        }
        return result;
    }
}

