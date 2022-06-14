using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Mc2.CrudTest.Presentation.Domain.Entities
{
    public interface IEntity
    {                                     
    }

    public abstract class BaseEntity<TKey> : IEntity
    { 
        [Required]
        public TKey Id { get; set; }
                                        
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}