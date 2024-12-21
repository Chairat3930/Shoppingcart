namespace Shoppingcar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_Coffee_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //get amout
            string strCoffeePrice = tb_Coffee_Price.Text;
            string strGreenTeaPrice = tb_GreenTea_Price.Text;
            //get price
            string strCoffeeQunatity = tb_Coffee_Qunatity.Text;
            string strGreenTeaQunatity = tb_GreenTea_Quantity.Text;

            int iCoffeePrice = 0;
            int iCoffeeQunatity = 0;
            int iGreenTeaPrice = 0;
            int iGreenTeaQunatity = 0;
            try
            {
                // convert string to ing
                if (cha_Coffee.Checked)
                {
                     iCoffeePrice = int.Parse(strCoffeePrice);
                     iCoffeeQunatity = int.Parse(strCoffeeQunatity);
                }
                if (cha_GreenTea.Checked)
                {
                     iGreenTeaPrice = int.Parse(strGreenTeaPrice);
                     iGreenTeaQunatity = int.Parse(strGreenTeaQunatity);
                }
            }
            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iCoffeeQunatity = 0;
                iGreenTeaPrice = 0;
                iGreenTeaQunatity = 0;
            }
            //caculate total
            int iTotal = iCoffeePrice * iCoffeeQunatity + iGreenTeaPrice * iGreenTeaQunatity;
            //displat total
            tb_total.Text = iTotal.ToString();
        }

        private void tb_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void cha_Coffee_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
