using CHHS.Common.Core.Data.DAL;
using CHHS.Common.Core.Data.Models;

namespace BlazorAppTutorial.DAL
{
    public class EfRepository<T> : EntityRepository<T> where T : BaseModel
    {
        public EfRepository(BlazorAppTutorialContext context) : base(context)
        {

        }
    }
}
