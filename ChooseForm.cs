using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Market.DealershipClasses;

namespace Car_Market
{
	public partial class ChooseForm : Form
	{
		public ChooseForm()
		{
			InitializeComponent();

			txtFilePath.Text = Dealership.PATH;
		}

		private void btnAddRemoveVehicles_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtFilePath.Text == "")
				{
					throw new Exception("Please add a valid path.");
				}

				Dealership.PATH = txtFilePath.Text;

				Hide();
				AdminForm adminForm = new AdminForm();
				adminForm.ShowDialog();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnViewVehicles_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtFilePath.Text == "")
				{
					throw new Exception("Please add a valid path.");
				}

				Dealership.PATH = txtFilePath.Text;

				Hide();
				UserForm userForm = new UserForm();
				userForm.ShowDialog();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void txtFilePath_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
