using Data.Repository.Abstract;
using Store.Model.Entities.dbml;

namespace Store.Model.Abstract.Service
{
    public interface IPaymentTypeService : IBaseService<PaymentType>
    {
        void UpsertRecord(int? id, string name);

        void DeleteRecord(int id);
    }
}
