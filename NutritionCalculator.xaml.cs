using System;
using System.Windows;

namespace NutritionCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeFoodComboBox();
        }

        private void InitializeFoodComboBox()
        {
            var foods = FoodDatabase.GetAllFoods();
            foreach (var food in foods)
            {
                FoodComboBox.Items.Add(food.Name);
            }
            
            if (FoodComboBox.Items.Count > 0)
            {
                FoodComboBox.SelectedIndex = 0;
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get selected food
                string selectedFoodName = FoodComboBox.SelectedItem as string;
                if (string.IsNullOrEmpty(selectedFoodName))
                {
                    MessageBox.Show("Please select a food item.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Get amount
                if (!double.TryParse(AmountTextBox.Text, out double amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid amount in grams (greater than 0).", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    AmountTextBox.Focus();
                    return;
                }

                // Get food from database
                FoodItem food = FoodDatabase.GetFoodByName(selectedFoodName);
                if (food == null)
                {
                    MessageBox.Show("Food not found in database.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Calculate nutrients based on amount
                double multiplier = amount / 100.0; // Database values are per 100g
                double energy = food.Energy * multiplier;
                double protein = food.Protein * multiplier;
                double fat = food.Fat * multiplier;
                double carbohydrates = food.Carbohydrates * multiplier;

                // Display results
                EnergyResult.Text = $"{energy:F1} kcal";
                ProteinResult.Text = $"{protein:F1} g";
                FatResult.Text = $"{fat:F1} g";
                CarbohydratesResult.Text = $"{carbohydrates:F1} g";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
