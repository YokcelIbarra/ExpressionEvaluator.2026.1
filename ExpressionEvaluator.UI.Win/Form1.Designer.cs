namespace ExpressionEvaluator.UI.Win
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnOpenParen;
        private Button btnCloseParen;
        private Button btnDelete;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnClear;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnPower;
        private Button btn0;
        private Button btnDot;
        private Button btnEquals;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            tableLayoutPanel = new TableLayoutPanel();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnOpenParen = new Button();
            btnCloseParen = new Button();
            btnDelete = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnPower = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();

            // txtDisplay
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Dock = DockStyle.Top;
            txtDisplay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(10, 10);
            txtDisplay.Margin = new Padding(10);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(564, 60);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Left;

            // tableLayoutPanel
            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.Controls.Add(btn7, 0, 0);
            tableLayoutPanel.Controls.Add(btn8, 1, 0);
            tableLayoutPanel.Controls.Add(btn9, 2, 0);
            tableLayoutPanel.Controls.Add(btnOpenParen, 3, 0);
            tableLayoutPanel.Controls.Add(btnCloseParen, 4, 0);
            tableLayoutPanel.Controls.Add(btnDelete, 5, 0);
            tableLayoutPanel.Controls.Add(btn4, 0, 1);
            tableLayoutPanel.Controls.Add(btn5, 1, 1);
            tableLayoutPanel.Controls.Add(btn6, 2, 1);
            tableLayoutPanel.Controls.Add(btnMultiply, 3, 1);
            tableLayoutPanel.Controls.Add(btnDivide, 4, 1);
            tableLayoutPanel.Controls.Add(btnClear, 5, 1);
            tableLayoutPanel.Controls.Add(btn1, 0, 2);
            tableLayoutPanel.Controls.Add(btn2, 1, 2);
            tableLayoutPanel.Controls.Add(btn3, 2, 2);
            tableLayoutPanel.Controls.Add(btnPlus, 3, 2);
            tableLayoutPanel.Controls.Add(btnMinus, 4, 2);
            tableLayoutPanel.Controls.Add(btnPower, 5, 2);
            tableLayoutPanel.Controls.Add(btn0, 0, 3);
            tableLayoutPanel.Controls.Add(btnDot, 1, 3);
            tableLayoutPanel.Controls.Add(btnEquals, 2, 3);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(10, 80);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Size = new Size(564, 321);
            tableLayoutPanel.TabIndex = 1;

            // btn7
            ConfigureButton(btn7, "7");
            btn7.Click += btn7_Click;

            // btn8
            ConfigureButton(btn8, "8");
            btn8.Click += btn8_Click;

            // btn9
            ConfigureButton(btn9, "9");
            btn9.Click += btn9_Click;

            // btnOpenParen
            ConfigureButton(btnOpenParen, "(");
            btnOpenParen.Click += btnOpenParen_Click;

            // btnCloseParen
            ConfigureButton(btnCloseParen, ")");
            btnCloseParen.Click += btnCloseParen_Click;

            // btnDelete
            ConfigureButton(btnDelete, "Delete");
            btnDelete.Click += btnDelete_Click;

            // btn4
            ConfigureButton(btn4, "4");
            btn4.Click += btn4_Click;

            // btn5
            ConfigureButton(btn5, "5");
            btn5.Click += btn5_Click;

            // btn6
            ConfigureButton(btn6, "6");
            btn6.Click += btn6_Click;

            // btnMultiply
            ConfigureButton(btnMultiply, "*");
            btnMultiply.Click += btnMultiply_Click;

            // btnDivide
            ConfigureButton(btnDivide, "/");
            btnDivide.Click += btnDivide_Click;

            // btnClear
            ConfigureButton(btnClear, "Clear");
            btnClear.Click += btnClear_Click;

            // btn1
            ConfigureButton(btn1, "1");
            btn1.Click += btn1_Click;

            // btn2
            ConfigureButton(btn2, "2");
            btn2.Click += btn2_Click;

            // btn3
            ConfigureButton(btn3, "3");
            btn3.Click += btn3_Click;

            // btnPlus
            ConfigureButton(btnPlus, "+");
            btnPlus.Click += btnPlus_Click;

            // btnMinus
            ConfigureButton(btnMinus, "-");
            btnMinus.Click += btnMinus_Click;

            // btnPower
            ConfigureButton(btnPower, "^");
            btnPower.Click += btnPower_Click;

            // btn0
            ConfigureButton(btn0, "0");
            btn0.Click += btn0_Click;

            // btnDot
            ConfigureButton(btnDot, ".");
            btnDot.Click += btnDot_Click;

            // btnEquals
            ConfigureButton(btnEquals, "=");
            tableLayoutPanel.SetColumnSpan(btnEquals, 4);
            btnEquals.Click += btnEquals_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(584, 411);
            Controls.Add(tableLayoutPanel);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Functions Evaluator";
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigureButton(Button button, string text)
        {
            button.BackColor = Color.DarkOrange;
            button.Dock = DockStyle.Fill;
            button.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button.Margin = new Padding(4);
            button.Name = "btn" + text;
            button.Text = text;
            button.UseVisualStyleBackColor = false;
        }
    }
}