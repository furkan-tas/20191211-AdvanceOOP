using PersonelAppDAL;
using PersonelAppDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelAppWinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new PersonelAppDbContext());
                unitOfWork.DepartmanRepository.Add(new Departman
                {
                    CreateDate = DateTime.Now,
                    Name = "Huuu",
                    IsActive = true,
                });

                unitOfWork.DepartmanRepository.Add(new Departman
                {
                    Name = "Hebele",
                    IsActive = true,
                });

                MessageBox.Show(unitOfWork.Complete().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
