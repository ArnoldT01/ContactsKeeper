﻿namespace ContactsKeeper.Core.DomainEntities
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}