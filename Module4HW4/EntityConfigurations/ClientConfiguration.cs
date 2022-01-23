using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entities;

namespace Module4HW4.EntityConfigurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Client").HasKey(t => t.ClientId);
            entityTypeBuilder.Property(t => t.ClientId).HasColumnName("ClientId").ValueGeneratedOnAdd();
            entityTypeBuilder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(t => t.EMail).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(t => t.Phone).IsRequired().HasMaxLength(50);
            entityTypeBuilder.Property(t => t.Adress).HasMaxLength(50);

            entityTypeBuilder.HasData(new List<ClientEntity>()
            {
                new ClientEntity() { ClientId = 1, Name = "Client 1", EMail = "Client1@gmail.com", Phone = "+380631234567" },
                new ClientEntity() { ClientId = 2, Name = "Client 2", EMail = "Client2@gmail.com", Phone = "+380641234567" },
                new ClientEntity() { ClientId = 3, Name = "Client 3", EMail = "Client3@gmail.com", Phone = "+380651234567" },
                new ClientEntity() { ClientId = 4, Name = "Client 4", EMail = "Client4@gmail.com", Phone = "+380691234567" },
                new ClientEntity() { ClientId = 5, Name = "Client 5", EMail = "Client5@gmail.com", Phone = "+380701234567" }
            });
        }
    }
}
