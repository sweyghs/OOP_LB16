namespace LB_5_oop
{
    partial class Form1
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
            label1 = new Label();
            txtPoly1 = new TextBox();
            label2 = new Label();
            txtPoly2 = new TextBox();
            label3 = new Label();
            txtX = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnEvaluate = new Button();
            lblResult = new Label();
            lblValue = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Многочлен P(x):";
            // 
            // txtPoly1
            // 
            txtPoly1.Location = new Point(28, 43);
            txtPoly1.Name = "txtPoly1";
            txtPoly1.Size = new Size(152, 23);
            txtPoly1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 83);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Многочлен Q(x):";
            // 
            // txtPoly2
            // 
            txtPoly2.Location = new Point(28, 118);
            txtPoly2.Name = "txtPoly2";
            txtPoly2.Size = new Size(152, 23);
            txtPoly2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 164);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Значення x:";
            // 
            // txtX
            // 
            txtX.Location = new Point(106, 164);
            txtX.Name = "txtX";
            txtX.Size = new Size(74, 23);
            txtX.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(119, 231);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 7;
            btnSubtract.Text = "Відняти";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(228, 231);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(82, 23);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "Помножити";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnEvaluate
            // 
            btnEvaluate.Location = new Point(341, 231);
            btnEvaluate.Name = "btnEvaluate";
            btnEvaluate.Size = new Size(80, 23);
            btnEvaluate.TabIndex = 9;
            btnEvaluate.Text = "Обчислити";
            btnEvaluate.UseVisualStyleBackColor = true;
            btnEvaluate.Click += btnEvaluate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(41, 288);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 15);
            lblResult.TabIndex = 10;
            lblResult.Text = "Результат:";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(41, 354);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(63, 15);
            lblValue.TabIndex = 11;
            lblValue.Text = "Значення:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValue);
            Controls.Add(lblResult);
            Controls.Add(btnEvaluate);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtX);
            Controls.Add(label3);
            Controls.Add(txtPoly2);
            Controls.Add(label2);
            Controls.Add(txtPoly1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPoly1;
        private Label label2;
        private TextBox txtPoly2;
        private Label label3;
        private TextBox txtX;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnEvaluate;
        private Label lblResult;
        private Label lblValue;
    }
}
