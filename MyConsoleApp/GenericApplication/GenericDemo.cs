using System;
using System.Collections;
using System.Collections.Generic;


namespace MyConsoleApp.GenericApplication;

public class GenericDemo
{
    public class MyGenericArray<T> where T : new() // 泛型约束
    {
        private T[] _array;

        public MyGenericArray(int size)
        {
            _array = new T[size];
        }
        
        public T GetItem(int index ) => _array[index];
        public void SetItem(int index, T value) => _array[index] = value;
        public T[] GetArray() => _array;
        public override string ToString() => string.Join(", ", _array);
    }

    public static void Demo()
    {
        MyGenericArray<int> array = new MyGenericArray<int>(10);

        for (int i = 0; i < 10; i++)
        {
            array.SetItem(i, i);
        }

        Console.WriteLine(array);
    }
}