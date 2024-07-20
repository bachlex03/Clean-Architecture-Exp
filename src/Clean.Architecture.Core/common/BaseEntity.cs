using Clean.Architecture.Core.interfaces;

namespace Clean.Architecture.Core.common
{
    public class BaseEntity<TId> : IAuditable, ISoftDeletable
    {
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DeletedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DeletedByUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}