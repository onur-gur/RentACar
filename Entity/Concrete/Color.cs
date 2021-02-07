using Core.Entity;

namespace Entity.Concrete
{
    public class Color : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }

    }
}
