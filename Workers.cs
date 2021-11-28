using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WP_Mixer_WinForms
{
    internal class Workers
    {
        // Given a cell name, parses the specified cell to get the column name.
        public static string PrepareCellValue(string? cellText)
        {
            if (string.IsNullOrEmpty(cellText) || string.IsNullOrWhiteSpace(cellText))
            {
                return "";
            }
            // Create a regular expression to match the column name portion of the cell name.
            Regex regex = new("[A-Za-z0-9]+");
            Match match = regex.Match(cellText);

            return match.Value;
        }
    }
}
