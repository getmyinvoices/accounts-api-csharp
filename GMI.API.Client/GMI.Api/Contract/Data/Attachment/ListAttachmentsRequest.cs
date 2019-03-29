using GMI.Api.Contract.Data.Requests;
using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Attachment {
  /// <summary>
  /// Used to fetch a list of attachments
  /// </summary>
  public class ListAttachmentsRequest : BaseRequest {

    /// <summary>
    /// PRIM_UID of the invoice. Example:"28715"
    /// </summary>
    [JsonProperty("invoice_id")]
    public int DocumentId { get; private set; }

    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="apiKey">API key of account</param>
    /// <param name="documentId">PRIM_UID of the invoice.</param>
    public ListAttachmentsRequest(string apiKey, int documentId) : base(apiKey) {
      this.DocumentId = documentId;
    }
  }
}