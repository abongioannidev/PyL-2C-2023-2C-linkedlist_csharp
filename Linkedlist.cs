using System.Collections;

namespace linkedlist_csharp;

public class Linkedlinst<T>
{
    private Node<T>? firstNode;

    public int CountElements
    {
        get
        {
            return this.GetCountElements();
        }
    }
    private int LastIndex
    {
        get
        {
            return this.CountElements - 1;
        }
    }


    private int GetCountElements()
    {
        Node<T>? node = this.firstNode;
        int count = 0;

        while (node is not null)
        {
            count++;
            node = node.nextNode;
        }
        return count;
    }


    public void AddElement(T[] elements)
    {
        foreach (T item in elements)
        {
            this.AddElement(item);
        }
    }

    public void AddElement(T element)
    {
        Node<T>? node = this.firstNode;
        Node<T> newNode = new Node<T>() { element = element };
        if (node is null)
        {
            this.firstNode = newNode;
        }
        else
        {
            node = this.GetNodeByIndex(this.LastIndex);
            node!.nextNode = newNode;
        }

    }
    private Node<T>? GetNodeByIndex(int index)
    {
        if (index > -1 && index < this.CountElements)
        {
            Node<T>? node = this.firstNode;

            if (index == 0)
            {
                return node;
            }
            int i = 1;
            node = node!.nextNode;
            while (node is not null && i != index)
            {
                i++;
                node = node!.nextNode;
            }
            return node;
        }
        return null;
    }

    public T? GetElementByIndex(int index)
    {
        Node<T>? node = this.GetNodeByIndex(index);

        if (node is null)
        {
            throw new Exception("index out of range");
        }
        return node.element;
    }

}