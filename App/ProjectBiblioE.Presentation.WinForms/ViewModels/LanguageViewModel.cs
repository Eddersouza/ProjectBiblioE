using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Presentation.WinForms.Utils.Attributes;

namespace ProjectBiblioE.Presentation.WinForms.ViewModels
{
    public class LanguageViewModel
    {
        public LanguageViewModel()
        {
        }

        [CustomTableAttributes(ColumnName = "LanguageViewModel_LanguageId", ColumnOrder = 0, IsIndex = true, ResourceType = typeof(Resources))]
        public int LanguageId
        {
            get; set;
        }

        [CustomTableAttributes(ColumnName = "LanguageViewModel_Code", ColumnOrder = 1, ResourceType = typeof(Resources))]
        public string Code
        {
            get; set;
        }

        [CustomTableAttributes(ColumnName = "LanguageViewModel_Name", ColumnOrder = 2, ResourceType = typeof(Resources))]
        public string Name
        {
            get; set;
        }
    }
}