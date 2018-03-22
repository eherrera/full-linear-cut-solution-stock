namespace FullLinearCutSolution.Stock.Model
{
    public class OrderDocumentItem
    {
        public int Id { get; set; }
        public decimal Measurement { get; set; }
        public decimal Diameter { get; set; }
        public int Units { get; set; }
        public string Reference { get; set; }
    }
}
