namespace CarShopGUI
{
    public partial class frmMain : Form
    {

        Store _Store = new Store();

        BindingSource _CarListBinding = new BindingSource();
        BindingSource _ShoppingListBinding = new BindingSource();

        public frmMain()
        {
            InitializeComponent();

            SetBindings();
        }


        private void SetBindings()
        {
            _CarListBinding.DataSource = _Store.CarList;
            lbCarInventory.DataSource= _CarListBinding;
            lbCarInventory.DisplayMember= "ToString";

            _ShoppingListBinding.DataSource = _Store.ShoppingList;
            lbShoppingCart.DataSource = _ShoppingListBinding;
            lbShoppingCart.DisplayMember = "ToString";


        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            // Error handling if user types non numeric in a numeric field. i.e Price or Miles.
            try
            {
                Car newCar = new Car();

                // Copy values over to new car from GUI.
                newCar.Make = txtMake.Text;
                newCar.Model = txtModel.Text;
                newCar.Price = Decimal.Parse(txtPrice.Text);
                newCar.Color = txtColor.Text;
                newCar.Miles = int.Parse(txtMiles.Text);

                _Store.CarList.Add(newCar);

                _CarListBinding.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Price & Miles must be numeric values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            _Store.ShoppingList.Add((Car)lbCarInventory.SelectedItem);

            _ShoppingListBinding.ResetBindings(false);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            decimal total = _Store.checkout();
            
            //Show total on UI.
            lblTotalCostOuput.Text = total.ToString();
        }

      
    }
}