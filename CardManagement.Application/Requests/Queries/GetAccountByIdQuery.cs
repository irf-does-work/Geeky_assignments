using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Application.DTOs;
using CardManagement.Domain.Entity;
using CardManagement.Infrastructure.Data;
using MediatR;

namespace CardManagement.Application.Requests.Queries
{
    public class GetAccountByIdQuery :IRequest<AccountsDTO>
    {
        public int Id { get; set; }

    }

    public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountByIdQuery, AccountsDTO>
    {
        private readonly CardManagementContext _context;

        public GetAccountByIdQueryHandler(CardManagementContext context)
        {
            _context = context;
        }

        public async Task<AccountsDTO> Handle(GetAccountByIdQuery query,CancellationToken cancellationToken)
        {
            Accounts requiredAccount = _context.Accounts.FirstOrDefault(x => x.Id == query.Id);

            AccountsDTO requiredAccountDTO = new AccountsDTO();
            requiredAccountDTO.Number = requiredAccount.Number;
            requiredAccountDTO.AccountType = requiredAccount.AccountType;
            requiredAccountDTO.Balance = requiredAccount.Balance;
            requiredAccountDTO.CustomerId = requiredAccount.CustomerId;

            return await Task.FromResult(requiredAccountDTO);
        }

    }

}
