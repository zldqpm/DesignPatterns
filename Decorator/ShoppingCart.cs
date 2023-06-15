namespace Decorator
{
    // 购物车接口
    public interface IShoppingCart
    {
        void AddItem(string itemName, decimal price);
        decimal GetTotalPrice();
    }

    // 基础购物车实现
    public class ShoppingCart : IShoppingCart
    {
        private List<(string, decimal)> items = new List<(string, decimal)>();

        public void AddItem(string itemName, decimal price)
        {
            items.Add((itemName, price));
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = items.Sum(item => item.Item2);
            return totalPrice;
        }
    }

    // 装饰器基类
    public abstract class ShoppingCartDecorator : IShoppingCart
    {
        protected IShoppingCart shoppingCart;

        public ShoppingCartDecorator(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public virtual void AddItem(string itemName, decimal price)
        {
            shoppingCart.AddItem(itemName, price);
        }

        public virtual decimal GetTotalPrice()
        {
            return shoppingCart.GetTotalPrice();
        }
    }

    // 优惠券装饰器
    public class CouponDecorator : ShoppingCartDecorator
    {
        private decimal couponAmount;

        public CouponDecorator(IShoppingCart shoppingCart, decimal couponAmount) : base(shoppingCart)
        {
            this.couponAmount = couponAmount;
        }

        public override decimal GetTotalPrice()
        {
            decimal totalPrice = base.GetTotalPrice();
            decimal discountedPrice = totalPrice - couponAmount;
            return discountedPrice;
        }
    }

    // 礼品包装装饰器
    public class GiftWrapDecorator : ShoppingCartDecorator
    {
        public GiftWrapDecorator(IShoppingCart shoppingCart) : base(shoppingCart)
        {
        }

        public override void AddItem(string itemName, decimal price)
        {
            base.AddItem(itemName + " (Gift Wrapped)", price);
        }
    }

}
