namespace State
{
    // 抽象状态类
    public abstract class ElevatorState
    {
        public abstract void OpenDoor();
        public abstract void CloseDoor();
        public abstract void GoUp();
        public abstract void GoDown();
    }

    // 具体状态类
    public class StopState : ElevatorState
    {
        public override void OpenDoor()
        {
            Console.WriteLine("打开电梯门");
        }

        public override void CloseDoor()
        {
            Console.WriteLine("关闭电梯门");
        }

        public override void GoUp()
        {
            Console.WriteLine("电梯上行");
        }

        public override void GoDown()
        {
            Console.WriteLine("电梯下行");
        }
    }

    public class RunState : ElevatorState
    {
        public override void OpenDoor()
        {
            Console.WriteLine("电梯运行中，无法打开门");
        }

        public override void CloseDoor()
        {
            Console.WriteLine("电梯运行中，无法关闭门");
        }

        public override void GoUp()
        {
            Console.WriteLine("电梯运行中，无法上行");
        }

        public override void GoDown()
        {
            Console.WriteLine("电梯运行中，无法下行");
        }
    }

    // 上下文类
    public class Elevator
    {
        private ElevatorState state;

        public Elevator()
        {
            // 默认状态为停止状态
            state = new StopState();
        }

        public void SetState(ElevatorState state)
        {
            this.state = state;
        }

        public void OpenDoor()
        {
            state.OpenDoor();
        }

        public void CloseDoor()
        {
            state.CloseDoor();
        }

        public void GoUp()
        {
            state.GoUp();
        }

        public void GoDown()
        {
            state.GoDown();
        }
    }
}
