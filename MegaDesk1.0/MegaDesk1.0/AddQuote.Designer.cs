namespace MegaDesk1._0
{
    partial class AddQuote
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.daysComboBox = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.widthNum = new System.Windows.Forms.TextBox();
            this.depthNum = new System.Windows.Forms.TextBox();
            this.drawersNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(64, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(149, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(20, 79);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(113, 13);
            this.depthLabel.TabIndex = 2;
            this.depthLabel.Text = "Desk Depth: (12\"-48\")";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(20, 106);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(112, 13);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Desk Width: (24\"-96\")";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desk Details";
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.Location = new System.Drawing.Point(20, 131);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(125, 13);
            this.drawLabel.TabIndex = 7;
            this.drawLabel.Text = "Number of Drawers: (0-7)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Material:";
            // 
            // materialComboBox
            // 
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(73, 155);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(140, 21);
            this.materialComboBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Days: (Default 14 days)";
            // 
            // daysComboBox
            // 
            this.daysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daysComboBox.FormattingEnabled = true;
            this.daysComboBox.Location = new System.Drawing.Point(143, 182);
            this.daysComboBox.Name = "daysComboBox";
            this.daysComboBox.Size = new System.Drawing.Size(70, 21);
            this.daysComboBox.TabIndex = 5;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(23, 234);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(190, 51);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create Quote";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(20, 297);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 13;
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(158, 103);
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(55, 20);
            this.widthNum.TabIndex = 2;
            this.widthNum.TextChanged += new System.EventHandler(this.widthNum_TextChanged);
            this.widthNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // depthNum
            // 
            this.depthNum.Location = new System.Drawing.Point(158, 79);
            this.depthNum.Name = "depthNum";
            this.depthNum.Size = new System.Drawing.Size(55, 20);
            this.depthNum.TabIndex = 1;
            this.depthNum.TextChanged += new System.EventHandler(this.depthNum_TextChanged);
            this.depthNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // drawersNum
            // 
            this.drawersNum.Location = new System.Drawing.Point(158, 128);
            this.drawersNum.Name = "drawersNum";
            this.drawersNum.Size = new System.Drawing.Size(55, 20);
            this.drawersNum.TabIndex = 3;
            this.drawersNum.TextChanged += new System.EventHandler(this.drawersNum_TextChanged);
            this.drawersNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Less then 14 is a rush charge.";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drawersNum);
            this.Controls.Add(this.depthNum);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.daysComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drawLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label drawLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox daysComboBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox widthNum;
        private System.Windows.Forms.TextBox depthNum;
        private System.Windows.Forms.TextBox drawersNum;
        private System.Windows.Forms.Label label2;
    }
}