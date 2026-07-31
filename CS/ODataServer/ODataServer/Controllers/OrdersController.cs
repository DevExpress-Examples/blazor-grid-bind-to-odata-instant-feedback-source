using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using ODataServer.Models;

namespace ODataServer.Controllers {
    public class OrdersController : ODataController {
        private NorthwindContext _context;

        public OrdersController(NorthwindContext context) {
            _context = context;
        }

        [EnableQuery]
        public ActionResult<IEnumerable<Order>> Get() {
            return Ok(_context.Orders);
        }

        public async Task<ActionResult> Post([FromBody] Order order) {
            order.OrderId = _context.Orders.Count() > 0
                ? _context.Orders.Max(p => p.OrderId) + 1
                : 1;
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return Created(order);
        }

        public async Task<ActionResult> Patch(int key, [FromBody] Delta<Order> delta) {
            var order = _context.Orders.FirstOrDefault(p => p.OrderId == key);
            if(order == null)
                return NotFound();
            delta.Patch(order);
            _context.Update(order);
            await _context.SaveChangesAsync();
            return Updated(order);
        }

        public async Task<ActionResult> Put(int key, [FromBody] Order order) {
            var existing = _context.Orders.FirstOrDefault(p => p.OrderId == key);
            if(existing == null)
                return NotFound();
            _context.Update(order);
            await _context.SaveChangesAsync();
            return Updated(order);
        }

        public async Task<ActionResult> Delete(int key) {
            var order = _context.Orders.FirstOrDefault(p => p.OrderId == key);
            if(order == null)
                return NotFound();
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
