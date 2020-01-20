using Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Maps
{
    public class QualificationMap : IEntityTypeConfiguration<Qualifications>
    {
        public void Configure(EntityTypeBuilder<Qualifications> builder)
        {
            builder.ToTable("Qualifications");
            builder.HasKey(x => x.IdQualification);
        }
    }
}
