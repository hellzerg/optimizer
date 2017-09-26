using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Optimizer
{
    public class ListViewColumnSorter : IComparer
    {
        /// <summary>
        /// Specifies the column to be sorted
        /// </summary>
        private int columnToSort;

        /// <summary>
        /// Specifies the order in which to sort (i.e. 'Ascending').
        /// </summary>
        private SortOrder orderOfSort;

        /// <summary>
        /// Case insensitive comparer object
        /// </summary>
        private CaseInsensitiveComparer objectCompare;

        /// <summary>
        /// Initializes a new instance of the ListViewColumnSorter class
        /// </summary>
        public ListViewColumnSorter()
        {
            // Initialize the column to '0'
            this.columnToSort = 0;

            // Initialize the sort order to 'none'
            this.orderOfSort = SortOrder.None;

            // Initialize the CaseInsensitiveComparer object
            this.objectCompare = new CaseInsensitiveComparer();
        }

        /// <summary>
        /// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        /// </summary>
        public int SortColumn
        {
            get
            {
                return this.columnToSort;
            }

            set
            {
                this.columnToSort = value;
            }
        }

        /// <summary>
        /// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        /// </summary>
        public SortOrder Order
        {
            get
            {
                return this.orderOfSort;
            }

            set
            {
                this.orderOfSort = value;
            }
        }

        /// <summary>
        /// This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            // Compare the two items
            try
            {
                // if the numeric sort (try) fails, then we want
                // to do the text sort (catch)
                compareResult = this.objectCompare.Compare(Convert.ToInt64(listviewX.SubItems[this.columnToSort].Text), Convert.ToInt64(listviewY.SubItems[this.columnToSort].Text));
            }
            catch
            {
                compareResult = this.objectCompare.Compare(listviewX.SubItems[this.columnToSort].Text, listviewY.SubItems[this.columnToSort].Text);
            }

            // Calculate correct return value based on object comparison
            if (this.orderOfSort == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (this.orderOfSort == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return -compareResult;
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }
    }
}
