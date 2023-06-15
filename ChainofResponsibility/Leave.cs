namespace ChainofResponsibility
{
    // 抽象处理者
    public abstract class LeaveHandler
    {
        protected LeaveHandler NextHandler;

        public void SetNextHandler(LeaveHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract void HandleRequest(LeaveRequest request);
    }

    // 具体处理者：主管
    public class Supervisor : LeaveHandler
    {
        public override void HandleRequest(LeaveRequest request)
        {
            if (request.Days <= 2)
            {
                Console.WriteLine($"Leave request approved by Supervisor for {request.Days} days.");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
        }
    }

    // 具体处理者：经理
    public class Manager : LeaveHandler
    {
        public override void HandleRequest(LeaveRequest request)
        {
            if (request.Days <= 5)
            {
                Console.WriteLine($"Leave request approved by Manager for {request.Days} days.");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
        }
    }

    // 具体处理者：人事部
    public class HR : LeaveHandler
    {
        public override void HandleRequest(LeaveRequest request)
        {
            if (request.Days <= 7)
            {
                Console.WriteLine($"Leave request approved by HR for {request.Days} days.");
            }
            else
            {
                Console.WriteLine($"Leave request rejected for {request.Days} days.");
            }
        }
    }

    // 请求类
    public class LeaveRequest
    {
        public int Days { get; set; }

        public LeaveRequest(int days)
        {
            Days = days;
        }
    }

    // 审批请求类
    public class ApprovalRequest
    {
        public string Requester { get; set; }
        public decimal Amount { get; set; }
    }

    // 审批处理器接口
    public interface IApprovalHandler
    {
        void SetNextHandler(IApprovalHandler handler);
        void HandleRequest(ApprovalRequest request);
    }

    // 抽象审批处理器
    public abstract class AbstractApprovalHandler : IApprovalHandler
    {
        protected IApprovalHandler NextHandler;

        public void SetNextHandler(IApprovalHandler handler)
        {
            NextHandler = handler;
        }

        public abstract void HandleRequest(ApprovalRequest request);
    }

    // 经理审批处理器
    public class ManagerApprovalHandler : AbstractApprovalHandler
    {
        public override void HandleRequest(ApprovalRequest request)
        {
            if (request.Amount <= 1000)
            {
                Console.WriteLine($"Manager approved the request from {request.Requester}");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine($"Request exceeds the approval limit and cannot be approved.");
            }
        }
    }

    // 主管审批处理器
    public class DirectorApprovalHandler : AbstractApprovalHandler
    {
        public override void HandleRequest(ApprovalRequest request)
        {
            if (request.Amount <= 5000)
            {
                Console.WriteLine($"Director approved the request from {request.Requester}");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine($"Request exceeds the approval limit and cannot be approved.");
            }
        }
    }

    // CEO审批处理器
    public class CEOApprovalHandler : AbstractApprovalHandler
    {
        public override void HandleRequest(ApprovalRequest request)
        {
            if (request.Amount <= 10000)
            {
                Console.WriteLine($"CEO approved the request from {request.Requester}");
            }
            else
            {
                Console.WriteLine($"Request exceeds the approval limit and cannot be approved.");
            }
        }
    }
}
