using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMSPlus.Domain.Entities;

public class CommentEntity : BaseEntity
{
    public string UserName { get; set; } = null!;
    public string CommentText { get; set; } = null!;
    public int TopicEntityId { get; set; }
    public TopicEntity TopicEntity { get; set; } = null!;
}
