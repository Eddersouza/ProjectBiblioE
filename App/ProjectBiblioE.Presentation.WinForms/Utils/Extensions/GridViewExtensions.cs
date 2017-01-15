using System;
using System.Reflection;
using System.Windows.Forms;

using ProjectBiblioE.CrossCutting.Resource;
using ProjectBiblioE.Presentation.WinForms.Utils.Attributes;

namespace ProjectBiblioE.Presentation.WinForms.Utils.Extensions
{
    /// <summary>
    /// Extensions to grid
    /// </summary>
    public static class GridViewExtensions
    {
        /// <summary>
        /// Add Edit Column
        /// </summary>
        /// <param name="grid">Grid to add column</param>
        /// <param name="type">Type of records in grid for show in tooltip</param>
        /// <param name="columnName">Name of column</param>
        /// <returns>This Grid</returns>
        public static DataGridView AddEditColumn(this DataGridView grid, string type, string columnName)
        {
            DataGridViewImageColumn columnPrevious = (DataGridViewImageColumn)grid.Columns[columnName];

            if (columnPrevious != null)
            {
                grid.Columns.Remove(columnPrevious);
            }

            DataGridViewImageColumn collumnEdit = new DataGridViewImageColumn();
            collumnEdit.Image = (System.Drawing.Image)Resources.icon_edit_16_16;
            collumnEdit.Width = 20;
            collumnEdit.Name = columnName;
            collumnEdit.HeaderText = string.Empty;
            collumnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            collumnEdit.CellTemplate.ToolTipText = string.Format(Resources.GridViewExtensions_Edit, type);

            grid.Columns.Add(collumnEdit);

            return grid;
        }

        /// <summary>
        /// Add Edit Column
        /// </summary>
        /// <param name="grid">Grid to add column</param>
        /// <param name="type">Type of records in grid for show in tooltip</param>
        /// <param name="columnName">Name of column</param>
        /// <returns>This Grid</returns>
        public static DataGridView AddRemoveColumn(this DataGridView grid, string type, string columnName)
        {
            DataGridViewImageColumn columnPrevious = (DataGridViewImageColumn)grid.Columns[columnName];

            if (columnPrevious != null)
            {
                grid.Columns.Remove(columnPrevious);
            }

            DataGridViewImageColumn collumnRemove = new DataGridViewImageColumn();
            collumnRemove.Image = (System.Drawing.Image)Resources.icon_trash_16_16;
            collumnRemove.Width = 20;
            collumnRemove.Name = columnName;
            collumnRemove.HeaderText = string.Empty;
            collumnRemove.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            collumnRemove.CellTemplate.ToolTipText = string.Format(Resources.GridViewExtensions_Remove, type);

            grid.Columns.Add(collumnRemove);

            return grid;
        }

        /// <summary>
        /// Create columns using the view
        /// </summary>
        /// <param name="grid">Grid to create columns</param>
        /// <param name="type">View type to create column</param>
        /// <returns>Changed Grid</returns>
        public static DataGridView CreateColumnsByView(this DataGridView grid, Type type)
        {
            grid.AutoGenerateColumns = false;

            PropertyInfo[] properties = type.GetProperties();

            foreach (var property in properties)
            {
                bool isIndex = CustomTableAttributes.ColumnIsIndex(property);
                int columnOrder = CustomTableAttributes.GetColumnOrder(property);
                string columnName = CustomTableAttributes.GetColumnName(property);

                if (isIndex)
                {
                    grid.Columns[property.Name].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }

                grid.Columns[property.Name].DisplayIndex = columnOrder;
                grid.Columns[property.Name].HeaderText = columnName;
            }

            return grid;
        }
    }
}