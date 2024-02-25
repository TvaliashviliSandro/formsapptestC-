namespace savarjisho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserData = new ListBox();
            AddBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // UserData
            // 
            UserData.FormattingEnabled = true;
            UserData.ItemHeight = 15;
            UserData.Location = new Point(502, 45);
            UserData.Name = "UserData";
            UserData.Size = new Size(201, 334);
            UserData.TabIndex = 0;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(82, 45);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(171, 63);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += Add_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(82, 181);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(171, 63);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += Edit_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(82, 316);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(171, 63);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(UserData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox UserData;
        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
    }
}