namespace newvending
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductsText = new System.Windows.Forms.TextBox();
            this.BtnChips = new System.Windows.Forms.Button();
            this.BtnPizza = new System.Windows.Forms.Button();
            this.ChipsPriceText = new System.Windows.Forms.TextBox();
            this.PizzaPriceText = new System.Windows.Forms.TextBox();
            this.BtnIceCream = new System.Windows.Forms.Button();
            this.BtnDonut = new System.Windows.Forms.Button();
            this.IceCreamPriceText = new System.Windows.Forms.TextBox();
            this.DonutPriceText = new System.Windows.Forms.TextBox();
            this.BtnSandwich = new System.Windows.Forms.Button();
            this.BtnDrink = new System.Windows.Forms.Button();
            this.SandwichPriceText = new System.Windows.Forms.TextBox();
            this.DrinkPriceText = new System.Windows.Forms.TextBox();
            this.BasketListBox = new System.Windows.Forms.ListBox();
            this.BasketTextBox = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LblWallet = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblChange = new System.Windows.Forms.TextBox();
            this.LblnewTotal = new System.Windows.Forms.TextBox();
            this.TwentyPencePic = new System.Windows.Forms.PictureBox();
            this.FiftyPencePic = new System.Windows.Forms.PictureBox();
            this.OnePoundPic = new System.Windows.Forms.PictureBox();
            this.FivePoundPic = new System.Windows.Forms.PictureBox();
            this.TenPoundPic = new System.Windows.Forms.PictureBox();
            this.CoinSlotPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxBin = new System.Windows.Forms.PictureBox();
            this.BtnPurchase = new System.Windows.Forms.Button();
            this.LblLastAction = new System.Windows.Forms.TextBox();
            this.ProductPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyPencePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyPencePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnePoundPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FivePoundPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenPoundPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinSlotPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPanel
            // 
            this.ProductPanel.Controls.Add(this.ProductsText);
            this.ProductPanel.Controls.Add(this.BtnChips);
            this.ProductPanel.Controls.Add(this.BtnPizza);
            this.ProductPanel.Controls.Add(this.ChipsPriceText);
            this.ProductPanel.Controls.Add(this.PizzaPriceText);
            this.ProductPanel.Controls.Add(this.BtnIceCream);
            this.ProductPanel.Controls.Add(this.BtnDonut);
            this.ProductPanel.Controls.Add(this.IceCreamPriceText);
            this.ProductPanel.Controls.Add(this.DonutPriceText);
            this.ProductPanel.Controls.Add(this.BtnSandwich);
            this.ProductPanel.Controls.Add(this.BtnDrink);
            this.ProductPanel.Controls.Add(this.SandwichPriceText);
            this.ProductPanel.Controls.Add(this.DrinkPriceText);
            this.ProductPanel.Location = new System.Drawing.Point(0, 28);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(378, 599);
            this.ProductPanel.TabIndex = 0;
            // 
            // ProductsText
            // 
            this.ProductsText.BackColor = System.Drawing.Color.White;
            this.ProductsText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsText.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsText.Location = new System.Drawing.Point(3, 3);
            this.ProductsText.Name = "ProductsText";
            this.ProductsText.ReadOnly = true;
            this.ProductsText.Size = new System.Drawing.Size(375, 52);
            this.ProductsText.TabIndex = 3;
            this.ProductsText.Text = "products 😋";
            this.ProductsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnChips
            // 
            this.BtnChips.BackColor = System.Drawing.Color.Transparent;
            this.BtnChips.BackgroundImage = global::newvending.Properties.Resources.bag_of_potato_chips_vector;
            this.BtnChips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnChips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChips.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnChips.Location = new System.Drawing.Point(3, 61);
            this.BtnChips.Name = "BtnChips";
            this.BtnChips.Size = new System.Drawing.Size(183, 140);
            this.BtnChips.TabIndex = 4;
            this.BtnChips.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnChips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnChips.UseVisualStyleBackColor = false;
            this.BtnChips.Click += new System.EventHandler(this.BtnGeneric_Click);
            // 
            // BtnPizza
            // 
            this.BtnPizza.BackColor = System.Drawing.Color.Transparent;
            this.BtnPizza.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_22_141949;
            this.BtnPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPizza.Location = new System.Drawing.Point(192, 61);
            this.BtnPizza.Name = "BtnPizza";
            this.BtnPizza.Size = new System.Drawing.Size(183, 140);
            this.BtnPizza.TabIndex = 5;
            this.BtnPizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPizza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPizza.UseVisualStyleBackColor = false;
            this.BtnPizza.Click += new System.EventHandler(this.BtnGeneric_Click);
            // 
            // ChipsPriceText
            // 
            this.ChipsPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChipsPriceText.Cursor = System.Windows.Forms.Cursors.No;
            this.ChipsPriceText.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsPriceText.Location = new System.Drawing.Point(3, 207);
            this.ChipsPriceText.Name = "ChipsPriceText";
            this.ChipsPriceText.ReadOnly = true;
            this.ChipsPriceText.Size = new System.Drawing.Size(182, 29);
            this.ChipsPriceText.TabIndex = 6;
            this.ChipsPriceText.Text = " Chips:        2.10£";
            // 
            // PizzaPriceText
            // 
            this.PizzaPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PizzaPriceText.Cursor = System.Windows.Forms.Cursors.No;
            this.PizzaPriceText.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaPriceText.Location = new System.Drawing.Point(191, 207);
            this.PizzaPriceText.Name = "PizzaPriceText";
            this.PizzaPriceText.ReadOnly = true;
            this.PizzaPriceText.Size = new System.Drawing.Size(182, 29);
            this.PizzaPriceText.TabIndex = 7;
            this.PizzaPriceText.Text = " Pizza:        4.55£";
            // 
            // BtnIceCream
            // 
            this.BtnIceCream.BackColor = System.Drawing.Color.Transparent;
            this.BtnIceCream.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_22_145220;
            this.BtnIceCream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIceCream.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIceCream.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIceCream.Location = new System.Drawing.Point(3, 242);
            this.BtnIceCream.Name = "BtnIceCream";
            this.BtnIceCream.Size = new System.Drawing.Size(182, 140);
            this.BtnIceCream.TabIndex = 8;
            this.BtnIceCream.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnIceCream.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnIceCream.UseVisualStyleBackColor = false;
            this.BtnIceCream.Click += new System.EventHandler(this.BtnGeneric_Click);
            // 
            // BtnDonut
            // 
            this.BtnDonut.BackColor = System.Drawing.Color.Transparent;
            this.BtnDonut.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_22_142115;
            this.BtnDonut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDonut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDonut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDonut.Location = new System.Drawing.Point(191, 242);
            this.BtnDonut.Name = "BtnDonut";
            this.BtnDonut.Size = new System.Drawing.Size(182, 140);
            this.BtnDonut.TabIndex = 9;
            this.BtnDonut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDonut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDonut.UseVisualStyleBackColor = false;
            this.BtnDonut.Click += new System.EventHandler(this.BtnGeneric_Click);
            // 
            // IceCreamPriceText
            // 
            this.IceCreamPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IceCreamPriceText.Cursor = System.Windows.Forms.Cursors.No;
            this.IceCreamPriceText.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IceCreamPriceText.Location = new System.Drawing.Point(3, 388);
            this.IceCreamPriceText.Name = "IceCreamPriceText";
            this.IceCreamPriceText.ReadOnly = true;
            this.IceCreamPriceText.Size = new System.Drawing.Size(182, 29);
            this.IceCreamPriceText.TabIndex = 10;
            this.IceCreamPriceText.Text = " IceCream:    3.29£";
            // 
            // DonutPriceText
            // 
            this.DonutPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DonutPriceText.Cursor = System.Windows.Forms.Cursors.No;
            this.DonutPriceText.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonutPriceText.Location = new System.Drawing.Point(191, 388);
            this.DonutPriceText.Name = "DonutPriceText";
            this.DonutPriceText.ReadOnly = true;
            this.DonutPriceText.Size = new System.Drawing.Size(182, 29);
            this.DonutPriceText.TabIndex = 11;
            this.DonutPriceText.Text = " Donut:       1.66£";
            // 
            // BtnSandwich
            // 
            this.BtnSandwich.BackColor = System.Drawing.Color.Transparent;
            this.BtnSandwich.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_22_142046;
            this.BtnSandwich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSandwich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSandwich.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSandwich.Location = new System.Drawing.Point(3, 423);
            this.BtnSandwich.Name = "BtnSandwich";
            this.BtnSandwich.Size = new System.Drawing.Size(182, 140);
            this.BtnSandwich.TabIndex = 12;
            this.BtnSandwich.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSandwich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSandwich.UseVisualStyleBackColor = false;
            this.BtnSandwich.Click += new System.EventHandler(this.BtnGeneric_Click);
            // 
            // BtnDrink
            // 
            this.BtnDrink.BackColor = System.Drawing.Color.Transparent;
            this.BtnDrink.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_22_211406;
            this.BtnDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDrink.Location = new System.Drawing.Point(191, 423);
            this.BtnDrink.Name = "BtnDrink";
            this.BtnDrink.Size = new System.Drawing.Size(182, 140);
            this.BtnDrink.TabIndex = 13;
            this.BtnDrink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDrink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDrink.UseVisualStyleBackColor = false;
            this.BtnDrink.Click += new System.EventHandler(this.BtnGeneric_Click);
            // 
            // SandwichPriceText
            // 
            this.SandwichPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SandwichPriceText.Cursor = System.Windows.Forms.Cursors.No;
            this.SandwichPriceText.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SandwichPriceText.Location = new System.Drawing.Point(3, 569);
            this.SandwichPriceText.Name = "SandwichPriceText";
            this.SandwichPriceText.ReadOnly = true;
            this.SandwichPriceText.Size = new System.Drawing.Size(182, 29);
            this.SandwichPriceText.TabIndex = 14;
            this.SandwichPriceText.Text = "Sandwich:   6.42£";
            // 
            // DrinkPriceText
            // 
            this.DrinkPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrinkPriceText.Cursor = System.Windows.Forms.Cursors.No;
            this.DrinkPriceText.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkPriceText.Location = new System.Drawing.Point(191, 569);
            this.DrinkPriceText.Name = "DrinkPriceText";
            this.DrinkPriceText.ReadOnly = true;
            this.DrinkPriceText.Size = new System.Drawing.Size(182, 29);
            this.DrinkPriceText.TabIndex = 15;
            this.DrinkPriceText.Text = "Drink:        3.20£";
            // 
            // BasketListBox
            // 
            this.BasketListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BasketListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BasketListBox.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketListBox.FormattingEnabled = true;
            this.BasketListBox.ItemHeight = 38;
            this.BasketListBox.Location = new System.Drawing.Point(383, 89);
            this.BasketListBox.Name = "BasketListBox";
            this.BasketListBox.Size = new System.Drawing.Size(399, 266);
            this.BasketListBox.TabIndex = 1;
            this.BasketListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BasketListBox_MouseDown);
            // 
            // BasketTextBox
            // 
            this.BasketTextBox.BackColor = System.Drawing.Color.White;
            this.BasketTextBox.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasketTextBox.Location = new System.Drawing.Point(381, 31);
            this.BasketTextBox.Name = "BasketTextBox";
            this.BasketTextBox.ReadOnly = true;
            this.BasketTextBox.Size = new System.Drawing.Size(399, 52);
            this.BasketTextBox.TabIndex = 4;
            this.BasketTextBox.Text = "Basket 🧺";
            this.BasketTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCancel
            // 
            this.BtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(790, 35);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(134, 76);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.White;
            this.TotalTextBox.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(384, 313);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(399, 46);
            this.TotalTextBox.TabIndex = 7;
            this.TotalTextBox.Text = "Total: ";
            // 
            // LblWallet
            // 
            this.LblWallet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblWallet.Cursor = System.Windows.Forms.Cursors.No;
            this.LblWallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblWallet.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWallet.Location = new System.Drawing.Point(0, 0);
            this.LblWallet.Name = "LblWallet";
            this.LblWallet.ReadOnly = true;
            this.LblWallet.Size = new System.Drawing.Size(545, 52);
            this.LblWallet.TabIndex = 1;
            this.LblWallet.Text = "wallet💰";
            this.LblWallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.LblChange);
            this.panel2.Controls.Add(this.LblnewTotal);
            this.panel2.Controls.Add(this.TwentyPencePic);
            this.panel2.Controls.Add(this.FiftyPencePic);
            this.panel2.Controls.Add(this.OnePoundPic);
            this.panel2.Controls.Add(this.LblWallet);
            this.panel2.Controls.Add(this.FivePoundPic);
            this.panel2.Controls.Add(this.TenPoundPic);
            this.panel2.Controls.Add(this.CoinSlotPic);
            this.panel2.Location = new System.Drawing.Point(378, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 268);
            this.panel2.TabIndex = 12;
            // 
            // LblChange
            // 
            this.LblChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblChange.Cursor = System.Windows.Forms.Cursors.No;
            this.LblChange.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChange.Location = new System.Drawing.Point(402, 232);
            this.LblChange.Name = "LblChange";
            this.LblChange.ReadOnly = true;
            this.LblChange.Size = new System.Drawing.Size(143, 33);
            this.LblChange.TabIndex = 8;
            this.LblChange.Text = "change: ";
            this.LblChange.Visible = false;
            // 
            // LblnewTotal
            // 
            this.LblnewTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblnewTotal.Cursor = System.Windows.Forms.Cursors.No;
            this.LblnewTotal.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblnewTotal.Location = new System.Drawing.Point(402, 197);
            this.LblnewTotal.Name = "LblnewTotal";
            this.LblnewTotal.ReadOnly = true;
            this.LblnewTotal.Size = new System.Drawing.Size(143, 33);
            this.LblnewTotal.TabIndex = 7;
            this.LblnewTotal.Text = "Total: ";
            this.LblnewTotal.Visible = false;
            // 
            // TwentyPencePic
            // 
            this.TwentyPencePic.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_24_101322;
            this.TwentyPencePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwentyPencePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwentyPencePic.Enabled = false;
            this.TwentyPencePic.Location = new System.Drawing.Point(250, 149);
            this.TwentyPencePic.Name = "TwentyPencePic";
            this.TwentyPencePic.Size = new System.Drawing.Size(129, 107);
            this.TwentyPencePic.TabIndex = 6;
            this.TwentyPencePic.TabStop = false;
            this.TwentyPencePic.Tag = "0.2";
            this.TwentyPencePic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TwentyPencePoundPic_MouseDown);
            // 
            // FiftyPencePic
            // 
            this.FiftyPencePic.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_24_101359;
            this.FiftyPencePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiftyPencePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiftyPencePic.Enabled = false;
            this.FiftyPencePic.Location = new System.Drawing.Point(131, 149);
            this.FiftyPencePic.Name = "FiftyPencePic";
            this.FiftyPencePic.Size = new System.Drawing.Size(125, 107);
            this.FiftyPencePic.TabIndex = 5;
            this.FiftyPencePic.TabStop = false;
            this.FiftyPencePic.Tag = "0.5";
            this.FiftyPencePic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FiftyPencePic_MouseDown);
            // 
            // OnePoundPic
            // 
            this.OnePoundPic.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_24_101303;
            this.OnePoundPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OnePoundPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnePoundPic.Enabled = false;
            this.OnePoundPic.Location = new System.Drawing.Point(0, 149);
            this.OnePoundPic.Name = "OnePoundPic";
            this.OnePoundPic.Size = new System.Drawing.Size(125, 107);
            this.OnePoundPic.TabIndex = 4;
            this.OnePoundPic.TabStop = false;
            this.OnePoundPic.Tag = "1";
            this.OnePoundPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnePoundPic_MouseDown);
            // 
            // FivePoundPic
            // 
            this.FivePoundPic.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_24_093117;
            this.FivePoundPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FivePoundPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FivePoundPic.Enabled = false;
            this.FivePoundPic.Location = new System.Drawing.Point(190, 58);
            this.FivePoundPic.Name = "FivePoundPic";
            this.FivePoundPic.Size = new System.Drawing.Size(175, 81);
            this.FivePoundPic.TabIndex = 2;
            this.FivePoundPic.TabStop = false;
            this.FivePoundPic.Tag = "5";
            this.FivePoundPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FivePoundPic_MouseDown);
            // 
            // TenPoundPic
            // 
            this.TenPoundPic.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_24_093152;
            this.TenPoundPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TenPoundPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TenPoundPic.Enabled = false;
            this.TenPoundPic.Location = new System.Drawing.Point(5, 58);
            this.TenPoundPic.Name = "TenPoundPic";
            this.TenPoundPic.Size = new System.Drawing.Size(175, 81);
            this.TenPoundPic.TabIndex = 0;
            this.TenPoundPic.TabStop = false;
            this.TenPoundPic.Tag = "10";
            this.TenPoundPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TenPoundPic_MouseDown);
            // 
            // CoinSlotPic
            // 
            this.CoinSlotPic.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_24_094742;
            this.CoinSlotPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoinSlotPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CoinSlotPic.Location = new System.Drawing.Point(371, 58);
            this.CoinSlotPic.Name = "CoinSlotPic";
            this.CoinSlotPic.Size = new System.Drawing.Size(179, 133);
            this.CoinSlotPic.TabIndex = 3;
            this.CoinSlotPic.TabStop = false;
            this.CoinSlotPic.Tag = "5";
            this.CoinSlotPic.DragDrop += new System.Windows.Forms.DragEventHandler(this.CoinSlotPic_DragDrop);
            this.CoinSlotPic.DragEnter += new System.Windows.Forms.DragEventHandler(this.CoinSlotPic_DragEnter);
            // 
            // pictureBoxBin
            // 
            this.pictureBoxBin.BackgroundImage = global::newvending.Properties.Resources.Screenshot_2024_10_22_2234292;
            this.pictureBoxBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBin.Location = new System.Drawing.Point(789, 119);
            this.pictureBoxBin.Name = "pictureBoxBin";
            this.pictureBoxBin.Size = new System.Drawing.Size(133, 114);
            this.pictureBoxBin.TabIndex = 10;
            this.pictureBoxBin.TabStop = false;
            this.pictureBoxBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxBin_DragDrop);
            this.pictureBoxBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxBin_DragEnter);
            // 
            // BtnPurchase
            // 
            this.BtnPurchase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPurchase.BackgroundImage = global::newvending.Properties.Resources.OIP__6_;
            this.BtnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPurchase.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPurchase.Location = new System.Drawing.Point(789, 235);
            this.BtnPurchase.Name = "BtnPurchase";
            this.BtnPurchase.Size = new System.Drawing.Size(134, 122);
            this.BtnPurchase.TabIndex = 8;
            this.BtnPurchase.Text = "Check out";
            this.BtnPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPurchase.UseVisualStyleBackColor = true;
            this.BtnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // LblLastAction
            // 
            this.LblLastAction.BackColor = System.Drawing.SystemColors.Control;
            this.LblLastAction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LblLastAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblLastAction.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastAction.Location = new System.Drawing.Point(0, 0);
            this.LblLastAction.Name = "LblLastAction";
            this.LblLastAction.ReadOnly = true;
            this.LblLastAction.Size = new System.Drawing.Size(926, 26);
            this.LblLastAction.TabIndex = 13;
            this.LblLastAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 637);
            this.Controls.Add(this.LblLastAction);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBoxBin);
            this.Controls.Add(this.BtnPurchase);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BasketTextBox);
            this.Controls.Add(this.BasketListBox);
            this.Controls.Add(this.ProductPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "vending machine-30079242";
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyPencePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyPencePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OnePoundPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FivePoundPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenPoundPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinSlotPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.TextBox ProductsText;
        private System.Windows.Forms.Button BtnChips;
        private System.Windows.Forms.Button BtnPizza;
        private System.Windows.Forms.TextBox ChipsPriceText;
        private System.Windows.Forms.TextBox PizzaPriceText;
        private System.Windows.Forms.Button BtnIceCream;
        private System.Windows.Forms.Button BtnDonut;
        private System.Windows.Forms.TextBox IceCreamPriceText;
        private System.Windows.Forms.TextBox DonutPriceText;
        private System.Windows.Forms.Button BtnSandwich;
        private System.Windows.Forms.Button BtnDrink;
        private System.Windows.Forms.TextBox SandwichPriceText;
        private System.Windows.Forms.TextBox DrinkPriceText;
        private System.Windows.Forms.ListBox BasketListBox;
        private System.Windows.Forms.TextBox BasketTextBox;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button BtnPurchase;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBoxBin;
        private System.Windows.Forms.PictureBox CoinSlotPic;
        private System.Windows.Forms.PictureBox FivePoundPic;
        private System.Windows.Forms.PictureBox TenPoundPic;
        private System.Windows.Forms.TextBox LblWallet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox OnePoundPic;
        private System.Windows.Forms.PictureBox TwentyPencePic;
        private System.Windows.Forms.PictureBox FiftyPencePic;
        private System.Windows.Forms.TextBox LblnewTotal;
        private System.Windows.Forms.TextBox LblChange;
        private System.Windows.Forms.TextBox LblLastAction;
    }
}

