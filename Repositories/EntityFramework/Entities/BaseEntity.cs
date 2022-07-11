using System;

namespace TravUpApi.Repositories.EntityFramework.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
