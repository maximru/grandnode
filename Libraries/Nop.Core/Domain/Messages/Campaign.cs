﻿using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Nop.Core.Domain.Messages
{
    /// <summary>
    /// Represents a campaign
    /// </summary>
    [BsonIgnoreExtraElements]
    public partial class Campaign : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the store identifier  which subscribers it will be sent to; set 0 for all newsletter subscribers
        /// </summary>
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }
    }
}
