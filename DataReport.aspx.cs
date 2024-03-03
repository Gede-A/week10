using System;
using System.Web.UI;

namespace week10
{
    public partial class DataReport : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load data into grid views
                LoadTransportEmissionsData();
                LoadElectricityConsumptionData();
            }
        }

        private void LoadTransportEmissionsData()
        {
            // Load data into gvTransportEmissions grid view
            // For demonstration purposes, let's assume data binding code here
            gvTransportEmissions.DataSource = GetTransportEmissionsData(); // Example method to retrieve data
            gvTransportEmissions.DataBind();
        }

        private void LoadElectricityConsumptionData()
        {
            // Load data into gvElectricityConsumption grid view
            // For demonstration purposes, let's assume data binding code here
            gvElectricityConsumption.DataSource = GetElectricityConsumptionData(); // Example method to retrieve data
            gvElectricityConsumption.DataBind();
        }

        // Example method to retrieve transport emissions data (replace with actual data retrieval logic)
        private object GetTransportEmissionsData()
        {
            // Sample data for demonstration
            return new[]
            {
                new { VehicleType = "Car", Distance = 100, FuelType = "Gasoline", FuelEfficiency = 20, EntryDate = DateTime.Now },
                new { VehicleType = "Truck", Distance = 200, FuelType = "Diesel", FuelEfficiency = 15, EntryDate = DateTime.Now.AddDays(-1) },
                // Add more data as needed
            };
        }

        // Example method to retrieve electricity consumption data (replace with actual data retrieval logic)
        private object GetElectricityConsumptionData()
        {
            // Sample data for demonstration
            return new[]
            {
                new { EnergySource = "Grid", ElectricityUsage = 500, EntryDate = DateTime.Now },
                new { EnergySource = "Solar", ElectricityUsage = 200, EntryDate = DateTime.Now.AddDays(-1) },
                // Add more data as needed
            };
        }
    }
}

