﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMSPlus.Domain.Entities;

public class CommentEntity : BaseEntity
{
    public string UserName { get; set; } = null!;
    public string CommentText { get; set; } = null!;
    public int TopicId { get; set; }
    public TopicEntity Topic { get; set; } = null!;
}
