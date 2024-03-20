namespace SomerenUI
{
    partial class DrinkUpdateForm
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
            txtVat = new System.Windows.Forms.TextBox();
            txtStock = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtVat
            // 
            txtVat.Location = new System.Drawing.Point(505, 299);
            txtVat.Name = "txtVat";
            txtVat.Size = new System.Drawing.Size(200, 39);
            txtVat.TabIndex = 21;
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(505, 220);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(200, 39);
            txtStock.TabIndex = 20;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(505, 139);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(200, 39);
            txtPrice.TabIndex = 19;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(505, 58);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(200, 39);
            txtName.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(64, 302);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(252, 32);
            label5.TabIndex = 17;
            label5.Text = "Enter a new drink VAT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(64, 223);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(267, 32);
            label4.TabIndex = 16;
            label4.Text = "Enter a new drink stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(64, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(264, 32);
            label3.TabIndex = 15;
            label3.Text = "Enter a new drink price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(64, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(272, 32);
            label2.TabIndex = 14;
            label2.Text = "Enter a new drink name:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(289, 382);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(199, 77);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update a drink";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateDrink
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 523);
            Controls.Add(txtVat);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Name = "UpdateDrink";
            Text = "UpdateDrink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
    }
}