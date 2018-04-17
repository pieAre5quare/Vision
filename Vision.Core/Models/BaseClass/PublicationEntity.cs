using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vision.Core.Models.BaseClass
{
    public abstract class PublicationEntity<T> : Entity<T>, IPublicationEntity<T>
    {
        private PublishStatus? status;
        public PublishStatus Status
        {
            get { return status ?? PublishStatus.Draft; }
            set { status = value; }
        }

        private DateTime? publishDate;
        [DataType(DataType.DateTime)]
        public DateTime? PublishDate
        {
            get
            {
                if (!publishDate.HasValue && Status == PublishStatus.Published)
                {
                    publishDate = DateTime.UtcNow;
                }
                return publishDate;
            }
            set { publishDate = value; }
        }

        [DataType(DataType.DateTime)]
        public DateTime? ExpireDate { get; set; }
    }
}
