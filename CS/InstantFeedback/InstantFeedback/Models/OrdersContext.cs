using Microsoft.OData.Client;

namespace InstantFeedback.Models {
    public class OrdersContext : DataServiceContext {
        public OrdersContext() : base(new Uri("https://localhost:5006/odata")) {
            MergeOption = MergeOption.OverwriteChanges;
        }

        public DataServiceQuery<Order> Orders => CreateQuery<Order>("Orders");
    }
}
