﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.ViewModels
{
    public class ParameterVM
    {
        public string Name { get; set; }
        public Int32 Value { get; set; }


        public ParameterVM() { }

        public ParameterVM(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        public void Update(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
