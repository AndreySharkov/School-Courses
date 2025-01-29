using System.ComponentModel;

namespace Shkolo_App
{
    public partial class AddNewStudentForm : Form
    {
        public AddNewStudentForm()
        {
            InitializeComponent();
        }

        public string Name { get; set; }

        public int Grade { get; set; }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.Name = this.textBoxName.Text.Trim();
            if (!int.TryParse(this.textBoxGrade.Text.Trim(), out int gradeValue))
            {
                MessageBox.Show("Invalid input! Please enter a valid grade between 1 and 12.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBoxGrade.Focus();
                return;
            }

            this.Grade = gradeValue;
            DialogResult = DialogResult.OK;
        }

        private bool CheckIfInputsAreValid()
            => CheckIfNameIsNotEmptyString() && CheckIfGardeIsValid();

        private bool CheckIfNameIsNotEmptyString()
            => !string.IsNullOrWhiteSpace(this.textBoxName.Text);

        private bool CheckIfGardeIsValid()
        {
            if (string.IsNullOrWhiteSpace(this.textBoxGrade.Text))
            {
                return false;
            }
            else if (double.TryParse(this.textBoxGrade.Text, out double gradeValue))
            {
                return gradeValue >= 1 && gradeValue <= 12;
            }

            return true;
        }

        private void ValidateStudentsName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxName.Text))
            {
                e.Cancel = true;
                this.textBoxName.Focus();
                this.errorProviderName.SetError(this.textBoxName, "Name should not be empty string!");
                this.labelNameValidation.Visible = true;
            }
            else
            {
                e.Cancel = false;
                this.errorProviderName.SetError(this.textBoxName, string.Empty);
                this.labelNameValidation.Visible = false;
            }
        }

        private void ValidatingGrade(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxGrade.Text))
            {
                e.Cancel = true;
                this.textBoxGrade.Focus();
                this.errorProviderName.SetError(this.textBoxGrade, "Grade should not be empty!");
                this.labelGradeValidation.Visible = true;
            }
            else if (!double.TryParse(this.textBoxGrade.Text, out double gradeValue))
            {
                e.Cancel = true;
                this.textBoxGrade.Focus();
                this.errorProviderName.SetError(this.textBoxGrade, "Grade should be a valid number!");
                this.labelGradeValidation.Visible = true;
            }
            else if (gradeValue < 1 || gradeValue > 12)  
            {
                e.Cancel = true;
                this.textBoxGrade.Focus();
                this.errorProviderName.SetError(this.textBoxGrade, "Grade should be between 1 and 12!");
                this.labelGradeValidation.Visible = true;
            }
            else
            {
                e.Cancel = false;
                this.errorProviderName.SetError(this.textBoxGrade, string.Empty);
                this.labelGradeValidation.Visible = false;
            }
        }

    }
}
