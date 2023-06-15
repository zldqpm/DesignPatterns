namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("适配器模式");
            //适配器模式（Adapter Pattern）是一种结构型设计模式，用于将一个类的接口转换成客户端所期望的另一个接口。适配器模式使得原本由于接口不兼容而无法在一起工作的类能够一起工作。
            //适配器模式的使用场景包括以下情况：
            //1.将已有的类集成到新的系统中：当我们需要使用一些已经存在的类，但是它们的接口与系统要求的接口不兼容时，可以创建适配器来将这些类的接口转换为系统所需的接口。这样就可以将这些已有的类集成到新的系统中，而无需修改它们的源代码。
            //2.统一接口：当我们需要统一一组类的接口，使其具有相同的方法或属性时，可以使用适配器模式。适配器模式可以将这些类的接口转换为统一的接口，以便在客户端代码中统一使用。
            //3.第三方库的使用：当我们使用第三方库或组件，但其接口与我们的系统不兼容时，可以使用适配器模式来将第三方库的接口转换为我们需要的接口，以便在我们的系统中使用该库。
            //下面是几个适配器模式的使用场景的示例：
            //1.数据库访问：不同的数据库通常具有不同的接口和查询语言。使用适配器模式，我们可以创建适配器来将不同数据库的接口转换为统一的数据库访问接口，以便在系统中使用不同的数据库，而无需更改系统的核心逻辑。
            //2.日志记录：不同的日志记录库可能具有不同的接口和方法。通过创建适配器，我们可以将这些不同的日志记录库的接口转换为统一的接口，以便在系统中使用不同的日志记录库。
            //3.外部服务调用：当我们需要调用外部服务，而其接口与我们的系统接口不匹配时，可以使用适配器模式。适配器可以将外部服务的接口转换为我们系统所期望的接口，以便与外部服务进行集成。
            //总的来说，适配器模式的使用场景是在需要将不兼容的接口转换为兼容接口的情况下，以便不修改现有代码的情况下进行集成或统一接口的使用。

            // 创建第三方日志记录库的实例
            ILogger thirdPartyLogger = new ThirdPartyLogger();
            // 创建适配器实例，将第三方日志记录库适配为系统内部的日志记录接口
            ILoggingService logger = new LoggerAdapter(thirdPartyLogger);
            // 使用适配器记录日志
            logger.LogInfo("This is an informational message.");
            logger.LogError("This is an error message.");
            //在上述示例中，我们首先定义了第三方日志记录库的接口 `ILogger`，其中包含了 `Log` 方法来记录日志。然后，我们实现了一个具体的第三方日志记录库 `ThirdPartyLogger`，用于模拟第三方日志记录库的实现。
            //接着，我们定义了系统内部的日志记录接口 `ILoggingService`，其中包含了 `LogInfo` 和 `LogError` 方法。然后，我们创建了一个适配器类 `LoggerAdapter`，它实现了系统内部的日志记录接口，并将调用转发给第三方日志记录库的 `ILogger` 接口。
            //在控制台程序的入口 `Main` 方法中，我们创建了第三方日志记录库的实例 `ThirdPartyLogger`，然后创建适配器实例 `LoggerAdapter`，将第三方日志记录库适配为系统内部的日志记录接口。最后，我们使用适配器来记录日志。
            //通过使用适配器模式，我们可以在控制台程序中将第三方日志记录库适配为系统内部所需的接口，从而实现日志记录功能。

            // 创建外部服务的实例
            IExternalService externalService = new ExternalService();
            // 创建适配器实例，将外部服务适配为系统内部的服务接口
            IInternalService internalService = new ExternalServiceAdapter(externalService);
            // 使用适配器调用外部服务
            internalService.ProcessData("Sample data");
            //在上述示例中，我们首先定义了外部服务的接口 `IExternalService`，其中包含了 `CallExternalApi` 方法来调用外部的API。然后，我们实现了一个具体的外部服务 `ExternalService`，用于模拟外部服务的实现。
            //接着，我们定义了系统内部的服务接口 `IInternalService`，其中包含了 `ProcessData` 方法。然后，我们创建了一个适配器类 `ExternalServiceAdapter`，它实现了系统内部的服务接口，并将调用转发给外部服务的 `IExternalService` 接口。
            //在控制台程序的入口 `Main` 方法中，我们创建了外部服务的实例 `ExternalService`，然后创建适配器实例 `ExternalServiceAdapter`，将外部服务适配为系统内部的服务接口。最后，我们使用适配器来调用外部服务。
            //通过使用适配器模式，我们可以在控制台程序中将外部服务适配为系统内部所需的接口，从而实现外部服务的调用功能。
        }
    }
}