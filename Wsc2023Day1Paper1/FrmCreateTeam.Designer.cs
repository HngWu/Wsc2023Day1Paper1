namespace Wsc2023Day1Paper1
{
    partial class FrmCreateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateTeam));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbairport = new System.Windows.Forms.ComboBox();
            this.cbcountry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbteamno = new System.Windows.Forms.TextBox();
            this.dgvcrewavailable = new System.Windows.Forms.DataGridView();
            this.dgvselectedcrew = new System.Windows.Forms.DataGridView();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnleftall = new System.Windows.Forms.Button();
            this.btnrightall = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcrewavailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectedcrew)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1307, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "WorldSKills Airlines Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Country";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Home Airport";
            // 
            // cbairport
            // 
            this.cbairport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbairport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbairport.FormattingEnabled = true;
            this.cbairport.Location = new System.Drawing.Point(521, 316);
            this.cbairport.Name = "cbairport";
            this.cbairport.Size = new System.Drawing.Size(247, 28);
            this.cbairport.TabIndex = 28;
            this.cbairport.SelectedIndexChanged += new System.EventHandler(this.cbairport_SelectedIndexChanged);
            // 
            // cbcountry
            // 
            this.cbcountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcountry.FormattingEnabled = true;
            this.cbcountry.Location = new System.Drawing.Point(521, 264);
            this.cbcountry.Name = "cbcountry";
            this.cbcountry.Size = new System.Drawing.Size(247, 28);
            this.cbcountry.TabIndex = 27;
            this.cbcountry.SelectedIndexChanged += new System.EventHandler(this.cbcountry_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Team Number";
            // 
            // tbteamno
            // 
            this.tbteamno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbteamno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbteamno.Location = new System.Drawing.Point(521, 214);
            this.tbteamno.Name = "tbteamno";
            this.tbteamno.Size = new System.Drawing.Size(247, 26);
            this.tbteamno.TabIndex = 20;
            // 
            // dgvcrewavailable
            // 
            this.dgvcrewavailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcrewavailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcrewavailable.Location = new System.Drawing.Point(12, 526);
            this.dgvcrewavailable.Name = "dgvcrewavailable";
            this.dgvcrewavailable.Size = new System.Drawing.Size(581, 395);
            this.dgvcrewavailable.TabIndex = 32;
            this.dgvcrewavailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcrewavailable_CellContentClick);
            // 
            // dgvselectedcrew
            // 
            this.dgvselectedcrew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvselectedcrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvselectedcrew.Location = new System.Drawing.Point(708, 526);
            this.dgvselectedcrew.Name = "dgvselectedcrew";
            this.dgvselectedcrew.Size = new System.Drawing.Size(581, 395);
            this.dgvselectedcrew.TabIndex = 33;
            // 
            // btnright
            // 
            this.btnright.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnright.Location = new System.Drawing.Point(611, 681);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(75, 23);
            this.btnright.TabIndex = 34;
            this.btnright.Text = ">";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btnleft
            // 
            this.btnleft.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleft.Location = new System.Drawing.Point(611, 745);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(75, 23);
            this.btnleft.TabIndex = 35;
            this.btnleft.Text = "<";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnleftall
            // 
            this.btnleftall.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleftall.Location = new System.Drawing.Point(611, 803);
            this.btnleftall.Name = "btnleftall";
            this.btnleftall.Size = new System.Drawing.Size(75, 23);
            this.btnleftall.TabIndex = 36;
            this.btnleftall.Text = "<<";
            this.btnleftall.UseVisualStyleBackColor = true;
            this.btnleftall.Click += new System.EventHandler(this.btnleftall_Click);
            // 
            // btnrightall
            // 
            this.btnrightall.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrightall.Location = new System.Drawing.Point(611, 628);
            this.btnrightall.Name = "btnrightall";
            this.btnrightall.Size = new System.Drawing.Size(75, 23);
            this.btnrightall.TabIndex = 37;
            this.btnrightall.Text = ">>";
            this.btnrightall.UseVisualStyleBackColor = true;
            this.btnrightall.Click += new System.EventHandler(this.btnrightall_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btnsave.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(521, 383);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(247, 23);
            this.btnsave.TabIndex = 38;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FrmCreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 933);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnrightall);
            this.Controls.Add(this.btnleftall);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.dgvselectedcrew);
            this.Controls.Add(this.dgvcrewavailable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbairport);
            this.Controls.Add(this.cbcountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbteamno);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCreateTeam";
            this.Text = "FrmCreateTeam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcrewavailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectedcrew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbairport;
        private System.Windows.Forms.ComboBox cbcountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbteamno;
        private System.Windows.Forms.DataGridView dgvcrewavailable;
        private System.Windows.Forms.DataGridView dgvselectedcrew;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnleftall;
        private System.Windows.Forms.Button btnrightall;
        private System.Windows.Forms.Button btnsave;
    }
}