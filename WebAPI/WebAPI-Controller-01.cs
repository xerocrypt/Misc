
//
namespace Metrics_Dashboard
{
    public class prMessagesProcessedByDay_ResultController : ApiController
    {
        private DatabaseEntities1 db = new DatabaseEntities1();

        // Web API controller for the Pathology metrics and all messages processed
        // GET: api/prMessagesProcessedByDay_Result
        public List<prMessagesProcessedByDay_Result> GetprMessagesProcessedByDay_Result()
        {
            var a= db.prMessagesProcessedByDay(null,null);
            return a.ToList();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}