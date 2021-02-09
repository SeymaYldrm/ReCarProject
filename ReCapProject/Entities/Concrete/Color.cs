using Entities.Abstract;

namespace Entities.Concrete
{
    public class Colors : IEntity
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }
    }
}
