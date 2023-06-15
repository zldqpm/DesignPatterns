namespace Bridge
{
    // 抽象消息发送接口
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    // 具体邮件发送实现
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("通过邮件发送消息：{0}", message);
        }
    }

    // 具体短信发送实现
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("通过短信发送消息：{0}", message);
        }
    }

    // 消息通知类
    public class MessageNotifier
    {
        private IMessageSender _messageSender;

        public MessageNotifier(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void SendNotification(string message)
        {
            _messageSender.SendMessage(message);
        }
    }
}
