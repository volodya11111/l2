namespace firstWork
{
    partial class MyForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnShowDialog = new Button();
            btnOk = new Button();
            timeDebug = new timeDebug();
            paswdHide1 = new PaswdHide();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnShowDialog
            // 
            btnShowDialog.Location = new Point(208, 124);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(89, 48);
            btnShowDialog.TabIndex = 1;
            btnShowDialog.Text = "ShowDialog";
            btnShowDialog.UseVisualStyleBackColor = true;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 124);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(89, 48);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // timeDebug
            // 
            timeDebug.Tick += TimeDebug_Tick;
            // 
            // paswdHide1
            // 
            paswdHide1.Label = "";
            paswdHide1.Location = new Point(12, 12);
            paswdHide1.MaximumSize = new Size(0, 50);
            paswdHide1.MinimumSize = new Size(149, 50);
            paswdHide1.Name = "paswdHide1";
            paswdHide1.Password = "";
            paswdHide1.Size = new Size(149, 50);
            paswdHide1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 184);
            Controls.Add(label1);
            Controls.Add(paswdHide1);
            Controls.Add(btnOk);
            Controls.Add(btnShowDialog);
            Name = "MyForm";
            Text = "My Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnShowDialog;
        private Button btnOk;
        private timeDebug timeDebug;
        private PaswdHide paswdHide1;
        private Label label1;
    }
}