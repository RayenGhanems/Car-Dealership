
namespace Car_Market
{
	partial class ChooseForm
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnAddRemoveVehicles = new System.Windows.Forms.Button();
			this.btnViewVehicles = new System.Windows.Forms.Button();
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(800, 250);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Welcome to the dealership";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAddRemoveVehicles
			// 
			this.btnAddRemoveVehicles.BackColor = System.Drawing.Color.Salmon;
			this.btnAddRemoveVehicles.FlatAppearance.BorderSize = 0;
			this.btnAddRemoveVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAddRemoveVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRemoveVehicles.Location = new System.Drawing.Point(190, 291);
			this.btnAddRemoveVehicles.Name = "btnAddRemoveVehicles";
			this.btnAddRemoveVehicles.Size = new System.Drawing.Size(182, 76);
			this.btnAddRemoveVehicles.TabIndex = 1;
			this.btnAddRemoveVehicles.Text = "Add/Remove vehicles";
			this.btnAddRemoveVehicles.UseVisualStyleBackColor = false;
			this.btnAddRemoveVehicles.Click += new System.EventHandler(this.btnAddRemoveVehicles_Click);
			// 
			// btnViewVehicles
			// 
			this.btnViewVehicles.BackColor = System.Drawing.Color.Lime;
			this.btnViewVehicles.FlatAppearance.BorderSize = 0;
			this.btnViewVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnViewVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewVehicles.Location = new System.Drawing.Point(450, 291);
			this.btnViewVehicles.Name = "btnViewVehicles";
			this.btnViewVehicles.Size = new System.Drawing.Size(182, 76);
			this.btnViewVehicles.TabIndex = 2;
			this.btnViewVehicles.Text = "View vehicles";
			this.btnViewVehicles.UseVisualStyleBackColor = false;
			this.btnViewVehicles.Click += new System.EventHandler(this.btnViewVehicles_Click);
			// 
			// txtFilePath
			// 
			this.txtFilePath.Location = new System.Drawing.Point(190, 253);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(442, 20);
			this.txtFilePath.TabIndex = 3;
			this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(265, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Type the file path here. You do not need to create the file.";
			// 
			// ChooseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFilePath);
			this.Controls.Add(this.btnViewVehicles);
			this.Controls.Add(this.btnAddRemoveVehicles);
			this.Controls.Add(this.lblTitle);
			this.Name = "ChooseForm";
			this.Text = "Welcome";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnAddRemoveVehicles;
		private System.Windows.Forms.Button btnViewVehicles;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.Label label1;
	}
}