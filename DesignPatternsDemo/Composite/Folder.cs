using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Composite
{
    internal class Folder : IFileSystemItem
    {
        private List<IFileSystemItem> _items = new List<IFileSystemItem>();
        public Folder(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        public void Add(IFileSystemItem item)
        {
            _items.Add(item);
        }
        public void Remove(IFileSystemItem item)
        {
            _items.Remove(item);
        }
        public int GetSize()
        {
            int totalSize = 0;
            foreach (var item in _items)
            {
                totalSize += item.GetSize();
            }
            return totalSize;
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + "FOLDER: " + Name);
            foreach (var item in _items)
            {
                item.Display(depth + 2);
            }
        }

    }
}
