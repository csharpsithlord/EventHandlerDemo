using System;

namespace EventHandlerExample
{
    // Custom event arguments
    public class TagEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public TagEventArgs(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
