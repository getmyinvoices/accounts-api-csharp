using GMI.Api.Contract.Data.Requests;
using Newtonsoft.Json;

namespace GMI.Api.Contract.Data.Document {
  /// <summary>
  /// Request used to fetch a single document
  /// </summary>
  public class GetDocumentRequest : BaseRequest {
    /// <summary>
    /// PRIM_UID of the document.. Example:"28714"
    /// </summary>
    [JsonProperty("document_prim_uid")]
    public int DocumentId { get; private set; }

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

    /// <inheritdoc />
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="documentId">PRIM_UID of the document.</param>
    /// <param name="loadLineItems">Set to true if you want to receive line items as well</param>
    /// <param name="readableText">Set to true if you want to receive readable text from document</param>
    public GetDocumentRequest(int documentId, bool loadLineItems, bool readableText) {
      this.DocumentId = documentId;
      this.LoadLineItems = loadLineItems;
      this.GetReadableText = readableText;
    }
  }
}