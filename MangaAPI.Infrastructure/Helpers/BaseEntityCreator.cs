using MangaAPI.Domain.Common;

namespace MangaAPI.Infrastructure.Helpers
{
    public class BaseEntityCreator
    {
        public static void Create(BaseEntity entity)
        {
            if (entity.Id == null || entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();
            if (entity.CreatedAt == null || entity.CreatedAt == DateTime.MinValue)
                entity.CreatedAt = DateTime.Now.ToUniversalTime();
            entity.IsDeleted = false;
        }
    }
}
