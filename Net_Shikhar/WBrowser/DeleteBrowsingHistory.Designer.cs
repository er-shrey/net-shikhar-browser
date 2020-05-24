namespace WBrowser
{
    partial class DeleteBrowsingHistory
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
            this.TempFiles = new System.Windows.Forms.CheckBox();
            this.History = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TempFiles
            // 
            this.TempFiles.AutoSize = true;
            this.TempFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempFiles.Location = new System.Drawing.Point(15, 19);
            this.TempFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TempFiles.Name = "TempFiles";
            this.TempFiles.Size = new System.Drawing.Size(155, 28);
            this.TempFiles.TabIndex = 0;
            this.TempFiles.Text = "अस्थाई ब्राउज़र फाइलें";
            this.TempFiles.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.Location = new System.Drawing.Point(15, 123);
            this.History.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(72, 28);
            this.History.TabIndex = 1;
            this.History.Text = "इतिहास";
            this.History.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "आप के द्वारा निरीक्षित की गए वेबपेजों की सूचि";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "वेबपेज की छवियों की प्रतियां, जो तेजी से";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "देखने के लिए सहेजे जाती हैं";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(100, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "हटाईये";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(195, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "रद्द करें";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DeleteBrowsingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.History);
            this.Controls.Add(this.TempFiles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DeleteBrowsingHistory";
            this.Text = "ब्राउज़िंग इतिहास हटाएँ:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckBox TempFiles;
        public System.Windows.Forms.CheckBox History;
    }
}