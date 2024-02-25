namespace savarjisho
{
    partial class UserDialogForm
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
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            maleCheckBox = new CheckBox();
            femaleCheckBox = new CheckBox();
            ageTextBox = new TextBox();
            SaveButton = new Button();
            FNameLab = new Label();
            LNameLab = new Label();
            EmailLabel = new Label();
            AgeLabel = new Label();
            GenderLabel = new Label();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(277, 74);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(267, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(277, 116);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(267, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(277, 160);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(267, 23);
            emailTextBox.TabIndex = 2;
            // 
            // maleCheckBox
            // 
            maleCheckBox.AutoSize = true;
            maleCheckBox.Location = new Point(277, 254);
            maleCheckBox.Name = "maleCheckBox";
            maleCheckBox.Size = new Size(52, 19);
            maleCheckBox.TabIndex = 3;
            maleCheckBox.Text = "Male";
            maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // femaleCheckBox
            // 
            femaleCheckBox.AutoSize = true;
            femaleCheckBox.Location = new Point(350, 253);
            femaleCheckBox.Name = "femaleCheckBox";
            femaleCheckBox.Size = new Size(64, 19);
            femaleCheckBox.TabIndex = 4;
            femaleCheckBox.Text = "Female";
            femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(277, 203);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(267, 23);
            ageTextBox.TabIndex = 5;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(315, 321);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(162, 39);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveBtn_Click;
            // 
            // FNameLab
            // 
            FNameLab.AutoSize = true;
            FNameLab.Location = new Point(200, 77);
            FNameLab.Name = "FNameLab";
            FNameLab.Size = new Size(62, 15);
            FNameLab.TabIndex = 7;
            FNameLab.Text = "First name";
            // 
            // LNameLab
            // 
            LNameLab.AutoSize = true;
            LNameLab.Location = new Point(201, 119);
            LNameLab.Name = "LNameLab";
            LNameLab.Size = new Size(61, 15);
            LNameLab.TabIndex = 8;
            LNameLab.Text = "Last name";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(224, 163);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 9;
            EmailLabel.Text = "Email";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(224, 206);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(28, 15);
            AgeLabel.TabIndex = 10;
            AgeLabel.Text = "Age";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(224, 254);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(45, 15);
            GenderLabel.TabIndex = 11;
            GenderLabel.Text = "Gender";
            // 
            // UserDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 460);
            Controls.Add(GenderLabel);
            Controls.Add(AgeLabel);
            Controls.Add(EmailLabel);
            Controls.Add(LNameLab);
            Controls.Add(FNameLab);
            Controls.Add(SaveButton);
            Controls.Add(ageTextBox);
            Controls.Add(femaleCheckBox);
            Controls.Add(maleCheckBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "UserDialogForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private CheckBox maleCheckBox;
        private CheckBox femaleCheckBox;
        private TextBox ageTextBox;
        private Button SaveButton;
        private Label FNameLab;
        private Label LNameLab;
        private Label EmailLabel;
        private Label AgeLabel;
        private Label GenderLabel;
    }
}