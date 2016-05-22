using Data.Repository.Concrete;
using Store.Model.Abstract;
using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;

namespace Store.Model.Concrete.Service
{
    public class DiliveryTypeService : BaseService<DiliveryType>, IDiliveryTypeService
    {
        public DiliveryTypeService(IStoreRepository repository) : base(repository) { }
    }
}
