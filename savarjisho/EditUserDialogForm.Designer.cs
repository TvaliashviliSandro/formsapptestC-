namespace savarjisho
{
    partial class EditUserDialogForm
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
            GenderLabel = new Label();
            AgeLabel = new Label();
            EmailLabel = new Label();
            LNameLab = new Label();
            FNameLab = new Label();
            SaveButton = new Button();
            ageTextBox = new TextBox();
            femaleCheckBox = new CheckBox();
            maleCheckBox = new CheckBox();
            emailTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(213, 250);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(45, 15);
            GenderLabel.TabIndex = 23;
            GenderLabel.Text = "Gender";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(213, 202);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(28, 15);
            AgeLabel.TabIndex = 22;
            AgeLabel.Text = "Age";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(213, 159);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 21;
            EmailLabel.Text = "Email";
            // 
            // LNameLab
            // 
            LNameLab.AutoSize = true;
            LNameLab.Location = new Point(190, 115);
            LNameLab.Name = "LNameLab";
            LNameLab.Size = new Size(61, 15);
            LNameLab.TabIndex = 20;
            LNameLab.Text = "Last name";
            // 
            // FNameLab
            // 
            FNameLab.AutoSize = true;
            FNameLab.Location = new Point(189, 73);
            FNameLab.Name = "FNameLab";
            FNameLab.Size = new Size(62, 15);
            FNameLab.TabIndex = 19;
            FNameLab.Text = "First name";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(304, 317);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(162, 39);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(266, 199);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(267, 23);
            ageTextBox.TabIndex = 17;
            // 
            // femaleCheckBox
            // 
            femaleCheckBox.AutoSize = true;
            femaleCheckBox.Location = new Point(339, 249);
            femaleCheckBox.Name = "femaleCheckBox";
            femaleCheckBox.Size = new Size(64, 19);
            femaleCheckBox.TabIndex = 16;
            femaleCheckBox.Text = "Female";
            femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // maleCheckBox
            // 
            maleCheckBox.AutoSize = true;
            maleCheckBox.Location = new Point(266, 250);
            maleCheckBox.Name = "maleCheckBox";
            maleCheckBox.Size = new Size(52, 19);
            maleCheckBox.TabIndex = 15;
            maleCheckBox.Text = "Male";
            maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(266, 156);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(267, 23);
            emailTextBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(266, 112);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(267, 23);
            lastNameTextBox.TabIndex = 13;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(266, 70);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(267, 23);
            firstNameTextBox.TabIndex = 12;
            // 
            // EditUserDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 457);
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
            Name = "EditUserDialogForm";
            Text = "EditUserDialogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GenderLabel;
        private Label AgeLabel;
        private Label EmailLabel;
        private Label LNameLab;
        private Label FNameLab;
        private Button SaveButton;
        private TextBox ageTextBox;
        private CheckBox femaleCheckBox;
        private CheckBox maleCheckBox;
        private TextBox emailTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
    }
}