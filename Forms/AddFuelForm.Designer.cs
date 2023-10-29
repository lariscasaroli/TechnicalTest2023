namespace TesteTecnico2023.Forms
{

    partial class AddFuelForm
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
            this.btnAddFuel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listFuel = new System.Windows.Forms.ListView();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddFuel
            // 
            this.btnAddFuel.Location = new System.Drawing.Point(36, 157);
            this.btnAddFuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFuel.Name = "btnAddFuel";
            this.btnAddFuel.Size = new System.Drawing.Size(244, 46);
            this.btnAddFuel.TabIndex = 3;
            this.btnAddFuel.Text = "Adicionar Combustivel";
            this.btnAddFuel.UseVisualStyleBackColor = true;
            this.btnAddFuel.Click += new System.EventHandler(this.btnAddFuel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Combustivel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(117, 86);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(86, 26);
            this.txtPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço";
            // 
            // listFuel
            // 
            this.listFuel.HideSelection = false;
            this.listFuel.Location = new System.Drawing.Point(321, 18);
            this.listFuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listFuel.Name = "listFuel";
            this.listFuel.Size = new System.Drawing.Size(362, 332);
            this.listFuel.TabIndex = 5;
            this.listFuel.UseCompatibleStateImageBehavior = false;
            // 
            // cmbFuel
            // 
            this.cmbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(117, 32);
            this.cmbFuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(180, 28);
            this.cmbFuel.TabIndex = 6;
            this.cmbFuel.SelectedIndexChanged += new System.EventHandler(this.cmbFuel_SelectedIndexChanged);
            // 
            // AddFuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 389);
            this.Controls.Add(this.cmbFuel);
            this.Controls.Add(this.listFuel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddFuel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddFuelForm";
            this.Text = "AddFuelForm";
            this.Load += new System.EventHandler(this.AddFuelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listFuel;
        private System.Windows.Forms.ComboBox cmbFuel;
    }
}