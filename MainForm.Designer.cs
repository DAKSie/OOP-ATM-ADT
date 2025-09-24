namespace OOPLab
{
    partial class MainForm
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
            label1 = new Label();
            txtOwner = new TextBox();
            label2 = new Label();
            txtBalance = new TextBox();
            chkActive = new CheckBox();
            btnAdd = new Button();
            dgvAccounts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Account Owner";
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(32, 54);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(255, 23);
            txtOwner.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 36);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Account Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(332, 54);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(255, 23);
            txtBalance.TabIndex = 3;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(32, 83);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(75, 19);
            chkActive.TabIndex = 4;
            chkActive.Text = "is Active?";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAccounts
            // 
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(32, 163);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.Size = new Size(555, 275);
            dgvAccounts.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(dgvAccounts);
            Controls.Add(btnAdd);
            Controls.Add(chkActive);
            Controls.Add(txtBalance);
            Controls.Add(label2);
            Controls.Add(txtOwner);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOwner;
        private Label label2;
        private TextBox txtBalance;
        private CheckBox chkActive;
        private Button btnAdd;
        private DataGridView dgvAccounts;
    }
}
