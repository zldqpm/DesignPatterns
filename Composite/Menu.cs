using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    using System;
    using System.Collections.Generic;

    // 菜单组件抽象类
    public abstract class MenuComponent
    {
        protected string name;

        public MenuComponent(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }

    // 菜单项类
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }

    // 子菜单类
    public class SubMenu : MenuComponent
    {
        private List<MenuComponent> children = new List<MenuComponent>();

        public SubMenu(string name) : base(name)
        {
        }

        public void Add(MenuComponent component)
        {
            children.Add(component);
        }

        public void Remove(MenuComponent component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (MenuComponent component in children)
            {
                component.Display(depth + 2);
            }
        }
    }

}
