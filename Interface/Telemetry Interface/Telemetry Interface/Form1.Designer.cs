namespace Telemetry_Interface
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
            this.Data = new System.Windows.Forms.TabControl();
            this.setupTab = new System.Windows.Forms.TabPage();
            this.connectBtn = new System.Windows.Forms.Button();
            this.baudRateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Data.SuspendLayout();
            this.setupTab.SuspendLayout();
            this.dataTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Controls.Add(this.setupTab);
            this.Data.Controls.Add(this.dataTab);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(0, 0);
            this.Data.Name = "Data";
            this.Data.SelectedIndex = 0;
            this.Data.Size = new System.Drawing.Size(1128, 549);
            this.Data.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Data.TabIndex = 0;
            // 
            // setupTab
            // 
            this.setupTab.Controls.Add(this.connectBtn);
            this.setupTab.Controls.Add(this.baudRateBox);
            this.setupTab.Controls.Add(this.label2);
            this.setupTab.Controls.Add(this.label1);
            this.setupTab.Controls.Add(this.comPortBox);
            this.setupTab.Location = new System.Drawing.Point(4, 22);
            this.setupTab.Name = "setupTab";
            this.setupTab.Padding = new System.Windows.Forms.Padding(3);
            this.setupTab.Size = new System.Drawing.Size(1120, 523);
            this.setupTab.TabIndex = 0;
            this.setupTab.Text = "Setup";
            this.setupTab.UseVisualStyleBackColor = true;
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(52, 79);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // baudRateBox
            // 
            this.baudRateBox.Location = new System.Drawing.Point(82, 39);
            this.baudRateBox.MaxLength = 10;
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(121, 20);
            this.baudRateBox.TabIndex = 3;
            this.baudRateBox.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port -";
            // 
            // comPortBox
            // 
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Location = new System.Drawing.Point(82, 6);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(121, 21);
            this.comPortBox.TabIndex = 0;
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.progressBar1);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(1120, 523);
            this.dataTab.TabIndex = 1;
            this.dataTab.Text = "Live Data";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(120, 75);
            this.progressBar1.Maximum = 6000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(441, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 549);
            this.Controls.Add(this.Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Data.ResumeLayout(false);
            this.setupTab.ResumeLayout(false);
            this.setupTab.PerformLayout();
            this.dataTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Data;
        private System.Windows.Forms.TabPage setupTab;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.TextBox baudRateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectBtn;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}

