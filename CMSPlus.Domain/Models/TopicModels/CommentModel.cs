namespace CMSPlus.Domain.Models.TopicModels;

public class CommentModel : BaseTopicModel
{
    public CommentModel()
    {
        UpdatedOnUtc = CreatedOnUtc = DateTime.UtcNow;
    }
    public int Id { get; set; }
    public string UserName { get; set; }
    public string CommentText { get; set; }
    public string TopicId { get; set; }
    public DateTime? CreatedOnUtc { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
}
