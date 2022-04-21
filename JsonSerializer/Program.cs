using JsonSerializer;

var options = new System.Text.Json.JsonSerializerOptions() {
    PropertyNameCaseInsensitive = true,
    WriteIndented = true
};

Wrapper wrapper = new() {
    TransactionResponse = new() {
        StatusCode = 200,
        HasError = false,
        StatusMessage = "Event Message(s) Received",
        ErrorMessage = null,
        HttpStatusCode = 0,
        SubmittedTransactions = new List<Transaction>() {
            new Transaction() {
                ConfirmationNumber = "something"
            }
        },
        ErrorCode = null,
        Correlation = null,
        State = null

    }
};
// serialize instance to json
var jsonTr = System.Text.Json.JsonSerializer.Serialize<Wrapper>(wrapper, options);

// deserialize json back to customer instance
var tr = System.Text.Json.JsonSerializer.Deserialize<Wrapper>(jsonTr);

Console.WriteLine(jsonTr);