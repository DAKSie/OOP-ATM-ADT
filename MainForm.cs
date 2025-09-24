using OOPLab.Models;
using OOPLab.ViewModels;

namespace OOPLab
{
    public partial class MainForm : Form
    {
        private readonly AccountViewModel viewModel = new();
        public MainForm()
        {
            InitializeComponent();
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            dgvAccounts.DataSource = null;
            var accounts = viewModel.GetAccounts();
            dgvAccounts.DataSource = accounts;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var account = new Account
            {
                OwnerName = txtOwner.Text,
                Balance = double.TryParse(txtBalance.Text, out var bal) ? bal : 0,
                IsActive = chkActive.Checked,
                CreatedDate = DateTime.Now
            };
            viewModel.AddAccount(account);
            LoadAccounts();
            resetElements();
        }

        private void resetElements()
        {
            txtOwner.Text = string.Empty;
            txtBalance.Text = string.Empty;
            chkActive.Checked = false;
        }
    }
} 
