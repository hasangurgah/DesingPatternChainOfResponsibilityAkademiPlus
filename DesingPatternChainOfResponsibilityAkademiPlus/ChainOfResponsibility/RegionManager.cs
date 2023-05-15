using DesingPatternChainOfResponsibilityAkademiPlus.DAL;
using DesingPatternChainOfResponsibilityAkademiPlus.Models;

namespace DesingPatternChainOfResponsibilityAkademiPlus.ChainOfResponsibility
{
    public class RegionManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 350000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Bölge Müdürü Yeliz Güneş";
                customerProcess.Description = "Müşterinin talep ettiği tutar Bölge Müdürü tarafından ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Bölge Müdürü Yeliz Güneş";
                customerProcess.Description = "Müşterinin talep ettiği tutar bankanın günlük para çekme limitinin üzerinde olduğu için müşteriye ödeme yapılamadı.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
