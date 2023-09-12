namespace InventoryMaintenance
{

    public partial class frmInventoryMaint : Form
    {
        //Ethan Beach
        public frmInventoryMaint()
        {
            InitializeComponent();
        }

        private List<InventoryItem> items = null;

        private void frmInventoryMaint_Load(object sender, EventArgs e)
        {
            items = new();
            FillItemListBox();
        }

        //Ethan Beach
        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            foreach (InventoryItem i in items)
            {
                lstItems.Items.Add(i.GetDisplayText("\t"));
            }
        }

        //Ethan Beach
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem itemForm = new();
            InventoryItem item = itemForm.GetNewItem();
            if (item != null)
            {
                items.Add(item);
            }
            FillItemListBox();
        }

        //Ethan Beach
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                InventoryItem item = items[i];
                items.Remove(item);
                FillItemListBox();
            }
        }

        //Ethan Beach
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}