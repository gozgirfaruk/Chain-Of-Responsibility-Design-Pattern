using ChainOfRespProject.DAL;
using ChainOfRespProject.Models;

namespace ChainOfRespProject.ChainOfResponsibility
{
    public class Menager : Employee
    {
        private readonly Context _context;

        public Menager(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Şube Müdürü";
                customerProcess.Description = "İstenen tutar müşteriye şube müdürü tarafından ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Şube Müdürü";
                customerProcess.Description = "Ödeme şube müdürü tarafından yapılamadı ve işlem Bölge Müdürüne aktarıldı.";
                _context.SaveChanges();
                NextApprover.ProcessRequest(model);
            }
        }
    }
}
