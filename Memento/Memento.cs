namespace Memento
{
    // 备忘录类
    public class Memento
    {
        public string State { get; }

        public Memento(string state)
        {
            State = state;
        }
    }

    // 发起人类
    public class Originator
    {
        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void RestoreMemento(Memento memento)
        {
            _state = memento.State;
        }
    }

    // 管理者类
    public class Caretaker
    {
        public Memento Memento { get; set; }
    }


}
