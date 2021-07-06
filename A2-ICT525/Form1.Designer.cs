namespace A2_ICT525
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
            this.CustomerGroupbox = new System.Windows.Forms.GroupBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemGroupbox = new System.Windows.Forms.GroupBox();
            this.ViewCartBtn = new System.Windows.Forms.Button();
            this.AddtoCartBtn = new System.Windows.Forms.Button();
            this.ItemNeededNum = new System.Windows.Forms.NumericUpDown();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.ItemPriceText = new System.Windows.Forms.Label();
            this.ItemsLeftText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerGroupbox.SuspendLayout();
            this.ItemGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNeededNum)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGroupbox
            // 
            this.CustomerGroupbox.Controls.Add(this.CreateBtn);
            this.CustomerGroupbox.Controls.Add(this.AddressText);
            this.CustomerGroupbox.Controls.Add(this.label3);
            this.CustomerGroupbox.Controls.Add(this.EmailText);
            this.CustomerGroupbox.Controls.Add(this.label2);
            this.CustomerGroupbox.Controls.Add(this.NameText);
            this.CustomerGroupbox.Controls.Add(this.label1);
            this.CustomerGroupbox.Location = new System.Drawing.Point(13, 13);
            this.CustomerGroupbox.Name = "CustomerGroupbox";
            this.CustomerGroupbox.Size = new System.Drawing.Size(980, 152);
            this.CustomerGroupbox.TabIndex = 0;
            this.CustomerGroupbox.TabStop = false;
            this.CustomerGroupbox.Text = "Customer Details";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(833, 47);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(132, 79);
            this.CreateBtn.TabIndex = 6;
            this.CreateBtn.Text = "Create Order";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(471, 22);
            this.AddressText.Multiline = true;
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(342, 104);
            this.AddressText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address :";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(106, 106);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(249, 26);
            this.EmailText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(106, 47);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(249, 26);
            this.NameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // ItemGroupbox
            // 
            this.ItemGroupbox.Controls.Add(this.ViewCartBtn);
            this.ItemGroupbox.Controls.Add(this.AddtoCartBtn);
            this.ItemGroupbox.Controls.Add(this.ItemNeededNum);
            this.ItemGroupbox.Controls.Add(this.ItemComboBox);
            this.ItemGroupbox.Controls.Add(this.ItemPriceText);
            this.ItemGroupbox.Controls.Add(this.ItemsLeftText);
            this.ItemGroupbox.Controls.Add(this.label7);
            this.ItemGroupbox.Controls.Add(this.label6);
            this.ItemGroupbox.Controls.Add(this.label5);
            this.ItemGroupbox.Controls.Add(this.label4);
            this.ItemGroupbox.Location = new System.Drawing.Point(13, 193);
            this.ItemGroupbox.Name = "ItemGroupbox";
            this.ItemGroupbox.Size = new System.Drawing.Size(974, 423);
            this.ItemGroupbox.TabIndex = 1;
            this.ItemGroupbox.TabStop = false;
            this.ItemGroupbox.Text = "Item List";
            // 
            // ViewCartBtn
            // 
            this.ViewCartBtn.Location = new System.Drawing.Point(762, 366);
            this.ViewCartBtn.Name = "ViewCartBtn";
            this.ViewCartBtn.Size = new System.Drawing.Size(140, 42);
            this.ViewCartBtn.TabIndex = 9;
            this.ViewCartBtn.Text = "View Cart";
            this.ViewCartBtn.UseVisualStyleBackColor = true;
            this.ViewCartBtn.Click += new System.EventHandler(this.ViewCartBtn_Click);
            // 
            // AddtoCartBtn
            // 
            this.AddtoCartBtn.Location = new System.Drawing.Point(566, 366);
            this.AddtoCartBtn.Name = "AddtoCartBtn";
            this.AddtoCartBtn.Size = new System.Drawing.Size(144, 42);
            this.AddtoCartBtn.TabIndex = 8;
            this.AddtoCartBtn.Text = "Add to Cart";
            this.AddtoCartBtn.UseVisualStyleBackColor = true;
            this.AddtoCartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ItemNeededNum
            // 
            this.ItemNeededNum.Location = new System.Drawing.Point(471, 281);
            this.ItemNeededNum.Name = "ItemNeededNum";
            this.ItemNeededNum.Size = new System.Drawing.Size(323, 26);
            this.ItemNeededNum.TabIndex = 7;
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(471, 84);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(323, 28);
            this.ItemComboBox.TabIndex = 6;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // ItemPriceText
            // 
            this.ItemPriceText.AutoSize = true;
            this.ItemPriceText.Location = new System.Drawing.Point(473, 157);
            this.ItemPriceText.Name = "ItemPriceText";
            this.ItemPriceText.Size = new System.Drawing.Size(40, 20);
            this.ItemPriceText.TabIndex = 5;
            this.ItemPriceText.Text = "$0.0";
            // 
            // ItemsLeftText
            // 
            this.ItemsLeftText.AutoSize = true;
            this.ItemsLeftText.Location = new System.Drawing.Point(473, 215);
            this.ItemsLeftText.Name = "ItemsLeftText";
            this.ItemsLeftText.Size = new System.Drawing.Size(18, 20);
            this.ItemsLeftText.TabIndex = 4;
            this.ItemsLeftText.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "No of items needed :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Items Left :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Item Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Item :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 641);
            this.Controls.Add(this.ItemGroupbox);
            this.Controls.Add(this.CustomerGroupbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CustomerGroupbox.ResumeLayout(false);
            this.CustomerGroupbox.PerformLayout();
            this.ItemGroupbox.ResumeLayout(false);
            this.ItemGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNeededNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerGroupbox;
        private System.Windows.Forms.Button CreateBtn;
        public System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ItemGroupbox;
        private System.Windows.Forms.Button ViewCartBtn;
        private System.Windows.Forms.Button AddtoCartBtn;
        private System.Windows.Forms.NumericUpDown ItemNeededNum;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.Label ItemPriceText;
        private System.Windows.Forms.Label ItemsLeftText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

