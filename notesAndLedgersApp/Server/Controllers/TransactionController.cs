using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using notesAndLedgersApp.Shared;
using notesAndLedgersApp.Shared.Enums;

namespace notesAndLedgersApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        List<Transaction> transactions = new List<Transaction>
        {
            new Transaction
            {
                Id = 1,
                Amount = 200.0f,
                Type = TransactionType.Deposit
            },
            new Transaction
            {
                Id =  2,
                Amount = 124.75f,
                Type = TransactionType.Withdrawl
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetTransactions()
        {
            return Ok(transactions[0]);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransaction(Transaction newTransaction)
        {
            return Ok(new Transaction { Id = 0, Amount = 500, Type = TransactionType.Withdrawl });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTransaction(int id)
        {
            return Ok($"Transaction {id} updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransaction(int id)
        {
            return Ok($"Transaction {id} deleted");
        }
    }
}
