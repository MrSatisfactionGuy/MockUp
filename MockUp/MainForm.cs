

namespace MockUp
{
    public partial class MainForm : Form
    {
        List<int> list = new List<int>();

        public MainForm()
        {
            //Initialize();
            InitializeComponent();
            InitializeList();
            InitializeComboBox();
        }

        private void InitializeList()
        {
            //this.listView1 = new ListView();

            for (int i = 0; i <= 10; i++)
            {
                this.list.Add(i);
            }


            foreach (int i in list)
            {
                ListViewItem item = new ListViewItem("TB " + i.ToString());
                listView1.Items.Add(item);
            }
        }

        //Comment

        private void InitializeComboBox()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown; // Damit es aussieht wie eine Dropdown-Liste
            comboBox1.Width = 150;

            foreach(int i in list)
            {
                ListViewItem item = new ListViewItem("TB " + i.ToString());
                comboBox1.Items.Add(item.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                MessageBox.Show("Item Selected is: " + comboBox1.Text);
            }
        }
    }
}
