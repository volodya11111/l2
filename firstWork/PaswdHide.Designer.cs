namespace firstWork
{
    partial class PaswdHide
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            btnShowPswd = new Button();
            lblPassword = new Label();
            txbPassword = new TextBox();
            SuspendLayout();
            // 
            // btnShowPswd
            // 
            btnShowPswd.Dock = DockStyle.Right;
            btnShowPswd.Location = new Point(144, 0);
            btnShowPswd.Margin = new Padding(3, 4, 3, 4);
            btnShowPswd.Name = "btnShowPswd";
            btnShowPswd.Size = new Size(26, 67);
            btnShowPswd.TabIndex = 1;
            btnShowPswd.Text = "👁";
            btnShowPswd.UseVisualStyleBackColor = true;
            btnShowPswd.Click += btnShowPswd_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Left;
            lblPassword.Location = new Point(0, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 20);
            lblPassword.TabIndex = 2;
            // 
            // txbPassword
            // 
            txbPassword.Dock = DockStyle.Bottom;
            txbPassword.Location = new Point(0, 40);
            txbPassword.Margin = new Padding(3, 4, 3, 4);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(144, 27);
            txbPassword.TabIndex = 3;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // PaswdHide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txbPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnShowPswd);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(0, 67);
            MinimumSize = new Size(170, 67);
            Name = "PaswdHide";
            Size = new Size(170, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnShowPswd;
        private Label lblPassword;
        private TextBox txbPassword;
    }
}
