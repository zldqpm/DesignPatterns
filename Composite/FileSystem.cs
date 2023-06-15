namespace Composite
{
    using System;
    using System.Collections.Generic;

    // 文件系统抽象类
    public abstract class FileSystemComponent
    {
        protected string name;

        public FileSystemComponent(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }

    // 文件类
    public class File : FileSystemComponent
    {
        public File(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }

    // 文件夹类
    public class Folder : FileSystemComponent
    {
        private List<FileSystemComponent> children = new List<FileSystemComponent>();

        public Folder(string name) : base(name)
        {
        }

        public void Add(FileSystemComponent component)
        {
            children.Add(component);
        }

        public void Remove(FileSystemComponent component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (FileSystemComponent component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
