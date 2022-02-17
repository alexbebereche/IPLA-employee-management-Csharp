using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_IPLA_Bebereche_Alexandru_Eugen
{
    public partial class AddForm : Form
    {
        public Employee item;

        public AddForm(Employee e)
        {
            InitializeComponent();
            this.item = e;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            bool success;
            float salary;
            success = float.TryParse(tbSalary.Text.Trim(), out salary);

            if (!success)
            {
                //MessageBox.Show("Negative salary");
            }
            else
            {
                salary = float.Parse(tbSalary.Text.Trim());
            }

            DateTime hireDate = dtpHireDate.Value;

            string position = tbPosition.Text.Trim();
            int freeDaysLeft = -1;
            success = float.TryParse(tbSalary.Text.Trim(), out salary);
            if (!success)
            {
                //MessageBox.Show("Free days left");
            }
            else
            {
                freeDaysLeft = int.Parse(tbFreeDaysLeft.Text.Trim());
            }

            bool ok = (name.Length != 0) && (salary > 0) && position.Length != 0 && freeDaysLeft >= 0 && freeDaysLeft <= 364;

            if (ok)
            {
                item.Name = name;
                item.Salary = salary;
                item.Position = position;
                item.HideDate = hireDate;
                item.FreeDaysLeft = freeDaysLeft;

                this.Close();
            }
            else
            {
            }


        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
