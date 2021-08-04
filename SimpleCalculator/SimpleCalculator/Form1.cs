using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Author : DotnetMob.Com  || Dotnet Mob -Youtube Channel
//Description : Simple Calculator
namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double operand1, operand2, operand3, operand4, operand5, operand6, operand7, operand8, Result, Result1, Result2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            operand3 = Convert.ToDouble(txtOperand3.Text);
            operand7 = Convert.ToDouble(txtOperand7.Text);
            Result = ((operand1 * operand2)/92903.04)*operand7;
            txtResult1.Text = Result.ToString("#0.00000");//Formate  to 2 decimal number
            Result1 = Result * operand3;
            txtResult2.Text = Result1.ToString("#0.000");
        }
        private void btnMultiply2_Click(object sender, EventArgs e)
        {
            operand4 = Convert.ToDouble(txtOperand4.Text);
            operand5 = Convert.ToDouble(txtOperand5.Text);
            operand6 = Convert.ToDouble(txtOperand6.Text);
            operand8 = Convert.ToDouble(txtOperand8.Text);
            Result2 = ((((operand4 * 60) + operand5) / 60) * operand6)* operand8;
            txtResult3.Text = Result2.ToString("#0.000");
        }

        //Prevent user from entering non-digit number
        private void txtOperand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand1.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void txtOperand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void txtOperand3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void txtOperand4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void txtOperand5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void txtOperand6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void txtOperand7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void txtOperand8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtOperand3_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void txtOperand4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOperand7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOperand8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOperand5_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtOperand6_TextChanged(object sender, EventArgs e)
        {

        }





        //reset to 0 if operands are empty
        private void txtOperand1_Leave(object sender, EventArgs e)
        {
            if (txtOperand1.Text == "")
                txtOperand1.Text = "0.00";
        }

        private void txtOperand2_Leave(object sender, EventArgs e)
        {
            if (txtOperand2.Text == "")
                txtOperand2.Text = "0.00";
        }
        private void txtOperand3_Leave(object sender, EventArgs e)
        {
            if (txtOperand3.Text == "")
                txtOperand3.Text = "0.00";
        }
        private void txtOperand4_Leave(object sender, EventArgs e)
        {
            if (txtOperand4.Text == "")
                txtOperand4.Text = "0.00";
        }
        private void txtOperand5_Leave(object sender, EventArgs e)
        {
            if (txtOperand5.Text == "")
                txtOperand5.Text = "0.00";
        }
        private void txtOperand6_Leave(object sender, EventArgs e)
        {
            if (txtOperand6.Text == "")
                txtOperand6.Text = "0.00";
        }
        private void txtOperand7_Leave(object sender, EventArgs e)
        {
            if (txtOperand6.Text == "")
                txtOperand6.Text = "0.00";
        }
        private void txtOperand8_Leave(object sender, EventArgs e)
        {
            if (txtOperand6.Text == "")
                txtOperand6.Text = "0.00";
        }



    }
}
