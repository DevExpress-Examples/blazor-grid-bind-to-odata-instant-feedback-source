using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataServer.Models;

namespace ODataServer.Controllers {
    public class ProductsController : ODataController {
        [EnableQuery]
        public ActionResult<IEnumerable<Product>> Get() {
            return Ok(SampleData.Products);
        }

        public ActionResult Post([FromBody] Product product) {
            product.Product_ID = SampleData.Products.Count > 0
                ? SampleData.Products.Max(p => p.Product_ID) + 1
                : 1;
            SampleData.Products.Add(product);
            return Created(product);
        }

        public ActionResult Patch(int key, [FromBody] Delta<Product> delta) {
            var product = SampleData.Products.FirstOrDefault(p => p.Product_ID == key);
            if(product == null)
                return NotFound();
            delta.Patch(product);
            return Updated(product);
        }

        public ActionResult Put(int key, [FromBody] Product product) {
            var existing = SampleData.Products.FirstOrDefault(p => p.Product_ID == key);
            if(existing == null)
                return NotFound();
            var index = SampleData.Products.IndexOf(existing);
            product.Product_ID = key;
            SampleData.Products[index] = product;
            return Updated(product);
        }

        public ActionResult Delete(int key) {
            var product = SampleData.Products.FirstOrDefault(p => p.Product_ID == key);
            if(product == null)
                return NotFound();
            SampleData.Products.Remove(product);
            return NoContent();
        }
    }
}
