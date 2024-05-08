using ChainOfRespProject.DAL;
using ChainOfRespProject.Models;

namespace ChainOfRespProject.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        private readonly Context _context;

        public Treasurer(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 80000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "ÖFG";
                customerProcess.Description = "İstenen tutar müşteriye veznedar tarafından ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else if(NewxtApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount=model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "ÖFG";
                customerProcess.Description = "Ödeme Veznedar tarafından yapılamadı. İşlem şube müdür yardımcısına gönderildi.";
                _context.CustomerProcesses.Add(customerProcess) ;
                _context.SaveChanges();
                NewxtApprover.ProcessRequest(model);
            }
        }
    }
}
