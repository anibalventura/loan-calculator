﻿
namespace LoanCalculator
{
    partial class FrmLoanCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblLoanAmount = new System.Windows.Forms.Label();
            this.LblLoanType = new System.Windows.Forms.Label();
            this.LblAmountMonthlyFee = new System.Windows.Forms.Label();
            this.LblAnualInterestRate = new System.Windows.Forms.Label();
            this.LblMonthlyFee = new System.Windows.Forms.Label();
            this.TxbLoanAmount = new System.Windows.Forms.TextBox();
            this.TxbAnualInterestRate = new System.Windows.Forms.TextBox();
            this.TxbMonthlyFee = new System.Windows.Forms.TextBox();
            this.CmbxLoanType = new System.Windows.Forms.ComboBox();
            this.CmbxMonthlyFee = new System.Windows.Forms.ComboBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 4;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpMain.Controls.Add(this.LblLoanAmount, 1, 1);
            this.TlpMain.Controls.Add(this.LblLoanType, 1, 2);
            this.TlpMain.Controls.Add(this.LblAmountMonthlyFee, 1, 3);
            this.TlpMain.Controls.Add(this.LblAnualInterestRate, 1, 4);
            this.TlpMain.Controls.Add(this.LblMonthlyFee, 1, 6);
            this.TlpMain.Controls.Add(this.TxbLoanAmount, 2, 1);
            this.TlpMain.Controls.Add(this.TxbAnualInterestRate, 2, 4);
            this.TlpMain.Controls.Add(this.TxbMonthlyFee, 2, 6);
            this.TlpMain.Controls.Add(this.CmbxLoanType, 2, 2);
            this.TlpMain.Controls.Add(this.CmbxMonthlyFee, 2, 3);
            this.TlpMain.Controls.Add(this.BtnCalculate, 2, 5);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 8;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TlpMain.Size = new System.Drawing.Size(800, 450);
            this.TlpMain.TabIndex = 0;
            // 
            // LblLoanAmount
            // 
            this.LblLoanAmount.AutoSize = true;
            this.LblLoanAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLoanAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLoanAmount.Location = new System.Drawing.Point(163, 56);
            this.LblLoanAmount.Name = "LblLoanAmount";
            this.LblLoanAmount.Size = new System.Drawing.Size(234, 56);
            this.LblLoanAmount.TabIndex = 0;
            this.LblLoanAmount.Text = "Loan amount";
            this.LblLoanAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblLoanType
            // 
            this.LblLoanType.AutoSize = true;
            this.LblLoanType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLoanType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLoanType.Location = new System.Drawing.Point(163, 112);
            this.LblLoanType.Name = "LblLoanType";
            this.LblLoanType.Size = new System.Drawing.Size(234, 56);
            this.LblLoanType.TabIndex = 1;
            this.LblLoanType.Text = "Loan type";
            this.LblLoanType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblAmountMonthlyFee
            // 
            this.LblAmountMonthlyFee.AutoSize = true;
            this.LblAmountMonthlyFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAmountMonthlyFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAmountMonthlyFee.Location = new System.Drawing.Point(163, 168);
            this.LblAmountMonthlyFee.Name = "LblAmountMonthlyFee";
            this.LblAmountMonthlyFee.Size = new System.Drawing.Size(234, 56);
            this.LblAmountMonthlyFee.TabIndex = 2;
            this.LblAmountMonthlyFee.Text = "Amount of monthly fee";
            this.LblAmountMonthlyFee.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblAnualInterestRate
            // 
            this.LblAnualInterestRate.AutoSize = true;
            this.LblAnualInterestRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAnualInterestRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAnualInterestRate.Location = new System.Drawing.Point(163, 224);
            this.LblAnualInterestRate.Name = "LblAnualInterestRate";
            this.LblAnualInterestRate.Size = new System.Drawing.Size(234, 56);
            this.LblAnualInterestRate.TabIndex = 3;
            this.LblAnualInterestRate.Text = "Annual interest rate";
            this.LblAnualInterestRate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblMonthlyFee
            // 
            this.LblMonthlyFee.AutoSize = true;
            this.LblMonthlyFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMonthlyFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMonthlyFee.Location = new System.Drawing.Point(163, 336);
            this.LblMonthlyFee.Name = "LblMonthlyFee";
            this.LblMonthlyFee.Size = new System.Drawing.Size(234, 56);
            this.LblMonthlyFee.TabIndex = 4;
            this.LblMonthlyFee.Text = "Monthly fee";
            this.LblMonthlyFee.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TxbLoanAmount
            // 
            this.TxbLoanAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbLoanAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbLoanAmount.Location = new System.Drawing.Point(403, 59);
            this.TxbLoanAmount.Name = "TxbLoanAmount";
            this.TxbLoanAmount.Size = new System.Drawing.Size(234, 29);
            this.TxbLoanAmount.TabIndex = 5;
            // 
            // TxbAnualInterestRate
            // 
            this.TxbAnualInterestRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxbAnualInterestRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbAnualInterestRate.Location = new System.Drawing.Point(403, 227);
            this.TxbAnualInterestRate.Name = "TxbAnualInterestRate";
            this.TxbAnualInterestRate.Size = new System.Drawing.Size(234, 29);
            this.TxbAnualInterestRate.TabIndex = 6;
            // 
            // TxbMonthlyFee
            // 
            this.TxbMonthlyFee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxbMonthlyFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbMonthlyFee.Location = new System.Drawing.Point(403, 360);
            this.TxbMonthlyFee.Name = "TxbMonthlyFee";
            this.TxbMonthlyFee.Size = new System.Drawing.Size(234, 29);
            this.TxbMonthlyFee.TabIndex = 7;
            // 
            // CmbxLoanType
            // 
            this.CmbxLoanType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbxLoanType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmbxLoanType.FormattingEnabled = true;
            this.CmbxLoanType.Location = new System.Drawing.Point(403, 115);
            this.CmbxLoanType.Name = "CmbxLoanType";
            this.CmbxLoanType.Size = new System.Drawing.Size(234, 29);
            this.CmbxLoanType.TabIndex = 8;
            // 
            // CmbxMonthlyFee
            // 
            this.CmbxMonthlyFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbxMonthlyFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmbxMonthlyFee.FormattingEnabled = true;
            this.CmbxMonthlyFee.Location = new System.Drawing.Point(403, 171);
            this.CmbxMonthlyFee.Name = "CmbxMonthlyFee";
            this.CmbxMonthlyFee.Size = new System.Drawing.Size(234, 29);
            this.CmbxMonthlyFee.TabIndex = 9;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCalculate.Location = new System.Drawing.Point(403, 283);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(234, 50);
            this.BtnCalculate.TabIndex = 10;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            // 
            // FrmLoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TlpMain);
            this.Name = "FrmLoanCalculator";
            this.Text = "Loan Calculator";
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblLoanAmount;
        private System.Windows.Forms.Label LblLoanType;
        private System.Windows.Forms.Label LblAmountMonthlyFee;
        private System.Windows.Forms.Label LblAnualInterestRate;
        private System.Windows.Forms.Label LblMonthlyFee;
        private System.Windows.Forms.TextBox TxbLoanAmount;
        private System.Windows.Forms.TextBox TxbAnualInterestRate;
        private System.Windows.Forms.TextBox TxbMonthlyFee;
        private System.Windows.Forms.ComboBox CmbxLoanType;
        private System.Windows.Forms.ComboBox CmbxMonthlyFee;
        private System.Windows.Forms.Button BtnCalculate;
    }
}

