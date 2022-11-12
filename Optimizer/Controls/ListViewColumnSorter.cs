using System;
using System.Collections;
using System.Windows.Forms;

namespace Optimizer
{
    internal sealed class ListViewColumnSorter : IComparer
    {
        int _columnToSort;
        SortOrder _sortOrder;
        CaseInsensitiveComparer _comparer;

        public ListViewColumnSorter()
        {
            _columnToSort = 0;
            _sortOrder = SortOrder.None;
            _comparer = new CaseInsensitiveComparer();
        }

        public int CurrentColumn
        {
            get { return _columnToSort; }
            set { _columnToSort = value; }
        }

        public SortOrder SortOrder
        {
            get { return _sortOrder; }
            set { _sortOrder = value; }
        }

        public int Compare(object x, object y)
        {
            int compareResult;

            ListViewItem listViewX = (ListViewItem)x;
            ListViewItem listViewY = (ListViewItem)y;

            try
            {
                compareResult = _comparer.Compare(Convert.ToInt64(listViewX.SubItems[_columnToSort].Text), Convert.ToInt64(listViewY.SubItems[_columnToSort].Text));
            }
            catch
            {
                compareResult = _comparer.Compare(listViewX.SubItems[_columnToSort].Text, listViewY.SubItems[_columnToSort].Text);
            }

            if (_sortOrder == SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (_sortOrder == SortOrder.Descending)
            {
                return -compareResult;
            }
            else
            {
                return 0;
            }
        }
    }
}
