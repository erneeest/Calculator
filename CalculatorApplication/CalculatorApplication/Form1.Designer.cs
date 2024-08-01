namespace CalculatorApplication
{
    partial class FrmCalculator
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
            firstNumberLbl = new Label();
            txtBoxInput1 = new TextBox();
            cbOperator = new ComboBox();
            secondNumberLbl = new Label();
            txtBoxInput2 = new TextBox();
            answerLbl = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // firstNumberLbl
            // 
            firstNumberLbl.Anchor = AnchorStyles.None;
            firstNumberLbl.AutoSize = true;
            firstNumberLbl.Location = new Point(22, 40);
            firstNumberLbl.Name = "firstNumberLbl";
            firstNumberLbl.Size = new Size(109, 15);
            firstNumberLbl.TabIndex = 0;
            firstNumberLbl.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Anchor = AnchorStyles.None;
            txtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput1.Location = new Point(144, 32);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(190, 29);
            txtBoxInput1.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Anchor = AnchorStyles.None;
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(182, 79);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(121, 27);
            cbOperator.TabIndex = 2;
            // 
            // secondNumberLbl
            // 
            secondNumberLbl.Anchor = AnchorStyles.None;
            secondNumberLbl.AutoSize = true;
            secondNumberLbl.Location = new Point(12, 129);
            secondNumberLbl.Name = "secondNumberLbl";
            secondNumberLbl.Size = new Size(126, 15);
            secondNumberLbl.TabIndex = 3;
            secondNumberLbl.Text = "Enter Second Number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Anchor = AnchorStyles.None;
            txtBoxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput2.Location = new Point(144, 121);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(190, 29);
            txtBoxInput2.TabIndex = 4;
            // 
            // answerLbl
            // 
            answerLbl.Anchor = AnchorStyles.None;
            answerLbl.AutoSize = true;
            answerLbl.Location = new Point(82, 183);
            answerLbl.Name = "answerLbl";
            answerLbl.Size = new Size(49, 15);
            answerLbl.TabIndex = 5;
            answerLbl.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.Anchor = AnchorStyles.None;
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(157, 166);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(0, 15);
            lblDisplayTotal.TabIndex = 6;
            // 
            // btnEqual
            // 
            btnEqual.Anchor = AnchorStyles.None;
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(193, 206);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(110, 29);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 256);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(answerLbl);
            Controls.Add(txtBoxInput2);
            Controls.Add(secondNumberLbl);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput1);
            Controls.Add(firstNumberLbl);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNumberLbl;
        private TextBox txtBoxInput1;
        private ComboBox cbOperator;
        private Label secondNumberLbl;
        private TextBox txtBoxInput2;
        private Label answerLbl;
        private Label lblDisplayTotal;
        private Button btnEqual;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
