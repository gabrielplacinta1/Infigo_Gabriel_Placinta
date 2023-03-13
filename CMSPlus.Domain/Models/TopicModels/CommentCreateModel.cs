namespace CMSPlus.Domain.Models.TopicModels;

public class CommentCreateModel : BaseTopicModel
{
    public string UserName { get; set; }
    public string CommentText { get; set; }
    public int TopicEntityId { get; set; }
}