using Bibi.ViewModel;
using System.Windows.Forms;

namespace FunkAppWF.Func
{
    public class Optik
    {
        public FavViewModel Fav = new FavViewModel();


        public void PrepareDataGrid(ref DataGridView value)
        {
            value.DataSource = Fav.ValueList;
            value.Columns["Name"].DisplayIndex = 0;
            value.Columns["ID"].DisplayIndex = 1;
            value.Columns["PID"].DisplayIndex = 2;
            value.Columns["CID"].DisplayIndex =3;
            value.Columns["Anmerkung"].DisplayIndex=4;

            value.Columns["Name"].Width = 100;
            value.Columns["ID"].Width = 25;

            value.Columns["ID"].HeaderText = "Nr.";

            value.Columns["PID"].Visible = false;
            value.Columns["CID"].Visible = false;
            value.Columns["Anmerkung"].Visible = false;
        }

        public void ChangeVisibilityStripMenueItem(ref ToolStripMenuItem value, bool Visibility = true)
        {
            value.Visible = Visibility;
        }

        public void SetTextBox(ref TextBox value, string Text = null, bool Readonly = true)
        {
            if(Text != null)
                value.Text = Text;
            value.ReadOnly = Readonly;
        }

        public void PrepareGroupBox(ref GroupBox value, string Name = null, bool Visibility = true)
        {
            if(Name != null)
                value.Text = Name;
            value.Visible = Visibility;
        }

        public void PrepareButton(ref Button value, string Text = null, bool Visibility = true)
        {
            if(Text != null)
                value.Text = Text;
            value.Visible = Visibility;
        }

        public void SetTextBox(ref RichTextBox value, string Text = null, bool Readonly = true)
        {
            if (Text != null)
                value.Text = Text;
            value.ReadOnly = Readonly;
        }

    }
}
