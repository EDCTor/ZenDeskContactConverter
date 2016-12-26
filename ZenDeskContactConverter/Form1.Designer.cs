namespace ZenDeskContactConverter
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
            this.btnGO = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtInputJSON = new System.Windows.Forms.TextBox();
            this.txtOutputCSV = new System.Windows.Forms.TextBox();
            this.txtOutputLog = new System.Windows.Forms.TextBox();
            this.lblInputJSON = new System.Windows.Forms.Label();
            this.lblOutputLog = new System.Windows.Forms.Label();
            this.lblOutputCSV = new System.Windows.Forms.Label();
            this.pbarProgress = new System.Windows.Forms.ProgressBar();
            this.lblErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.Location = new System.Drawing.Point(638, 299);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(136, 68);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "Go";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtInputJSON
            // 
            this.txtInputJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputJSON.Location = new System.Drawing.Point(15, 70);
            this.txtInputJSON.Name = "txtInputJSON";
            this.txtInputJSON.Size = new System.Drawing.Size(759, 22);
            this.txtInputJSON.TabIndex = 1;
            // 
            // txtOutputCSV
            // 
            this.txtOutputCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputCSV.Location = new System.Drawing.Point(12, 128);
            this.txtOutputCSV.Name = "txtOutputCSV";
            this.txtOutputCSV.Size = new System.Drawing.Size(762, 22);
            this.txtOutputCSV.TabIndex = 2;
            // 
            // txtOutputLog
            // 
            this.txtOutputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputLog.Location = new System.Drawing.Point(15, 192);
            this.txtOutputLog.Name = "txtOutputLog";
            this.txtOutputLog.Size = new System.Drawing.Size(759, 22);
            this.txtOutputLog.TabIndex = 3;
            // 
            // lblInputJSON
            // 
            this.lblInputJSON.AutoSize = true;
            this.lblInputJSON.Location = new System.Drawing.Point(12, 50);
            this.lblInputJSON.Name = "lblInputJSON";
            this.lblInputJSON.Size = new System.Drawing.Size(80, 17);
            this.lblInputJSON.TabIndex = 4;
            this.lblInputJSON.Text = "Input JSON";
            // 
            // lblOutputLog
            // 
            this.lblOutputLog.AutoSize = true;
            this.lblOutputLog.Location = new System.Drawing.Point(14, 172);
            this.lblOutputLog.Name = "lblOutputLog";
            this.lblOutputLog.Size = new System.Drawing.Size(79, 17);
            this.lblOutputLog.TabIndex = 5;
            this.lblOutputLog.Text = "Output Log";
            // 
            // lblOutputCSV
            // 
            this.lblOutputCSV.AutoSize = true;
            this.lblOutputCSV.Location = new System.Drawing.Point(12, 108);
            this.lblOutputCSV.Name = "lblOutputCSV";
            this.lblOutputCSV.Size = new System.Drawing.Size(82, 17);
            this.lblOutputCSV.TabIndex = 6;
            this.lblOutputCSV.Text = "Output CSV";
            // 
            // pbarProgress
            // 
            this.pbarProgress.Location = new System.Drawing.Point(17, 247);
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(757, 23);
            this.pbarProgress.TabIndex = 8;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(14, 289);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(63, 17);
            this.lblErrors.TabIndex = 9;
            this.lblErrors.Text = "Errors: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 379);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.pbarProgress);
            this.Controls.Add(this.lblOutputCSV);
            this.Controls.Add(this.lblOutputLog);
            this.Controls.Add(this.lblInputJSON);
            this.Controls.Add(this.txtOutputLog);
            this.Controls.Add(this.txtOutputCSV);
            this.Controls.Add(this.txtInputJSON);
            this.Controls.Add(this.btnGO);
            this.Name = "Form1";
            this.Text = "ZenDesk Contact Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtInputJSON;
        private System.Windows.Forms.TextBox txtOutputCSV;
        private System.Windows.Forms.TextBox txtOutputLog;
        private System.Windows.Forms.Label lblInputJSON;
        private System.Windows.Forms.Label lblOutputLog;
        private System.Windows.Forms.Label lblOutputCSV;
        private System.Windows.Forms.ProgressBar pbarProgress;
        private System.Windows.Forms.Label lblErrors;
    }
}

