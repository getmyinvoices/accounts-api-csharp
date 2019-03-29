namespace GMI.Api.Contract.Data.Requests.ListDocuments {
  /// <summary>
  /// Used to filter companies in listDocuments request
  /// </summary>
  public enum ListDocumentArchivedFilters {
    OnlyNonArchived = 0,
    Any = 1,
    OnlyArchived = 2,
  }
}