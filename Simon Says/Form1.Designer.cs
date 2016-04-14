namespace Simon_Says {
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
			this.redButton = new System.Windows.Forms.Button();
			this.blueButton = new System.Windows.Forms.Button();
			this.yellowButton = new System.Windows.Forms.Button();
			this.greenButton = new System.Windows.Forms.Button();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.patternLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// redButton
			// 
			this.redButton.Location = new System.Drawing.Point(12, 12);
			this.redButton.Name = "redButton";
			this.redButton.Size = new System.Drawing.Size(155, 85);
			this.redButton.TabIndex = 0;
			this.redButton.Text = "Red";
			this.redButton.UseVisualStyleBackColor = true;
			this.redButton.Click += new System.EventHandler(this.redButton_Click);
			// 
			// blueButton
			// 
			this.blueButton.Location = new System.Drawing.Point(173, 12);
			this.blueButton.Name = "blueButton";
			this.blueButton.Size = new System.Drawing.Size(155, 85);
			this.blueButton.TabIndex = 1;
			this.blueButton.Text = "Blue";
			this.blueButton.UseVisualStyleBackColor = true;
			this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
			// 
			// yellowButton
			// 
			this.yellowButton.Location = new System.Drawing.Point(173, 103);
			this.yellowButton.Name = "yellowButton";
			this.yellowButton.Size = new System.Drawing.Size(155, 85);
			this.yellowButton.TabIndex = 3;
			this.yellowButton.Text = "Yellow";
			this.yellowButton.UseVisualStyleBackColor = true;
			this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
			// 
			// greenButton
			// 
			this.greenButton.Location = new System.Drawing.Point(12, 103);
			this.greenButton.Name = "greenButton";
			this.greenButton.Size = new System.Drawing.Size(155, 85);
			this.greenButton.TabIndex = 2;
			this.greenButton.Text = "Green";
			this.greenButton.UseVisualStyleBackColor = true;
			this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.Location = new System.Drawing.Point(12, 191);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(68, 20);
			this.scoreLabel.TabIndex = 4;
			this.scoreLabel.Text = "Score: 0";
			// 
			// patternLabel
			// 
			this.patternLabel.AutoSize = true;
			this.patternLabel.Location = new System.Drawing.Point(173, 191);
			this.patternLabel.Name = "patternLabel";
			this.patternLabel.Size = new System.Drawing.Size(129, 20);
			this.patternLabel.TabIndex = 5;
			this.patternLabel.Text = "Item in pattern: 0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 241);
			this.Controls.Add(this.patternLabel);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.yellowButton);
			this.Controls.Add(this.greenButton);
			this.Controls.Add(this.blueButton);
			this.Controls.Add(this.redButton);
			this.Name = "Form1";
			this.Text = "Simon Says";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button redButton;
		private System.Windows.Forms.Button blueButton;
		private System.Windows.Forms.Button yellowButton;
		private System.Windows.Forms.Button greenButton;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Label patternLabel;
	}
}

