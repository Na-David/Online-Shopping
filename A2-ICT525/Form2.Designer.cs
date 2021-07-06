namespace A2_ICT525
{
    partial class Form2
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
            this.ItemListView = new System.Windows.Forms.ListView();
            this.ItemList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumRequiredList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EamilText = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPriceText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PlaceOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemListView
            // 
            this.ItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemList,
            this.NumRequiredList,
            this.TotalPriceList});
            this.ItemListView.HideSelection = false;
            this.ItemListView.Location = new System.Drawing.Point(12, 12);
            this.ItemListView.Name = "ItemListView";
            this.ItemListView.Size = new System.Drawing.Size(900, 489);
            this.ItemListView.TabIndex = 0;
            this.ItemListView.UseCompatibleStateImageBehavior = false;
            this.ItemListView.View = System.Windows.Forms.View.Details;
            this.ItemListView.SelectedIndexChanged += new System.EventHandler(this.ItemListView_SelectedIndexChanged);
            // 
            // ItemList
            // 
            this.ItemList.Text = "Item";
            this.ItemList.Width = 492;
            // 
            // NumRequiredList
            // 
            this.NumRequiredList.Text = "Num Required";
            this.NumRequiredList.Width = 131;
            // 
            // TotalPriceList
            // 
            this.TotalPriceList.Text = "Total Price";
            this.TotalPriceList.Width = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(168, 560);
            this.NameText.Name = "NameText";
            this.NameText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameText.Size = new System.Drawing.Size(18, 20);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email :";
            // 
            // EamilText
            // 
            this.EamilText.AutoSize = true;
            this.EamilText.Location = new System.Drawing.Point(168, 610);
            this.EamilText.Name = "EamilText";
            this.EamilText.Size = new System.Drawing.Size(18, 20);
            this.EamilText.TabIndex = 3;
            this.EamilText.Text = "0";
            // 
            // AddressText
            // 
            this.AddressText.AutoSize = true;
            this.AddressText.Location = new System.Drawing.Point(168, 658);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(18, 20);
            this.AddressText.TabIndex = 6;
            this.AddressText.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address :";
            // 
            // TotalPriceText
            // 
            this.TotalPriceText.AutoSize = true;
            this.TotalPriceText.Location = new System.Drawing.Point(596, 560);
            this.TotalPriceText.Name = "TotalPriceText";
            this.TotalPriceText.Size = new System.Drawing.Size(18, 20);
            this.TotalPriceText.TabIndex = 8;
            this.TotalPriceText.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Price :";
            // 
            // PlaceOrderBtn
            // 
            this.PlaceOrderBtn.Location = new System.Drawing.Point(505, 610);
            this.PlaceOrderBtn.Name = "PlaceOrderBtn";
            this.PlaceOrderBtn.Size = new System.Drawing.Size(165, 99);
            this.PlaceOrderBtn.TabIndex = 9;
            this.PlaceOrderBtn.Text = "Place Order";
            this.PlaceOrderBtn.UseVisualStyleBackColor = true;
            this.PlaceOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 734);
            this.Controls.Add(this.PlaceOrderBtn);
            this.Controls.Add(this.TotalPriceText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EamilText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemListView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ItemListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EamilText;
        private System.Windows.Forms.Label AddressText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalPriceText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PlaceOrderBtn;
        private System.Windows.Forms.ColumnHeader ItemList;
        private System.Windows.Forms.ColumnHeader NumRequiredList;
        private System.Windows.Forms.ColumnHeader TotalPriceList;
    }
}