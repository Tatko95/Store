using Data.Repository.Concrete;
using Store.Model.Abstract;
using Store.Model.Entities.dbml;

namespace Store.Model.Concrete
{
    public class StoreRepository : BaseRepository, IStoreRepository
    {
        #region constructor
        public StoreRepository(string connectionString)
        {
            dataContext = new LinqToStoreDataContext(connectionString);
            dataContext.CommandTimeout = 1800; //полчаса
            this.connectionString = connectionString;
        }
        #endregion
    }
}
