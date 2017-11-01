namespace MandleBrot {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.mandleBrotImageBox = new System.Windows.Forms.PictureBox();
			this.offXLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.offXInput = new System.Windows.Forms.NumericUpDown();
			this.offYInput = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.scaleInput = new System.Windows.Forms.NumericUpDown();
			this.maxIterationsInput = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.juliaSetBoolInput = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.realInput = new System.Windows.Forms.NumericUpDown();
			this.imaginaryInput = new System.Windows.Forms.NumericUpDown();
			this.colorInput = new System.Windows.Forms.CheckBox();
			this.autoCheckbox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.mandleBrotImageBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.offXInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.offYInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scaleInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxIterationsInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.realInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imaginaryInput)).BeginInit();
			this.SuspendLayout();
			// 
			// mandleBrotImageBox
			// 
			this.mandleBrotImageBox.Location = new System.Drawing.Point(16, 71);
			this.mandleBrotImageBox.Name = "mandleBrotImageBox";
			this.mandleBrotImageBox.Size = new System.Drawing.Size(700, 700);
			this.mandleBrotImageBox.TabIndex = 1;
			this.mandleBrotImageBox.TabStop = false;
			this.mandleBrotImageBox.WaitOnLoad = true;
			this.mandleBrotImageBox.Click += new System.EventHandler(this.mandleBrotImageBox_Click);
			// 
			// offXLabel
			// 
			this.offXLabel.AutoSize = true;
			this.offXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.offXLabel.Location = new System.Drawing.Point(12, 14);
			this.offXLabel.Name = "offXLabel";
			this.offXLabel.Size = new System.Drawing.Size(72, 20);
			this.offXLabel.TabIndex = 4;
			this.offXLabel.Text = "Offset X:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(173, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Offset Y:";
			// 
			// offXInput
			// 
			this.offXInput.DecimalPlaces = 5;
			this.offXInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.offXInput.Location = new System.Drawing.Point(90, 14);
			this.offXInput.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.offXInput.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
			this.offXInput.Name = "offXInput";
			this.offXInput.Size = new System.Drawing.Size(78, 20);
			this.offXInput.TabIndex = 6;
			this.offXInput.ValueChanged += new System.EventHandler(this.offXInput_ValueChanged);
			// 
			// offYInput
			// 
			this.offYInput.DecimalPlaces = 5;
			this.offYInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.offYInput.Location = new System.Drawing.Point(251, 14);
			this.offYInput.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.offYInput.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
			this.offYInput.Name = "offYInput";
			this.offYInput.Size = new System.Drawing.Size(78, 20);
			this.offYInput.TabIndex = 7;
			this.offYInput.ValueChanged += new System.EventHandler(this.offYInput_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(335, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Scale:";
			// 
			// scaleInput
			// 
			this.scaleInput.DecimalPlaces = 5;
			this.scaleInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.scaleInput.Location = new System.Drawing.Point(394, 14);
			this.scaleInput.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.scaleInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            1835008});
			this.scaleInput.Name = "scaleInput";
			this.scaleInput.Size = new System.Drawing.Size(78, 20);
			this.scaleInput.TabIndex = 9;
			this.scaleInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
			this.scaleInput.ValueChanged += new System.EventHandler(this.scaleInput_ValueChanged);
			// 
			// maxIterationsInput
			// 
			this.maxIterationsInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.maxIterationsInput.Location = new System.Drawing.Point(601, 14);
			this.maxIterationsInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.maxIterationsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.maxIterationsInput.Name = "maxIterationsInput";
			this.maxIterationsInput.Size = new System.Drawing.Size(78, 20);
			this.maxIterationsInput.TabIndex = 10;
			this.maxIterationsInput.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
			this.maxIterationsInput.ValueChanged += new System.EventHandler(this.maxIterationsInput_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(478, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Max Iterations: ";
			// 
			// juliaSetBoolInput
			// 
			this.juliaSetBoolInput.AutoSize = true;
			this.juliaSetBoolInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.juliaSetBoolInput.Location = new System.Drawing.Point(12, 41);
			this.juliaSetBoolInput.Name = "juliaSetBoolInput";
			this.juliaSetBoolInput.Size = new System.Drawing.Size(177, 24);
			this.juliaSetBoolInput.TabIndex = 13;
			this.juliaSetBoolInput.Text = "Use custom C values";
			this.juliaSetBoolInput.UseVisualStyleBackColor = true;
			this.juliaSetBoolInput.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(195, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 20);
			this.label4.TabIndex = 16;
			this.label4.Text = "Real:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(335, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 20);
			this.label5.TabIndex = 17;
			this.label5.Text = "Imaginary:";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(586, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 28);
			this.button1.TabIndex = 20;
			this.button1.Text = "Generate!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// realInput
			// 
			this.realInput.DecimalPlaces = 5;
			this.realInput.Enabled = false;
			this.realInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.realInput.Location = new System.Drawing.Point(247, 44);
			this.realInput.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.realInput.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
			this.realInput.Name = "realInput";
			this.realInput.Size = new System.Drawing.Size(78, 20);
			this.realInput.TabIndex = 21;
			this.realInput.ValueChanged += new System.EventHandler(this.realInput_ValueChanged);
			// 
			// imaginaryInput
			// 
			this.imaginaryInput.DecimalPlaces = 5;
			this.imaginaryInput.Enabled = false;
			this.imaginaryInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.imaginaryInput.Location = new System.Drawing.Point(423, 44);
			this.imaginaryInput.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.imaginaryInput.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            -2147483648});
			this.imaginaryInput.Name = "imaginaryInput";
			this.imaginaryInput.Size = new System.Drawing.Size(78, 20);
			this.imaginaryInput.TabIndex = 22;
			this.imaginaryInput.ValueChanged += new System.EventHandler(this.imaginaryInput_ValueChanged);
			// 
			// colorInput
			// 
			this.colorInput.AutoSize = true;
			this.colorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colorInput.Location = new System.Drawing.Point(507, 42);
			this.colorInput.Name = "colorInput";
			this.colorInput.Size = new System.Drawing.Size(73, 24);
			this.colorInput.TabIndex = 23;
			this.colorInput.Text = "Colors";
			this.colorInput.UseVisualStyleBackColor = true;
			this.colorInput.CheckedChanged += new System.EventHandler(this.colorInput_CheckedChanged);
			// 
			// autoCheckbox
			// 
			this.autoCheckbox.AutoSize = true;
			this.autoCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autoCheckbox.Location = new System.Drawing.Point(681, 50);
			this.autoCheckbox.Name = "autoCheckbox";
			this.autoCheckbox.Size = new System.Drawing.Size(48, 17);
			this.autoCheckbox.TabIndex = 24;
			this.autoCheckbox.Text = "Auto";
			this.autoCheckbox.UseVisualStyleBackColor = true;
			this.autoCheckbox.CheckedChanged += new System.EventHandler(this.autoCheckbox_CheckedChanged);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(728, 787);
			this.Controls.Add(this.autoCheckbox);
			this.Controls.Add(this.colorInput);
			this.Controls.Add(this.imaginaryInput);
			this.Controls.Add(this.realInput);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.juliaSetBoolInput);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.maxIterationsInput);
			this.Controls.Add(this.scaleInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.offYInput);
			this.Controls.Add(this.offXInput);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.offXLabel);
			this.Controls.Add(this.mandleBrotImageBox);
			this.MaximumSize = new System.Drawing.Size(744, 826);
			this.MinimumSize = new System.Drawing.Size(744, 826);
			this.Name = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.mandleBrotImageBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.offXInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.offYInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scaleInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxIterationsInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.realInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imaginaryInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label offXLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown offXInput;
		private System.Windows.Forms.NumericUpDown offYInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown scaleInput;
		private System.Windows.Forms.NumericUpDown maxIterationsInput;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.PictureBox mandleBrotImageBox;
		private System.Windows.Forms.CheckBox juliaSetBoolInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown realInput;
		private System.Windows.Forms.NumericUpDown imaginaryInput;
		private System.Windows.Forms.CheckBox colorInput;
		private System.Windows.Forms.CheckBox autoCheckbox;
	}
}

