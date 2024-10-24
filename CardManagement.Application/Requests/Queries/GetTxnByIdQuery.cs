using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CardManagement.Application.DTOs;
using CardManagement.Domain.Entity;
using CardManagement.Infrastructure.Data;
using MediatR;

namespace CardManagement.Application.Requests.Queries
{
    public class GetTxnByIdQuery : IRequest<TransactionDTO>
    {
        public int Id { get; set; }
    }

    public class GetTxnByIdQueryHandler : IRequestHandler<GetTxnByIdQuery, TransactionDTO>
    {
        private readonly CardManagementContext _context;

        public GetTxnByIdQueryHandler(CardManagementContext context)
        {
            _context = context; 
        }
        public async Task<TransactionDTO> Handle(GetTxnByIdQuery query, CancellationToken cancellationToken)
        {
            TransactionDTO transactionDTO = new TransactionDTO();
            Transactions requiredTransaction = _context.Transactions.FirstOrDefault(x => x.Id == query.Id);

            transactionDTO.Id = requiredTransaction.Id;
            transactionDTO.Amount = requiredTransaction.Amount;
            transactionDTO.Description = requiredTransaction.Description;
            transactionDTO.TxnType = requiredTransaction.TxnType;
            transactionDTO.AccountID = requiredTransaction.AccountID;

            return await Task.FromResult(transactionDTO);

        }
    }
}
