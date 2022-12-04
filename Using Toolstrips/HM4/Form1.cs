namespace HM4
{
    public partial class Form1 : Form
    {
        public int size = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {
            lblUserOutput.Text = txtUserInput.Text;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.lblUserOutput.Font = new Font("Segoe UI", size);
            size+= 4;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (size == 0)
            {
                size= 12;
            }
            this.lblUserOutput.Font = new Font("Segoe UI", size);
            size -= 4;
        }
    }
}