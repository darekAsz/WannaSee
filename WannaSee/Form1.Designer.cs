namespace WannaSee
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
            this.components = new System.ComponentModel.Container();
            this.ChangeUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListOfFilms = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loadRates = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ChangeUser
            // 
            this.ChangeUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeUser.Location = new System.Drawing.Point(59, 230);
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Size = new System.Drawing.Size(110, 41);
            this.ChangeUser.TabIndex = 0;
            this.ChangeUser.Text = "Zmień użytkownika";
            this.ChangeUser.UseVisualStyleBackColor = false;
            this.ChangeUser.Click += new System.EventHandler(this.changeUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(198, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wanna See";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(583, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aplikacja wyświetlająca filmy dodane w zakładce \"Chcę zobaczyć\" na profilu na \r\nf" +
    "ilmwebie, dodatkowo z opcją losowania filmu i selekcji według podanych kryteriów" +
    "";
            // 
            // ListOfFilms
            // 
            this.ListOfFilms.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListOfFilms.Location = new System.Drawing.Point(293, 230);
            this.ListOfFilms.Name = "ListOfFilms";
            this.ListOfFilms.Size = new System.Drawing.Size(210, 41);
            this.ListOfFilms.TabIndex = 3;
            this.ListOfFilms.Text = "Lista Filmów";
            this.ListOfFilms.UseVisualStyleBackColor = false;
            this.ListOfFilms.Click += new System.EventHandler(this.ListOfFilms_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(86, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wczytaj oceny";
            // 
            // loadRates
            // 
            this.loadRates.AutoSize = true;
            this.loadRates.Location = new System.Drawing.Point(257, 345);
            this.loadRates.Name = "loadRates";
            this.loadRates.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadRates.Size = new System.Drawing.Size(15, 14);
            this.loadRates.TabIndex = 5;
            this.toolTip1.SetToolTip(this.loadRates, "Zaznaczenie tej opcji spowoduje wczytanie informacji o aktualnych\r\nocenach danych" +
        " filmów. Uwaga: wczytanie danych może zająć dużo \r\nczasu");
            this.loadRates.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(611, 411);
            this.Controls.Add(this.loadRates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListOfFilms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeUser);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ListOfFilms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox loadRates;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

