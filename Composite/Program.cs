namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("组合模式");
            //组合模式是一种结构型设计模式，用于将对象组织成树形结构，并以统一的方式处理单个对象和对象组合。
            //组合模式适用于以下场景：
            //1.当你需要表示对象的部分 - 整体层次结构，并能够以统一的方式处理单个对象和对象组合时，可以使用组合模式。例如，树形结构、文件系统、菜单和子菜单等都可以使用组合模式来表示。
            //2.当你希望客户端代码以一致的方式处理单个对象和对象组合时，可以使用组合模式。客户端不需要知道处理的是单个对象还是对象组合，统一使用相同的接口进行操作。这样可以简化客户端代码，并且使得代码更加可扩展和可维护。
            //3.当你希望在不影响客户端代码的情况下增加新类型的组件时，可以使用组合模式。组合模式通过定义统一的接口，使得新的组件可以无缝地与现有组件进行集成，而不需要修改客户端代码。
            //以下是一些常见的应用场景举例：
            //1.文件系统：文件系统可以使用组合模式来表示目录和文件的层次结构。目录和文件都是组合模式中的节点，可以统一使用相同的接口进行操作，例如创建、删除、复制等。
            //2.菜单和子菜单：在图形用户界面中，菜单和子菜单可以使用组合模式来表示。菜单可以包含其他菜单或菜单项，从而形成一个层次结构。用户可以对菜单和菜单项进行统一的操作，例如选择、禁用等。
            //3.组织架构：组织架构可以使用组合模式来表示。组织可以包含部门、团队和员工等，形成一个树形结构。通过组合模式，可以统一处理组织中的不同节点，并且可以方便地进行组织结构的扩展和修改。
            //4.图形图像处理：在图形图像处理中，可以使用组合模式来表示图形对象的层次结构。图形对象可以是简单的形状，也可以是复杂的图形组合。通过组合模式，可以统一处理图形对象，并且可以灵活地组合不同的图形对象。
            //总之，组合模式适用于需要处理对象的部分 - 整体层次结构，并且希望以统一的方式处理单个对象和对象组合的场景。它可以简化代码结构，提高代码的可扩展性和可维护性，同时保持客户端代码的简洁性。

            // 创建文件系统
            Folder rootFolder = new Folder("Root");
            FileSystemComponent file1 = new File("File 1");
            FileSystemComponent file2 = new File("File 2");
            Folder subFolder = new Folder("Sub Folder");
            FileSystemComponent file3 = new File("File 3");
            FileSystemComponent file4 = new File("File 4");
            subFolder.Add(file3);
            subFolder.Add(file4);
            rootFolder.Add(file1);
            rootFolder.Add(file2);
            rootFolder.Add(subFolder);
            // 显示文件系统
            rootFolder.Display(0);
            //在这个示例中，我们定义了一个抽象类 FileSystemComponent，它有两个子类 File 和 Folder。File 表示文件，它是文件系统中的叶子节点。Folder 表示文件夹，它可以包含其他 FileSystemComponent 对象，形成树形结构。
            //客户端代码中，我们创建了一个根文件夹 rootFolder，并向其添加了两个文件和一个子文件夹。然后调用 rootFolder.Display(0) 来显示整个文件系统。
            //通过这个示例，我们可以使用控制台程序模拟文件系统的功能。你可以根据需要扩展和修改代码，例如添加更多的文件或子文件夹，并调整显示的格式。

            // 创建菜单
            SubMenu mainMenu = new SubMenu("Main Menu");

            MenuComponent menuItem1 = new MenuItem("Menu Item 1");
            MenuComponent menuItem2 = new MenuItem("Menu Item 2");

            SubMenu subMenu = new SubMenu("Sub Menu");
            MenuComponent menuItem3 = new MenuItem("Menu Item 3");
            MenuComponent menuItem4 = new MenuItem("Menu Item 4");

            subMenu.Add(menuItem3);
            subMenu.Add(menuItem4);

            mainMenu.Add(menuItem1);
            mainMenu.Add(menuItem2);
            mainMenu.Add(subMenu);
            // 显示菜单
            mainMenu.Display(0);
            //在这个示例中，我们定义了一个抽象类 MenuComponent，它有两个子类 MenuItem 和 SubMenu。MenuItem 表示菜单项，它是菜单中的叶子节点。SubMenu 表示子菜单，它可以包含其他 MenuComponent 对象，形成菜单的层次结构。
            //客户端代码中，我们创建了一个主菜单 mainMenu，并向其添加了两个菜单项和一个子菜单。然后调用 mainMenu.Display(0) 来显示整个菜单。
            //通过这个示例，我们可以使用控制台程序模拟菜单和子菜单的功能。你可以根据需要扩展和修改代码，例如添加更多的菜单项或子菜单，并调整显示的格式。
            Console.ReadLine();

        }
    }
}