﻿using Microsoft.EntityFrameworkCore;

namespace LoanOrigination.Models.CustomerSearch
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
