using DesingPatternChainOfResponsibilityAkademiPlus.DAL;
using DesingPatternChainOfResponsibilityAkademiPlus.Models;

namespace DesingPatternChainOfResponsibilityAkademiPlus.ChainOfResponsibility
{
    public class ManagerAsistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if(req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı Zeynep Çiçek";
                customerProcess.Description = "Müşterinin talep ettiği tutar Şube Müdür Yardımcısı tarafından ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı Zeynep Çiçek";
                customerProcess.Description = "Müşterinin talep ettiği tutar Şube Müdür Yardımcısı tarafından ödenemedi, işlem Şube Müdürüne aktarıldı.";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
