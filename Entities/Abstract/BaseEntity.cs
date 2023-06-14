﻿namespace customerManagement.Entities.Abstract
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
