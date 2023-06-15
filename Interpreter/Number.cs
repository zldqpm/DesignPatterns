namespace Interpreter
{
    // 抽象表达式
    public interface IExpression
    {
        int Interpret();
    }

    // 终结符表达式
    public class NumberExpression : IExpression
    {
        private int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }

    // 非终结符表达式 - 加法表达式
    public class AddExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public AddExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() + _right.Interpret();
        }
    }

    // 上下文
    public class Context
    {
        public IExpression ParseExpression(string expression)
        {
            // 解析表达式并构建抽象语法树
            // 这里仅作示例，简单地将表达式解析为一个数字和一个加号的组合

            int number = int.Parse(expression.Substring(0, 1));
            IExpression left = new NumberExpression(number);
            IExpression right = new NumberExpression(int.Parse(expression.Substring(2, 1)));

            return new AddExpression(left, right);
        }
    }
}
