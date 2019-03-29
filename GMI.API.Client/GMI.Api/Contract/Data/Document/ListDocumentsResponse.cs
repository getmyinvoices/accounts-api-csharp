using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Document {
  public class ListDocumentsResponse {

    [JsonProperty("total_count")] public int TotalCount { get; set; }
    [JsonProperty("start")] public int Start { get; set; }
    [JsonProperty("offset")] public int Offset { get; set; }
    [JsonProperty("records")] public Records Records { get; set; }

    /// <summary>
    /// ctor
    /// </summary>
    public ListDocumentsResponse() {
      
    }
  }

  public class Records {
    [JsonProperty("prim_uid")] public int PrimUid { get; set; }
    [JsonProperty("company_uid")] public int CompanyUid { get; set; }
    [JsonProperty("document_type")] public string DocumentType { get; set; }
    [JsonProperty("document_number")] public string DocumentNumber { get; set; }
    [JsonProperty("document_date")] public string DocumentDate { get; set; }
    [JsonProperty("document_due_date")] public string DocumentDueDate { get; set; }
    [JsonProperty("net_amount")] public double NetAmount { get; set; }
    [JsonProperty("vat")] public double Vat { get; set; }
    [JsonProperty("gross_amount")] public double GrossAmount { get; set; }
    [JsonProperty("currency")] public string Currency { get; set; }
    [JsonProperty("is_archived")] public int IsArchived { get; set; }
    [JsonProperty("is_ocr_completed")] public int IsOcrCompleted { get; set; }
    [JsonProperty("tags")] public string Tags { get; set; }
    [JsonProperty("note")] public string Note { get; set; }
    [JsonProperty("source")] public string Source { get; set; }
    [JsonProperty("filename")] public string Filename { get; set; }
    [JsonProperty("file_size")] public string FileSize { get; set; }
    [JsonProperty("payment_status")] public string PaymentStatus { get; set; }
    [JsonProperty("payment_method")] public string PaymentMethod { get; set; }
    [JsonProperty("payment_details")] public PaymentDetails PaymentDetails { get; set; }

    /// <summary>
    /// ctor
    /// </summary>
    public Records() {
      
    }
  }

  public class PaymentDetails {
    [JsonProperty("sender_email")] public string SenderEmail { get; set; }
    [JsonProperty("recipient_email")] public string RecipientEmail { get; set; }
    [JsonProperty("transaction_id")] public string TransactionId { get; set; }
    [JsonProperty("card_number")] public string CardNumber { get; set; }
    [JsonProperty("sepa_creditor_id")] public string SepaCreditorId { get; set; }
    [JsonProperty("sepa_mandate_reference")] public string SepaMandateReference { get; set; }
    [JsonProperty("iban")] public string Iban { get; set; }
    [JsonProperty("bic")] public string Bic { get; set; }
    [JsonProperty("account_holder_name")] public string AccountHolderName { get; set; }
    [JsonProperty("account_number")] public string AccountNumber { get; set; }
    [JsonProperty("bank_name")] public string BankName { get; set; }
    [JsonProperty("bank_address")] public string BankAddress { get; set; }
    [JsonProperty("sort_code")] public string SortCode { get; set; }
    [JsonProperty("routing_number")] public string RoutingNumber { get; set; }
    [JsonProperty("ifsc_code")] public string IfscCode { get; set; }
    [JsonProperty("routing_code")] public string RoutingCode { get; set; }
    [JsonProperty("cash_discount_date")] public string CashDiscountDate { get; set; }
    [JsonProperty("cash_discount_value")] public double CashDiscountValue { get; set; }

    /// <summary>
    /// ctor
    /// </summary>
    public PaymentDetails() {
      
    }
  }
}
