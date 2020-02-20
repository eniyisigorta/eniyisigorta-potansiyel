using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MaterialSkin;
using MaterialSkin.Controls;
using Pages;

namespace eniyisigorta
{
    public partial class FormMain : MaterialForm
    {
        static FormMain _obj;

        public static FormMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormMain();
                }

                return _obj;
            }
        }

        public Panel PnlContent
        {
            get { return pnlContent; }
            set { pnlContent = value; }
        }

        private void BtnClear()
        {
            btnHome.BackColor = Color.White;
            btnOffer.BackColor = Color.White;
            btnTransfer.BackColor = Color.White;
            btnPotential.BackColor = Color.White;
        }

        public FormMain()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Red500,
                Primary.Red500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _obj = this;

            Home home = new Home();
            home.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(home);

            btnHome.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(home);

            BtnClear();
            btnHome.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void btnOffer_Click(object sender, EventArgs e)
        {
            Offer offer = new Offer();
            offer.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(offer);

            BtnClear();
            btnOffer.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(transfer);

            BtnClear();
            btnTransfer.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void btnPotential_Click(object sender, EventArgs e)
        {
            Potential potential = new Potential();
            potential.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(potential);

            BtnClear();
            btnPotential.BackColor = Color.FromArgb(229, 229, 229);
        }
    }
}
