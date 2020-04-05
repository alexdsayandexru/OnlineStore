namespace OnlineStore.Pages
{
    partial class ProductPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.measureComboBox = new System.Windows.Forms.ComboBox();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(91, 14);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(154, 21);
            this.categoryComboBox.TabIndex = 1;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(21, 17);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Enabled = false;
            this.addCategoryButton.Location = new System.Drawing.Point(251, 13);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(38, 23);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "...";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(21, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(21, 69);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(91, 67);
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(79, 20);
            this.priceNumericUpDown.TabIndex = 6;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(21, 95);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(91, 93);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(79, 20);
            this.quantityNumericUpDown.TabIndex = 9;
            // 
            // measureComboBox
            // 
            this.measureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measureComboBox.FormattingEnabled = true;
            this.measureComboBox.Location = new System.Drawing.Point(176, 92);
            this.measureComboBox.Name = "measureComboBox";
            this.measureComboBox.Size = new System.Drawing.Size(69, 21);
            this.measureComboBox.TabIndex = 10;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(170, 132);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 11;
            this.acceptButton.Text = "Accept product";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.measureComboBox);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "ProductPage";
            this.Size = new System.Drawing.Size(679, 436);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.ComboBox measureComboBox;
        private System.Windows.Forms.Button acceptButton;
    }
}
