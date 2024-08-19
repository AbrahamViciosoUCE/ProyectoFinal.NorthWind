namespace NorthWind.Winforms.Modals
{
    partial class CategoryModal
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
            categorybindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            acceptButton = new Button();
            cancelButton = new Button();
            label3 = new Label();
            loadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)categorybindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Category Name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", categorybindingSource, "CategoryName", true));
            textBox1.Location = new Point(12, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 1;
            // 
            // categorybindingSource
            // 
            categorybindingSource.DataSource = typeof(Infrastructure.Category);
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", categorybindingSource, "Description", true));
            textBox2.Location = new Point(12, 108);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 119);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // pictureBox1
            // 
            pictureBox1.DataBindings.Add(new Binding("Image", categorybindingSource, "Picture", true));
            pictureBox1.Location = new Point(43, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(177, 533);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(115, 32);
            acceptButton.TabIndex = 5;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 533);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(115, 32);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 230);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Image";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(43, 478);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(211, 23);
            loadButton.TabIndex = 8;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // CategoryModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 577);
            Controls.Add(loadButton);
            Controls.Add(label3);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CategoryModal";
            Text = "CategoryModal";
            FormClosed += CategoryModal_FormClosed;
            Load += CategoryModal_Load;
            ((System.ComponentModel.ISupportInitialize)categorybindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button acceptButton;
        private Button cancelButton;
        private Label label3;
        private BindingSource categorybindingSource;
        private Button loadButton;
    }
}