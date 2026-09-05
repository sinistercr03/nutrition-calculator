# Nutrition Calculator

A simple Windows desktop application to calculate the nutritional content (energy, protein, fat, and carbohydrates) of common food items.

## Features

- **5 Pre-loaded Food Items:**
  - Beef (lean)
  - Chicken (skinless breast)
  - Fish (Salmon, cooked)
  - Egg (whole, boiled)
  - Mutton (cooked, lean)

- **Easy-to-use Interface:**
  - Select a food from dropdown
  - Enter amount in grams
  - Click "Calculate" to get nutritional breakdown

- **Nutritional Information Displayed:**
  - Energy (kcal)
  - Protein (g)
  - Fat (g)
  - Carbohydrates (g)

## Nutritional Database

All values are per 100g of cooked food:

| Food | Energy (kcal) | Protein (g) | Fat (g) | Carbohydrates (g) |
|------|---------------|-------------|---------|-------------------|
| Beef (lean) | 250 | 26 | 17 | 0 |
| Chicken (skinless breast) | 165 | 31 | 3.6 | 0 |
| Fish (Salmon, cooked) | 206 | 22 | 13 | 0 |
| Egg (whole, boiled) | 155 | 13 | 11 | 1.1 |
| Mutton (cooked, lean) | 250 | 25 | 17 | 0 |

## Requirements

- .NET 6.0 or later
- Windows 7 or later
- Visual Studio 2022 (or Visual Studio Code with .NET extension)

## How to Build and Run

### Option 1: Using Visual Studio
1. Open the project in Visual Studio 2022
2. Click "Build" → "Build Solution"
3. Press F5 to run the application

### Option 2: Using Command Line
```bash
dotnet build
dotnet run
```

## Usage

1. Launch the application
2. Select a food item from the dropdown menu
3. Enter the amount in grams (e.g., 150)
4. Click the "Calculate" button
5. View the nutritional information in the results section

## Project Structure

- `NutritionCalculator.csproj` - Project file
- `FoodDatabase.cs` - Food database and data models
- `NutritionCalculator.xaml` - UI layout (XAML)
- `NutritionCalculator.xaml.cs` - UI logic (C#)
- `App.xaml` - Application configuration
- `App.xaml.cs` - Application code-behind

## Future Enhancements

- Add more food items
- Save/export calculation history
- Add custom food items
- Display recommended daily values
- Support for different units (kg, oz, etc.)
- Meal planning features

## License

This project is open source and available for personal use.