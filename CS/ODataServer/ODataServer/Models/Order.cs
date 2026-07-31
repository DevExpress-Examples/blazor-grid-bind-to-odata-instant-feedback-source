using System.ComponentModel.DataAnnotations;

namespace ODataServer.Models;

public partial class Order {
    [Key]
    public int OrderId { get; set; }

    public string ShipName { get; set; }

    public string ShipCity { get; set; }

    public string ShipCountry { get; set; }

    public double? Freight { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? ShippedDate { get; set; }
}