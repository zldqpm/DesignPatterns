using System.Collections;

namespace Iterator
{
    // 抽象迭代器接口
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

    // 具体迭代器实现
    public class ConcreteIterator : IIterator
    {
        private ArrayList _collection;
        private int _currentIndex = 0;

        public ConcreteIterator(ArrayList collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _currentIndex < _collection.Count;
        }

        public object Next()
        {
            object currentItem = _collection[_currentIndex];
            _currentIndex++;
            return currentItem;
        }
    }

    // 抽象聚合对象接口
    public interface IAggregate
    {
        IIterator CreateIterator();
    }

    // 具体聚合对象实现
    public class ConcreteAggregate : IAggregate
    {
        private ArrayList _collection;

        public ConcreteAggregate()
        {
            _collection = new ArrayList();
        }

        public void AddItem(object item)
        {
            _collection.Add(item);
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(_collection);
        }
    }
}
