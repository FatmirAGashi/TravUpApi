using System;

namespace TravUpApi.Domain
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
