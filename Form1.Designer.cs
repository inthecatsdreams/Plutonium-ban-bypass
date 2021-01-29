
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newGUID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.weed = new System.Windows.Forms.Label();
            this.computerNameField = new System.Windows.Forms.TextBox();
            this.setComputerName = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.machineGUID);
            this.groupBox1.Controls.Add(this.computerName);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 143);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setComputerName);
            this.groupBox2.Controls.Add(this.computerNameField);
            this.groupBox2.Controls.Add(this.weed);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.newGUID);
            this.groupBox2.Location = new System.Drawing.Point(13, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change values";
            // 
            // newGUID
            // 
            this.newGUID.AutoSize = true;
            this.newGUID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGUID.Location = new System.Drawing.Point(6, 25);
            this.newGUID.Name = "newGUID";
            this.newGUID.Size = new System.Drawing.Size(76, 16);
            this.newGUID.TabIndex = 2;
            this.newGUID.Text = "New GUID: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate and set new GUID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weed
            // 
            this.weed.AutoSize = true;
            this.weed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weed.Location = new System.Drawing.Point(6, 92);
            this.weed.Name = "weed";
            this.weed.Size = new System.Drawing.Size(108, 16);
            this.weed.TabIndex = 4;
            this.weed.Text = "Computer name: ";
            // 
            // computerNameField
            // 
            this.computerNameField.Location = new System.Drawing.Point(10, 111);
            this.computerNameField.Multiline = true;
            this.computerNameField.Name = "computerNameField";
            this.computerNameField.Size = new System.Drawing.Size(160, 23);
            this.computerNameField.TabIndex = 5;
            // 
            // setComputerName
            // 
            this.setComputerName.Location = new System.Drawing.Point(177, 111);
            this.setComputerName.Name = "setComputerName";
            this.setComputerName.Size = new System.Drawing.Size(113, 23);
            this.setComputerName.TabIndex = 6;
            this.setComputerName.Text = "Set new name";
            this.setComputerName.UseVisualStyleBackColor = true;
            this.setComputerName.Click += new System.EventHandler(this.setComputerName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Plutonium ban bypass";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label computerName;
        private System.Windows.Forms.Label machineGUID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button setComputerName;
        private System.Windows.Forms.TextBox computerNameField;
        private System.Windows.Forms.Label weed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label newGUID;
    }
}

