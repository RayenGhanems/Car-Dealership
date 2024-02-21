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
	public partial class AdminForm : Form
	{
		Dealership dealership;
		List<Vehicle> list;

		public AdminForm()
		{
			InitializeComponent();

			try
			{
				dealership = new Dealership();

				dealership.onUpdateFileAsyncFinishedEventHandler += OnFileUpdateFinished;

				UpdateVehicleList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void OnFileUpdateFinished()
		{
			MessageBox.Show("Saved successfully");
		}

		private void UpdateVehicleList()
		{
			try
			{
				list = dealership.GetAllVehicles();

				listVehicles.Items.Clear();

				for (int i = 0; i < list.Count; i++)
				{
					listVehicles.Items.Add(list[i].GetID() + " Stock: " + list[i].Stock);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAddVehicle_Click(object sender, EventArgs e)
		{
			try
			{
				switch (tabCtrl.SelectedTab.Text)
				{
					case "Car":
						if (txtModelCar.Text == "")
						{
							throw new Exception("Please add a model for car.");
						}
						dealership.AddToInventory(1, cmbBrandCar.Text, txtModelCar.Text, (double)numPriceCar.Value, (int)numYearCar.Value, (double)numMileageCar.Value, cmbFuelTypeCar.Text, cmbBodyStyleCar.Text);
						break;
					case "Truck":
						if (txtModelTruck.Text == "")
						{
							throw new Exception("Please add a model for truck.");
						}
						dealership.AddToInventory(1, cmbBrandTruck.Text, txtModelTruck.Text, (double)numPriceTruck.Value, (int)numYearTruck.Value, (double)numMileageTruck.Value, cmbFuelTypeTruck.Text, (double)numBedSizeTruck.Value, (double)numLoadCapacityTruck.Value);
						break;
					default:
						if (txtModelSUV.Text == "")
						{
							throw new Exception("Please add a model for SUV.");
						}
						dealership.AddToInventory(1, cmbBrandSUV.Text, txtModelSUV.Text, (double)numPriceSUV.Value, (int)numYearSUV.Value, (double)numMileageSUV.Value, cmbFuelTypeSUV.Text, (int)numSeatingCapacitySUV.Value);
						break;
				}

				UpdateVehicleList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAdd1_Click(object sender, EventArgs e)
		{
			try
			{
				if (listVehicles.SelectedIndex < 0)
				{
					throw new Exception("Please choose a car to add 1 to.");
				}

				dealership.AddToInventoryByID(list[listVehicles.SelectedIndex].GetID(), 1);

				UpdateVehicleList();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnRemoveVehicle_Click(object sender, EventArgs e)
		{
			try
			{
				if (listVehicles.SelectedIndex < 0)
				{
					throw new Exception("Please choose a car to add 1 to.");
				}

				dealership.RemoveFromInventory(list[listVehicles.SelectedIndex].GetID(), 1);

				UpdateVehicleList();
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
