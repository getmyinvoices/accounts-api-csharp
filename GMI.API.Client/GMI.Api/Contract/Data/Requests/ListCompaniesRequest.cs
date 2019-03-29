using System;
using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Requests {
  /// <summary>
  /// Request used to fetch a filtered company list
  /// </summary>
  public class ListCompaniesRequest : BaseRequest {


    /// <summary>
    /// Used to filter for status
    /// </summary>
    [JsonProperty("status_filter")]
    public ListCompaniesStates State { get; private set; }

    /// <summary>
    /// Possible values: 0 = Any, ONLINE_PORTAL = Online-Portal only, CUSTOM_COMPANY = Custom company only
    /// </summary>
    [JsonProperty("company_type_filter")]
    public string CompanyTypeFilter { get; private set; }

    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    public ListCompaniesRequest(string apiKey) : base(apiKey) {
      this.State = ListCompaniesStates.Any;
      this.CompanyTypeFilter = "0";
    }

    /// <inheritdoc />
    /// <summary>
    /// ctor with filter parameters
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    /// <param name="state"></param>
    /// <param name="companyTypeFilter">Possible values: 0 = Any, ONLINE_PORTAL = Online-Portal only, CUSTOM_COMPANY = Custom company only</param>
    public ListCompaniesRequest(string apiKey, ListCompaniesStates state, CompanyTypeFilters companyTypeFilter) : base(apiKey) {
      this.State = state;

      switch (companyTypeFilter) {
        case CompanyTypeFilters.OnlinePortal: {
            this.CompanyTypeFilter = "ONLINE_PORTAL";
            break;
          }
        case CompanyTypeFilters.CustomCompany: {
            this.CompanyTypeFilter = "CUSTOM_COMPANY";
            break;
          }
        default: {
            this.CompanyTypeFilter = "0";
            break;
          }
      }
    }
  }

  /// <summary>
  /// Used in listCompanies request to filter for company types
  /// </summary>
  public enum CompanyTypeFilters {
    Any,
    OnlinePortal,
    CustomCompany,
  }

  /// <summary>
  /// Request used to fetch a single company
  /// </summary>
  public class GetCompanyRequest : BaseRequest {
    /// <summary>
    /// ID of the company
    /// </summary>
    [JsonProperty("company_id")]
    public int CompanyId { get; private set; }

    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    /// <param name="companyId">PRIM_UID of the company.</param>
    public GetCompanyRequest(string apiKey, int companyId) : base(apiKey) {
      this.CompanyId = companyId;
    }
  }

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

  /// <summary>
  /// Used to filter companies in listDocuments request
  /// </summary>
  public enum ListDocumentCompanyFilters {
    Unassigned = -1,
    Any = 0,
  }

  /// <summary>
  /// Used to filter companies in listDocuments request
  /// </summary>
  public enum ListDocumentArchivedFilters {
    OnlyNonArchived = 0,
    Any = 1,
    OnlyArchived = 2,
  }

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

  /// <summary>
  /// Request used to fetch a single document
  /// </summary>
  public class GetDocumentRequest : BaseRequest {
    /// <summary>
    /// PRIM_UID of the document.. Example:"28714"
    /// </summary>
    [JsonProperty("document_prim_uid")]
    public int PrimUidStartFilter { get; private set; }

    /// <summary>
    /// Set to true if you want to receive line items as well
    /// </summary>
    [JsonProperty("load_line_items")]
    public bool LoadLineItems { get; private set; }

    /// <summary>
    /// Set to true if you want to receive readable text from document
    /// </summary>
    [JsonProperty("readable_text")]
    public bool GetReadableText { get; private set; }
  }
}