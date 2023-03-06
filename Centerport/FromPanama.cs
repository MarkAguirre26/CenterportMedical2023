using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSoftware
{
    public partial class FrmPanama : Form, MyInter
    {
        Main fmain;
        public FrmPanama(Main main)
        {
            InitializeComponent();
            fmain = main;
        }

        public void New()
        {
            this.Text = "New";
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {

        }




        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        private void FrmPanama_Load(object sender, EventArgs e)
        {

        }
    }
}
