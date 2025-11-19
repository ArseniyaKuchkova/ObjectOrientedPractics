namespace OOP_1.View.Tabs
{
    partial class ItemsTab
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
            itemsLabel = new Label();
            itemsListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            selectedLabel = new Label();
            idLabel = new Label();
            costLabel = new Label();
            nameLabel = new Label();
            infoLabel = new Label();
            idTextBox = new TextBox();
            costTextBox = new TextBox();
            nameTextBox = new TextBox();
            infoTextBox = new TextBox();
            refactorButton = new Button();
            SuspendLayout();
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            itemsLabel.Location = new Point(0, 0);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(39, 15);
            itemsLabel.TabIndex = 0;
            itemsLabel.Text = "Items";
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(0, 18);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(351, 484);
            itemsListBox.TabIndex = 1;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 508);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(91, 42);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(100, 508);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(91, 42);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // selectedLabel
            // 
            selectedLabel.AutoSize = true;
            selectedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedLabel.Location = new Point(357, 0);
            selectedLabel.Name = "selectedLabel";
            selectedLabel.Size = new Size(86, 15);
            selectedLabel.TabIndex = 4;
            selectedLabel.Text = "Selected Item";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(357, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 5;
            idLabel.Text = "ID:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(357, 62);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(34, 15);
            costLabel.TabIndex = 6;
            costLabel.Text = "Cost:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(357, 93);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(357, 215);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(31, 15);
            infoLabel.TabIndex = 8;
            infoLabel.Text = "Info:";
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            idTextBox.Location = new Point(394, 28);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(122, 23);
            idTextBox.TabIndex = 9;
            // 
            // costTextBox
            // 
            costTextBox.BackColor = SystemColors.Control;
            costTextBox.BorderStyle = BorderStyle.FixedSingle;
            costTextBox.Location = new Point(394, 62);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(122, 23);
            costTextBox.TabIndex = 10;
            costTextBox.TextChanged += costTextBox_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.Control;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(357, 111);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(518, 101);
            nameTextBox.TabIndex = 11;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // infoTextBox
            // 
            infoTextBox.BackColor = SystemColors.Control;
            infoTextBox.BorderStyle = BorderStyle.FixedSingle;
            infoTextBox.Location = new Point(357, 233);
            infoTextBox.Multiline = true;
            infoTextBox.Name = "infoTextBox";
            infoTextBox.Size = new Size(518, 181);
            infoTextBox.TabIndex = 12;
            infoTextBox.TextChanged += infoTextBox_TextChanged;
            // 
            // refactorButton
            // 
            refactorButton.Location = new Point(197, 508);
            refactorButton.Name = "refactorButton";
            refactorButton.Size = new Size(91, 42);
            refactorButton.TabIndex = 13;
            refactorButton.Text = "Refactor";
            refactorButton.UseVisualStyleBackColor = true;
            refactorButton.Click += refactorButton_Click;
            // 
            // ItemTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(refactorButton);
            Controls.Add(infoTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(costTextBox);
            Controls.Add(idTextBox);
            Controls.Add(infoLabel);
            Controls.Add(nameLabel);
            Controls.Add(costLabel);
            Controls.Add(idLabel);
            Controls.Add(selectedLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(itemsListBox);
            Controls.Add(itemsLabel);
            Name = "ItemTab";
            Size = new Size(897, 553);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemsLabel;
        private ListBox itemsListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Label selectedLabel;
        private Label idLabel;
        private Label costLabel;
        private Label nameLabel;
        private Label infoLabel;
        private TextBox idTextBox;
        private TextBox costTextBox;
        private TextBox nameTextBox;
        private TextBox infoTextBox;
        private Button refactorButton;
    }
}
     
