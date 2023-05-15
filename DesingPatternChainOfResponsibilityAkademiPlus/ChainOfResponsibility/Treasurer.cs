﻿using DesingPatternChainOfResponsibilityAkademiPlus.DAL;
using DesingPatternChainOfResponsibilityAkademiPlus.Models;

namespace DesingPatternChainOfResponsibilityAkademiPlus.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if(req.Amount <= 80000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Gişe Memuru Ali Yıldırım";
                customerProcess.Description = "Müşterinin talep ettiği tutar müşteriye gişe memuru tarafından ödenmiştir.";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.CustomerName = req.CustomerName;
                customerProcess.CustomerSurname = req.CustomerSurname;
                customerProcess.EmployeeName = "Gişe Memuru Ali Yıldırım";
                customerProcess.Description = "Müşterinin talep ettiği tutar Gişe Memuru tarafından ödenemedi, işlem Şube Müdür Yardımcısına aktarıldı.";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
