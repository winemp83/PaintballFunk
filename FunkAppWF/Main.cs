using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibi.ViewModel;
using Bibi.Model;
using System.Collections.ObjectModel;

namespace FunkAppWF
{
    public partial class Main : Form
    {

        private readonly CTSSViewModel _CTSS;
        private readonly PMR466ViewModel _PMR;

        public Main()
        {
            InitializeComponent();
            _CTSS = new CTSSViewModel();
            _PMR = new PMR466ViewModel();
            tSSL.Text = (_CTSS.ValueList.Count + _PMR.ValueList.Count).ToString();
            dGV.DataSource = _CTSS.ValueList;
            dGV.Columns["ID"].DisplayIndex = 0;
            dGV.Columns["Ton"].DisplayIndex = 1;
            dGV.Columns["SC"].DisplayIndex = 2;
            dGVPMR.DataSource = _PMR.ValueList;
            dGVPMR.Columns["ID"].DisplayIndex = 0;
            dGVPMR.Columns["Frequenz"].DisplayIndex= 1;
        }

        private void cTSS38ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObservableCollection<CTSSModel> list = new ObservableCollection<CTSSModel>();
            foreach(CTSSModel cm in _CTSS.ValueList)
                if(cm.SC != "0")
                    list.Add(cm);
            dGV.DataSource = list;
        }

        private void cTSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dGV.DataSource = _CTSS.ValueList;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGV_SelectionChanged(object sender, EventArgs e)
        {
            gB.Visible = true;
            if (dGV.SelectedRows.Count > 0 && dGV.SelectedRows[0].Cells.Count > 0)
            {
                tBCID.Text = dGV.SelectedRows[0].Cells[2].Value.ToString();
                tBC38.Text =  dGV.SelectedRows[0].Cells[1].Value.ToString();
                tBCTon.Text =  dGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dGVPMR_SelectionChanged(object sender, EventArgs e)
        {
            gB.Visible = true;
            if(dGVPMR.SelectedRows.Count > 0 && dGVPMR.SelectedRows[0].Cells.Count > 0)
            {
                tBPID.Text = dGVPMR.SelectedRows[0].Cells[2].Value.ToString();
                tBPFreq.Text = dGVPMR.SelectedRows[0].Cells[0].Value.ToString();
                rTBPAn.Text = dGVPMR.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void pMR466ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _channel = "0";
            if (Customs.InputBox("PMR466 Suche", "Channel Nummer : ", ref _channel) == DialogResult.OK)
            {
                tBPID.Text = _channel;
                var _tmp = _PMR.ValueList.Where(c => c.ID.Equals(_channel));
                foreach (PMR466Model pm in _tmp)
                {
                    tBPFreq.Text = pm.Frequenz;
                    rTBPAn.Text = pm.Anmerkung;
                }
            }
        }
    }
}
