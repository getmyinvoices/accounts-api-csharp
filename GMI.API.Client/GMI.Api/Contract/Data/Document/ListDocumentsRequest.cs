using System;
using GMI.Api.Contract.Data.Requests;
using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Document {
  /// <summary>
  /// Request used to fetch document list
  /// </summary>
  public class ListDocumentsRequest : BaseRequest {
    /// <summary>
    /// Filter by company
    /// </summary>
    [JsonProperty("company_filter")]
    public ListDocumentCompanyFilters CompanyFilter { get; private set; }

    /// <summary>
    /// Filter by archivedState
    /// </summary>
    [JsonProperty("archived_filter")]
    public ListDocumentArchivedFilters ArchivedFilter { get; private set; }

    /// <summary>
    /// Filter by documentType
    /// </summary>
    [JsonProperty("document_type_filter")]
    public string DocumentTypeFilter { get; private set; }

    /// <summary>
    /// Filter by document number. Example:"144-23232"
    /// </summary>
    [JsonProperty("document_number_filter")]
    public string DocumentNumberFilter { get; private set; }

    /// <summary>
    /// Filter by document note. Example:"Hosting"
    /// </summary>
    [JsonProperty("note_filter")]
    public string NoteFilter { get; private set; }

    /// <summary>
    /// Filter by start date. Example:"2017-08-18"
    /// </summary>
    [JsonProperty("start_date_filter")]
    public string StartDateFilter { get; private set; }

    /// <summary>
    /// Filter by end date. Example:"2027-08-18"
    /// </summary>
    [JsonProperty("end_date_filter")]
    public string EndDate { get; private set; }

    /// <summary>
    /// Comma separated list of prim_uids that should not be in the results. Example:"28715,28716"
    /// </summary>
    [JsonProperty("prim_uid_exclusion_filter")]
    public string IdExclusionFilter { get; private set; }

    /// <summary>
    /// prim_uid that can be used to limit result to only higher prim_uids. Example:"28714"
    /// </summary>
    [JsonProperty("prim_uid_start_filter")]
    public int PrimUidStartFilter { get; private set; }

    /// <summary>
    /// Limit result to documents modified or created after given date.. Example:"2027-08-18 18:12:50"
    /// </summary>
    [JsonProperty("updated_or_new_since_filter")]
    public string UpdateOrNewSinceDateFilter { get; private set; }

    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    public ListDocumentsRequest(string apiKey) : base(apiKey) {
    }

    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    /// <param name="companyFilter">Filter by company</param>
    /// <param name="archivedFilter">Filter archived documents</param>
    /// <param name="documentTypeFilter">Document type</param>
    /// <param name="documentNumberFilter">Filter by document number.</param>
    /// <param name="noteFilter">Filter by note.</param>
    /// <param name="startDateFilter">Start document date filter</param>
    /// <param name="endDate">End document date filter</param>
    /// <param name="idExclusionFilter">Comma separated list of prim_uids that should not be in the results</param>
    /// <param name="primUidStartFilter">prim_uid that can be used to limit result to only higher prim_uids</param>
    /// <param name="updateOrNewSinceDateFilter">Limit result to documents modified or created after given date.</param>
    public ListDocumentsRequest(string apiKey, ListDocumentCompanyFilters companyFilter = ListDocumentCompanyFilters.Any, ListDocumentArchivedFilters archivedFilter = ListDocumentArchivedFilters.Any, ListDocumentsDocumentTypeFilters documentTypeFilter = ListDocumentsDocumentTypeFilters.Any, string documentNumberFilter = null, string noteFilter = null, string startDateFilter = null, string endDate = null, string idExclusionFilter = null, int primUidStartFilter = 0, string updateOrNewSinceDateFilter = null) : base(apiKey) {
      this.CompanyFilter = companyFilter;
      this.ArchivedFilter = archivedFilter;
      this.DocumentNumberFilter = documentNumberFilter;
      this.NoteFilter = noteFilter;
      this.StartDateFilter = startDateFilter;
      this.EndDate = endDate;
      this.IdExclusionFilter = idExclusionFilter;
      this.PrimUidStartFilter = primUidStartFilter;
      this.UpdateOrNewSinceDateFilter = updateOrNewSinceDateFilter;

      switch (documentTypeFilter) {
        case ListDocumentsDocumentTypeFilters.Any:
          this.DocumentTypeFilter = null;
          break;
        case ListDocumentsDocumentTypeFilters.IncomingInvoice:
          this.DocumentTypeFilter = "INCOMING_INVOICE";
          break;
        case ListDocumentsDocumentTypeFilters.Receipt:
          this.DocumentTypeFilter = "RECEIPT";
          break;
        case ListDocumentsDocumentTypeFilters.PaymentReceipt:
          this.DocumentTypeFilter = "PAYMENT_RECEIPT";
          break;
        case ListDocumentsDocumentTypeFilters.ExpenseReimbursement:
          this.DocumentTypeFilter = "EXPENSE_REIMBURSEMENT";
          break;
        case ListDocumentsDocumentTypeFilters.SalesInvoice:
          this.DocumentTypeFilter = "SALES_INVOICE";
          break;
        case ListDocumentsDocumentTypeFilters.CreditNote:
          this.DocumentTypeFilter = "CREDIT_NOTE";
          break;
        case ListDocumentsDocumentTypeFilters.Statement:
          this.DocumentTypeFilter = "STATEMENT";
          break;
        case ListDocumentsDocumentTypeFilters.DeliveryNote:
          this.DocumentTypeFilter = "DELIVERY_NOTE";
          break;
        case ListDocumentsDocumentTypeFilters.OrderConfirmation:
          this.DocumentTypeFilter = "ORDER_CONFIRMATION";
          break;
        case ListDocumentsDocumentTypeFilters.Payroll:
          this.DocumentTypeFilter = "PAYROLL";
          break;
        case ListDocumentsDocumentTypeFilters.CompanyRegistrationDocument:
          this.DocumentTypeFilter = "COMPANY_REGISTRATION_DOCUMENT";
          break;
        case ListDocumentsDocumentTypeFilters.Misc:
          this.DocumentTypeFilter = "MISC";
          break;
        case ListDocumentsDocumentTypeFilters.TravelExpenses:
          this.DocumentTypeFilter = "TRAVEL_EXPENSES";
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof(documentTypeFilter), documentTypeFilter, null);
      }
    }
  }
}