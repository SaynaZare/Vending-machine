using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.Media;

namespace newvending
{

    public partial class MainForm : Form
    {
        //initializing vaiables
        ToolTip toolTip = new ToolTip();
        string itemName;
        double itemPrice = 0;
        double TotalPurchase = 0;
        double NewTotal = 0.0;
        double change = 0.0;

        //loading sounds
        readonly SoundPlayer addItemSound = new SoundPlayer("C:/Users/saina/OneDrive - University of South Wales/year2/programming/newvending/Resources/minimal-pop-click-ui-1-198301.wav");
        readonly SoundPlayer StartSound = new SoundPlayer("C:/Users/saina/OneDrive - University of South Wales/year2/programming/newvending/Resources/game-start-6104 (1).wav");
        readonly SoundPlayer purchaseSound =  new SoundPlayer("C:/Users/saina/OneDrive - University of South Wales/year2/programming/newvending/Resources/mixkit-page-forward-single-chime-1107.wav");
        readonly SoundPlayer DeleteSound = new SoundPlayer("C:/Users/saina/OneDrive - University of South Wales/year2/programming/newvending/Resources/delete.wav");
        readonly SoundPlayer ErrorSound = new SoundPlayer("C:/Users/saina/OneDrive - University of South Wales/year2/programming/newvending/Resources/error.wav");
        readonly SoundPlayer coinDropSound = new SoundPlayer("C:/Users/saina/OneDrive - University of South Wales/year2/programming/newvending/Resources/coinDrop.wav");
        readonly SoundPlayer CheckoutSound = new SoundPlayer("C:/Users/saina/OneDrive - University of South Wales/year2/programming/newvending/Resources/checkout.wav");

        public MainForm()
        {
            InitializeComponent();

            //showning info when user is hovering on the buttom for better user experience
            toolTip.SetToolTip(pictureBoxBin, "Drag Items from your basket to the bin to remove them.");
            toolTip.SetToolTip(BtnCancel, "Cancel order and restart");
            toolTip.SetToolTip(BtnPurchase, "check out and pay");
            toolTip.SetToolTip(CoinSlotPic, "drag money to this slot for payment");
            toolTip.SetToolTip(TenPoundPic, "Ten Pounds");
            toolTip.SetToolTip(FivePoundPic, "Five pounds");
            toolTip.SetToolTip(OnePoundPic, "one pound");
            toolTip.SetToolTip(FiftyPencePic, "Fifty pence");
            toolTip.SetToolTip(TwentyPencePic, "twenty pence");


            //enabling drag and drop 
            pictureBoxBin.AllowDrop = true;

            //updating the last action label that will guide users
            LblLastAction.Text = "Welcome! Add an item to get started.";

            //preloading the sound to prevent delay when they are called
            addItemSound.Load();
            StartSound.Load();
            DeleteSound.Load();
            coinDropSound.Load();
            purchaseSound.Load();
            ErrorSound.Load();
            CheckoutSound.Load();

            //playing the starting sound when app is starts to run
            StartSound.Play();
           

        }


        //all buttons are refrenced to this function when clicked
        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            //adding click sound effect
            addItemSound.Play();

