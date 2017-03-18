using System.Data.Entity.ModelConfiguration;

using ProjectBiblioE.Domain.Entities;

namespace ProjectBiblioE.Infra.Data.Map
{
    public class GenreMap : EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            HasKey(g => g.GenreId);

            Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(Genre.GenreNameMaxLength);
        }
    }
}