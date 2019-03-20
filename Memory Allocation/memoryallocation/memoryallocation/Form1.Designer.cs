namespace memoryallocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FirstFit = new System.Windows.Forms.RadioButton();
            this.BestFit = new System.Windows.Forms.RadioButton();
            this.fragmentation = new System.Windows.Forms.CheckBox();
            this.MSize = new System.Windows.Forms.NumericUpDown();
            this.GigaByte = new System.Windows.Forms.RadioButton();
            this.MegaByte = new System.Windows.Forms.RadioButton();
            this.KiloByte = new System.Windows.Forms.RadioButton();
            this.MemorySize = new System.Windows.Forms.GroupBox();
            this.Byte = new System.Windows.Forms.RadioButton();
            this.Set = new System.Windows.Forms.Button();
            this.Holes = new System.Windows.Forms.GroupBox();
            this.Byte1 = new System.Windows.Forms.RadioButton();
            this.Done = new System.Windows.Forms.Button();
            this.AddHole = new System.Windows.Forms.Button();
            this.holeAddress = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MegaByte1 = new System.Windows.Forms.RadioButton();
            this.GigaByte1 = new System.Windows.Forms.RadioButton();
            this.HSize = new System.Windows.Forms.NumericUpDown();
            this.KiloByte1 = new System.Windows.Forms.RadioButton();
            this.Allocate = new System.Windows.Forms.Button();
            this.AllocateProcess = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Byte2 = new System.Windows.Forms.RadioButton();
            this.PID = new System.Windows.Forms.Label();
            this.KiloByte2 = new System.Windows.Forms.RadioButton();
            this.MegaByte2 = new System.Windows.Forms.RadioButton();
            this.PSize = new System.Windows.Forms.NumericUpDown();
            this.GigaByte2 = new System.Windows.Forms.RadioButton();
            this.Reset = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.RAM = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.GroupBox();
            this.Result = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MSize)).BeginInit();
            this.MemorySize.SuspendLayout();
            this.Holes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holeAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSize)).BeginInit();
            this.AllocateProcess.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.Status.SuspendLayout();
            this.Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstFit
            // 
            this.FirstFit.AutoSize = true;
            this.FirstFit.Location = new System.Drawing.Point(12, 22);
            this.FirstFit.Name = "FirstFit";
            this.FirstFit.Size = new System.Drawing.Size(72, 21);
            this.FirstFit.TabIndex = 0;
            this.FirstFit.Text = "First Fit";
            this.FirstFit.UseVisualStyleBackColor = true;
            // 
            // BestFit
            // 
            this.BestFit.AutoSize = true;
            this.BestFit.Location = new System.Drawing.Point(12, 49);
            this.BestFit.Name = "BestFit";
            this.BestFit.Size = new System.Drawing.Size(73, 21);
            this.BestFit.TabIndex = 1;
            this.BestFit.Text = "Best Fit";
            this.BestFit.UseVisualStyleBackColor = true;
            // 
            // fragmentation
            // 
            this.fragmentation.AutoSize = true;
            this.fragmentation.Location = new System.Drawing.Point(12, 87);
            this.fragmentation.Name = "fragmentation";
            this.fragmentation.Size = new System.Drawing.Size(116, 21);
            this.fragmentation.TabIndex = 2;
            this.fragmentation.Text = "fragmentation";
            this.fragmentation.UseVisualStyleBackColor = true;
            // 
            // MSize
            // 
            this.MSize.Location = new System.Drawing.Point(118, 51);
            this.MSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MSize.Name = "MSize";
            this.MSize.Size = new System.Drawing.Size(104, 24);
            this.MSize.TabIndex = 3;
            this.MSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GigaByte
            // 
            this.GigaByte.AutoSize = true;
            this.GigaByte.Location = new System.Drawing.Point(29, 41);
            this.GigaByte.Name = "GigaByte";
            this.GigaByte.Size = new System.Drawing.Size(87, 21);
            this.GigaByte.TabIndex = 2;
            this.GigaByte.TabStop = true;
            this.GigaByte.Text = "Giga Byte";
            this.GigaByte.UseVisualStyleBackColor = true;
            // 
            // MegaByte
            // 
            this.MegaByte.AutoSize = true;
            this.MegaByte.Location = new System.Drawing.Point(29, 68);
            this.MegaByte.Name = "MegaByte";
            this.MegaByte.Size = new System.Drawing.Size(93, 21);
            this.MegaByte.TabIndex = 3;
            this.MegaByte.TabStop = true;
            this.MegaByte.Text = "Mega Byte";
            this.MegaByte.UseVisualStyleBackColor = true;
            // 
            // KiloByte
            // 
            this.KiloByte.AutoSize = true;
            this.KiloByte.Location = new System.Drawing.Point(29, 95);
            this.KiloByte.Name = "KiloByte";
            this.KiloByte.Size = new System.Drawing.Size(81, 21);
            this.KiloByte.TabIndex = 4;
            this.KiloByte.TabStop = true;
            this.KiloByte.Text = "Kilo Byte";
            this.KiloByte.UseVisualStyleBackColor = true;
            // 
            // MemorySize
            // 
            this.MemorySize.Controls.Add(this.Byte);
            this.MemorySize.Controls.Add(this.Set);
            this.MemorySize.Controls.Add(this.MegaByte);
            this.MemorySize.Controls.Add(this.GigaByte);
            this.MemorySize.Controls.Add(this.MSize);
            this.MemorySize.Controls.Add(this.KiloByte);
            this.MemorySize.Location = new System.Drawing.Point(24, 41);
            this.MemorySize.Name = "MemorySize";
            this.MemorySize.Size = new System.Drawing.Size(228, 291);
            this.MemorySize.TabIndex = 5;
            this.MemorySize.TabStop = false;
            this.MemorySize.Text = "Memory Size ";
            // 
            // Byte
            // 
            this.Byte.AutoSize = true;
            this.Byte.Location = new System.Drawing.Point(29, 122);
            this.Byte.Name = "Byte";
            this.Byte.Size = new System.Drawing.Size(57, 21);
            this.Byte.TabIndex = 14;
            this.Byte.TabStop = true;
            this.Byte.Text = "Byte";
            this.Byte.UseVisualStyleBackColor = true;
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(118, 86);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(74, 30);
            this.Set.TabIndex = 13;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Holes
            // 
            this.Holes.Controls.Add(this.Byte1);
            this.Holes.Controls.Add(this.Done);
            this.Holes.Controls.Add(this.AddHole);
            this.Holes.Controls.Add(this.holeAddress);
            this.Holes.Controls.Add(this.label2);
            this.Holes.Controls.Add(this.MegaByte1);
            this.Holes.Controls.Add(this.GigaByte1);
            this.Holes.Controls.Add(this.HSize);
            this.Holes.Controls.Add(this.KiloByte1);
            this.Holes.Enabled = false;
            this.Holes.Location = new System.Drawing.Point(264, 32);
            this.Holes.Name = "Holes";
            this.Holes.Size = new System.Drawing.Size(289, 300);
            this.Holes.TabIndex = 6;
            this.Holes.TabStop = false;
            this.Holes.Text = "Make Holes";
            // 
            // Byte1
            // 
            this.Byte1.AutoSize = true;
            this.Byte1.Location = new System.Drawing.Point(26, 115);
            this.Byte1.Name = "Byte1";
            this.Byte1.Size = new System.Drawing.Size(57, 21);
            this.Byte1.TabIndex = 15;
            this.Byte1.TabStop = true;
            this.Byte1.Text = "Byte";
            this.Byte1.UseVisualStyleBackColor = true;
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(97, 248);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(74, 30);
            this.Done.TabIndex = 13;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // AddHole
            // 
            this.AddHole.Location = new System.Drawing.Point(177, 189);
            this.AddHole.Name = "AddHole";
            this.AddHole.Size = new System.Drawing.Size(74, 30);
            this.AddHole.TabIndex = 12;
            this.AddHole.Text = "Add Hole";
            this.AddHole.UseVisualStyleBackColor = true;
            this.AddHole.Click += new System.EventHandler(this.AddHole_Click);
            // 
            // holeAddress
            // 
            this.holeAddress.Location = new System.Drawing.Point(26, 197);
            this.holeAddress.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.holeAddress.Name = "holeAddress";
            this.holeAddress.Size = new System.Drawing.Size(104, 24);
            this.holeAddress.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting Address";
            // 
            // MegaByte1
            // 
            this.MegaByte1.AutoSize = true;
            this.MegaByte1.Location = new System.Drawing.Point(26, 61);
            this.MegaByte1.Name = "MegaByte1";
            this.MegaByte1.Size = new System.Drawing.Size(93, 21);
            this.MegaByte1.TabIndex = 7;
            this.MegaByte1.TabStop = true;
            this.MegaByte1.Text = "Mega Byte";
            this.MegaByte1.UseVisualStyleBackColor = true;
            // 
            // GigaByte1
            // 
            this.GigaByte1.AutoSize = true;
            this.GigaByte1.Location = new System.Drawing.Point(26, 32);
            this.GigaByte1.Name = "GigaByte1";
            this.GigaByte1.Size = new System.Drawing.Size(87, 21);
            this.GigaByte1.TabIndex = 6;
            this.GigaByte1.TabStop = true;
            this.GigaByte1.Text = "Giga Byte";
            this.GigaByte1.UseVisualStyleBackColor = true;
            // 
            // HSize
            // 
            this.HSize.Location = new System.Drawing.Point(147, 61);
            this.HSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HSize.Name = "HSize";
            this.HSize.Size = new System.Drawing.Size(104, 24);
            this.HSize.TabIndex = 8;
            this.HSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // KiloByte1
            // 
            this.KiloByte1.AutoSize = true;
            this.KiloByte1.Location = new System.Drawing.Point(26, 88);
            this.KiloByte1.Name = "KiloByte1";
            this.KiloByte1.Size = new System.Drawing.Size(81, 21);
            this.KiloByte1.TabIndex = 9;
            this.KiloByte1.TabStop = true;
            this.KiloByte1.Text = "Kilo Byte";
            this.KiloByte1.UseVisualStyleBackColor = true;
            // 
            // Allocate
            // 
            this.Allocate.Location = new System.Drawing.Point(80, 195);
            this.Allocate.Name = "Allocate";
            this.Allocate.Size = new System.Drawing.Size(122, 39);
            this.Allocate.TabIndex = 13;
            this.Allocate.Text = "AllocateProcess";
            this.Allocate.UseVisualStyleBackColor = true;
            this.Allocate.Click += new System.EventHandler(this.Allocate_Click);
            // 
            // AllocateProcess
            // 
            this.AllocateProcess.Controls.Add(this.groupBox1);
            this.AllocateProcess.Controls.Add(this.Byte2);
            this.AllocateProcess.Controls.Add(this.PID);
            this.AllocateProcess.Controls.Add(this.Allocate);
            this.AllocateProcess.Controls.Add(this.KiloByte2);
            this.AllocateProcess.Controls.Add(this.MegaByte2);
            this.AllocateProcess.Controls.Add(this.PSize);
            this.AllocateProcess.Controls.Add(this.GigaByte2);
            this.AllocateProcess.Enabled = false;
            this.AllocateProcess.Location = new System.Drawing.Point(558, 32);
            this.AllocateProcess.Name = "AllocateProcess";
            this.AllocateProcess.Size = new System.Drawing.Size(344, 300);
            this.AllocateProcess.TabIndex = 14;
            this.AllocateProcess.TabStop = false;
            this.AllocateProcess.Text = "Allocate Process";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fragmentation);
            this.groupBox1.Controls.Add(this.FirstFit);
            this.groupBox1.Controls.Add(this.BestFit);
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 118);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "algorithm type";
            // 
            // Byte2
            // 
            this.Byte2.AutoSize = true;
            this.Byte2.Location = new System.Drawing.Point(133, 124);
            this.Byte2.Name = "Byte2";
            this.Byte2.Size = new System.Drawing.Size(57, 21);
            this.Byte2.TabIndex = 16;
            this.Byte2.TabStop = true;
            this.Byte2.Text = "Byte";
            this.Byte2.UseVisualStyleBackColor = true;
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.Location = new System.Drawing.Point(262, 63);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(29, 20);
            this.PID.TabIndex = 14;
            this.PID.Text = "P1";
            // 
            // KiloByte2
            // 
            this.KiloByte2.AutoSize = true;
            this.KiloByte2.Location = new System.Drawing.Point(133, 97);
            this.KiloByte2.Name = "KiloByte2";
            this.KiloByte2.Size = new System.Drawing.Size(81, 21);
            this.KiloByte2.TabIndex = 3;
            this.KiloByte2.TabStop = true;
            this.KiloByte2.Text = "Kilo Byte";
            this.KiloByte2.UseVisualStyleBackColor = true;
            // 
            // MegaByte2
            // 
            this.MegaByte2.AutoSize = true;
            this.MegaByte2.Location = new System.Drawing.Point(133, 70);
            this.MegaByte2.Name = "MegaByte2";
            this.MegaByte2.Size = new System.Drawing.Size(93, 21);
            this.MegaByte2.TabIndex = 2;
            this.MegaByte2.TabStop = true;
            this.MegaByte2.Text = "Mega Byte";
            this.MegaByte2.UseVisualStyleBackColor = true;
            // 
            // PSize
            // 
            this.PSize.Location = new System.Drawing.Point(234, 97);
            this.PSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PSize.Name = "PSize";
            this.PSize.Size = new System.Drawing.Size(104, 24);
            this.PSize.TabIndex = 3;
            this.PSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GigaByte2
            // 
            this.GigaByte2.AutoSize = true;
            this.GigaByte2.Location = new System.Drawing.Point(134, 41);
            this.GigaByte2.Name = "GigaByte2";
            this.GigaByte2.Size = new System.Drawing.Size(87, 21);
            this.GigaByte2.TabIndex = 4;
            this.GigaByte2.TabStop = true;
            this.GigaByte2.Text = "Giga Byte";
            this.GigaByte2.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(491, 386);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(83, 48);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.ForeColor = System.Drawing.Color.Black;
            this.StatusBox.Location = new System.Drawing.Point(17, 21);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(411, 57);
            this.StatusBox.TabIndex = 16;
            // 
            // RAM
            // 
            this.RAM.AllowUserToAddRows = false;
            this.RAM.AllowUserToDeleteRows = false;
            this.RAM.AllowUserToOrderColumns = true;
            this.RAM.AllowUserToResizeColumns = false;
            this.RAM.AllowUserToResizeRows = false;
            this.RAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RAM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RAM.Location = new System.Drawing.Point(19, 25);
            this.RAM.MaximumSize = new System.Drawing.Size(350, 380);
            this.RAM.Name = "RAM";
            this.RAM.RowHeadersVisible = false;
            this.RAM.RowTemplate.Height = 24;
            this.RAM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RAM.Size = new System.Drawing.Size(350, 350);
            this.RAM.TabIndex = 18;
            this.RAM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RAM_CellDoubleClick);
            // 
            // Status
            // 
            this.Status.Controls.Add(this.StatusBox);
            this.Status.Location = new System.Drawing.Point(24, 365);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(442, 96);
            this.Status.TabIndex = 19;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            // 
            // Result
            // 
            this.Result.Controls.Add(this.label1);
            this.Result.Controls.Add(this.textBox2);
            this.Result.Controls.Add(this.textBox1);
            this.Result.Controls.Add(this.RAM);
            this.Result.Location = new System.Drawing.Point(24, 467);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(878, 525);
            this.Result.TabIndex = 15;
            this.Result.TabStop = false;
            this.Result.Text = "Result";
            this.Result.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(387, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 71);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "To deallocate any process just double click on it in the table ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(504, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 17);
            this.textBox2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Size of holes = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 1055);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.AllocateProcess);
            this.Controls.Add(this.Holes);
            this.Controls.Add(this.MemorySize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Memory Managment";
            ((System.ComponentModel.ISupportInitialize)(this.MSize)).EndInit();
            this.MemorySize.ResumeLayout(false);
            this.MemorySize.PerformLayout();
            this.Holes.ResumeLayout(false);
            this.Holes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holeAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSize)).EndInit();
            this.AllocateProcess.ResumeLayout(false);
            this.AllocateProcess.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton FirstFit;
        private System.Windows.Forms.RadioButton BestFit;
        private System.Windows.Forms.NumericUpDown MSize;
        private System.Windows.Forms.RadioButton GigaByte;
        private System.Windows.Forms.RadioButton MegaByte;
        private System.Windows.Forms.RadioButton KiloByte;
        private System.Windows.Forms.GroupBox MemorySize;
        private System.Windows.Forms.GroupBox Holes;
        private System.Windows.Forms.NumericUpDown holeAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton MegaByte1;
        private System.Windows.Forms.RadioButton GigaByte1;
        private System.Windows.Forms.NumericUpDown HSize;
        private System.Windows.Forms.RadioButton KiloByte1;
        private System.Windows.Forms.Button AddHole;
        private System.Windows.Forms.Button Allocate;
        private System.Windows.Forms.GroupBox AllocateProcess;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.RadioButton KiloByte2;
        private System.Windows.Forms.RadioButton MegaByte2;
        private System.Windows.Forms.NumericUpDown PSize;
        private System.Windows.Forms.RadioButton GigaByte2;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.DataGridView RAM;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.CheckBox fragmentation;
        private System.Windows.Forms.RadioButton Byte;
        private System.Windows.Forms.RadioButton Byte1;
        private System.Windows.Forms.RadioButton Byte2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

