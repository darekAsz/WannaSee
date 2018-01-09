namespace WannaSee
{
    partial class UserPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.SaveUser = new System.Windows.Forms.Button();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa użytkownika: ";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(26, 106);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(181, 20);
            this.userName.TabIndex = 1;
            // 
            // SaveUser
            // 
            this.SaveUser.Location = new System.Drawing.Point(26, 198);
            this.SaveUser.Name = "SaveUser";
            this.SaveUser.Size = new System.Drawing.Size(75, 23);
            this.SaveUser.TabIndex = 2;
            this.SaveUser.Text = "OK";
            this.SaveUser.UseVisualStyleBackColor = true;
            this.SaveUser.Click += new System.EventHandler(this.SaveUser_Click);
            // 
            // BackToMenu
            // 
            this.BackToMenu.Location = new System.Drawing.Point(163, 198);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(75, 23);
            this.BackToMenu.TabIndex = 3;
            this.BackToMenu.Text = "Anuluj";
            this.BackToMenu.UseVisualStyleBackColor = true;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.SaveUser);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button SaveUser;
        private System.Windows.Forms.Button BackToMenu;
    }
}