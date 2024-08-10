using ContactsKeeper.Core.DomainEntities;
using ContactsKeeper.Data.DataEntities;

namespace ContactsKeeper.Data.Mappers.Interfaces
{
    public interface IContactMapper
    {
        Contact MapToModel(ContactEntity contactEntity);
        ContactEntity MapToEntity(Contact contact);
    }
}