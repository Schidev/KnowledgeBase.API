namespace KnowledgeBase.WebAPI.Models.Dictionary.Languages
{
    public class CreateLanguageModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = String.Empty;
        public string Code { get; set; } = String.Empty;
    }
}