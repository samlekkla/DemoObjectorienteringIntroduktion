namespace DemoObjectorienteringIntroduktion
{
    partial class FormCreateUser
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
            textBoxUsername = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonSave = new Button();
            labelUsername = new Label();
            labelPassword = new Label();
            labelEmail = new Label();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(148, 89);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(259, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(148, 215);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(259, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(148, 151);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(259, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(280, 274);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(127, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(148, 67);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(109, 20);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "Användarnamn";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(148, 129);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Lösenord";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(148, 193);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // FormCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 381);
            Controls.Add(labelEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxUsername);
            Name = "FormCreateUser";
            Text = "Skapa ett nytta användarkonto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonSave;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelEmail;
    }
}
