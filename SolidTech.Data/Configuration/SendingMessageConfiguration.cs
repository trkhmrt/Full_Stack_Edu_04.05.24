using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTech.Data.Configuration 
{
    public class SendingMessageConfiguration : IEntityTypeConfiguration<SendingMessage>
    {
        public void Configure(EntityTypeBuilder<SendingMessage> builder)
        {
            builder.ToTable("SendingMessageLog");

            builder.HasKey(sm => sm.SendingMessageId);

            builder.Property(sm => sm.MessageHeader).HasMaxLength(100);

            builder.Property(sm => sm.MessageContent).HasMaxLength(200);


             

        }
    }
}
