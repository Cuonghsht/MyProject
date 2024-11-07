﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyprojectData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojectData.Config
{
    public class AccountConfig : IEntityTypeConfiguration<Accounts>
    {
        public void Configure(EntityTypeBuilder<Accounts> builder)
        {
            builder.HasKey(x => x.AccountId);
            builder.HasIndex(x => x.AccountName).IsUnique();
            builder.HasOne(x=>x.role).WithMany(x=>x.Accounts).HasForeignKey(x=>x.RoleId);
        }
    }
}
