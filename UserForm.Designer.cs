
namespace Car_Market
{
	partial class UserForm
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
			this.listVehicles = new System.Windows.Forms.ListBox();
			this.cmbSortBy = new System.Windows.Forms.ComboBox();
			this.cmbShowOnly = new System.Windows.Forms.ComboBox();
			this.lblSortBy = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSortBy = new System.Windows.Forms.Button();
			this.btnShowOnly = new System.Windows.Forms.Button();
			this.numBudget = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBudget = new System.Windows.Forms.Button();
			this.lblBudget = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numBudget)).BeginInit();
			this.SuspendLayout();
			// 
			// listVehicles
			// 
			this.listVehicles.FormattingEnabled = true;
			this.listVehicles.Location = new System.Drawing.Point(13, 39);
			this.listVehicles.Name = "listVehicles";
			this.listVehicles.Size = new System.Drawing.Size(775, 186);
			this.listVehicles.TabIndex = 0;
			this.listVehicles.SelectedIndexChanged += new System.EventHandler(this.listVehicles_SelectedIndexChanged);
			// 
			// cmbSortBy
			// 
			this.cmbSortBy.FormattingEnabled = true;
			this.cmbSortBy.Items.AddRange(new object[] {
            "BRAND NAME",
            "PRICE",
            "QUANTITY"});
			this.cmbSortBy.Location = new System.Drawing.Point(131, 231);
			this.cmbSortBy.Name = "cmbSortBy";
			this.cmbSortBy.Size = new System.Drawing.Size(420, 21);
			this.cmbSortBy.TabIndex = 1;
			this.cmbSortBy.Text = "BRAND NAME";
			this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
			// 
			// cmbShowOnly
			// 
			this.cmbShowOnly.FormattingEnabled = true;
			this.cmbShowOnly.Items.AddRange(new object[] {
            "ALL",
            "ALFA ROMEO",
            "ASTON MARTIN",
            "AUDI",
            "BENTLEY",
            "BMW",
            "BUGATTI",
            "BUICK",
            "CADILLAC",
            "CHEVROLET",
            "CHRYSLER",
            "CITROEN",
            "DACIA",
            "DAIHATSU",
            "DATSUN",
            "DODGE",
            "FERRARI",
            "FIAT",
            "FORD",
            "GENESIS",
            "GMC",
            "HONDA",
            "HYUNDAI",
            "INFINITI",
            "ISUZU",
            "JAGUAR",
            "JEEP",
            "KIA",
            "KOENIGSEGG",
            "LAMBORGHINI",
            "LANCIA",
            "LAND ROVER",
            "LEXUS",
            "LINCOLN",
            "LOTUS",
            "MASERATI",
            "MAZDA",
            "MCLAREN",
            "MERCEDES-BENZ",
            "MINI",
            "MITSUBISHI",
            "NISSAN",
            "OPEL",
            "PEUGEOT",
            "PLYMOUTH",
            "PONTIAC",
            "PORSCHE",
            "RAM",
            "RENAULT",
            "ROLLS-ROYCE",
            "SAAB",
            "SEAT",
            "SKODA",
            "SMART",
            "SUBARU",
            "SUZUKI",
            "TESLA",
            "TOYOTA",
            "VOLKSWAGEN",
            "VOLVO"});
			this.cmbShowOnly.Location = new System.Drawing.Point(131, 258);
			this.cmbShowOnly.Name = "cmbShowOnly";
			this.cmbShowOnly.Size = new System.Drawing.Size(420, 21);
			this.cmbShowOnly.TabIndex = 2;
			this.cmbShowOnly.Text = "ALL";
			this.cmbShowOnly.SelectedIndexChanged += new System.EventHandler(this.cmbShowOnly_SelectedIndexChanged);
			// 
			// lblSortBy
			// 
			this.lblSortBy.Location = new System.Drawing.Point(13, 231);
			this.lblSortBy.Name = "lblSortBy";
			this.lblSortBy.Size = new System.Drawing.Size(112, 21);
			this.lblSortBy.TabIndex = 3;
			this.lblSortBy.Text = "Sort by:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 258);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Show only:";
			// 
			// btnSortBy
			// 
			this.btnSortBy.Enabled = false;
			this.btnSortBy.Location = new System.Drawing.Point(558, 231);
			this.btnSortBy.Name = "btnSortBy";
			this.btnSortBy.Size = new System.Drawing.Size(230, 21);
			this.btnSortBy.TabIndex = 5;
			this.btnSortBy.Text = "Apply";
			this.btnSortBy.UseVisualStyleBackColor = true;
			this.btnSortBy.Click += new System.EventHandler(this.btnSortBy_Click);
			// 
			// btnShowOnly
			// 
			this.btnShowOnly.Enabled = false;
			this.btnShowOnly.Location = new System.Drawing.Point(558, 258);
			this.btnShowOnly.Name = "btnShowOnly";
			this.btnShowOnly.Size = new System.Drawing.Size(230, 21);
			this.btnShowOnly.TabIndex = 6;
			this.btnShowOnly.Text = "Apply";
			this.btnShowOnly.UseVisualStyleBackColor = true;
			this.btnShowOnly.Click += new System.EventHandler(this.btnShowOnly_Click);
			// 
			// numBudget
			// 
			this.numBudget.Location = new System.Drawing.Point(131, 286);
			this.numBudget.Maximum = new decimal(new int[] {
            -1539607552,
            11,
            0,
            0});
			this.numBudget.Name = "numBudget";
			this.numBudget.Size = new System.Drawing.Size(420, 20);
			this.numBudget.TabIndex = 7;
			this.numBudget.ValueChanged += new System.EventHandler(this.numBudget_ValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 286);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 21);
			this.label2.TabIndex = 8;
			this.label2.Text = "Budget:";
			// 
			// btnBudget
			// 
			this.btnBudget.Enabled = false;
			this.btnBudget.Location = new System.Drawing.Point(558, 285);
			this.btnBudget.Name = "btnBudget";
			this.btnBudget.Size = new System.Drawing.Size(230, 21);
			this.btnBudget.TabIndex = 9;
			this.btnBudget.Text = "Get vehicle equal to your budget";
			this.btnBudget.UseVisualStyleBackColor = true;
			this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
			// 
			// lblBudget
			// 
			this.lblBudget.Location = new System.Drawing.Point(16, 309);
			this.lblBudget.Name = "lblBudget";
			this.lblBudget.Size = new System.Drawing.Size(375, 132);
			this.lblBudget.TabIndex = 10;
			this.lblBudget.Text = "Vehicle equal to your budget: ";
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(397, 309);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(391, 132);
			this.lblDescription.TabIndex = 11;
			this.lblDescription.Text = "Selected vehicle description:";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(13, 10);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 12;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblBudget);
			this.Controls.Add(this.btnBudget);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numBudget);
			this.Controls.Add(this.btnShowOnly);
			this.Controls.Add(this.btnSortBy);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblSortBy);
			this.Controls.Add(this.cmbShowOnly);
			this.Controls.Add(this.cmbSortBy);
			this.Controls.Add(this.listVehicles);
			this.Name = "UserForm";
			this.Text = "User";
			((System.ComponentModel.ISupportInitialize)(this.numBudget)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listVehicles;
		private System.Windows.Forms.ComboBox cmbSortBy;
		private System.Windows.Forms.ComboBox cmbShowOnly;
		private System.Windows.Forms.Label lblSortBy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSortBy;
		private System.Windows.Forms.Button btnShowOnly;
		private System.Windows.Forms.NumericUpDown numBudget;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBudget;
		private System.Windows.Forms.Label lblBudget;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Button btnBack;
	}
}