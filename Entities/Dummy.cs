using DataRepository.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataRepository.Entities;

public class Dummy : BaseEntity
{
    public string Name { get; set; }
}


public class DummyConfiguration : BaseEntityTypeConfiguration<Dummy>
{
    public override void Configure(EntityTypeBuilder<Dummy> builder)
    {
        base.Configure(builder);
        builder.Property(b => b.Name).HasDefaultValue("Unknown");
    }
}