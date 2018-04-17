using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vision.Core.Models.BaseClass
{
    public enum PublishStatus
    {
        [Display(Name = "Draft")]
        Draft,
        [Display(Name = "Pending Review")]
        PendingReview,
        [Display(Name = "Published")]
        Published
    }

    public interface IModifiablePublicationEntity : IModifiableEntity
    {
        PublishStatus Status { get; set; }
        DateTime? PublishDate { get; set; }
        DateTime? ExpireDate { get; set; }
    }

    public interface IPublicationEntity : IModifiablePublicationEntity, IEntity
    {
    }

    public interface IPublicationEntity<T> : IPublicationEntity, IEntity<T>
    {
    }
}
