using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ViewModel
{
    public class BaseViewModel
    {

        public BaseViewModel(Entity entity)
        {
            Id = entity.Id;
            Created = entity.Created;
            CreatedBy = entity.CreatedBy;
            Modified = entity.Modified;
            ModifiedBy = entity.ModifiedBy;
            IsActive = entity.IsActive;
            IsDeleted = entity.IsDeleted;
        }


        public string Id { get; }
        public DateTime? Created { get; }
        public string CreatedBy { get; }
        public DateTime? Modified { get; }
        public string ModifiedBy { get; }
        public bool IsActive { get; }
        public bool IsDeleted { get; }
    }
}
