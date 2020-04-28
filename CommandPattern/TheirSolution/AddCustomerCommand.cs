using System;
using System.Collections.Generic;
using System.Text;

namespace TheirSolution
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService service;

        public AddCustomerCommand(CustomerService customerService)
        {
            service = customerService;
        }

        public void Execute()
        {
            service.AddCustomer();
        }
    }
}
