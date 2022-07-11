using System;

namespace TravUpApi.Api.Models
{
    public class BaseModelOutput
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
