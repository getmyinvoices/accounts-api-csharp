namespace GMI.Api.Contract.Data.Document {
  /// <summary>
  /// Used to filter documentTypes
  /// </summary>
  public enum ListDocumentsDocumentTypeFilters {
    Any,
    IncomingInvoice,
    Receipt,
    PaymentReceipt,
    ExpenseReimbursement,
    SalesInvoice,
    CreditNote,
    Statement,
    DeliveryNote,
    OrderConfirmation,
    Payroll,
    CompanyRegistrationDocument,
    Misc,
    TravelExpenses
  }
}