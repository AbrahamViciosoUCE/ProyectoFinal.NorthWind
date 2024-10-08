﻿namespace NorthWind.Winforms
{
    partial class MainForm
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
            mainPanel = new Panel();
            productToolStripMenuItem = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 24);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 426);
            mainPanel.TabIndex = 1;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            productToolStripMenuItem.Size = new Size(61, 20);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem, categoryToolStripMenuItem, supplierToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            categoryToolStripMenuItem.Size = new Size(67, 20);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            supplierToolStripMenuItem.Size = new Size(62, 20);
            supplierToolStripMenuItem.Text = "Supplier";
            supplierToolStripMenuItem.Click += supplierToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel mainPanel;
        private ToolStripMenuItem productToolStripMenuItem;
        private MenuStrip menuStrip;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
    }
}