using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace InventoryMaintenance
{
    //Ethan Beach
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        private InventoryItem item = null;

        //Ethan Beach
        private void btnSave_Click(object sender, EventArgs e)
        {
            item = new InventoryItem
            {
                ItemNo = txtItemNo.Text,
                Description = txtDescription.Text,
                Price = Convert.ToDecimal(txtPrice.Text)
            };
            this.Close();
        }

        //Ethan Beach
        public InventoryItem GetNewItem() //Grabs item for return
        {
            this.ShowDialog();
            return item;
        }

        //Ethan Beach
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}