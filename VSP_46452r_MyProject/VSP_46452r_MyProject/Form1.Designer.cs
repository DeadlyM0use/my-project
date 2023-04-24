namespace VSP_46452r_MyProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonHelpENG = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxEducation = new System.Windows.Forms.GroupBox();
            this.checkBoxsredno = new System.Windows.Forms.CheckBox();
            this.checkBoxbachelor = new System.Windows.Forms.CheckBox();
            this.checkBoxmaster = new System.Windows.Forms.CheckBox();
            this.checkBoxdoctoral = new System.Windows.Forms.CheckBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.textBoxOccupation = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxEducation.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 828);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonHelpENG);
            this.tabPage1.Controls.Add(this.buttonOK);
            this.tabPage1.Controls.Add(this.buttonHelp);
            this.tabPage1.Controls.Add(this.groupBoxEducation);
            this.tabPage1.Controls.Add(this.groupBoxGender);
            this.tabPage1.Controls.Add(this.textBoxSummary);
            this.tabPage1.Controls.Add(this.textBoxOccupation);
            this.tabPage1.Controls.Add(this.textBoxAddress);
            this.tabPage1.Controls.Add(this.textBoxAge);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.labelSummary);
            this.tabPage1.Controls.Add(this.labelOccupation);
            this.tabPage1.Controls.Add(this.labelAddress);
            this.tabPage1.Controls.Add(this.labelAge);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 802);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кандидатура";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonHelpENG
            // 
            this.buttonHelpENG.CausesValidation = false;
            this.buttonHelpENG.Image = global::VSP_46452r_MyProject.Properties.Resources.Flag_of_the_United_Kingdom_svg;
            this.buttonHelpENG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHelpENG.Location = new System.Drawing.Point(466, 163);
            this.buttonHelpENG.Name = "buttonHelpENG";
            this.buttonHelpENG.Size = new System.Drawing.Size(120, 50);
            this.buttonHelpENG.TabIndex = 12;
            this.buttonHelpENG.Text = "Help";
            this.buttonHelpENG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelpENG.UseVisualStyleBackColor = true;
            this.buttonHelpENG.Click += new System.EventHandler(this.buttonHelpENG_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(466, 28);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(120, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.CausesValidation = false;
            this.buttonHelp.Image = global::VSP_46452r_MyProject.Properties.Resources._Flag_of_Bulgaria_svg;
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHelp.Location = new System.Drawing.Point(466, 81);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(120, 50);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Помощ";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxEducation
            // 
            this.groupBoxEducation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEducation.Controls.Add(this.checkBoxsredno);
            this.groupBoxEducation.Controls.Add(this.checkBoxbachelor);
            this.groupBoxEducation.Controls.Add(this.checkBoxmaster);
            this.groupBoxEducation.Controls.Add(this.checkBoxdoctoral);
            this.groupBoxEducation.Location = new System.Drawing.Point(27, 386);
            this.groupBoxEducation.Name = "groupBoxEducation";
            this.groupBoxEducation.Size = new System.Drawing.Size(412, 154);
            this.groupBoxEducation.TabIndex = 11;
            this.groupBoxEducation.TabStop = false;
            this.groupBoxEducation.Text = "Образование";
            // 
            // checkBoxsredno
            // 
            this.checkBoxsredno.AutoSize = true;
            this.checkBoxsredno.Checked = true;
            this.checkBoxsredno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxsredno.Location = new System.Drawing.Point(58, 19);
            this.checkBoxsredno.Name = "checkBoxsredno";
            this.checkBoxsredno.Size = new System.Drawing.Size(132, 17);
            this.checkBoxsredno.TabIndex = 12;
            this.checkBoxsredno.Text = "Средно образование";
            this.checkBoxsredno.UseVisualStyleBackColor = true;
            // 
            // checkBoxbachelor
            // 
            this.checkBoxbachelor.AutoSize = true;
            this.checkBoxbachelor.Location = new System.Drawing.Point(58, 52);
            this.checkBoxbachelor.Name = "checkBoxbachelor";
            this.checkBoxbachelor.Size = new System.Drawing.Size(82, 17);
            this.checkBoxbachelor.TabIndex = 13;
            this.checkBoxbachelor.Text = "Бакалавър";
            this.checkBoxbachelor.UseVisualStyleBackColor = true;
            // 
            // checkBoxmaster
            // 
            this.checkBoxmaster.AutoSize = true;
            this.checkBoxmaster.Location = new System.Drawing.Point(58, 87);
            this.checkBoxmaster.Name = "checkBoxmaster";
            this.checkBoxmaster.Size = new System.Drawing.Size(76, 17);
            this.checkBoxmaster.TabIndex = 14;
            this.checkBoxmaster.Text = "Магистър";
            this.checkBoxmaster.UseVisualStyleBackColor = true;
            // 
            // checkBoxdoctoral
            // 
            this.checkBoxdoctoral.AutoSize = true;
            this.checkBoxdoctoral.Location = new System.Drawing.Point(58, 122);
            this.checkBoxdoctoral.Name = "checkBoxdoctoral";
            this.checkBoxdoctoral.Size = new System.Drawing.Size(81, 17);
            this.checkBoxdoctoral.TabIndex = 15;
            this.checkBoxdoctoral.Text = "Докторант";
            this.checkBoxdoctoral.UseVisualStyleBackColor = true;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Location = new System.Drawing.Point(27, 79);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(412, 87);
            this.groupBoxGender.TabIndex = 10;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Пол";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(58, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(49, 17);
            this.radioButtonMale.TabIndex = 12;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мъж";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(58, 53);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(54, 17);
            this.radioButtonFemale.TabIndex = 13;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Жена";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSummary.Location = new System.Drawing.Point(27, 630);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(412, 150);
            this.textBoxSummary.TabIndex = 9;
            // 
            // textBoxOccupation
            // 
            this.textBoxOccupation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOccupation.Location = new System.Drawing.Point(227, 556);
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.Size = new System.Drawing.Size(212, 20);
            this.textBoxOccupation.TabIndex = 8;
            this.textBoxOccupation.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxOccupation.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOccupation_Validating);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Location = new System.Drawing.Point(85, 251);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(354, 120);
            this.textBoxAddress.TabIndex = 7;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Location = new System.Drawing.Point(85, 193);
            this.textBoxAge.MaxLength = 2;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(108, 20);
            this.textBoxAge.TabIndex = 6;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            this.textBoxAge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAge_KeyUp);
            this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAge_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(85, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(354, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            // 
            // labelSummary
            // 
            this.labelSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(24, 601);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(174, 13);
            this.labelSummary.TabIndex = 4;
            this.labelSummary.Text = "Разкажете още нещо за себе си";
            // 
            // labelOccupation
            // 
            this.labelOccupation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Location = new System.Drawing.Point(24, 563);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(188, 13);
            this.labelOccupation.TabIndex = 3;
            this.labelOccupation.Text = "За каква позиция кандидатствате?";
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(24, 251);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Адрес";
            // 
            // labelAge
            // 
            this.labelAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(24, 196);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(50, 13);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Възраст";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Име";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 802);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Общ преглед";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(20, 49);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxOutput.Size = new System.Drawing.Size(549, 408);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 829);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(619, 868);
            this.MinimumSize = new System.Drawing.Size(619, 868);
            this.Name = "Form1";
            this.Text = "Кандидатстване за работа";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxEducation.ResumeLayout(false);
            this.groupBoxEducation.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxEducation;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.TextBox textBoxOccupation;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelOccupation;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.CheckBox checkBoxsredno;
        private System.Windows.Forms.CheckBox checkBoxbachelor;
        private System.Windows.Forms.CheckBox checkBoxmaster;
        private System.Windows.Forms.CheckBox checkBoxdoctoral;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Button buttonHelpENG;
    }
}

