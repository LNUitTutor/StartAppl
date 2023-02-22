using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartAppl
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Чи справді Ви хочете завершити програму?",
                "Підтвердження",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;
            label2.Text = Logic.GetString((int)numeric.Value);
        }
    }
}
