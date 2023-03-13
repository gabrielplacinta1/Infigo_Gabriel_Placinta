using CMSPlus.Domain.Entities;

namespace CMSPlus.Domain.Models.TopicModels;

public class TopicDetailsModel:BaseTopicModel
{
    public TopicDetailsModel()
    {
        UpdatedOnUtc = CreatedOnUtc = DateTime.UtcNow;
    }
    
    public int Id { get; set; }
    public string SystemName { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public CommentCreateModel CommentCreateModel { get; set; }
    public List<CommentEntity> Comments { get; set; }
    public DateTime? CreatedOnUtc { get; set; }
    public DateTime? UpdatedOnUtc { get; set; }
}