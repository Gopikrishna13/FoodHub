using FoodHub.Models;
using FoodHub.Services;
using System;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class AddBikeForm : Form
    {
        public AddBikeForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            colorTextBox.Text= string.Empty;
            colorsListBox.Items.Clear();
        }

        private void addColorButton_Click(object sender, EventArgs e)
        {
            colorsListBox.Items.Add(colorTextBox.Text);
            colorTextBox.Text = string.Empty;
        }

        private void removeColorButton_Click(object sender, EventArgs e)
        {
            if (colorsListBox.Items.Count > 0)
            {
                colorsListBox.Items.RemoveAt(colorsListBox.Items.Count - 1);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FoodHubService foodHubService = new FoodHubService();

            MotorBike motorBike = new MotorBike();
            AddBikeForm form=new AddBikeForm();
     
            motorBike.BikeRegNo= regNoTextBox.Text;
            motorBike.EngineNumber=engineTextBox.Text;
            motorBike.Brand=brandTextBox.Text;
            motorBike.Model= modelTextBox.Text;
            motorBike.RegisteredDate = registeredDatePicker.Value;

            var status=foodHubService.AddBike(motorBike);

            if (!status)
            {
                MessageBox.Show("Failed To Insert Bike!");
                return;
            }


            foreach (var color in colorsListBox.Items)
            {
                BikeColor bikeColor = new BikeColor(); 
                bikeColor.BikeRegNo = motorBike.BikeRegNo; 
                bikeColor.Color = color.ToString();                

             
                foodHubService.AddBikeColor(bikeColor);
            }
            MessageBox.Show("Bike Added Successfully!");
            form.Show();
            this.Close();


        }
    }
}
