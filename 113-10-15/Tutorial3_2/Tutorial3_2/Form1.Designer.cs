namespace Tutorial3_2
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
            label2 = new Label();
            label3 = new Label();
            txbKm = new TextBox();
            txbliber = new TextBox();
            lblShow = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(65, 92);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(65, 199);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(65, 302);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            // 
            // txbKm
            // 
            txbKm.Font = new Font("Microsoft JhengHei UI", 24F);
            txbKm.Location = new Point(278, 92);
            txbKm.Name = "txbKm";
            txbKm.Size = new Size(265, 48);
            txbKm.TabIndex = 3;
            // 
            // txbliber
            // 
            txbliber.Font = new Font("Microsoft JhengHei UI", 24F);
            txbliber.Location = new Point(278, 192);
            txbliber.Name = "txbliber";
            txbliber.Size = new Size(265, 48);
            txbliber.TabIndex = 4;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblShow.Location = new Point(295, 302);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(203, 62);
            lblShow.TabIndex = 5;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(104, 389);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(107, 57);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "計算";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(343, 389);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 57);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 542);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(lblShow);
            Controls.Add(txbliber);
            Controls.Add(txbKm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbKm;
        private TextBox txbliber;
        private Label lblShow;
        private Button btnCalculate;
        private Button btnExit;
    }
}
