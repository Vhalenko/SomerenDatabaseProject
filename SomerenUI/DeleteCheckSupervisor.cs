using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class DeleteCheckSupervisor : Form
    {
        private ListViewItem SelectedItem;

        public DeleteCheckSupervisor(ListViewItem selectedItem)
        {
            InitializeComponent();
            SelectedItem = selectedItem;
        }

        public bool DeleteMessage()
        {
            return DialogResult == DialogResult.OK;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
