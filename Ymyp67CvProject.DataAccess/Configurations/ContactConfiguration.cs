﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ymyp67CvProject.Entity.Concrete;

namespace Ymyp67CvProject.DataAccess.Configurations;
internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.Property(c => c.Address).HasMaxLength(250).IsRequired();
        builder.Property(c => c.City).HasMaxLength(50).IsRequired();
        builder.Property(c => c.Town).HasMaxLength(100).IsRequired();
        builder.Property(c => c.Phone).HasMaxLength(12).IsFixedLength().IsRequired();
        //builder.Property(c => c.Phone).HasColumnType("char(12)");
        builder.Property(c => c.Email).HasMaxLength(50).IsRequired();
    }
}
