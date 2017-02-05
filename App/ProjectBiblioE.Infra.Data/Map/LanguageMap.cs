using System.Data.Entity.ModelConfiguration;

using ProjectBiblioE.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectBiblioE.Infra.Data.Map
{
    /// <summary>
    /// Map Language properties
    /// </summary>
    public class LanguageMap : EntityTypeConfiguration<Language>
    {
        /// <summary>
        /// Map Constructor.
        /// </summary>
        public LanguageMap()
        {
            this.HasKey(x => x.CultureCode);

            this.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Language.LanguageNameMaxLength);

            this.Property(x => x.CultureCode)
                .IsRequired()
                .HasMaxLength(Language.LanguageCultureCodeMaxLength)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}