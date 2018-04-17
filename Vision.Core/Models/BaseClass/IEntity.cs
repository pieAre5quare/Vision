using System;
using System.Collections.Generic;
using System.Text;

namespace Vision.Core.Models.BaseClass
{
    //this is a template for creating view models
    public interface IModifiableEntity
    {
        string Name { get; set; }
    }

    public interface IEntity : IModifiableEntity
    {
        object Id { get; }
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }

    }

    public interface IEntity<T> : IEntity
    {
        new T Id { get; set; }
    }
}
