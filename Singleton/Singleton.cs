namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object lockObject = new object();

        // 私有构造函数，防止通过 new 关键字直接实例化对象
        private Singleton()
        {
            // 进行初始化操作
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        // 在锁内再次检查实例是否为null，避免多个线程同时通过第一个检查
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
    //在单例模式的实现中，进行两次判断是为了提高性能和避免不必要的同步开销。
    //第一次判断 instance == null 是为了避免不必要的锁定。当多个线程同时到达这个判断时，只有第一个线程会进入锁定的代码块，其他线程会被阻塞。如果没有这个判断，所有线程都会进入锁定的代码块，造成性能上的损失。
    //第二次判断 instance == null 是为了在获得锁之后再次检查实例是否为 null。这是因为在多线程环境下，可能会出现多个线程都通过了第一次判断，然后竞争锁定并进入锁定的代码块。如果没有这个第二次判断，当第一个线程创建了实例并退出锁定时，第二个线程也会创建实例，这违背了单例模式的定义。
    //通过这两次判断，可以在保证线程安全的前提下，尽可能地避免对锁的竞争和开销，提高了单例模式的性能。
}
