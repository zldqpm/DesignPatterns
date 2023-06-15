namespace Adapter
{
    // 外部服务的接口
    public interface IExternalService
    {
        void CallExternalApi(string data);
    }

    // 外部服务的实现
    public class ExternalService : IExternalService
    {
        public void CallExternalApi(string data)
        {
            Console.WriteLine($"Calling external API with data: {data}");
            // 实际的外部服务调用逻辑
        }
    }

    // 系统内部的服务接口
    public interface IInternalService
    {
        void ProcessData(string data);
    }

    // 适配器类，将外部服务适配为系统内部的服务接口
    public class ExternalServiceAdapter : IInternalService
    {
        private readonly IExternalService externalService;

        public ExternalServiceAdapter(IExternalService externalService)
        {
            this.externalService = externalService;
        }

        public void ProcessData(string data)
        {
            // 调用外部服务的方法来处理数据
            externalService.CallExternalApi(data);
        }
    }
}
