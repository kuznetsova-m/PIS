using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using RoadmapApp.Enums;
using RoadmapApp.Models;
using RoadmapApp.Rules;

namespace RoadmapApp.Forms
{
    public partial class FormMain : Form
    {
        private User _currentUser;
        private bool _dataChanged = false;

        public FormMain(User user)
        {
            _currentUser = user;
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cmbPurpose.DataSource = Enum.GetValues(typeof(Purpose))
                .Cast<Purpose>()
                .Select(p => new
                {
                    Value = p,
                    Description = GetEnumDescription(p)
                })
                .ToList();
            cmbPurpose.DisplayMember = "Description";
            cmbPurpose.ValueMember = "Value";
            cmbPurpose.SelectedValue = _currentUser.Purpose;

            dtpEntryDate.Value = _currentUser.EntryDate != DateTime.MinValue ? _currentUser.EntryDate : DateTime.Today;

            if (_currentUser.PatentDate.HasValue && _currentUser.PatentDate != DateTime.MinValue)
            {
                dtpPatentDate.Value = _currentUser.PatentDate.Value;
                dtpPatentDate.Checked = true;
            }
            else
            {
                dtpPatentDate.Value = DateTime.Today;
                dtpPatentDate.Checked = false;
            }

            DisplayRoadMap();
        }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPurpose.SelectedValue is Purpose selectedPurpose)
            {
                _currentUser.Purpose = selectedPurpose;
            }

            _currentUser.EntryDate = dtpEntryDate.Value.Date;

            if (dtpPatentDate.Checked)
                _currentUser.PatentDate = dtpPatentDate.Value.Date;
            else
                _currentUser.PatentDate = null;

            Program.UserRepo.Save();
            _dataChanged = false;
            MessageBox.Show("Данные сохранены.");
        }

        private void btnGenerateRoadMap_Click(object sender, EventArgs e)
        {
            GenerateRoadMap();
            Program.UserRepo.Save();
            DisplayRoadMap();
            tabControlMain.SelectedTab = tabPageRoadMap;
        }

        private void GenerateRoadMap()
        {
            _currentUser.RoadMap.Points.Clear();

            try
            {
                IRule rule = RuleFactory.GetRule(_currentUser.Purpose);
                string message = rule.GetMessage(_currentUser);

                _currentUser.RoadMap.Points.Add(new RoadMapPoint(message, DateTime.Now)); 
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayRoadMap()
        {
            txtRoadMap.Text = _currentUser.RoadMap.ToString();
            txtRoadMap.SelectionStart = 0;
            txtRoadMap.SelectionLength = 0;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dataChanged)
            {
                var result = MessageBox.Show("Есть несохраненные изменения. Сохранить?",
                    "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btnSave_Click(null, null);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }

            Environment.Exit(0);
        }

        private void cmbPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dataChanged = true;
        }

        private void dtpEntryDate_ValueChanged(object sender, EventArgs e)
        {
            _dataChanged = true;
        }

        private void dtpPatentDate_ValueChanged(object sender, EventArgs e)
        {
            _dataChanged = true;
        }
    }
}
