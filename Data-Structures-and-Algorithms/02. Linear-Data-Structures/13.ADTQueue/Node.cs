﻿namespace _13.ADTQueue
{
    public class Node<T>
    {
        public Node(T data)
        {
            this.Data = data;
        }

        public T Data { get; set; }

        public Node<T> Next { get; set; }
    }
}
