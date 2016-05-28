using Data.Repository.Abstract;
using Store.Model.Entities.dbml;

namespace Store.Model.Abstract.Service
{
    public interface IDiliveryTypeService : IBaseService<DiliveryType>
    {
        void UpsertRecord(int? id, string name);

        void DeleteRecord(int id);
    }
}
