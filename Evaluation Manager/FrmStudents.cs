using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void btnEvaluateStudent_Click(object sender, EventArgs e) {
            Student selectedStudent = dgvStudent.CurrentRow.DataBoundItem as Student;
            if (selectedStudent != null) {
                FrmEvaluation frmEvaluation = new FrmEvaluation(selectedStudent);
                frmEvaluation.ShowDialog();
            }
        }
    }
}
