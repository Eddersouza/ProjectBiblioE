using System;
using System.Reflection;
using System.Resources;

namespace ProjectBiblioE.Presentation.WinForms.Utils.Attributes
{
    /// <summary>
    /// Custom table attributes. 
    /// </summary>
    public class CustomTableAttributes : Attribute
    {
        /// <summary>
        /// Variable control to column name.
        /// </summary>
        private string columnName = string.Empty;

        /// <summary>
        /// Object to Resources.
        /// </summary>
        private ResourceManager resManager = null;

        /// <summary>
        /// Column header.
        /// </summary>
        public string ColumnName
        {
            get { return getResourceString(columnName); }
            set { columnName = value; }
        }

        /// <summary>
        /// Column order in table.
        /// </summary>
        public int ColumnOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Column is index.
        /// </summary>
        public bool FitColumn
        {
            get;
            set;
        }

        /// <summary>
        /// Resource type.
        /// </summary>
        public Type ResourceType
        {
            get; set;
        }

        /// <summary>
        /// Get is the column Index.
        /// </summary>
        /// <param name="property">Property to get attribute.</param>
        /// <returns>True: Is index / False: not is index.</returns>
        public static bool ColumnIsFit(PropertyInfo property)
        {
            bool columnIsIndex = false;

            object[] attrs = property.GetCustomAttributes(true);

            foreach (object item in attrs)
            {
                CustomTableAttributes customAtribute = item as CustomTableAttributes;

                if (customAtribute != null)
                {
                    columnIsIndex = customAtribute.FitColumn;
                }
            }

            return columnIsIndex;
        }

        /// <summary>
        /// Get the column name.
        /// </summary>
        /// <param name="property">Property to get attribute.</param>
        /// <returns>Name of column.</returns>
        public static string GetColumnName(PropertyInfo property)
        {
            string columnName = string.Empty;

            object[] attrs = property.GetCustomAttributes(true);

            foreach (object item in attrs)
            {
                CustomTableAttributes customAtribute = item as CustomTableAttributes;

                if (customAtribute != null)
                {
                    columnName = customAtribute.ColumnName;
                }
            }

            return columnName;
        }

        /// <summary>
        /// Get column order in table.
        /// </summary>
        /// <param name="property">Property to get attribute.</param>
        /// <returns>Index of column.</returns>
        public static int GetColumnOrder(PropertyInfo property)
        {
            int columnIndex = 0;

            object[] attrs = property.GetCustomAttributes(true);

            foreach (object item in attrs)
            {
                CustomTableAttributes customAtribute = item as CustomTableAttributes;

                if (customAtribute != null)
                {
                    columnIndex = customAtribute.ColumnOrder;
                }
            }

            return columnIndex;
        }

        /// <summary>
        /// Get string from resource key.
        /// </summary>
        /// <param name="resourceKey">Resource key to find string.</param>
        /// <returns>String to resourcekey.</returns>
        private string getResourceString(string resourceKey)
        {
            if (string.IsNullOrWhiteSpace(resourceKey))
                return string.Empty;

            if (ResourceType == default(Type))
                return resourceKey;

            if (resManager == null)
                resManager = new ResourceManager(ResourceType);

            return resManager.GetString(resourceKey) ?? string.Format("[[{0}]]", resourceKey);
        }
    }
}