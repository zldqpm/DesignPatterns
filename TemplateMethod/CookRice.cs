namespace TemplateMethod
{
    // 煮饭抽象类
    public abstract class CookRice
    {
        // 模板方法，定义了煮饭的步骤
        public void Cook()
        {
            WashRice();
            AddWater();
            CookRiceInPot();
            Serve();
        }

        // 抽象方法，洗米
        protected abstract void WashRice();

        // 具体方法，加水
        protected void AddWater()
        {
            Console.WriteLine("加水");
        }

        // 具体方法，煮米饭
        protected void CookRiceInPot()
        {
            Console.WriteLine("在锅里煮饭");
        }

        // 抽象方法，上菜
        protected abstract void Serve();
    }

    // 煮白米饭类
    public class CookWhiteRice : CookRice
    {
        protected override void WashRice()
        {
            Console.WriteLine("洗白米饭");
        }

        protected override void Serve()
        {
            Console.WriteLine("将白米饭上菜");
        }
    }

    // 煮糯米饭类
    public class CookStickyRice : CookRice
    {
        protected override void WashRice()
        {
            Console.WriteLine("洗糯米饭");
        }

        protected override void Serve()
        {
            Console.WriteLine("将糯米饭上菜");
        }
    }
}
