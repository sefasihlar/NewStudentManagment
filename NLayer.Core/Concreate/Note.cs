﻿using NLayer.Core.Abstract;

namespace NLayer.Core.Concreate
{
    public class Note : BaseEntity
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string? Task { get; set; }
        public bool? Favorite { get; set; }
        public int? UserId { get; set; }
    }
}
