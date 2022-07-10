using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configuration
{
    public class MovementConfiguration : IEntityTypeConfiguration<Movement>
    {
        public void Configure(EntityTypeBuilder<Movement> builder)
        {            
            builder.Property(p => p.Amount)
                .HasPrecision(13, 3)
                .IsRequired();

            builder.Property(p => p.MovementDate)
                .IsRequired()
                .HasColumnType("Date");

            //builder.HasOne("CategoryId").WithMany().OnDelete(DeleteBehavior.Restrict);
        }        
    }
}
