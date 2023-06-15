namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //单例模式（Singleton Pattern）是一种创建型设计模式，用于确保一个类只有一个实例，并提供全局访问点来访问该实例
            //单例模式适用于以下场景：
            //1.全局配置信息：当需要在应用程序中共享全局配置信息时，可以使用单例模式。这样可以确保只有一个配置对象存在，并且可以在需要的任何地方访问它。
            //2.日志记录器：在应用程序中使用单例模式来创建一个日志记录器，以确保只有一个日志实例，并且可以在应用程序的不同部分使用它来记录日志。
            //3.数据库连接池：当应用程序需要频繁地与数据库进行连接时，使用单例模式可以创建一个数据库连接池，以确保连接的复用和最佳的性能。
            //4.缓存管理器：使用单例模式来创建缓存管理器，可以确保应用程序中只有一个缓存实例，用于存储经常使用的数据，提高访问速度。
            Console.WriteLine("单例模式!");
            Console.WriteLine("使用单例模式实现全局配置信息的示例");
            //使用单例模式实现全局配置信息的示例
            var configManager = ConfigurationManager.Instance;
            string configurationData = configManager.GetConfigurationData();
            Console.WriteLine(configurationData);
            Console.ReadLine();
            //在上述示例中，ConfigurationManager 类使用单例模式来创建一个全局的配置管理器。通过 Instance 属性可以获取 ConfigurationManager 类的唯一实例。在实例化过程中，加载配置数据的逻辑只会执行一次，并且可以通过 GetConfigurationData 方法访问配置数据。
            //在应用程序的任何地方都可以通过 ConfigurationManager.Instance 访问到全局的配置信息。
        }
    }
}