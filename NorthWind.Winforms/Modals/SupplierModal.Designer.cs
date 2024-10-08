﻿namespace NorthWind.Winforms.Modals
{
    partial class SupplierModal
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
            label1 = new Label();
            textBox1 = new TextBox();
            supplierBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            textBox11 = new TextBox();
            label11 = new Label();
            cancelButton = new Button();
            acceptButton = new Button();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Company Name";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", supplierBindingSource, "CompanyName", true));
            textBox1.Location = new Point(12, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 1;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Infrastructure.Supplier);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", supplierBindingSource, "ContactName", true));
            textBox2.Location = new Point(12, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Contact Name";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", supplierBindingSource, "ContactTitle", true));
            textBox3.Location = new Point(12, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Contact Title";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", supplierBindingSource, "Address", true));
            textBox4.Location = new Point(12, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(313, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 191);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", supplierBindingSource, "City", true));
            textBox5.Location = new Point(12, 262);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(313, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 244);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 8;
            label5.Text = "City";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", supplierBindingSource, "Region", true));
            textBox6.Location = new Point(12, 311);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(313, 23);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 293);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 10;
            label6.Text = "Region";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", supplierBindingSource, "PostalCode", true));
            textBox7.Location = new Point(12, 366);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(313, 23);
            textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 348);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 12;
            label7.Text = "Postal Code";
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", supplierBindingSource, "Country", true));
            textBox8.Location = new Point(12, 421);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(313, 23);
            textBox8.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 403);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 14;
            label8.Text = "Country";
            // 
            // textBox9
            // 
            textBox9.DataBindings.Add(new Binding("Text", supplierBindingSource, "Phone", true));
            textBox9.Location = new Point(12, 478);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(313, 23);
            textBox9.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 460);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 16;
            label9.Text = "Phone";
            // 
            // textBox10
            // 
            textBox10.DataBindings.Add(new Binding("Text", supplierBindingSource, "Fax", true));
            textBox10.Location = new Point(12, 535);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(313, 23);
            textBox10.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 517);
            label10.Name = "label10";
            label10.Size = new Size(25, 15);
            label10.TabIndex = 18;
            label10.Text = "Fax";
            // 
            // textBox11
            // 
            textBox11.DataBindings.Add(new Binding("Text", supplierBindingSource, "HomePage", true));
            textBox11.Location = new Point(12, 586);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(313, 23);
            textBox11.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 568);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 20;
            label11.Text = "Home Page";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(11, 634);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(95, 30);
            cancelButton.TabIndex = 24;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(230, 634);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(95, 30);
            acceptButton.TabIndex = 25;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // SupplierModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 676);
            Controls.Add(acceptButton);
            Controls.Add(cancelButton);
            Controls.Add(textBox11);
            Controls.Add(label11);
            Controls.Add(textBox10);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "SupplierModal";
            Text = "SupplierModal";
            FormClosed += SupplierModal_FormClosed;
            Load += SupplierModal_Load;
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox11;
        private Label label11;
        private Button cancelButton;
        private Button acceptButton;
        private BindingSource supplierBindingSource;
    }
}