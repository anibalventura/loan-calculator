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
            LoadMonthlyFeeOptions();
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

        private void LoadMonthlyFeeOptions()
        {
            for (int i = 12; i <= 120; i += 6)
            {
                CmbxAmountOfMonts.Items.Add(i);
            }

            CmbxAmountOfMonts.SelectedItem = new ComboBoxItem()
            {
                Text = "Select an option",
                Value = null
            };
        }
    }
}