            Button ClickedButton = sender as Button;
            int quantity = 1;

          
            if (ClickedButton != null )
            {
             //updating variables when a button is clicked
                switch (ClickedButton.Name)
                {
                    case "BtnChips":

                        itemName = "Chips";
                        itemPrice = 2.10;

                        break;
                    case "BtnPizza":

                        itemName = "Pizza";
                        itemPrice = 4.55;

                        break;
                    case "BtnIceCream":

                        itemName = "IceCream";
                        itemPrice = 3.29;

                        break;
                    case "BtnDonut":

                        itemName = "Donut";
                        itemPrice = 1.50;

                        break;
                    case "BtnSandwich":

                        itemName = "Sandwich";
                        itemPrice = 6.42;

                        break;
                    case "BtnDrink":

                        itemName = "Drink";
                        itemPrice = 3.20;
                        break;

                }
                //update the total
                TotalPurchase += itemPrice;

                bool itemExists = false;
                if (BasketListBox.Items.Count > 0)
                {
                    for (int i = 0; i < BasketListBox.Items.Count; i++)
                    {
                        //getting the infomation of each added item in the list
                        string listItem = BasketListBox.Items[i].ToString();

                        //searching to see if a product already is in the basket
                        if (listItem.Contains(itemName))
                        {

                            //finding the starting and ending index for each item
                            int startIndex = listItem.IndexOf(itemName) - (quantity.ToString().Length + 2); ;
                            int endIndex = listItem.IndexOf(Environment.NewLine, startIndex);
                            if (endIndex == -1) endIndex = listItem.Length;
                            string currentItemLine = listItem.Substring(startIndex, endIndex - startIndex);
                            //finding the quantitiy of the item in that line
                            quantity = int.Parse(currentItemLine[0].ToString());
                            
                            quantity++;

                            // Update the list item with the new quantity and total price
                            BasketListBox.Items[i] = $"{quantity + "x " + itemName.PadRight(18) + ": " + itemPrice * quantity + "£"}";

                            itemExists = true;
                            break;

                        }

                    }
                }
                if (itemExists == false)
                {
                    BasketListBox.Items.Add($"{quantity}x {itemName.PadRight(18)}: {itemPrice.ToString("F")}£");
                }

                TotalTextBox.Text = ("Total: ").PadRight(25) + TotalPurchase.ToString("F") + "£";
                LblLastAction.Text = $"Added {itemName} to basket. Current total: {TotalPurchase:F}£";
              
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
           
            // Show a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to cancel and clear everything?",
                                                  "Cancel Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // If user clicks 'Yes', clear everything
            if (result == DialogResult.Yes)
            {
                
                BasketListBox.Items.Clear();
                TotalPurchase = 0.0;
                TotalTextBox.Text = ("Total: ").PadRight(25) + TotalPurchase.ToString("F") + "£";
                ResetProgram();

                MessageBox.Show("Order cancelled and basket cleared.",
                                "Cancelled",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LblLastAction.Text = "Order cancelled. Start a new order.";
               
            }
            //if user press no, order will be continued
            else
            {
                MessageBox.Show("returning to the ongoing order", "Continue Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblLastAction.Text = "Order continued.";
            }

        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {

            if (TotalPurchase > 0)
            {
                purchaseSound.Play();
                //disabling product buttoms
                BtnDonut.Enabled = false;
                BtnDrink.Enabled = false;
                BtnIceCream.Enabled = false;
                BtnPizza.Enabled = false;
                BtnSandwich.Enabled = false;
                BtnChips.Enabled = false;
                //disabling changes of basket by disabling drag and drop
                pictureBoxBin.AllowDrop = false;
                //enabling the currency drag and drop
                OnePoundPic.Enabled = true;
                TenPoundPic.Enabled = true;
                FivePoundPic.Enabled = true;
                FiftyPencePic.Enabled = true;
                TwentyPencePic.Enabled = true;
                LblnewTotal.Visible = true;
                LblChange.Visible = true;
                CoinSlotPic.AllowDrop = true;

                NewTotal = TotalPurchase;
                LblnewTotal.Text = ("Total: ").PadRight(3) + NewTotal.ToString("F") + "£";
                LblLastAction.Text = "Purchase initiated. Please insert payment.";

            }
            //if basket is emppty
            else
            {
                ErrorSound.Play();
                MessageBox.Show("your basket is empty! :| ");
                LblLastAction.Text = "Basket is empty. Add items to start an order.";
            }
        }

        // Start the drag-and-drop operation, passing the selected item
        private void BasketListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (BasketListBox.SelectedItem != null)
            {
                BasketListBox.DoDragDrop(BasketListBox.SelectedItem.ToString(), DragDropEffects.All);
                LblLastAction.Text = $"item removed from basket. Current total: {TotalPurchase:F}£";

            }
        }

        private void pictureBoxBin_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBoxBin_DragDrop(object sender, DragEventArgs e)
        {
            // Get the item data that is being dropped
            string draggedItem = e.Data.GetData(DataFormats.Text).ToString();
            DeleteSound.Play();

            // Check if the item exists in the BasketListBox
            if (BasketListBox.Items.Count > 0)
            {
                for (int i = 0; i < BasketListBox.Items.Count; i++)
                {
                    // Get the current item from the BasketListBox
                    string listItem = BasketListBox.Items[i].ToString();

                    // Check if the current list item contains the same item name as the dragged item
                    if (listItem.Contains(draggedItem.Substring(draggedItem.IndexOf('x') + 1).Trim()))
                    {
                        // Find the quantity by locating 'x'
                        int xIndex = listItem.IndexOf('x');
                        int colonIndex = listItem.IndexOf(':');

                        // Extract quantity part
                        string quantityString = listItem.Substring(0, xIndex).Trim();
                        int quantity = int.Parse(quantityString);

                        // Extract item name and single item price
                        string itemName = listItem.Substring(xIndex + 1, colonIndex - xIndex - 1).Trim();
                        double itemTotalPrice = double.Parse(listItem.Substring(colonIndex + 1).Replace("£", "").Trim());

                        // Calculate the price for a single item
                        double singleItemPrice = itemTotalPrice / quantity;

                        // Reduce quantity by 1
                        quantity--;

                        if (quantity > 0)
                        {
                            // Update total purchase and update list item with the new quantity and total price
                            TotalPurchase -= singleItemPrice;
                            string newItem = $"{quantity}x {itemName.PadRight(18)}: {(singleItemPrice * quantity).ToString("F")}£";
                            BasketListBox.Items[i] = newItem; // Replace the updated item in the ListBox
                        }
                        else
                        {
                            // Remove the item from the list if quantity reaches 0
                            TotalPurchase -= singleItemPrice;
                            BasketListBox.Items.RemoveAt(i);
                        }

                        // Update the total price in the textbox
                        TotalTextBox.Text = ("Total: ").PadRight(25) + TotalPurchase.ToString("F") + "£";
                        LblLastAction.Text = $"{itemName} is deleted";
                        break;
                       

                    }
                }
            }
        }

        private void TenPoundPic_MouseDown(object sender, MouseEventArgs e)
        {

            TenPoundPic.DoDragDrop(TenPoundPic.Tag, DragDropEffects.All);

        }
        private void FivePoundPic_MouseDown(object sender, MouseEventArgs e)
        {

            FivePoundPic.DoDragDrop(FivePoundPic.Tag, DragDropEffects.All);

        }
        private void OnePoundPic_MouseDown(object sender, MouseEventArgs e)
        {

            OnePoundPic.DoDragDrop(OnePoundPic.Tag, DragDropEffects.All);

        }
        private void FiftyPencePic_MouseDown(object sender, MouseEventArgs e)
        {

            FiftyPencePic.DoDragDrop(FiftyPencePic.Tag, DragDropEffects.All);

        }
        private void TwentyPencePoundPic_MouseDown(object sender, MouseEventArgs e)
        {

            TwentyPencePic.DoDragDrop(TwentyPencePic.Tag, DragDropEffects.All);

        }


        private void CoinSlotPic_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void CoinSlotPic_DragDrop(object sender, DragEventArgs e)
        {
            coinDropSound.Play();
            // getting the vaklue of the tag in the picture
            string draggedItem = e.Data.GetData(DataFormats.Text).ToString();

            //convert value to double
            double currency = double.Parse(draggedItem);
         
           
            if (NewTotal > currency)
            {
                NewTotal -= currency;
                LblnewTotal.Text = ("Total: ").PadRight(3) + NewTotal.ToString("F") + "£";
                LblLastAction.Text = $"currency added: {currency:F}£, Total update: {NewTotal:F}";
            }

            //if the order has been paid completely
            else
            {
                CheckoutSound.Play();
                //update change
                change = currency - NewTotal;
                NewTotal = 0.0;
                LblnewTotal.Text = ("Total: ").PadRight(3) + NewTotal.ToString("F") + "£";
                LblChange.Text = ("change: ").PadRight(3) + change.ToString("F") + "£";

                MessageBox.Show(("change: ").PadRight(3) + change.ToString() + "£", "purchase successful! ");
                LblLastAction.Text = $"Purchase completed. Change given: {change:F}£";
                //call save to file function after successful transaction
                SaveTransactionToFile();
                //begin the program again
                ResetProgram();

            }
        
        }

        private void SaveTransactionToFile()
        {
     
            // Set file path and name
            string filePath = "transaction_log.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true)) // 'true' to append to the file
            {
                writer.WriteLine($"Transaction Date: {DateTime.Now}");
                writer.WriteLine("Items Purchased:");
                foreach (var item in BasketListBox.Items)
                {
                    writer.WriteLine(item.ToString()); //write the items data that been purchased
                }
                writer.WriteLine($"Total: {TotalPurchase}£");
                writer.WriteLine($"Amount Paid: {TotalPurchase+change}£");
                writer.WriteLine($"Change Given: {change}£");
                writer.WriteLine("--------------------------------------------------------");
            }
        }

        private void ResetProgram()
        {
            // Clear the BasketListBox
            BasketListBox.Items.Clear();

            // Reset total purchase
            NewTotal = 0.0;
            TotalPurchase = 0.0;

            // Update the total and change labels
            LblnewTotal.Text = ("Total: ").PadRight(3) + NewTotal.ToString("F") + "£";
            LblChange.Text = ("change: "); // Clear change message
            TotalTextBox.Text = ("Total: ").PadRight(3) + NewTotal.ToString("F") + "£";
            LblLastAction.Text = "Welcome! Add an item to get started.";


           
            // enable the product buttons
            BtnDonut.Enabled = true;
            BtnDrink.Enabled = true;
            BtnIceCream.Enabled = true;
            BtnPizza.Enabled = true;
            BtnSandwich.Enabled = true;
            BtnChips.Enabled = true;
            pictureBoxBin.AllowDrop = true;

            //disable currency
            OnePoundPic.Enabled = false;
            TenPoundPic.Enabled = false;
            FivePoundPic.Enabled = false;
            FiftyPencePic.Enabled = false;
            TwentyPencePic.Enabled = false;
            LblnewTotal.Visible = false;
            LblChange.Visible = false;
            CoinSlotPic.AllowDrop = false;

            StartSound.Play();
        }

      
    }
    
}

