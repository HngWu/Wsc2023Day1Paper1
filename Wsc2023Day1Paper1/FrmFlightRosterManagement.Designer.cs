namespace Wsc2023Day1Paper1
{
    partial class FrmFlightRosterManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlightRosterManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvflights = new System.Windows.Forms.DataGridView();
            this.monthpicker = new System.Windows.Forms.DateTimePicker();
            this.yearpicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnretrieve = new System.Windows.Forms.Button();
            this.btnnrosterflight = new System.Windows.Forms.Button();
            this.tbnsave = new System.Windows.Forms.Button();
            this.dgvtotalactivehours = new System.Windows.Forms.DataGridView();
            this.lbteamtotalactivedutyhours = new System.Windows.Forms.Label();
            this.lbflightrecordsviolatedrestperiod = new System.Windows.Forms.Label();
            this.dgvflightrecordsrestperiod = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lbteamsunabletoreturntohomeairport = new System.Windows.Forms.Label();
            this.dgvteamsunabletoreturntoairport = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lbfightrecordsunabletoregister = new System.Windows.Forms.Label();
            this.dgvflightsunabletoroster = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btndeletersoter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotalactivehours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflightrecordsrestperiod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteamsunabletoreturntoairport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflightsunabletoroster)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1581, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 44);
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
            // dgvflights
            // 
            this.dgvflights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvflights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvflights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvflights.Location = new System.Drawing.Point(12, 213);
            this.dgvflights.Name = "dgvflights";
            this.dgvflights.Size = new System.Drawing.Size(1553, 360);
            this.dgvflights.TabIndex = 3;
            this.dgvflights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // monthpicker
            // 
            this.monthpicker.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthpicker.Location = new System.Drawing.Point(117, 167);
            this.monthpicker.Name = "monthpicker";
            this.monthpicker.Size = new System.Drawing.Size(200, 32);
            this.monthpicker.TabIndex = 4;
            // 
            // yearpicker
            // 
            this.yearpicker.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearpicker.Location = new System.Drawing.Point(387, 168);
            this.yearpicker.Name = "yearpicker";
            this.yearpicker.Size = new System.Drawing.Size(200, 32);
            this.yearpicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // tbnretrieve
            // 
            this.tbnretrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.tbnretrieve.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnretrieve.ForeColor = System.Drawing.Color.White;
            this.tbnretrieve.Location = new System.Drawing.Point(593, 165);
            this.tbnretrieve.Name = "tbnretrieve";
            this.tbnretrieve.Size = new System.Drawing.Size(247, 36);
            this.tbnretrieve.TabIndex = 8;
            this.tbnretrieve.Text = "Retrieve Flight Records";
            this.tbnretrieve.UseVisualStyleBackColor = false;
            this.tbnretrieve.Click += new System.EventHandler(this.tbnretrieve_Click);
            // 
            // btnnrosterflight
            // 
            this.btnnrosterflight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btnnrosterflight.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnrosterflight.ForeColor = System.Drawing.Color.White;
            this.btnnrosterflight.Location = new System.Drawing.Point(846, 165);
            this.btnnrosterflight.Name = "btnnrosterflight";
            this.btnnrosterflight.Size = new System.Drawing.Size(149, 36);
            this.btnnrosterflight.TabIndex = 9;
            this.btnnrosterflight.Text = "Roster Flight Records";
            this.btnnrosterflight.UseVisualStyleBackColor = false;
            this.btnnrosterflight.Click += new System.EventHandler(this.tbnrosterflight_Click);
            // 
            // tbnsave
            // 
            this.tbnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.tbnsave.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnsave.ForeColor = System.Drawing.Color.White;
            this.tbnsave.Location = new System.Drawing.Point(1001, 165);
            this.tbnsave.Name = "tbnsave";
            this.tbnsave.Size = new System.Drawing.Size(149, 36);
            this.tbnsave.TabIndex = 10;
            this.tbnsave.Text = "Save Flight Roster";
            this.tbnsave.UseVisualStyleBackColor = false;
            this.tbnsave.Click += new System.EventHandler(this.tbnsave_Click);
            // 
            // dgvtotalactivehours
            // 
            this.dgvtotalactivehours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtotalactivehours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtotalactivehours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtotalactivehours.Location = new System.Drawing.Point(786, 328);
            this.dgvtotalactivehours.Name = "dgvtotalactivehours";
            this.dgvtotalactivehours.Size = new System.Drawing.Size(777, 232);
            this.dgvtotalactivehours.TabIndex = 1;
            // 
            // lbteamtotalactivedutyhours
            // 
            this.lbteamtotalactivedutyhours.AutoSize = true;
            this.lbteamtotalactivedutyhours.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbteamtotalactivedutyhours.Location = new System.Drawing.Point(786, 281);
            this.lbteamtotalactivedutyhours.Name = "lbteamtotalactivedutyhours";
            this.lbteamtotalactivedutyhours.Size = new System.Drawing.Size(278, 24);
            this.lbteamtotalactivedutyhours.TabIndex = 0;
            this.lbteamtotalactivedutyhours.Text = "Team Total Active Duty Hours";
            // 
            // lbflightrecordsviolatedrestperiod
            // 
            this.lbflightrecordsviolatedrestperiod.AutoSize = true;
            this.lbflightrecordsviolatedrestperiod.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbflightrecordsviolatedrestperiod.Location = new System.Drawing.Point(3, 305);
            this.lbflightrecordsviolatedrestperiod.Name = "lbflightrecordsviolatedrestperiod";
            this.lbflightrecordsviolatedrestperiod.Size = new System.Drawing.Size(225, 20);
            this.lbflightrecordsviolatedrestperiod.TabIndex = 2;
            this.lbflightrecordsviolatedrestperiod.Text = "Number of Flight Records: ";
            // 
            // dgvflightrecordsrestperiod
            // 
            this.dgvflightrecordsrestperiod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvflightrecordsrestperiod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvflightrecordsrestperiod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvflightrecordsrestperiod.Location = new System.Drawing.Point(3, 328);
            this.dgvflightrecordsrestperiod.Name = "dgvflightrecordsrestperiod";
            this.dgvflightrecordsrestperiod.Size = new System.Drawing.Size(777, 232);
            this.dgvflightrecordsrestperiod.TabIndex = 1;
            this.dgvflightrecordsrestperiod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvflightrecordsrestperiod_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Flight Records Violated Rest Period";
            // 
            // lbteamsunabletoreturntohomeairport
            // 
            this.lbteamsunabletoreturntohomeairport.AutoSize = true;
            this.lbteamsunabletoreturntohomeairport.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbteamsunabletoreturntohomeairport.Location = new System.Drawing.Point(786, 24);
            this.lbteamsunabletoreturntohomeairport.Name = "lbteamsunabletoreturntohomeairport";
            this.lbteamsunabletoreturntohomeairport.Size = new System.Drawing.Size(161, 20);
            this.lbteamsunabletoreturntohomeairport.TabIndex = 2;
            this.lbteamsunabletoreturntohomeairport.Text = "Number of Teams: ";
            this.lbteamsunabletoreturntohomeairport.Click += new System.EventHandler(this.lbteamsunabletoreturntohomeairport_Click);
            // 
            // dgvteamsunabletoreturntoairport
            // 
            this.dgvteamsunabletoreturntoairport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvteamsunabletoreturntoairport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvteamsunabletoreturntoairport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteamsunabletoreturntoairport.Location = new System.Drawing.Point(786, 47);
            this.dgvteamsunabletoreturntoairport.Name = "dgvteamsunabletoreturntoairport";
            this.dgvteamsunabletoreturntoairport.Size = new System.Drawing.Size(777, 231);
            this.dgvteamsunabletoreturntoairport.TabIndex = 1;
            this.dgvteamsunabletoreturntoairport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvteamsunabletoreturntoairport_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(786, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Teams Unable to Return to Home Airport";
            // 
            // lbfightrecordsunabletoregister
            // 
            this.lbfightrecordsunabletoregister.AutoSize = true;
            this.lbfightrecordsunabletoregister.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfightrecordsunabletoregister.Location = new System.Drawing.Point(3, 24);
            this.lbfightrecordsunabletoregister.Name = "lbfightrecordsunabletoregister";
            this.lbfightrecordsunabletoregister.Size = new System.Drawing.Size(225, 20);
            this.lbfightrecordsunabletoregister.TabIndex = 2;
            this.lbfightrecordsunabletoregister.Text = "Number of Flight Records: ";
            // 
            // dgvflightsunabletoroster
            // 
            this.dgvflightsunabletoroster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvflightsunabletoroster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvflightsunabletoroster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvflightsunabletoroster.Location = new System.Drawing.Point(3, 47);
            this.dgvflightsunabletoroster.Name = "dgvflightsunabletoroster";
            this.dgvflightsunabletoroster.Size = new System.Drawing.Size(777, 231);
            this.dgvflightsunabletoroster.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Flight Records Unable to Roster";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btnclear.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(1156, 165);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 36);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvflightrecordsrestperiod, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.dgvtotalactivehours, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbflightrecordsviolatedrestperiod, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbteamtotalactivedutyhours, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dgvteamsunabletoreturntoairport, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dgvflightsunabletoroster, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbteamsunabletoreturntohomeairport, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbfightrecordsunabletoregister, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 616);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1566, 563);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btndeletersoter
            // 
            this.btndeletersoter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btndeletersoter.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletersoter.ForeColor = System.Drawing.Color.White;
            this.btndeletersoter.Location = new System.Drawing.Point(1287, 166);
            this.btndeletersoter.Name = "btndeletersoter";
            this.btndeletersoter.Size = new System.Drawing.Size(165, 36);
            this.btndeletersoter.TabIndex = 14;
            this.btndeletersoter.Text = "Delete Roster";
            this.btndeletersoter.UseVisualStyleBackColor = false;
            this.btndeletersoter.Click += new System.EventHandler(this.btndeletersoter_Click);
            // 
            // FrmFlightRosterManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 1182);
            this.Controls.Add(this.btndeletersoter);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.tbnsave);
            this.Controls.Add(this.btnnrosterflight);
            this.Controls.Add(this.tbnretrieve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearpicker);
            this.Controls.Add(this.monthpicker);
            this.Controls.Add(this.dgvflights);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFlightRosterManagement";
            this.Text = "FrmFlightRosterManagement";
            this.Load += new System.EventHandler(this.FrmFlightRosterManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtotalactivehours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflightrecordsrestperiod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteamsunabletoreturntoairport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvflightsunabletoroster)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvflights;
        private System.Windows.Forms.DateTimePicker monthpicker;
        private System.Windows.Forms.DateTimePicker yearpicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tbnretrieve;
        private System.Windows.Forms.Button btnnrosterflight;
        private System.Windows.Forms.Button tbnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvtotalactivehours;
        private System.Windows.Forms.Label lbteamtotalactivedutyhours;
        private System.Windows.Forms.Label lbflightrecordsviolatedrestperiod;
        private System.Windows.Forms.DataGridView dgvflightrecordsrestperiod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbteamsunabletoreturntohomeairport;
        private System.Windows.Forms.DataGridView dgvteamsunabletoreturntoairport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbfightrecordsunabletoregister;
        private System.Windows.Forms.DataGridView dgvflightsunabletoroster;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btndeletersoter;
    }
}