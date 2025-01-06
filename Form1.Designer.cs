namespace TemplateTool
{
    partial class Form1
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
            TemplatePage = new TabPage();
            panel1 = new Panel();
            SelectedTemplateBox = new TextBox();
            label2 = new Label();
            CreateTemplateButton = new Button();
            TemplateList = new ListBox();
            MapPage = new TabPage();
            FilePathDisplay = new Label();
            FilePickerButton = new Button();
            TemplateDisplay = new DataGridView();
            RemoveButton = new Button();
            AddButton = new Button();
            label1 = new Label();
            TemplateNameBox = new TextBox();
            SettingsPage = new TabPage();
            button1 = new Button();
            ExportButton = new Button();
            tabControl1.SuspendLayout();
            TemplatePage.SuspendLayout();
            panel1.SuspendLayout();
            MapPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TemplateDisplay).BeginInit();
            SettingsPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TemplatePage);
            tabControl1.Controls.Add(MapPage);
            tabControl1.Controls.Add(SettingsPage);
            tabControl1.Location = new Point(7, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(448, 327);
            tabControl1.TabIndex = 0;
            // 
            // TemplatePage
            // 
            TemplatePage.Controls.Add(panel1);
            TemplatePage.Controls.Add(TemplateList);
            TemplatePage.Location = new Point(4, 24);
            TemplatePage.Name = "TemplatePage";
            TemplatePage.Padding = new Padding(3);
            TemplatePage.Size = new Size(440, 299);
            TemplatePage.TabIndex = 0;
            TemplatePage.Text = "Templates";
            TemplatePage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(SelectedTemplateBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CreateTemplateButton);
            panel1.Location = new Point(245, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 287);
            panel1.TabIndex = 5;
            // 
            // SelectedTemplateBox
            // 
            SelectedTemplateBox.Enabled = false;
            SelectedTemplateBox.Font = new Font("Segoe UI", 12F);
            SelectedTemplateBox.Location = new Point(3, 52);
            SelectedTemplateBox.Name = "SelectedTemplateBox";
            SelectedTemplateBox.Size = new Size(183, 29);
            SelectedTemplateBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 3;
            label2.Text = "Selected Template";
            // 
            // CreateTemplateButton
            // 
            CreateTemplateButton.BackColor = Color.SpringGreen;
            CreateTemplateButton.Font = new Font("Segoe UI", 12F);
            CreateTemplateButton.ForeColor = Color.Black;
            CreateTemplateButton.Location = new Point(3, 228);
            CreateTemplateButton.Name = "CreateTemplateButton";
            CreateTemplateButton.Size = new Size(183, 56);
            CreateTemplateButton.TabIndex = 1;
            CreateTemplateButton.Text = "Create Template";
            CreateTemplateButton.UseVisualStyleBackColor = false;
            CreateTemplateButton.Click += CreateTemplateButton_Click;
            // 
            // TemplateList
            // 
            TemplateList.Font = new Font("Segoe UI", 10F);
            TemplateList.FormattingEnabled = true;
            TemplateList.ItemHeight = 17;
            TemplateList.Location = new Point(6, 6);
            TemplateList.Name = "TemplateList";
            TemplateList.Size = new Size(233, 276);
            TemplateList.TabIndex = 2;
            TemplateList.SelectedIndexChanged += TemplateList_SelectedIndexChanged;
            // 
            // MapPage
            // 
            MapPage.BackColor = Color.LightSteelBlue;
            MapPage.Controls.Add(FilePathDisplay);
            MapPage.Controls.Add(FilePickerButton);
            MapPage.Controls.Add(TemplateDisplay);
            MapPage.Controls.Add(RemoveButton);
            MapPage.Controls.Add(AddButton);
            MapPage.Controls.Add(label1);
            MapPage.Controls.Add(TemplateNameBox);
            MapPage.Location = new Point(4, 24);
            MapPage.Name = "MapPage";
            MapPage.Padding = new Padding(3);
            MapPage.Size = new Size(440, 299);
            MapPage.TabIndex = 1;
            MapPage.Text = "Mappings";
            MapPage.Click += SettingPage_Click;
            // 
            // FilePathDisplay
            // 
            FilePathDisplay.AutoSize = true;
            FilePathDisplay.Font = new Font("Segoe UI", 10F);
            FilePathDisplay.ForeColor = Color.Black;
            FilePathDisplay.Location = new Point(239, 229);
            FilePathDisplay.Name = "FilePathDisplay";
            FilePathDisplay.Size = new Size(59, 19);
            FilePathDisplay.TabIndex = 8;
            FilePathDisplay.Text = "(No File)";
            // 
            // FilePickerButton
            // 
            FilePickerButton.ForeColor = Color.Black;
            FilePickerButton.Location = new Point(239, 203);
            FilePickerButton.Name = "FilePickerButton";
            FilePickerButton.Size = new Size(198, 23);
            FilePickerButton.TabIndex = 7;
            FilePickerButton.Text = "Pick Template File";
            FilePickerButton.UseVisualStyleBackColor = true;
            FilePickerButton.Click += FilePicker_Click;
            // 
            // TemplateDisplay
            // 
            TemplateDisplay.AllowUserToDeleteRows = false;
            TemplateDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TemplateDisplay.BackgroundColor = Color.DimGray;
            TemplateDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TemplateDisplay.GridColor = Color.Black;
            TemplateDisplay.Location = new Point(6, 6);
            TemplateDisplay.Name = "TemplateDisplay";
            TemplateDisplay.Size = new Size(428, 172);
            TemplateDisplay.TabIndex = 6;
            // 
            // RemoveButton
            // 
            RemoveButton.ForeColor = SystemColors.ActiveCaptionText;
            RemoveButton.Location = new Point(125, 261);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(108, 32);
            RemoveButton.TabIndex = 5;
            RemoveButton.Text = "Remove Path";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.ForeColor = Color.Black;
            AddButton.Location = new Point(6, 261);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(113, 32);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add Entry";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 181);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 3;
            label1.Text = "Template Name";
            // 
            // TemplateNameBox
            // 
            TemplateNameBox.Location = new Point(6, 203);
            TemplateNameBox.Name = "TemplateNameBox";
            TemplateNameBox.Size = new Size(227, 23);
            TemplateNameBox.TabIndex = 1;
            // 
            // SettingsPage
            // 
            SettingsPage.Controls.Add(button1);
            SettingsPage.Controls.Add(ExportButton);
            SettingsPage.Location = new Point(4, 24);
            SettingsPage.Name = "SettingsPage";
            SettingsPage.Size = new Size(440, 299);
            SettingsPage.TabIndex = 2;
            SettingsPage.Text = "Settings";
            SettingsPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(112, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 1;
            button1.Text = "Import Configuration";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExportButton
            // 
            ExportButton.ForeColor = SystemColors.ActiveCaptionText;
            ExportButton.Location = new Point(3, 3);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(103, 28);
            ExportButton.TabIndex = 0;
            ExportButton.Text = "Export Configuation";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(467, 351);
            Controls.Add(tabControl1);
            Cursor = Cursors.IBeam;
            ForeColor = SystemColors.Control;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexiant Template Tool";
            tabControl1.ResumeLayout(false);
            TemplatePage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            MapPage.ResumeLayout(false);
            MapPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TemplateDisplay).EndInit();
            SettingsPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TemplatePage;
        private TabPage MapPage;
        private Label label1;
        private TextBox TemplateNameBox;
        private Button AddButton;
        private Button RemoveButton;
        private DataGridView TemplateDisplay;
        private Button FilePickerButton;
        private Label FilePathDisplay;
        private Button CreateTemplateButton;
        private Panel panel1;
        private Label label2;
        private ListBox TemplateList;
        private TextBox SelectedTemplateBox;
        private TabPage SettingsPage;
        private Button ExportButton;
        private Button button1;
    }
}
