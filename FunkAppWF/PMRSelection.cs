using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunkAppWF
{
    public partial class PMRSelection : Form
    {
        public Bibi.ViewModel.PMR466ViewModel result;

        public PMRSelection()
        {
            InitializeComponent();
        }

        public PMRSelection(string Title, string Question, ref Bibi.ViewModel.PMR466ViewModel list)
        {
            InitializeComponent();
            result = new Bibi.ViewModel.PMR466ViewModel();
            result = list;
            this.Text = Title;
            this.LQuestion.Text = Question;
            this.LBSelection.DataSource = result.ValueList;
            this.LBSelection.DisplayMember = "Frequenz";
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void LBSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            result.Value = result.ValueList[LBSelection.SelectedIndex];
        }
    }
}
