using ContactsKeeper.Core.DomainEntities;
using ContactsKeeper.Core.Interfaces;
using ContactsKeeper.Data.Mappers.Interfaces;

namespace ContactsKeeper.Data.Services
{
    public class ContactsRepository(ContactsKeeperDbContext contactsKeeperDbContext, IContactMapper contactMapper) : IContactsRepository
    {
        public bool AddContact(Contact contact)
        {
            try
            {
                var contactEntity = contactMapper.MapToEntity(contact);
                contactEntity.CreatedDate = DateTime.Now;
                contactsKeeperDbContext.ContactEntities.Add(contactEntity);
                var result = contactsKeeperDbContext.SaveChanges();
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Contact> GetAllContacts()
        {
            return contactsKeeperDbContext.ContactEntities
                .Select(x => contactMapper.MapToModel(x))
                .ToList();
        }

        public Contact GetContactById(int id)
        {
            return contactMapper.MapToModel(contactsKeeperDbContext.ContactEntities
                .FirstOrDefault(x => x.Id == id));
        }

        public bool UpdateContact(Contact contact)
        {
            try
            {
                // logic
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteContact(int id)
        {
            try
            {
                var contactEntity = contactsKeeperDbContext.ContactEntities
                    .FirstOrDefault(x => x.Id == id);
                contactsKeeperDbContext.ContactEntities.Remove(contactEntity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Contact GetContactByName(string name)
        {
            throw new NotImplementedException();
        }

        public Contact GetContactByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public Contact GetContactByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}