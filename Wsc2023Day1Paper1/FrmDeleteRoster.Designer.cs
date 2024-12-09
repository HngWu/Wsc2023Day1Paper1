namespace Wsc2023Day1Paper1
{
    partial class FrmDeleteRoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteRoster));
            this.tbnrosterflight = new System.Windows.Forms.Button();
            this.tbnretrieve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearpicker = new System.Windows.Forms.DateTimePicker();
            this.monthpicker = new System.Windows.Forms.DateTimePicker();
            this.dgvflights = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflights)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnrosterflight
            // 
            this.tbnrosterflight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.tbnrosterflight.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnrosterflight.ForeColor = System.Drawing.Color.White;
            this.tbnrosterflight.Location = new System.Drawing.Point(846, 161);
            this.tbnrosterflight.Name = "tbnrosterflight";
            this.tbnrosterflight.Size = new System.Drawing.Size(205, 36);
            this.tbnrosterflight.TabIndex = 20;
            this.tbnrosterflight.Text = "Delete Roster";
            this.tbnrosterflight.UseVisualStyleBackColor = false;
            this.tbnrosterflight.Click += new System.EventHandler(this.tbnrosterflight_Click);
            // 
            // tbnretrieve
            // 
            this.tbnretrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.tbnretrieve.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnretrieve.ForeColor = System.Drawing.Color.White;
            this.tbnretrieve.Location = new System.Drawing.Point(593, 161);
            this.tbnretrieve.Name = "tbnretrieve";
            this.tbnretrieve.Size = new System.Drawing.Size(247, 36);
            this.tbnretrieve.TabIndex = 19;
            this.tbnretrieve.Text = "Retrieve Flight Records";
            this.tbnretrieve.UseVisualStyleBackColor = false;
            this.tbnretrieve.Click += new System.EventHandler(this.tbnretrieve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Month";
            // 
            // yearpicker
            // 
            this.yearpicker.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearpicker.Location = new System.Drawing.Point(387, 164);
            this.yearpicker.Name = "yearpicker";
            this.yearpicker.Size = new System.Drawing.Size(200, 32);
            this.yearpicker.TabIndex = 16;
            // 
            // monthpicker
            // 
            this.monthpicker.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthpicker.Location = new System.Drawing.Point(117, 163);
            this.monthpicker.Name = "monthpicker";
            this.monthpicker.Size = new System.Drawing.Size(200, 32);
            this.monthpicker.TabIndex = 15;
            // 
            // dgvflights
            // 
            this.dgvflights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvflights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvflights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvflights.Location = new System.Drawing.Point(12, 209);
            this.dgvflights.Name = "dgvflights";
            this.dgvflights.Size = new System.Drawing.Size(1269, 399);
            this.dgvflights.TabIndex = 14;
            this.dgvflights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvflights_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1297, 125);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 44);
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
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btnclear.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(1057, 161);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(205, 36);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // FrmDeleteRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 620);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.tbnrosterflight);
            this.Controls.Add(this.tbnretrieve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearpicker);
            this.Controls.Add(this.monthpicker);
            this.Controls.Add(this.dgvflights);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDeleteRoster";
            this.Text = "FrmDeleteRoster";
            ((System.ComponentModel.ISupportInitialize)(this.dgvflights)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tbnrosterflight;
        private System.Windows.Forms.Button tbnretrieve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker yearpicker;
        private System.Windows.Forms.DateTimePicker monthpicker;
        private System.Windows.Forms.DataGridView dgvflights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnclear;
    }
}