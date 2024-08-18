namespace NorthWind.Winforms.Modals
{
    partial class ProductModal
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
            components = new System.ComponentModel.Container();
            productBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            supplierComboBox = new ComboBox();
            categoryComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            checkBox1 = new CheckBox();
            acceptButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Application.ViewModels.ProductViewModel);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", productBindingSource, "ProductName", true));
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Supplier";
            // 
            // supplierComboBox
            // 
            supplierComboBox.DataBindings.Add(new Binding("SelectedValue", productBindingSource, "SupplierId", true));
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(12, 80);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(292, 23);
            supplierComboBox.TabIndex = 3;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DataBindings.Add(new Binding("SelectedValue", productBindingSource, "CategoryId", true));
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 132);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(292, 23);
            categoryComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Quantity Per Unity";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", productBindingSource, "QuantityPerUnit", true));
            textBox2.Location = new Point(12, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 23);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Unit Price";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", productBindingSource, "UnitPrice", true));
            textBox3.Location = new Point(12, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 23);
            textBox3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 272);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 11;
            label6.Text = "Units In Stock";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", productBindingSource, "UnitsInStock", true));
            textBox4.Location = new Point(12, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 23);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 324);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 13;
            label7.Text = "Units On Order";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", productBindingSource, "UnitsOnOrder", true));
            textBox5.Location = new Point(12, 342);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(292, 23);
            textBox5.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 374);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 15;
            label8.Text = "Reorder Level";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", productBindingSource, "ReorderLevel", true));
            textBox6.Location = new Point(12, 392);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(292, 23);
            textBox6.TabIndex = 14;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("CheckState", productBindingSource, "Discontinued", true));
            checkBox1.Location = new Point(110, 435);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Discontinued";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(193, 583);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(111, 32);
            acceptButton.TabIndex = 19;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 583);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(111, 32);
            cancelButton.TabIndex = 20;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ProductModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 627);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(categoryComboBox);
            Controls.Add(label3);
            Controls.Add(supplierComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ProductModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductModal";
            FormClosed += ProductModal_FormClosed;
            Load += ProductModal_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource productBindingSource;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox supplierComboBox;
        private ComboBox categoryComboBox;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private CheckBox checkBox1;
        private Button acceptButton;
        private Button cancelButton;
    }
}