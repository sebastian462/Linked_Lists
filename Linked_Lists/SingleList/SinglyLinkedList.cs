﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SingleList;

public class SinglyLinkedList<T>
{
    private SingleNode<T>? head;


    public SinglyLinkedList()
    {
        head = null;
    }

    public void InsertAtBeginning(T data)
    {
        var newNode = new SingleNode<T>(data);
        newNode.Next = head;
        head = newNode;
    }

    public override string ToString()
    {
        var output = string.Empty;
        var currentNode = head;
        while (currentNode != null)
        {
            output += $"{currentNode.Data} -> ";
            currentNode = currentNode.Next;
        }
        output += "null";
        return output;
    }

    public void InsertAtEnd(T data)
    {
        var newNode = new SingleNode<T>(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        var current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public bool Contains(T data)
    {
        var current = head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;

    }

    public void Clear()
    {
        head = null;
    }

    public void Remove(T data)
    {
        if (head == null)
        {
            return;
        }

        if (head.Data!.Equals(data))
        {
            head = head.Next;
            return;
        }

        var current = head;
        while (current.Next != null && !current.Next.Data!.Equals(data))
        {
            current = current.Next;
        }
        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }

    }

    public void Ahead(T data)
    {

    }

    

}

