using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Composite
{
    internal class File : IFileSystemItem
    {
        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public string Name { get; private set; }
        private int Size { get; set; }

        public void Display(int depth)
        {
            Console.WriteLine("FILE");
        }

        public int GetSize() => Size;
    }
}
