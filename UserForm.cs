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
using Car_Market.VehicleClasses;

namespace Car_Market
{
	public partial class UserForm : Form
	{
		Dealership dealership;
		List<Vehicle> list;

		public UserForm()
		{
			InitializeComponent();

			try
			{
				dealership = new Dealership();

				UpdateVehicleList();
				UpdateDescriptionText();
				UpdateBudgetText();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateVehicleList()
		{
			try
			{
				list = dealership.GetAllVehicles();

				listVehicles.Items.Clear();

				for (int i = 0; i < list.Count; i++)
				{
					listVehicles.Items.Add(list[i].vehicleType.ToString() + ": " + list[i].Brand + " " + list[i].Model + " $" + list[i].Price.ToString() + " " + list[i].Mileage + "km Stock:" + list[i].Stock);
				}

				UpdateDescriptionText();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateVehicleListSorted(string sortingCriteria)
		{
			try
			{
				list = dealership.GetAllVehiclesSorted(sortingCriteria);

				listVehicles.Items.Clear();

				for (int i = 0; i < list.Count; i++)
				{
					listVehicles.Items.Add(list[i].vehicleType.ToString() + ": " + list[i].Brand + " " + list[i].Model + " $" + list[i].Price.ToString() + " " + list[i].Mileage + "km Stock:" + list[i].Stock);
				}

				UpdateDescriptionText();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateVehicleListFiltered(string brand)
		{
			try
			{
				list = dealership.GetAllVehiclesFiltered(brand);

				listVehicles.Items.Clear();

				for (int i = 0; i < list.Count; i++)
				{
					listVehicles.Items.Add(list[i].vehicleType.ToString() + ": " + list[i].Brand + " " + list[i].Model + " $" + list[i].Price.ToString() + " " + list[i].Mileage + "km Stock:" + list[i].Stock);
				}

				UpdateDescriptionText();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateDescriptionText()
		{
			try
			{
				if (listVehicles.SelectedIndex >= 0)
				{
					lblDescription.Text = "Selected vehicle desciption:\n" + list[listVehicles.SelectedIndex].GetDescription();
				}
				else
				{
					lblDescription.Text = "Selected vehicle desciption: [no selected vehicles]";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void listVehicles_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				UpdateDescriptionText();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSortBy_Click(object sender, EventArgs e)
		{
			try
			{
				btnSortBy.Enabled = false;
				UpdateVehicleListSorted(cmbSortBy.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnShowOnly_Click(object sender, EventArgs e)
		{
			try
			{
				btnShowOnly.Enabled = false;
				UpdateVehicleListFiltered(cmbShowOnly.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateBudgetText()
		{
			try
			{
				Vehicle v = dealership.GetVehicleWithPrice((double)numBudget.Value);

				if (v == null)
				{
					lblBudget.Text = "Vehicle with price equal to your budget: \n NONE";
				}
				else
				{
					lblBudget.Text = "Vehicle with price equal to your budget: \n" + v.GetDescription();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBudget_Click(object sender, EventArgs e)
		{
			try
			{
				btnBudget.Enabled = false;
				UpdateBudgetText();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				btnSortBy.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cmbShowOnly_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				btnShowOnly.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void numBudget_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				btnBudget.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			try
			{
				Hide();
				ChooseForm chooseForm = new ChooseForm();
				chooseForm.ShowDialog();
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
