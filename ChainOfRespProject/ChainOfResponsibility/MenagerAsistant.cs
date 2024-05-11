using ChainOfRespProject.DAL;
using ChainOfRespProject.Models;

namespace ChainOfRespProject.ChainOfResponsibility
{
    public class MenagerAsistant : Employee
    {
        private readonly Context _context;

        public MenagerAsistant(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerProcessViewModel model)
        {
            if (model.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcıcı";
                customerProcess.Description = "İstenen tutar müşteriye şube müdür yardımcısı tarafından ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
            }
            else if(NextApprover!=null)
            {
                CustomerProcess customerProcess=new CustomerProcess();
                customerProcess.Amount = model.Amount;
                customerProcess.Name = model.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı";
                customerProcess.Description = "Ödeme şube müdür yardımcısı tarafından yapılamadı ve işlem Şube Müdürüne aktarıldı.";
                _context.SaveChanges();
                NextApprover.ProcessRequest(model);
            }
        }
    }
}
