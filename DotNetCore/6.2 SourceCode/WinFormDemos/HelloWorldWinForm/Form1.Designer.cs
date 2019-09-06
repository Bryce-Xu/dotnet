namespace HelloWorldWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClick = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(75, 24);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(121, 41);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click Me!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(30, 93);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(213, 19);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "当前时间：2019/8/7 20:24:31";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 164);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblTime;
    }
}

