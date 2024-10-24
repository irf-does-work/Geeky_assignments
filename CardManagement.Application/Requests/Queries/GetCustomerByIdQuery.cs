using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Application.DTOs;
using CardManagement.Domain.Entity;
using CardManagement.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CardManagement.Application.Requests.Queries
{
    public class GetCustomerByIdQuery : IRequest<CustomerDTO>
    {
        public int Id { get; set; }
    }

    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDTO>
    {
        private readonly CardManagementContext _context;

        public GetCustomerByIdQueryHandler(CardManagementContext context)
        {
            _context = context;   
        }
        public async Task<CustomerDTO> Handle(GetCustomerByIdQuery query, CancellationToken cancellationToken)
        {

            var requiredCustomer = _context.Customers.Include(x => x.Accounts).FirstOrDefault(x => x.Id == query.Id);
            CustomerDTO requiredCustomerDTO = new CustomerDTO();
            requiredCustomerDTO.Name = requiredCustomer.Name;
            requiredCustomerDTO.Address = requiredCustomer.Address;
            requiredCustomerDTO.Name = requiredCustomer.Name;

            List<AccountsDTO> accountsList = new List<AccountsDTO>();
            foreach (var acc in requiredCustomer.Accounts)
            {
                AccountsDTO accountsDTO = new AccountsDTO();
                accountsDTO.Number = acc.Number;
                accountsDTO.AccountType = acc.AccountType;
                accountsDTO.Balance = acc.Balance;
                accountsList.Add(accountsDTO);
            }
             
            requiredCustomerDTO.Accounts = accountsList;

            return await Task.FromResult(requiredCustomerDTO);
        }
    }
}
