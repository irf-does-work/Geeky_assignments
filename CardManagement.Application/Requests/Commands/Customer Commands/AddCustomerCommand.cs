using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Domain.Entity;
using CardManagement.Infrastructure.Data;
using CardManagement.Infrastructure.Repositories;
using MediatR;

namespace CardManagement.Application.Requests.Commands.CustomerCommands
{
    public class AddCustomerCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        //public List<Accounts> Accounts { get; set; }
    }

    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, int>
    {
        private readonly ICustomerRepository customerRepository;

        public AddCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public async Task<int> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            Customers cust = new Customers();
            cust.Name = request.Name;
            cust.Address = request.Address;
            cust.Email = request.Email;

            int result = customerRepository.Add(cust);
            return await Task.FromResult(result);
        }
    }
}
