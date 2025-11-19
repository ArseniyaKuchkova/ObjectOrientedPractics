using System.Windows.Forms;

namespace OOP_1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            itemsTab = new TabPage();
            itemTab1 = new View.Tabs.ItemsTab();
            customersPage = new TabPage();
            customersTab = new View.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            itemsTab.SuspendLayout();
            customersPage.SuspendLayout();
            SuspendLayout();
            //
            //tabControl1
            //
            tabControl1.Controls.Add(itemsTab);
            tabControl1.Controls.Add(customersPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;

            //
            //itemsTab
            //
            itemsTab.Controls.Add(itemTab1);
            itemsTab.Location = new Point(4, 24);
            itemsTab.Name = "itemsTab";
            itemsTab.Padding = new Padding(3);
            itemsTab.Size = new Size(792, 567);
            itemsTab.TabIndex = 1;
            itemsTab.Text = "Items";
            itemsTab.UseVisualStyleBackColor = true;
            //
            //itemTab1
            //
            itemTab1.Dock=DockStyle.Fill;
            itemTab1.Location = new Point(3, 3);
            itemTab1.Name = "itemTab1"; new Size(792, 567);
            itemTab1.Size = new Size(792, 567);
            itemTab1.TabIndex = 0;
            itemTab1.Load += itemTab1_Load;
            // 
            // customersPage
            // 
            customersPage.Controls.Add(customersTab);
            customersPage.Location = new Point(4, 24);
            customersPage.Name = "customersPage";
            customersPage.Padding = new Padding(3);
            customersPage.Size = new Size(792, 567);
            customersPage.TabIndex = 2;
            customersPage.Text = "Customers";
            customersPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 3);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(786, 561);
            customersTab.TabIndex = 0;

            //
            //MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 595);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout (false);
            itemsTab.ResumeLayout (false);
            customersPage.ResumeLayout(false);
            ResumeLayout (false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage itemsTab;
        private View.Tabs.ItemsTab itemTab1;
        private TabPage customersPage;
        private View.Tabs.CustomersTab customersTab;
    }
}
