using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Composite
{
    internal interface IFileSystemItem
    {
        string Name { get; }
        int GetSize();
        void Display(int depth);
    }
}
