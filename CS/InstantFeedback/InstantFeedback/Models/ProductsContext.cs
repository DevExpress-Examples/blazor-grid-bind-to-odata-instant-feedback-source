using Microsoft.OData.Client;

namespace InstantFeedback.Models {
    public class ProductsContext : DataServiceContext {
        public ProductsContext() : base(new Uri("https://localhost:5006/odata")) {
            MergeOption = MergeOption.OverwriteChanges;
        }

        public DataServiceQuery<Product> Products => CreateQuery<Product>("Products");
    }
}
