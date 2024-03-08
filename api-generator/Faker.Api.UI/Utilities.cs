using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Faker.Api.UI
{
    internal static class Utilities
    {
        #region GetCommonIndent
        /// <summary>
        /// works out the max number of whitespace positions that exist on every line (with content)
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="tabWidth"></param>
        /// <returns></returns>
        public static int GetCommonIndent(string txt, int tabWidth)
        {
            if (string.IsNullOrEmpty(txt))
                return 0;

            StringBuilder output = new StringBuilder();
            int maxLeadingWhitespace = int.MaxValue;
            int thisLineLeadingWhitespace = 0;
            bool nonWhitespaceEncountered = false;

            foreach (var c in txt)
            {
                switch (c)
                {
                    case ' ':
                        if (nonWhitespaceEncountered == false)
                            thisLineLeadingWhitespace++;
                        break;
                    case '\t':
                        if (nonWhitespaceEncountered == false)
                        {
                            int spacesToAdd = tabWidth - (thisLineLeadingWhitespace % tabWidth);
                            thisLineLeadingWhitespace += spacesToAdd;
                        }
                        break;

                    case '\n':
                        if (nonWhitespaceEncountered)
                        {
                            maxLeadingWhitespace = Math.Min(thisLineLeadingWhitespace, maxLeadingWhitespace);
                        }
                        thisLineLeadingWhitespace = 0;
                        nonWhitespaceEncountered = false;
                        break;

                    default:
                        nonWhitespaceEncountered = true;
                        break;
                }
            }
            if (nonWhitespaceEncountered)
                maxLeadingWhitespace = Math.Min(thisLineLeadingWhitespace, maxLeadingWhitespace);
            if (maxLeadingWhitespace == int.MaxValue)
                maxLeadingWhitespace = 0;
            return maxLeadingWhitespace;
        }
        #endregion

        #region RemoveCommonIndent
        /// <summary>
        /// Takes of any c
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="tabWidth"></param>
        /// <returns></returns>
        public static string RemoveCommonIndent(string txt, int whitespaceCharsToRemove, int tabWidth)
        {
            if (string.IsNullOrEmpty(txt))
                return "";

            StringBuilder output = new StringBuilder();
            int spacesToRemove = whitespaceCharsToRemove;
            bool nonWhitespaceEncountered = false;
            int colPos = 0;
            StringBuilder sb = new StringBuilder(txt.Length);

            foreach (var c in txt)
            {
                switch (c)
                {
                    case ' ':
                        colPos++;
                        if (nonWhitespaceEncountered == false && spacesToRemove-- > 0)
                            continue; // skip space

                        break;
                    case '\t':
                        int spacesForTab = tabWidth - (colPos % tabWidth);

                        if (nonWhitespaceEncountered || spacesToRemove <= 0)
                            break;

                        spacesToRemove -= spacesForTab;
                        if (spacesToRemove < 0)
                            sb.Append(' ', -spacesToRemove);
                        continue;

                    case '\n':
                        colPos = 0;
                        spacesToRemove = whitespaceCharsToRemove;
                        nonWhitespaceEncountered = false;
                        break;

                    default:
                        nonWhitespaceEncountered = true;
                        break;
                }

                sb.Append(c);
            }
            return sb.ToString();
        }
        #endregion
        public static TreeViewItem? ContainerFromItemRecursive(this ItemContainerGenerator root, object item)
        {
            var treeViewItem = root.ContainerFromItem(item) as TreeViewItem;
            if (treeViewItem != null)
                return treeViewItem;
            foreach (var subItem in root.Items)
            {
                treeViewItem = root.ContainerFromItem(subItem) as TreeViewItem;
                var search = treeViewItem?.ItemContainerGenerator.ContainerFromItemRecursive(item);
                if (search != null)
                    return search;
            }
            return null;
        }


    }
}
