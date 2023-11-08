
namespace GestionInfirmerie
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSurl1 = new System.Windows.Forms.Panel();
            this.pnlSurl2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.picLSV = new System.Windows.Forms.PictureBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLSV)).BeginInit();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(97, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONNEXION";
            // 
            // pnlSurl1
            // 
            this.pnlSurl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.pnlSurl1.Location = new System.Drawing.Point(60, 234);
            this.pnlSurl1.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSurl1.Name = "pnlSurl1";
            this.pnlSurl1.Size = new System.Drawing.Size(239, 3);
            this.pnlSurl1.TabIndex = 3;
            // 
            // pnlSurl2
            // 
            this.pnlSurl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.pnlSurl2.Location = new System.Drawing.Point(14, 422);
            this.pnlSurl2.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSurl2.Name = "pnlSurl2";
            this.pnlSurl2.Size = new System.Drawing.Size(384, 2);
            this.pnlSurl2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 60);
            this.panel3.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::GestionInfirmerie.Properties.Resources.cfafda99_2287_4a22_9f42_375d72734804;
            this.btnClose.Location = new System.Drawing.Point(764, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 41);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textUsername
            // 
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.textUsername.Location = new System.Drawing.Point(28, 321);
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(325, 34);
            this.textUsername.TabIndex = 10;
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.textPassword.Location = new System.Drawing.Point(28, 281);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(325, 34);
            this.textPassword.TabIndex = 11;
            // 
            // picPassword
            // 
            this.picPassword.Image = global::GestionInfirmerie.Properties.Resources.padlock;
            this.picPassword.Location = new System.Drawing.Point(246, 375);
            this.picPassword.Margin = new System.Windows.Forms.Padding(5);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(41, 44);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 4;
            this.picPassword.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::GestionInfirmerie.Properties.Resources.user__1_;
            this.picUser.Location = new System.Drawing.Point(65, 208);
            this.picUser.Margin = new System.Windows.Forms.Padding(5);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(19, 24);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 2;
            this.picUser.TabStop = false;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Location = new System.Drawing.Point(14, 434);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(384, 52);
            this.btnConnexion.TabIndex = 12;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.lblDelete.Location = new System.Drawing.Point(48, 397);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(170, 20);
            this.lblDelete.TabIndex = 13;
            this.lblDelete.Text = "effacer les champs";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // picLSV
            // 
            this.picLSV.BackColor = System.Drawing.Color.Transparent;
            this.picLSV.Image = global::GestionInfirmerie.Properties.Resources.Logo_St_Vincent_3;
            this.picLSV.Location = new System.Drawing.Point(114, 14);
            this.picLSV.Margin = new System.Windows.Forms.Padding(5);
            this.picLSV.Name = "picLSV";
            this.picLSV.Size = new System.Drawing.Size(141, 124);
            this.picLSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLSV.TabIndex = 14;
            this.picLSV.TabStop = false;
            this.picLSV.Click += new System.EventHandler(this.picLSV_Click);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Transparent;
            this.pnl2.Controls.Add(this.lblNom);
            this.pnl2.Controls.Add(this.picLSV);
            this.pnl2.Controls.Add(this.label1);
            this.pnl2.Controls.Add(this.pnlSurl1);
            this.pnl2.Controls.Add(this.picUser);
            this.pnl2.ForeColor = System.Drawing.Color.White;
            this.pnl2.Location = new System.Drawing.Point(274, 89);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(351, 338);
            this.pnl2.TabIndex = 15;
            this.pnl2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl2_Paint);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(49)))), ((int)(((byte)(104)))));
            this.lblNom.Location = new System.Drawing.Point(92, 208);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 24);
            this.lblNom.TabIndex = 15;
            this.lblNom.Text = "nom\r\n";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlSurl2);
            this.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLSV)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel pnlSurl1;
        private System.Windows.Forms.Panel pnlSurl2;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.PictureBox picLSV;
        private System.Windows.Forms.Label lblNom;
    }
}

