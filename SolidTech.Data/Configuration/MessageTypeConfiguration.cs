﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Data.Configuration
{
    internal class MessageTypeConfiguration : IEntityTypeConfiguration<MessageType>
    {

        public void Configure(EntityTypeBuilder<MessageType> builder)
        {


            builder.Property(mt => mt.MessageTypeName).IsRequired().HasMaxLength(20);

            builder.Property(mt=>mt.MessageTypeDescription).IsRequired().HasMaxLength(50);


        }
    }
}
