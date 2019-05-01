
namespace SilverlightAddressBook.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using SilverlightAddressBook.Web.Models;


    // Implements application logic using the ContactInfoEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class ContactInofDomainService : LinqToEntitiesDomainService<ContactInfoEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Contacts' query.
        public IQueryable<Contact> GetContacts()
        {
            return this.ObjectContext.Contacts;
        }

        public void InsertContact(Contact contact)
        {
            if ((contact.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(contact, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Contacts.AddObject(contact);
            }
        }

        public void UpdateContact(Contact currentContact)
        {
            this.ObjectContext.Contacts.AttachAsModified(currentContact, this.ChangeSet.GetOriginal(currentContact));
        }

        public void DeleteContact(Contact contact)
        {
            if ((contact.EntityState == EntityState.Detached))
            {
                this.ObjectContext.Contacts.Attach(contact);
            }
            this.ObjectContext.Contacts.DeleteObject(contact);
        }
    }
}


