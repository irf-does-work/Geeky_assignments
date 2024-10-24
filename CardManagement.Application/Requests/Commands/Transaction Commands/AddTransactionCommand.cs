using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardManagement.Domain.Entity;
using CardManagement.Infrastructure.Data;
using MediatR;

namespace CardManagement.Application.Requests.Commands.Transaction_Commands
{
    public class AddTransactionCommand :IRequest<int>
    {
        //public int Id { get; set; }
        //public Accounts Account { get; set; }
        public int AccountID { get; set; }
        public double Amount { get; set; }
        public CardManagement.Domain.Entity.Transactions.txnType TxnType { get; set; }
        public string Description { get; set; }

    }

    public class AddtTransactionCommandHandler : IRequestHandler<AddTransactionCommand, int>
    {
        private readonly CardManagementContext _context;

        public AddtTransactionCommandHandler(CardManagementContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(AddTransactionCommand request, CancellationToken cancellationToken)
        {
            Transactions txn = new Transactions();
            txn.Amount = request.Amount;
            txn.Date = DateTime.Now;
            txn.Description = request.Description;
            txn.TxnType = request.TxnType;
            txn.AccountID = request.AccountID;


            if (request.TxnType == CardManagement.Domain.Entity.Transactions.txnType.Deposit)  //Deposit Logic
            {
                _context.Accounts.FirstOrDefault(x => x.Id == request.AccountID).Balance += request.Amount;
            }

            else
            {
                _context.Accounts.FirstOrDefault(x => x.Id == request.AccountID).Balance -= request.Amount;
            }

            _context.Transactions.Add(txn);
            return await _context.SaveChangesAsync();
        }
    }

}
