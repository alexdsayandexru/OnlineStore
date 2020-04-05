namespace OnlineStore
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.productPage = new System.Windows.Forms.TabPage();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.paymentPage = new System.Windows.Forms.TabPage();
            this.analyticPage = new System.Windows.Forms.TabPage();
            this.productPage1 = new OnlineStore.Pages.ProductPage();
            this.tabControl1.SuspendLayout();
            this.productPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.productPage);
            this.tabControl1.Controls.Add(this.orderPage);
            this.tabControl1.Controls.Add(this.paymentPage);
            this.tabControl1.Controls.Add(this.analyticPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // productPage
            // 
            this.productPage.Controls.Add(this.productPage1);
            this.productPage.Location = new System.Drawing.Point(4, 22);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPage.Size = new System.Drawing.Size(792, 424);
            this.productPage.TabIndex = 0;
            this.productPage.Text = "Product";
            this.productPage.UseVisualStyleBackColor = true;
            // 
            // orderPage
            // 
            this.orderPage.Location = new System.Drawing.Point(4, 22);
            this.orderPage.Name = "orderPage";
            this.orderPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderPage.Size = new System.Drawing.Size(722, 379);
            this.orderPage.TabIndex = 1;
            this.orderPage.Text = "Order";
            this.orderPage.UseVisualStyleBackColor = true;
            // 
            // paymentPage
            // 
            this.paymentPage.Location = new System.Drawing.Point(4, 22);
            this.paymentPage.Name = "paymentPage";
            this.paymentPage.Size = new System.Drawing.Size(722, 379);
            this.paymentPage.TabIndex = 2;
            this.paymentPage.Text = "Payment";
            this.paymentPage.UseVisualStyleBackColor = true;
            // 
            // analyticPage
            // 
            this.analyticPage.Location = new System.Drawing.Point(4, 22);
            this.analyticPage.Name = "analyticPage";
            this.analyticPage.Size = new System.Drawing.Size(722, 379);
            this.analyticPage.TabIndex = 3;
            this.analyticPage.Text = "Analytic";
            this.analyticPage.UseVisualStyleBackColor = true;
            // 
            // productPage1
            // 
            this.productPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPage1.Location = new System.Drawing.Point(3, 3);
            this.productPage1.Name = "productPage1";
            this.productPage1.Size = new System.Drawing.Size(786, 418);
            this.productPage1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Online store";
            this.tabControl1.ResumeLayout(false);
            this.productPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.TabPage orderPage;
        private System.Windows.Forms.TabPage paymentPage;
        private System.Windows.Forms.TabPage analyticPage;
        private Pages.ProductPage productPage1;
    }
}

