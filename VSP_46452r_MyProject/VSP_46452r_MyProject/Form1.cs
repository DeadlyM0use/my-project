using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_46452r_MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.buttonOK.Enabled = false;
            this.textBoxName.Tag = false;
            this.textBoxAge.Tag = false;
            this.textBoxAddress.Tag = false;
            this.textBoxOccupation.Tag = false;
            this.groupBoxEducation.Tag = false;

            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string education = string.Empty;
            if (checkBoxsredno.Checked == true)
            {
                education = checkBoxsredno.Text;
            }
            if (checkBoxbachelor.Checked == true)
            {
                education = checkBoxbachelor.Text;
            }
            if (checkBoxmaster.Checked == true)
            {
                education = checkBoxmaster.Text;
            }
            if (checkBoxdoctoral.Checked == true)
            {
                education = checkBoxdoctoral.Text;
            }
            if (checkBoxsredno.Checked == false && checkBoxbachelor.Checked == false && checkBoxmaster.Checked == false && checkBoxdoctoral.Checked == false)
            {
                MessageBox.Show("Отбележете образование", "error");
            }

            string output;
            output = "Име: " + this.textBoxName.Text + "\r\n";
            output += "Пол: " + (string)(this.radioButtonMale.Checked ? "Мъж" : "Жена") + "\r\n";
            output += "Възраст: " + this.textBoxAge.Text + "\r\n";
            output += "Адрес: " + this.textBoxAddress.Text + "\r\n";
            output += "Образование: " + education + "\r\n";
            output += "За каква позиция кандидатствате?: " + this.textBoxOccupation.Text + "\r\n \r\n";
            output += "Разкажете още нещо за себе си: \r\n" + this.textBoxSummary.Text + "\r\n";

            this.richTextBoxOutput.Text = output;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string output;
            output = "Помощна информация: \r\n \r\n";
            output += "Име - Въведете вашето име \r\n";
            output += "Пол - Отбележете вашият пол \r\n";
            output += "Възраст - Въведете вашата възраст \r\n";
            output += "Адрес - Въведете вашият адрес \r\n";
            output += "Образование - Въведете вашето образование \r\n";
            output += "За каква позиция кандидатствате? - Единствената допустима стойност е 'Програмист' \r\n";
            output += "Разкажете нещо за себе си - Въведете информация за Вас, която смятате, че би Ви помогнала (не е задължително) \r\n";

            this.richTextBoxOutput.Text = output;
        }

        private void ValidateOK()
        {
            this.buttonOK.Enabled = ((bool)(this.textBoxName.Tag)
                && (bool)(this.textBoxAge.Tag)
                && (bool)(this.textBoxAddress.Tag)
                && (bool)(this.textBoxOccupation.Tag));
        }

        private void textBoxEmpty_Validating (object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }

            ValidateOK();
        }

        private void textBoxOccupation_Validating (object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.CompareTo("Програмист") ==0 || tb.Text.Length == 0)
            {
                tb.Tag = true;
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }

            ValidateOK();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(((tb.Text.Length==0)&&(e.KeyChar==48)) ||
                ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxAge_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            ValidateOK();
        }

        private void textBoxAge_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                if (Int16.Parse(tb.Text.ToString()) < 18)
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }

                ValidateOK();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0 && tb != textBoxOccupation)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else if (tb == textBoxOccupation && (tb.Text.Length !=0 && tb.Text.CompareTo("Програмист") != 0))
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }

            ValidateOK();
        }

        private void buttonHelpENG_Click(object sender, EventArgs e)
        {
            string output;
            output = "Auxiliary information: \r\n \r\n";
            output += "Име - Enter your name \r\n";
            output += "Пол - Mark your gender \r\n";
            output += "Възраст - Enter your age \r\n";
            output += "Адрес - Enter your address \r\n";
            output += "Образование - enter your education \r\n";
            output += "За каква позиция кандидатствате? - The only allowable value is 'Programmer' \r\n";
            output += "Разкажете нещо за себе си - Enter information about you that you think would help you (optional) ";

            this.richTextBoxOutput.Text = output;
        }
    }
}
