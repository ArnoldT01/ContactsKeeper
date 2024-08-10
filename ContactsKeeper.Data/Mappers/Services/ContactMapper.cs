using ContactsKeeper.Core.DomainEntities;
using ContactsKeeper.Data.DataEntities;
using ContactsKeeper.Data.Mappers.Interfaces;

namespace ContactsKeeper.Data.Mappers.Services
{
    public class ContactMapper : IContactMapper
    {
        public Contact MapToModel(ContactEntity contactEntity)
        {
            if (contactEntity != null)
            {
                return new Contact
                {
                    Name = contactEntity.Name,
                    Phone = contactEntity.Phone,
                    Email = contactEntity.Email,
                    Address = contactEntity.Address
                };
            }
            return null;
        }

        public ContactEntity MapToEntity(Contact contact)
        {
            if (contact != null)
            {
                return new ContactEntity
                {
                    Name = contact.Name,
                    Phone = contact.Phone,
                    Email = contact.Email,
                    Address = contact.Address,
                    UpdatedDate = DateTime.Now
                };
            }
            return null;
        }
    }
}