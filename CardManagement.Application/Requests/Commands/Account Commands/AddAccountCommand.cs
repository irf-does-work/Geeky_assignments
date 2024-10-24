using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Application.Requests.Commands.AccountCommands;
using CardManagement.Domain.Entity;
using CardManagement.Infrastructure.Data;
using MediatR;

namespace CardManagement.Application.Requests.Commands.AccountCommands
{
    public class AddAccountCommand : IRequest<int>
    {
        //public int Id { get; set; }
        public string Number { get; set; }
        public double Balance { get; set; }

        public Accounts.accountType AccountType { get; set; }
        public int CustomerId { get; set; }
    }
}

public class AddAccountCommandHandler : IRequestHandler<AddAccountCommand, int>
{
    private readonly CardManagementContext _context;

    public AddAccountCommandHandler(CardManagementContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(AddAccountCommand request, CancellationToken cancellationToken)
    {
        Accounts acc = new Accounts();
        acc.Number = request.Number;
        acc.AccountType = request.AccountType;
        acc.Balance = request.Balance;

        Customers customers = _context.Customers.FirstOrDefault(x => x.Id == request.CustomerId);
        acc.Customer = customers;
        _context.Accounts.Add(acc);
        return await _context.SaveChangesAsync();
    }
}
