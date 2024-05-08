using ChainOfRespProject.Models;

namespace ChainOfRespProject.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NewxtApprover;
        public void SetNextApprover(Employee superVisior)
        {
            this.NewxtApprover = superVisior;
        }

        public abstract void ProcessRequest(CustomerProcessViewModel model);
    }
}
