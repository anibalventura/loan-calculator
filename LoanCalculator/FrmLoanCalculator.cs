using LoanCalculator.CustomControlItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace LoanCalculator
{
    public partial class FrmLoanCalculator : Form
    {
        public FrmLoanCalculator()
        {
            InitializeComponent();

            LoadLoanTypeOptions();
            LoadAmountOfMonthsOptions();
        }

        private void CmbxLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAnnualInterest();
        }

        private void UpdateAnnualInterest()
        {
            ComboBoxItem loanType = CmbxLoanType.SelectedItem as ComboBoxItem;

            if (loanType.Value != null)
            {
                switch (loanType.Value)
                {
                    case (int)LoanTypeOptions.PERSONAL:
                        TxbAnualInterestRate.Text = $"{(int)InterestOptions.PERSONAL}%";
                        break;
                    case (int)LoanTypeOptions.VEHICLE:
                        TxbAnualInterestRate.Text = $"{(int)InterestOptions.VEHICLE}%";
                        break;
                    case (int)LoanTypeOptions.MORTAGE:
                        TxbAnualInterestRate.Text = $"{(int)InterestOptions.MORTAGE}%";
                        break;
                }
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                ComboBoxItem loanType = CmbxLoanType.SelectedItem as ComboBoxItem;
                ComboBoxItem amountOfMonths = CmbxAmountOfMonts.SelectedItem as ComboBoxItem;

                if (string.IsNullOrEmpty(TxbLoanAmount.Text))
                {
                    MessageBox.Show("Please enter a loan amount.", "Warning!");
                }
                else if (loanType.Value == null)
                {
                    MessageBox.Show("Please select a loan type.", "Warning!");
                }
                else if (amountOfMonths.Value == null)
                {
                    MessageBox.Show("Please select an amount of months.", "Warning!");
                }
                else
                {
                    Calculator calculator = new Calculator();

                    int amount = int.Parse(TxbLoanAmount.Text);
                    int type = (int)loanType.Value;
                    int months = (int)amountOfMonths.Value;
                    double result = calculator.CalculateLoan(amount, type, months);

                    TxbMonthlyFee.Text = $"$ {result.ToString("#,000.##")}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a numeric amount.", "Error!");
            }
        }

        private void LoadLoanTypeOptions()
        {
            List<ComboBoxItem> loanTypeOptions = new List<ComboBoxItem>()
            {
                new ComboBoxItem()
                {
                    Text = "Select an option",
                    Value = null
                },
                new ComboBoxItem()
                {
                    Text = "Personal",
                    Value = (int)LoanTypeOptions.PERSONAL
                },
                new ComboBoxItem
                {
                    Text = "Vehicle",
                    Value = (int)LoanTypeOptions.VEHICLE
                },
                new ComboBoxItem
                {
                    Text = "Mortage",
                    Value = (int)LoanTypeOptions.MORTAGE
                }
            };

            foreach (ComboBoxItem loanType in loanTypeOptions)
            {
                CmbxLoanType.Items.Add(loanType);
            }

            CmbxLoanType.SelectedItem = loanTypeOptions[0];
        }

        private void LoadAmountOfMonthsOptions()
        {
            ComboBoxItem defaultOption = new ComboBoxItem()
            {
                Text = "Select an option",
                Value = null
            };

            CmbxAmountOfMonts.Items.Add(defaultOption);
            CmbxAmountOfMonts.SelectedItem = defaultOption;

            for (int i = 12; i <= 120; i += 6)
            {
                ComboBoxItem newItem = new ComboBoxItem
                {
                    Text = i.ToString(),
                    Value = i
                };

                CmbxAmountOfMonts.Items.Add(newItem);
            }
        }
    }
}
