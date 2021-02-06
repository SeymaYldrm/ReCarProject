using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brands :IEntity
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
