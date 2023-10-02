using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pizzza_app
{
    public class CartItem
    {
        public MenuItem MenuItem { get; }
        public int Quantity { get; set; }

        public CartItem(MenuItem menuItem, int quantity = 1)
        {
            MenuItem = menuItem;
            Quantity = quantity;
        }
    }

    public abstract class MenuItem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Pizza_Menu : MenuItem 
    {
        public string Toppings { get; set; } 
        public List<Toppings> ToppingsList = new List<Toppings>();
        public string Description { get; set; }
    }

    public class Toppings : Pizza_Menu
    {
        
        public string Topping { get; set; }
        public int ToppingPrice { get; set; }

        
    }

    public class Drink_Menu : MenuItem
    {
        // Additional properties specific to drinks can be added here
    }

    public class Extra_Menu : MenuItem
    {
        // Additional properties specific to extras can be added here
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Pizza_Menu> pizzaItems = new List<Pizza_Menu>();
        private List<Drink_Menu> drinkItems = new List<Drink_Menu>();
        private List<Extra_Menu> extraItems = new List<Extra_Menu>();
        public List<Toppings> ToppingsList = new List<Toppings>();

        public ObservableCollection<CartItem> cartItems = new ObservableCollection<CartItem>();
        

        public MainWindow()
        {
            InitializeComponent();

            pizzaItems.Add(new Pizza_Menu { Number = 1, Name = "Pepperoni Pizza", Toppings = "Pepperoni, Cheese", Price = 69.99M, Description = "Classic Pepperoni Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 2, Name = "Margherita Pizza", Toppings = "Tomato, Mozzarella, Basil", Price = 60M, Description = "Traditional Margherita Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 3, Name = "Vegetarian Pizza", Toppings = "Mushrooms, Peppers, Onions, Olives", Price = 100M, Description = "Veggie-Loaded Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 4, Name = "Meat Lovers Pizza", Toppings = "Pepperoni, Sausage, Bacon, Ham", Price = 100M, Description = "For the Meat Lovers" });
            pizzaItems.Add(new Pizza_Menu { Number = 5, Name = "BBQ Chicken Pizza", Toppings = "BBQ Sauce, Chicken, Red Onion, Cheese", Price = 80M, Description = "Tangy BBQ Chicken Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 6, Name = "Supreme Pizza", Toppings = "Pepperoni, Sausage, Peppers, Olives", Price = 80M, Description = "Loaded Supreme Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 7, Name = "Hawaiian Pizza", Toppings = "Ham, Pineapple, Cheese", Price = 79.99M, Description = "Sweet and Savory Hawaiian Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 8, Name = "Four Cheese Pizza", Toppings = "Mozzarella, Cheddar, Parmesan, Gouda", Price = 80m, Description = "A Cheesy Delight" });
            pizzaItems.Add(new Pizza_Menu { Number = 9, Name = "Mushroom Truffle Pizza", Toppings = "Mushrooms, Truffle Oil, Cheese", Price = 80M, Description = "Elegant Mushroom and Truffle Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 10, Name = "Sausage and Pepper Pizza", Toppings = "Sausage, Peppers, Onions, Cheese", Price = 75M, Description = "Classic Combo" });
            pizzaItems.Add(new Pizza_Menu { Number = 11, Name = "Buffalo Chicken Pizza", Toppings = "Buffalo Sauce, Chicken, Blue Cheese", Price = 80M, Description = "Spicy Buffalo Chicken Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 12, Name = "Pesto Veggie Pizza", Toppings = "Pesto Sauce, Tomatoes, Spinach, Cheese", Price = 70M, Description = "Fresh and Flavorful" });
            pizzaItems.Add(new Pizza_Menu { Number = 13, Name = "Barbecue Bacon Pizza", Toppings = "BBQ Sauce, Bacon, Onions, Cheese", Price = 70M, Description = "Sweet and Savory Combo" });
            pizzaItems.Add(new Pizza_Menu { Number = 14, Name = "Artichoke and Olive Pizza", Toppings = "Artichokes, Olives, Cheese", Price = 70M, Description = "Mediterranean Flavors" });
            pizzaItems.Add(new Pizza_Menu { Number = 15, Name = "Spinach and Feta Pizza", Toppings = "Spinach, Feta Cheese, Onions", Price = 65M, Description = "Greek Inspired Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 16, Name = "Bacon and Egg Breakfast Pizza", Toppings = "Bacon, Eggs, Cheese", Price = 90M, Description = "Morning Delight" });
            pizzaItems.Add(new Pizza_Menu { Number = 17, Name = "BBQ Pork Pizza", Toppings = "BBQ Sauce, Pulled Pork, Red Onion, Cheese", Price = 85M, Description = "Hearty BBQ Pork Pizza" });
            pizzaItems.Add(new Pizza_Menu { Number = 18, Name = "Pepper and Onion Pizza", Toppings = "Peppers, Onions, Cheese", Price = 80M, Description = "Simple and Delicious" });
            pizzaItems.Add(new Pizza_Menu { Number = 19, Name = "Seafood Supreme Pizza", Toppings = "Shrimp, Crab, Scallops, Cheese", Price = 90M, Description = "Seafood Lover's Delight" });
            pizzaItems.Add(new Pizza_Menu { Number = 20, Name = "DEMO-MAN", Toppings ="Chili 4 kinds, Secret sauce, Pepper, no cheese", Price = 110m, Description ="if you want to die"});
            drinkItems.Add(new Drink_Menu { Number = 1, Name = "Soda", Price = 12M });
            drinkItems.Add(new Drink_Menu { Number = 2, Name = "Lemonade", Price = 5.99M });
            drinkItems.Add(new Drink_Menu { Number = 3, Name = "Iced Tea", Price = 6.49M });
            drinkItems.Add(new Drink_Menu { Number = 4, Name = "Orange Juice", Price = 12.99M });
            drinkItems.Add(new Drink_Menu { Number = 5, Name = "Coca-Cola", Price = 14.99M });
            drinkItems.Add(new Drink_Menu { Number = 6, Name = "Sprite", Price = 14.99M });
            extraItems.Add(new Extra_Menu { Number = 1, Name = "Garlic Bread", Price = 9.99M });
            extraItems.Add(new Extra_Menu { Number = 2, Name = "Pomfritter small", Price = 14.99M });
            extraItems.Add(new Extra_Menu { Number = 3, Name = "Pomfirtter Stor", Price = 29.99M });
            extraItems.Add(new Extra_Menu { Number = 4, Name = "Mozzarella Sticks", Price = 9.99M });
            extraItems.Add(new Extra_Menu { Number = 5, Name = "Salad", Price = 10.49M });
            extraItems.Add(new Extra_Menu { Number = 6, Name = "Chicken Wings", Price = 19.99M });
            extraItems.Add(new Extra_Menu { Number = 7, Name = "Onion Rings", Price = 14.99M });
            ComboBoxItem pizzaType = new ComboBoxItem { Content = "Select Menu Type" };
            ComboBoxItem pizzaItem = new ComboBoxItem { Content = "Pizza" };
            ComboBoxItem drinkItem = new ComboBoxItem { Content = "Drink" };
            ComboBoxItem extraItem = new ComboBoxItem { Content = "Extra" };
            Selection.Items.Add(pizzaType);
            Selection.Items.Add(pizzaItem);
            Selection.Items.Add(drinkItem);
            Selection.Items.Add(extraItem);


            Selection.SelectedIndex = 0;
            CartItemsGrid.ItemsSource = cartItems;
        }




        public void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedType = Selection.SelectedItem as ComboBoxItem;
            string menuType = selectedType.Content.ToString();

            if (menuType == "Pizza" && MenuSelect.ItemsSource != pizzaItems)
            {
                MenuSelect.ItemsSource = pizzaItems;

                // Define the columns for Pizza menu with Toppings and Description
                MenuSelect.Columns.Clear();
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Number", Binding = new Binding("Number") });
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Name", Binding = new Binding("Name") });
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Price", Binding = new Binding("Price") });
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Toppings", Binding = new Binding("Toppings") });
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Description", Binding = new Binding("Description") });
            }
            else if (menuType == "Drink" && MenuSelect.ItemsSource != drinkItems)
            {
                MenuSelect.ItemsSource = drinkItems;

                // Define the columns for Drink menu
                MenuSelect.Columns.Clear();
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Number", Binding = new Binding("Number") });
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Name", Binding = new Binding("Name") });
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Price", Binding = new Binding("Price") });
            }
            else if (menuType == "Extra" && MenuSelect.ItemsSource != extraItems)
            {
                MenuSelect.ItemsSource = extraItems;

                // Define the columns for Extra menu
                MenuSelect.Columns.Clear();
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Number", Binding = new Binding("Number") });
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Name", Binding = new Binding("Name") });
                MenuSelect.Columns.Add(new DataGridTextColumn { Header = "Price", Binding = new Binding("Price") });
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
         {
            if (CartItemsGrid.SelectedItem is CartItem selectedItem)
            {
                cartItems.Remove(selectedItem);
                CalculateTotalPrice(); // Update total price after item is removed
                                       // Optionally, update the cart display or any related UI elements here
            }
        }


        
        private decimal CalculateTotalPrice()
        {

            decimal totalPrice = 0;

            foreach (CartItem cartItem in cartItems)
            {
                totalPrice += cartItem.MenuItem.Price * cartItem.Quantity;
            }

            return totalPrice;
        }




        public void Buy_check_out_Click(object sender, RoutedEventArgs e)
        {
            List<CartItem> ShopCartItems = cartItems.ToList();
            decimal fullPrice = CalculateTotalPrice();
            Checkout_page checkoutPage = new Checkout_page(ShopCartItems, fullPrice);
            checkoutPage.Show();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {

            if (MenuSelect.SelectedItem != null && MenuSelect.SelectedItem is MenuItem selectedItem)
    {
        CartItem cartItem = new CartItem(selectedItem); // Create a CartItem instance
        cartItems.Add(cartItem); // Add the item to the cartItems collection
        CartItemsGrid.Items.Refresh();
        // Optionally, update the cart display or any related UI elements here
    }

        }
    }
}
