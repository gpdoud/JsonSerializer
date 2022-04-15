using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializer
{
    public class TransactionResponse
    {
        public int StatusCode { get; set; }
        public bool HasError { get; set; }
        public string? StatusMessage { get; set; }
        public string? ErrorMessage { get; set; }
        public int HttpStatusCode { get; set; }
        public IEnumerable<Transaction>? SubmittedTransactions { get; set; }
        public string? ErrorCode { get; set; }
        public string? Correlation { get; set; }
        public string? State { get; set; }
    }
}
