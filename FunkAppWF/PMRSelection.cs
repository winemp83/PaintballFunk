using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace FunkAppWF
{
    public partial class PMRSelection<T> : Form
    {
        public T result;
        public ObservableCollection<T> items;

        public PMRSelection(string Title, string Question,string DisplayedMember, ref ObservableCollection<T> list)
        {
            items = list;
            InitializeComponent(); 
            Text = Title;
            LQuestion.Text = Question;
            LBSelection.DataSource = list;
            LBSelection.DisplayMember = DisplayedMember;
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void LBSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            result = items[LBSelection.SelectedIndex];
        }
    }
}
