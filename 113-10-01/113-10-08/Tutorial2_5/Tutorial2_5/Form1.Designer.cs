﻿namespace Tutorial2_5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ptxback = new System.Windows.Forms.PictureBox();
            this.ptxfront = new System.Windows.Forms.PictureBox();
            this.btnshowback = new System.Windows.Forms.Button();
            this.btnshowfront = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptxback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxfront)).BeginInit();
            this.SuspendLayout();
            // 
            // ptxback
            // 
            this.ptxback.Image = global::Tutorial2_5.Properties.Resources.Backface_Blue;
            this.ptxback.Location = new System.Drawing.Point(84, 40);
            this.ptxback.Name = "ptxback";
            this.ptxback.Size = new System.Drawing.Size(174, 217);
            this.ptxback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxback.TabIndex = 1;
            this.ptxback.TabStop = false;
            this.ptxback.Visible = false;
            // 
            // ptxfront
            // 
            this.ptxfront.Image = global::Tutorial2_5.Properties.Resources.Ace_Spades;
            this.ptxfront.Location = new System.Drawing.Point(297, 40);
            this.ptxfront.Name = "ptxfront";
            this.ptxfront.Size = new System.Drawing.Size(174, 217);
            this.ptxfront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxfront.TabIndex = 0;
            this.ptxfront.TabStop = false;
            this.ptxfront.Visible = false;
            // 
            // btnshowback
            // 
            this.btnshowback.Location = new System.Drawing.Point(94, 291);
            this.btnshowback.Name = "btnshowback";
            this.btnshowback.Size = new System.Drawing.Size(147, 55);
            this.btnshowback.TabIndex = 2;
            this.btnshowback.Text = "背面";
            this.btnshowback.UseVisualStyleBackColor = true;
            this.btnshowback.Click += new System.EventHandler(this.btnshowback_Click);
            // 
            // btnshowfront
            // 
            this.btnshowfront.Location = new System.Drawing.Point(307, 291);
            this.btnshowfront.Name = "btnshowfront";
            this.btnshowfront.Size = new System.Drawing.Size(164, 55);
            this.btnshowfront.TabIndex = 3;
            this.btnshowfront.Text = "正面";
            this.btnshowfront.UseVisualStyleBackColor = true;
            this.btnshowfront.Click += new System.EventHandler(this.btnshowfront_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(94, 381);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(377, 75);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "離開";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 468);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnshowfront);
            this.Controls.Add(this.btnshowback);
            this.Controls.Add(this.ptxback);
            this.Controls.Add(this.ptxfront);
            this.Name = "Form1";
            this.Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)(this.ptxback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxfront)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptxfront;
        private System.Windows.Forms.PictureBox ptxback;
        private System.Windows.Forms.Button btnshowback;
        private System.Windows.Forms.Button btnshowfront;
        private System.Windows.Forms.Button btnexit;
    }
}

