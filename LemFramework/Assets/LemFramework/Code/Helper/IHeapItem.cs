using System;

namespace LemFramework.Helper
{
    public interface IHeapItem<T> : IComparable<T>
    {
        int HeapIndex { get; set; }
    }
}