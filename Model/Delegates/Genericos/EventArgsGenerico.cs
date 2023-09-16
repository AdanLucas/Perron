using System;


public class EventArgsGenerico<T> : EventArgs
{
    public T Item { get; set; }

}

