using System;
using System.Data;
using System.Linq;
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
        private readonly FavViewModel _Fav;
        private readonly Func.Optik _Optik;

        public Main()
        {
            InitializeComponent();
            _CTSS = new CTSSViewModel();
            _PMR = new PMR466ViewModel();
            _Fav = new FavViewModel();
            _Optik = new Func.Optik();
            tSSL.Text = (_Fav.ValueList.Count).ToString();
            _Optik.Fav = _Fav;
            _Optik.PrepareDataGrid(ref dGV);

            _Optik.ChangeVisibilityStripMenueItem(ref MainMenueEditDelete, false);
            _Optik.ChangeVisibilityStripMenueItem(ref MainMenueEditEdit, false);
            _Optik.PrepareGroupBox(ref gBEI, Name = "Informationen", false);
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV.SelectedRows.Count > 0 && dGV.SelectedRows[0].Cells.Count > 0)
            {
                FavModel _tempf = new FavModel
                {
                    ID = dGV.SelectedRows[0].Cells["ID"].Value.ToString(),
                    PID = dGV.SelectedRows[0].Cells["PID"].Value.ToString(),
                    CID = dGV.SelectedRows[0].Cells["CID"].Value.ToString(),
                    Name = dGV.SelectedRows[0].Cells["Name"].Value.ToString(),
                    Anmerkung = dGV.SelectedRows[0].Cells["Anmerkung"].Value.ToString()

                };

                PMR466Model _tempp = new PMR466Model();
                CTSSModel _tempc = new CTSSModel();

                if (_tempf.PID != "0" || _tempf.PID != null || _tempf.PID != string.Empty)
                {
                    PMR466Model[] a = _PMR.ValueList.Where(c => c.ID.Equals(_tempf.PID)).ToArray();
                    _tempp = a[0];
                }
                else
                    _tempp = new PMR466Model { ID = "0", Frequenz = "0,0", Anmerkung = "Noch nicht angelegt" };

                if (_tempf.CID != null || _tempf.CID != string.Empty)
                {
                    CTSSModel[] b = _CTSS.ValueList.Where(c => c.ID.Equals(_tempf.CID)).ToArray();
                    _tempc = b[0];
                }
                else
                    _tempc = new CTSSModel { ID = "0", SC = "0", Ton= "0,0" };

                _Optik.SetTextBox(ref tBID, _tempf.Name);
                _Optik.SetTextBox(ref rTBAn, _tempf.Anmerkung);

                _Optik.SetTextBox(ref tBPID, _tempp.ID);
                _Optik.SetTextBox(ref tBPFreq, _tempp.Frequenz);
                _Optik.SetTextBox(ref rTBPAn, _tempp.Anmerkung);
                
                _Optik.SetTextBox(ref tBCID, _tempc.ID);
                _Optik.SetTextBox(ref tBCTon, _tempc.Ton);
                _Optik.SetTextBox(ref tBC38, _tempc.SC);

                _Optik.PrepareGroupBox(ref gBEI);
                _Optik.ChangeVisibilityStripMenueItem(ref MainMenueEditDelete);
                _Optik.ChangeVisibilityStripMenueItem(ref MainMenueEditEdit);
                _Optik.PrepareButton(ref CmdCancel);
                _Optik.PrepareButton(ref CmdSave);
            }
            else
            {
                _Optik.PrepareGroupBox(ref gBEI, Visibility:false);
                _Optik.ChangeVisibilityStripMenueItem(ref MainMenueEditDelete,false) ;
                _Optik.ChangeVisibilityStripMenueItem(ref MainMenueEditEdit,false);
                _Optik.PrepareButton(ref CmdCancel, Visibility: false);
                _Optik.PrepareButton(ref CmdSave, Visibility: false);
            }
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            FavModel fav = new FavModel();
            string _tmp = "Neuer Eintrag";
            if (Customs.InputBox("Neue Eintrag", "Geben Sie bitte einen Namen ein :", ref _tmp) == DialogResult.OK)
            {
                fav.Name = _tmp;
                _tmp = "Neuer Eintrag";
                if (Customs.InputBox("Neue Eintrag", "Geben Sie bitte eine Beschreibung ein :", ref _tmp) == DialogResult.OK)
                {
                    fav.Anmerkung = _tmp;
                    ObservableCollection<PMR466Model> _list = _PMR.ValueList;
                    PMRSelection<PMR466Model> _sec = new PMRSelection<PMR466Model>("Neuer Eintrag", "Channel Nummer : ", "ID", ref _list);
                    if (_sec.ShowDialog() == DialogResult.OK)
                    {
                        foreach (PMR466Model pm in _PMR.ValueList.Where(c => c.Frequenz.Equals(_sec.result.Frequenz)))
                        {
                            fav.PID = pm.ID;
                        }
                    }
                    else { _sec.Close(); return; }
                    _sec.Close();
                    ObservableCollection<CTSSModel> list = new ObservableCollection<CTSSModel>();
                    list = _CTSS.ValueList;
                    PMRSelection<CTSSModel> _one = new PMRSelection<CTSSModel>("Neuer Eintrag", "CTSS Channel (0 für keinen) : ", "ID", ref list);
                    if (_one.ShowDialog() == DialogResult.OK)
                    {
                        foreach (CTSSModel cm in list.Where(c => c.ID.Equals(_one.result.ID)))
                        {
                            fav.CID = cm.ID;
                        }
                    }
                    else { _one.Close(); return; }
                    _one.Close();
                    _Fav.Value = fav;
                    _Fav.Insert();
                    dGV.DataSource = _Fav.ValueList;
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            FavModel _tmp = new FavModel
            {
                ID = dGV.SelectedRows[0].Cells["ID"].Value.ToString(),
                Name = tBID.Text,
                Anmerkung = rTBAn.Text,
                PID = tBPID.Text,
                CID = tBCID.Text
            };
            _Fav.Value = _tmp;
            _Fav.Update();
            dGV.DataSource = _Fav.ValueList;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            MainMenueFileLoad_Click(sender, e);
        }

        private void MainMenueFileLoad_Click(object sender, EventArgs e)
        {
            _Fav.Load();
            dGV.DataSource = _Fav.ValueList;
        }

        private void MainMenueFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchMenueCTSS38Channel_Click(object sender, EventArgs e)
        {
            ObservableCollection<CTSSModel> list = new ObservableCollection<CTSSModel>();
            foreach (CTSSModel cm in _CTSS.ValueList)
                if (cm.SC != "0")
                    list.Add(cm);
            PMRSelection<CTSSModel> _sec = new PMRSelection<CTSSModel>("CTSS38 Suche", "Channel Nummer : ", "SC", ref list);
            if (_sec.ShowDialog() == DialogResult.OK)
            {
                foreach (CTSSModel cm in list.Where(c => c.SC.Equals(_sec.result.SC)))
                {
                    tBCID.Text = cm.ID;
                    tBCTon.Text = cm.Ton;
                    tBC38.Text = cm.SC;
                }
            }
            _sec.Close();
            _Optik.PrepareButton(ref CmdSave, "Speichern");
            _Optik.PrepareButton(ref CmdCancel);
        }

        private void SearchMenueCTSS38Ton_Click(object sender, EventArgs e)
        {
            ObservableCollection<CTSSModel> list = new ObservableCollection<CTSSModel>();
            foreach (CTSSModel cm in _CTSS.ValueList)
                if (cm.SC != "0")
                    list.Add(cm);
            PMRSelection<CTSSModel> _sec = new PMRSelection<CTSSModel>("CTSS38 Suche", "Ton Frequenz(in Hz) : ", "Ton", ref list);
            if (_sec.ShowDialog() == DialogResult.OK)
            {
                foreach (CTSSModel cm in list.Where(c => c.Ton.Equals(_sec.result.Ton)))
                {
                    tBCID.Text = cm.ID;
                    tBCTon.Text = cm.Ton;
                    tBC38.Text = cm.SC;
                }
            }
            _sec.Close();
            _Optik.PrepareButton(ref CmdSave, "Speichern");
            _Optik.PrepareButton(ref CmdCancel);
        }

        private void SearchMenueCTSSTon_Click(object sender, EventArgs e)
        {
            ObservableCollection<CTSSModel> list = new ObservableCollection<CTSSModel>();
            list = _CTSS.ValueList;
            PMRSelection<CTSSModel> _sec = new PMRSelection<CTSSModel>("CTSS Suche", "Ton Frequenz(in Hz) : ", "Ton", ref list);
            if (_sec.ShowDialog() == DialogResult.OK)
            {
                foreach (CTSSModel cm in list.Where(c => c.Ton.Equals(_sec.result.Ton)))
                {
                    tBCID.Text = cm.ID;
                    tBCTon.Text = cm.Ton;
                    tBC38.Text = cm.SC;
                }
            }
            _sec.Close();
            _Optik.PrepareButton(ref CmdSave, "Speichern");
            _Optik.PrepareButton(ref CmdCancel);
        }

        private void SearchMenueCTSSChanel_Click(object sender, EventArgs e)
        {
            ObservableCollection<CTSSModel> list = new ObservableCollection<CTSSModel>();
            list = _CTSS.ValueList;
            PMRSelection<CTSSModel> _sec = new PMRSelection<CTSSModel>("CTSS Suche", "Channel Nummer : ", "ID", ref list);
            if (_sec.ShowDialog() == DialogResult.OK)
            {
                foreach (CTSSModel cm in list.Where(c => c.ID.Equals(_sec.result.ID)))
                {
                    tBCID.Text = cm.ID;
                    tBCTon.Text = cm.Ton;
                    tBC38.Text = cm.SC;
                }
            }
            _sec.Close();
            _Optik.PrepareButton(ref CmdSave, "Speichern");
            _Optik.PrepareButton(ref CmdCancel);
        }

        private void MainMenueEditNew_Click(object sender, EventArgs e)
        {
            CmdNew_Click(sender, e);
            _Optik.ChangeVisibilityStripMenueItem(ref MainMenueEditDelete, false);
            _Optik.ChangeVisibilityStripMenueItem(ref MainMenueEdit, false);
        }

        private void MainMenueEditEdit_Click(object sender, EventArgs e)
        {
            FavModel _fav = new FavModel();
            ObservableCollection<FavModel> list = new ObservableCollection<FavModel>();
            list = _Fav.ValueList;
            PMRSelection<FavModel> _sec = new PMRSelection<FavModel>("Eintrag bearbeiten", "Welcher Eintrag soll bearbeitet werden ?", "Name", ref list);
            if (_sec.ShowDialog() == DialogResult.OK)
            {
                foreach (FavModel fav in list.Where(c => c.Name.Equals(_sec.result.Name)))
                {
                    _fav.ID = fav.ID;
                    _fav.Name = fav.Name;
                    _fav.PID = fav.PID;
                    _fav.CID = fav.CID;
                    _fav.Anmerkung = fav.Anmerkung;
                }
            }
            _sec.Close();

            string _tmp = _fav.Name;
            if (Customs.InputBox("Eintrag bearbeiten", "Geben Sie bitte einen Namen ein :", ref _tmp) == DialogResult.OK)
            {
                _fav.Name = _tmp;
                _tmp = _fav.Anmerkung;
                if (Customs.InputBox("Eintrag bearbeiten", "Geben Sie bitte eine Beschreibung ein :", ref _tmp) == DialogResult.OK)
                {
                    _fav.Anmerkung = _tmp;
                    ObservableCollection<PMR466Model> _list = _PMR.ValueList;
                    PMRSelection<PMR466Model> _one = new PMRSelection<PMR466Model>("Eintrag bearbeiten", "Channel Nummer : ", "ID", ref _list);
                    if (_one.ShowDialog() == DialogResult.OK)
                    {
                        foreach (PMR466Model pm in _PMR.ValueList.Where(c => c.ID.Equals(_one.result.ID)))
                        {
                            _fav.PID = pm.ID;
                        }
                    }
                    else { _one.Close(); return; }
                    _one.Close();
                    ObservableCollection<CTSSModel> _List = new ObservableCollection<CTSSModel>();
                    _List = _CTSS.ValueList;
                    PMRSelection<CTSSModel> _th = new PMRSelection<CTSSModel>("Eintrag bearbeiten", "CTSS Channel (0 für keinen) : ", "ID", ref _List);
                    if (_th.ShowDialog() == DialogResult.OK)
                    {
                        foreach (CTSSModel cm in _List.Where(c => c.ID.Equals(_one.result.ID)))
                        {
                            _fav.CID = cm.ID;
                        }
                    }
                    else { _th.Close(); return; }
                    _th.Close();
                    _Fav.Value = _fav;
                    _Fav.Update();
                    dGV.DataSource = _Fav.ValueList;
                }
            }
        }

        private void MainMenueEditDelete_Click(object sender, EventArgs e)
        {
            if (dGV.SelectedRows.Count > 0 && dGV.SelectedRows[0].Cells.Count > 0)
            {
                FavModel _tempf = new FavModel
                {
                    ID = dGV.SelectedRows[0].Cells["ID"].Value.ToString(),
                    PID = dGV.SelectedRows[0].Cells["PID"].Value.ToString(),
                    CID = dGV.SelectedRows[0].Cells["CID"].Value.ToString(),
                    Name = dGV.SelectedRows[0].Cells["Name"].Value.ToString(),
                    Anmerkung = dGV.SelectedRows[0].Cells["Anmerkung"].Value.ToString()

                };
                _Fav.Value = _tempf;
                _Fav.OnDelete();
                dGV.DataSource = _Fav.ValueList;
            }
        }

        private void SearchPMR466Chanel_Click(object sender, EventArgs e)
        {
            ObservableCollection<PMR466Model> _tmp = _PMR.ValueList;
            PMRSelection<PMR466Model> _sec = new PMRSelection<PMR466Model>("PMR466 Suche", "Channel Nummer : ", "ID", ref _tmp);
            if (_sec.ShowDialog() == DialogResult.OK)
            {
                foreach (PMR466Model pm in _PMR.ValueList.Where(c => c.ID.Equals(_sec.result.ID)))
                {
                    tBPID.Text = pm.ID;
                    tBPFreq.Text = pm.Frequenz;
                    rTBPAn.Text = pm.Anmerkung;
                }
            }
            _sec.Close();
            _Optik.PrepareButton(ref CmdSave, "Speichern");
            _Optik.PrepareButton(ref CmdCancel);
        }

        private void SearchPMR466Frequenz_Click(object sender, EventArgs e)
        {
            ObservableCollection<PMR466Model> _tmp = _PMR.ValueList;
            PMRSelection<PMR466Model> _sec = new PMRSelection<PMR466Model>("PMR466 Suche", "Channel Frequenz : ", "Frequenz", ref _tmp);
            if (_sec.ShowDialog() == DialogResult.OK)
            {
                foreach (PMR466Model pm in _PMR.ValueList.Where(c => c.Frequenz.Equals(_sec.result.Frequenz)))
                {
                    tBPID.Text = pm.ID;
                    tBPFreq.Text = pm.Frequenz;
                    rTBPAn.Text = pm.Anmerkung;
                }
            }
            _sec.Close();
            _Optik.PrepareButton(ref CmdSave, "Speichern");
            _Optik.PrepareButton(ref CmdCancel);
        }

        private void SearchSavesName_Click(object sender, EventArgs e)
        {
            ObservableCollection<FavModel> _tmp = _Fav.ValueList;
            PMRSelection<FavModel> _sec = new PMRSelection<FavModel>("Voreinstellung Suchen", "Name der Voreinstellung : ", "Name", ref _tmp);
            if (_sec.ShowDialog() == DialogResult.OK)
            {
                foreach (FavModel fav in _Fav.ValueList.Where(c => c.Name.Equals(_sec.result.Name)))
                {
                    _Optik.SetTextBox(ref tBID, fav.Name);
                    _Optik.SetTextBox(ref rTBAn, fav.Anmerkung, false);
                    _Optik.SetTextBox(ref tBPID, fav.PID);
                    _Optik.SetTextBox(ref tBPFreq, _PMR.ValueList.Where(c=>c.ID.Equals(fav.PID)).First().Frequenz);
                    _Optik.SetTextBox(ref rTBPAn, _PMR.ValueList.Where(c => c.ID.Equals(fav.PID)).First().Anmerkung);
                    _Optik.SetTextBox(ref tBCID, fav.CID);
                    _Optik.SetTextBox(ref tBC38, _CTSS.ValueList.Where(c => c.ID.Equals(fav.CID)).First().SC);
                    _Optik.SetTextBox(ref tBCTon, _CTSS.ValueList.Where(c => c.ID.Equals(fav.CID)).First().Ton);
                }
                _Optik.PrepareButton(ref CmdSave, "Speichern");
                _Optik.PrepareButton(ref CmdCancel);
                _Optik.PrepareGroupBox(ref gBEI);
            }
            else
            {
                _Optik.PrepareButton(ref CmdSave, Visibility: false);
                _Optik.PrepareButton(ref CmdCancel, Visibility: false);
                _Optik.PrepareGroupBox(ref gBEI, Visibility: false);
                MainMenueFileLoad_Click(null,null);
            }
            _sec.Close();
        }

        private void MainMenueInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alle Rechte bei Sascha Köhne \r\n"+
                "Dieses Programm ist ihnen zur Freien Verfügung überlassen worden.\r\n"+
                "Für Eventuelle Schäden oder Datenverlust wird keine Haftung übernohmen!\r\n"
            );
        }
    }
}
