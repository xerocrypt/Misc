// Context model code for a stored procedure that accepts startDate and endDate as nullable

namespace Metrics_Dashboard.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseEntities1 : DbContext
    {
        public DatabaseEntities1()
            : base("name=DatabaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<prMessagesProcessedByDay_Result> prMessagesProcessedByDay(Nullable<System.DateTime> startDay, Nullable<System.DateTime> endDay)
        {
            var startDayParameter = startDay.HasValue ?
                new ObjectParameter("StartDay", startDay) :
                new ObjectParameter("StartDay", typeof(System.DateTime));
    
            var endDayParameter = endDay.HasValue ?
                new ObjectParameter("EndDay", endDay) :
                new ObjectParameter("EndDay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prMessagesProcessedByDay_Result>("prMessagesProcessedByDay", startDayParameter, endDayParameter);
        }
    }
}
