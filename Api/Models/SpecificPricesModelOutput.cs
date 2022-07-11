using System.Collections.Generic;

namespace TravUpApi.Api.Models
{
    public class SpecificPricesModelOutput
    {
        public CustomerModelOutput Customer { get; set; }
        public IEnumerable<ProductsModelOutput> Products { get; set; }
    }
}
