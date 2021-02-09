using Entities.Abstract;

namespace Entities.Concrete
{
    public class Cars : IEntity
    {
        public int Id { get; set; }
        public int BrandID { get; set; }
        public int ColorID { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
