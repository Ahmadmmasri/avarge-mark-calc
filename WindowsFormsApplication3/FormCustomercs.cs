using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FormCustomercs : Form
    {
        public FormCustomercs()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
            string grade1 = "D";  //1
            string grade2 = "C";  //2
            string grade3 = "B";  //3
            string grade4 = "A";  //4
            double value1 = Convert.ToDouble(textBoxVal.Text);   //5
            double value2 = Convert.ToDouble(textBoxval2.Text);   //5
            double value3 = Convert.ToDouble(textBoxval3.Text);   //5
            double value4 = Convert.ToDouble(textBoxVal4.Text);   //5
            double value5 = Convert.ToDouble(TextBoxval5.Text);   //5
            double value6 = Convert.ToDouble(TextBoxval6.Text);   //5

            
                double average = (value1 + value2 + value3 + value4 + value5 + value6) / 6;
                if (value1 >= 0 && value2 >= 0 && value3 >= 0 && value4 >= 0 && value5 >= 0 && value6 >= 0)
                {                                      //7
                    Average.Text = Convert.ToString(average); //8   
                    if (average <= 49.9)   //9
                        Grade.Text = "your grade is fail"; //10
                    else if (average <= 67.9)    //11
                        Grade.Text = "your grade is " + grade1;  //12
                    else if (average <= 75.9) //13
                        Grade.Text = "your grade is " + grade2;   //14
                    else if (average <= 83.9) //15
                        Grade.Text = "your grade is " + grade3;  //16
                    else if (average <= 100)//17
                        Grade.Text = "your grade is " + grade4;  //18
                    //19
                }
                else
                {
                    MessageBox.Show("you should put only positive numbers"); //20
                    textBoxVal.Clear();
                    //21
                }
            }
            catch (Exception) { 
            MessageBox.Show("please fill the blanks");
            }
            
        }//22
        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormCustomercs_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        }
    }

