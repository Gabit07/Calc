namespace WinFormsAppCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] plusSplit = textBox1.Text.Split('+');
            double result = 0;
            for (int i = 0; i < plusSplit.Length; i++)
            {
                //Console.WriteLine(plusSplit[i]);
                string[] minusSplit = plusSplit[i].Split('-');
                double minusSplitResult = 0;

                for (int j = 0; j < minusSplit.Length; j++)
                {
                    string[] multiSplit = minusSplit[j].Split('*');    
                    double multiSplitResult = 0;

                    for (int k = 0; k < multiSplit.Length; k++)
                    {
                        string[] divSplit = multiSplit[k].Split('/');   
                        double divSplitResult = 0;

                        for (int l = 0; l < divSplit.Length; l++)
                        {
                            if (l == 0)
                            {
                                divSplitResult += Convert.ToDouble(divSplit[l]);    
                            }
                            else
                            {
                                divSplitResult /= Convert.ToDouble(divSplit[l]);    
                            }
                        }

                        multiSplit[k] = Convert.ToString(divSplitResult);

                        if (k == 0)
                        {
                            multiSplitResult += Convert.ToDouble(multiSplit[k]);
                        }
                        else
                        {
                            multiSplitResult *= Convert.ToDouble(multiSplit[k]);
                        }
                    }
                    minusSplit[j] = Convert.ToString(multiSplitResult);
                    
                    if (j == 0)
                    {
                        minusSplitResult += Convert.ToDouble(minusSplit[j]);
                    }
                    else
                    {
                        minusSplitResult -= Convert.ToDouble(minusSplit[j]);
                    }
                }
                plusSplit[i] = Convert.ToString(minusSplitResult);
                Console.WriteLine(plusSplit[i]);
                result += Convert.ToDouble(plusSplit[i]);
            }
            label1.Text = Convert.ToString(result);
        }
    }
}