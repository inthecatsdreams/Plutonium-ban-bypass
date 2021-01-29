
namespace Plutonium_ban_bypass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.computerName = new System.Windows.Forms.Label();
            this.machineGUID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.machineGUID);
            this.groupBox1.Controls.Add(this.computerName);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current values";
            // 
            // computerName
            // 
            this.computerName.AutoSize = true;
            this.computerName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerName.Location = new System.Drawing.Point(7, 20);
            this.computerName.Name = "computerName";
            this.computerName.Size = new System.Drawing.Size(108, 16);
            this.computerName.TabIndex = 0;
            this.computerName.Text = "Computer name: ";
            // 
            // machineGUID
            // 
            this.machineGUID.AutoSize = true;
            this.machineGUID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineGUID.Location = new System.Drawing.Point(7, 59);
            this.machineGUID.Name = "machineGUID";
            this.machineGUID.Size = new System.Drawing.Size(100, 16);
            this.machineGUID.TabIndex = 1;
            this.machineGUID.Text = "Machine GUID: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 468);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Plutonium ban bypass";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label computerName;
        private System.Windows.Forms.Label machineGUID;
    }
}

