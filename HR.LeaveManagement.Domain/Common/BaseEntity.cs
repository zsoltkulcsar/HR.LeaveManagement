namespace HR.LeaveManagement.Domain.Common
{
    public abstract class BaseEntity<T> where T : struct
    {
        public T Id { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
    }
}
