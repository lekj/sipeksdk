namespace TestSoftphone
{
	partial class MainForm
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
			this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
			this.MakeCallBtn = new System.Windows.Forms.Button();
			this.RealeaseBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.RegStateBox = new System.Windows.Forms.MaskedTextBox();
			this.CallStateBox = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.IncomePhoneBox = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TakeBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PhoneBox
			// 
			this.PhoneBox.Location = new System.Drawing.Point(114, 25);
			this.PhoneBox.Name = "PhoneBox";
			this.PhoneBox.Size = new System.Drawing.Size(236, 20);
			this.PhoneBox.TabIndex = 1;
			// 
			// MakeCallBtn
			// 
			this.MakeCallBtn.Location = new System.Drawing.Point(377, 22);
			this.MakeCallBtn.Name = "MakeCallBtn";
			this.MakeCallBtn.Size = new System.Drawing.Size(75, 23);
			this.MakeCallBtn.TabIndex = 2;
			this.MakeCallBtn.Text = "Make Call";
			this.MakeCallBtn.UseVisualStyleBackColor = true;
			this.MakeCallBtn.Click += new System.EventHandler(this.MakeCallBtn_Click);
			// 
			// RealeaseBtn
			// 
			this.RealeaseBtn.Location = new System.Drawing.Point(377, 90);
			this.RealeaseBtn.Name = "RealeaseBtn";
			this.RealeaseBtn.Size = new System.Drawing.Size(75, 23);
			this.RealeaseBtn.TabIndex = 3;
			this.RealeaseBtn.Text = "Realease";
			this.RealeaseBtn.UseVisualStyleBackColor = true;
			this.RealeaseBtn.Click += new System.EventHandler(this.RealeaseBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "RegState";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "CallState";
			// 
			// RegStateBox
			// 
			this.RegStateBox.Location = new System.Drawing.Point(114, 116);
			this.RegStateBox.Name = "RegStateBox";
			this.RegStateBox.ReadOnly = true;
			this.RegStateBox.Size = new System.Drawing.Size(236, 20);
			this.RegStateBox.TabIndex = 6;
			// 
			// CallStateBox
			// 
			this.CallStateBox.Location = new System.Drawing.Point(114, 153);
			this.CallStateBox.Name = "CallStateBox";
			this.CallStateBox.ReadOnly = true;
			this.CallStateBox.Size = new System.Drawing.Size(236, 20);
			this.CallStateBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Call to";
			// 
			// IncomePhoneBox
			// 
			this.IncomePhoneBox.Location = new System.Drawing.Point(114, 59);
			this.IncomePhoneBox.Name = "IncomePhoneBox";
			this.IncomePhoneBox.ReadOnly = true;
			this.IncomePhoneBox.Size = new System.Drawing.Size(236, 20);
			this.IncomePhoneBox.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Incoming";
			// 
			// TakeBtn
			// 
			this.TakeBtn.Location = new System.Drawing.Point(377, 56);
			this.TakeBtn.Name = "TakeBtn";
			this.TakeBtn.Size = new System.Drawing.Size(75, 23);
			this.TakeBtn.TabIndex = 11;
			this.TakeBtn.Text = "Take";
			this.TakeBtn.UseVisualStyleBackColor = true;
			this.TakeBtn.Click += new System.EventHandler(this.TakeBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 348);
			this.Controls.Add(this.TakeBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.IncomePhoneBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CallStateBox);
			this.Controls.Add(this.RegStateBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RealeaseBtn);
			this.Controls.Add(this.MakeCallBtn);
			this.Controls.Add(this.PhoneBox);
			this.Name = "MainForm";
			this.Text = "Softphone!!!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox PhoneBox;
		private System.Windows.Forms.Button MakeCallBtn;
		private System.Windows.Forms.Button RealeaseBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox RegStateBox;
		private System.Windows.Forms.MaskedTextBox CallStateBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox IncomePhoneBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button TakeBtn;
	}
}

