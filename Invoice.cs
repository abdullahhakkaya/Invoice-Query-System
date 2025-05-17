

namespace InvoiceQuerySystem
{
    class Invoice
    {
        public int PartNumber { get; set; }
        public required string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
