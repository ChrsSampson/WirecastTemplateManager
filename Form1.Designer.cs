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
            SelectedTemplate = new Label();
            label2 = new Label();
            CreateTemplateButton = new Button();
            TemplateList = new ListBox();
            SettingPage = new TabPage();
            ImportButton = new Button();
            ExportButton = new Button();
            FilePathDisplay = new Label();
            FilePickerButton = new Button();
            TemplateDisplay = new DataGridView();
            RemoveButton = new Button();
            AddButton = new Button();
            label1 = new Label();
            TemplateNameBox = new TextBox();
            SaveButton = new Button();
            tabControl1.SuspendLayout();
            TemplatePage.SuspendLayout();
            panel1.SuspendLayout();
            SettingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TemplateDisplay).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TemplatePage);
            tabControl1.Controls.Add(SettingPage);
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
            panel1.Controls.Add(SelectedTemplate);
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
            // SelectedTemplate
            // 
            SelectedTemplate.AutoSize = true;
            SelectedTemplate.Font = new Font("Segoe UI", 10F);
            SelectedTemplate.ForeColor = Color.Black;
            SelectedTemplate.Location = new Point(47, 30);
            SelectedTemplate.Name = "SelectedTemplate";
            SelectedTemplate.Size = new Size(94, 19);
            SelectedTemplate.TabIndex = 4;
            SelectedTemplate.Text = "(No Template)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 9);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 3;
            label2.Text = "Selected Template";
            // 
            // CreateTemplateButton
            // 
            CreateTemplateButton.BackColor = Color.FromArgb(128, 128, 255);
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
            TemplateList.FormattingEnabled = true;
            TemplateList.ItemHeight = 15;
            TemplateList.Location = new Point(6, 6);
            TemplateList.Name = "TemplateList";
            TemplateList.Size = new Size(233, 289);
            TemplateList.TabIndex = 2;
            TemplateList.SelectedIndexChanged += TemplateList_SelectedIndexChanged;
            // 
            // SettingPage
            // 
            SettingPage.BackColor = Color.LightSteelBlue;
            SettingPage.Controls.Add(ImportButton);
            SettingPage.Controls.Add(ExportButton);
            SettingPage.Controls.Add(FilePathDisplay);
            SettingPage.Controls.Add(FilePickerButton);
            SettingPage.Controls.Add(TemplateDisplay);
            SettingPage.Controls.Add(RemoveButton);
            SettingPage.Controls.Add(AddButton);
            SettingPage.Controls.Add(label1);
            SettingPage.Controls.Add(TemplateNameBox);
            SettingPage.Controls.Add(SaveButton);
            SettingPage.Location = new Point(4, 24);
            SettingPage.Name = "SettingPage";
            SettingPage.Padding = new Padding(3);
            SettingPage.Size = new Size(440, 299);
            SettingPage.TabIndex = 1;
            SettingPage.Text = "Settings";
            SettingPage.Click += SettingPage_Click;
            // 
            // ImportButton
            // 
            ImportButton.ForeColor = Color.Black;
            ImportButton.Location = new Point(359, 184);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(75, 23);
            ImportButton.TabIndex = 10;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.ForeColor = Color.Black;
            ExportButton.Location = new Point(269, 184);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(75, 23);
            ExportButton.TabIndex = 9;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // FilePathDisplay
            // 
            FilePathDisplay.AutoSize = true;
            FilePathDisplay.Font = new Font("Segoe UI", 10F);
            FilePathDisplay.ForeColor = Color.Black;
            FilePathDisplay.Location = new Point(184, 242);
            FilePathDisplay.Name = "FilePathDisplay";
            FilePathDisplay.Size = new Size(59, 19);
            FilePathDisplay.TabIndex = 8;
            FilePathDisplay.Text = "(No File)";
            // 
            // FilePickerButton
            // 
            FilePickerButton.ForeColor = Color.Black;
            FilePickerButton.Location = new Point(184, 219);
            FilePickerButton.Name = "FilePickerButton";
            FilePickerButton.Size = new Size(160, 23);
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
            RemoveButton.Location = new Point(6, 184);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(131, 23);
            RemoveButton.TabIndex = 5;
            RemoveButton.Text = "Remove Path";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.ForeColor = Color.Black;
            AddButton.Location = new Point(6, 270);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 219);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 3;
            label1.Text = "Template Name";
            // 
            // TemplateNameBox
            // 
            TemplateNameBox.Location = new Point(6, 241);
            TemplateNameBox.Name = "TemplateNameBox";
            TemplateNameBox.Size = new Size(172, 23);
            TemplateNameBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(128, 128, 255);
            SaveButton.FlatAppearance.BorderColor = Color.Gray;
            SaveButton.FlatAppearance.BorderSize = 3;
            SaveButton.ForeColor = SystemColors.ActiveCaptionText;
            SaveButton.Location = new Point(359, 270);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
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
            SettingPage.ResumeLayout(false);
            SettingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TemplateDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TemplatePage;
        private TabPage SettingPage;
        private Button SaveButton;
        private Label label1;
        private TextBox TemplateNameBox;
        private Button AddButton;
        private Button RemoveButton;
        private DataGridView TemplateDisplay;
        private Button FilePickerButton;
        private Label FilePathDisplay;
        private Button CreateTemplateButton;
        private Panel panel1;
        private Label SelectedTemplate;
        private Label label2;
        private ListBox TemplateList;
        private Button ExportButton;
        private TextBox SelectedTemplateBox;
        private Button ImportButton;
    }
}
