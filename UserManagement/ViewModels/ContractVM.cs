﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.ViewModels
{
    public class ContractVM
    {
        public DateTime? JoinDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StatusContract { get; set; }
        public int EmployeeId { get; set; }

        public ContractVM() { }

        public ContractVM(DateTime? joindate, DateTime? enddate, string statuscontract, int employeeid)
        {
            this.JoinDate = joindate;
            this.EndDate = enddate;
            this.StatusContract = statuscontract;
            this.EmployeeId = employeeid;
        }

        public void Update(DateTime? joindate, DateTime? enddate, string statuscontract, int employeeid)
        {
            this.JoinDate = joindate;
            this.EndDate = enddate;
            this.StatusContract = statuscontract;
            this.EmployeeId = employeeid;
        }
    }
}
