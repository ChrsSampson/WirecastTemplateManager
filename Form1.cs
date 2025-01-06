using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net.Security;
using System.Xml.Linq;

namespace TemplateTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load_table();
            load_existing_config();
            // TODO: REMOVE LATER;
            //load_test_data();
        }

        String DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //working memory
        DataTable AppData = new DataTable();

        // Init Data table
        private void load_table()
        {
            //----------Loads the Template Tab---------------
            foreach (var item in AppData.Rows)
            {
                var name = item.GetType();
                Debug.WriteLine(item.ToString());
                //TemplateList.Items.Add(name);   
            }

            //----------Loads The Settings Table-------------
            AppData.TableName = "Conexiant Template DataTable";
            AppData.Columns.Add("Template Name");
            AppData.Columns.Add("Path");

            TemplateDisplay.DataSource = AppData;

            // sets better contrast for data table
            TemplateDisplay.ForeColor = Color.Black;
            TemplateDisplay.BackgroundColor = Color.White;
        }

        private void load_test_data()
        {
            int entries = 3;
            for (var i = 0; i < entries; i++)
            {
                DataRow newRow = AppData.NewRow();

                newRow["Template Name"] = "This is a test" + i + ".jpg";
                newRow["Path"] = "C:\\Users\\sampson.chris\\OneDrive - BroadcastMed, Inc\\Pictures\\FrozenLake.jpg";

                AppData.Rows.Add(newRow);

                TemplateNameBox.Text = "";
            }
            Update_TemplateList();
        }

        // Updates the displayed values in the list of templates
        private void Update_TemplateList()
        {
            TemplateList.Items.Clear();

            //----------Loads the Template Tab---------------
            foreach (DataRow row in AppData.Rows)
            {
                String name = row["Template Name"].ToString();
                TemplateList.Items.Add(name);
            }
        }

        // Read config from save file
        private void load_existing_config()
        {
            try
            {
                if (File.Exists("Config.xml"))
                {
                    var config = AppData.ReadXml("Config.xml");
                    Debug.WriteLine(config.GetType());
                    Update_TemplateList();
                }
            }
            catch (Exception err)
            {
                throw_error(err);
            }
        }

        private void write_config_file()
        {
            try
            {
                AppData.WriteXml("Config.xml");
            }
            catch (Exception err)
            {
                throw_error(err);
            }
        }

        private void SettingPage_Click(object sender, EventArgs e)
        {

        }

        //Create a new Copy of the Template file and move it to the desktop
        private void Create_New_Template()
        {
            try
            {
                String name = SelectedTemplateBox.Text;

                DataRow selectedRow = null;

                foreach (DataRow row in AppData.Rows)
                {
                    String rowNameValue = row["Template Name"].ToString();
                    if (rowNameValue != null && rowNameValue == name)
                    {
                        selectedRow = row;
                        break;
                    }
                }

                String file_path = selectedRow["Path"].ToString();
                bool fileExists = File.Exists(file_path);

                Debug.WriteLine(DesktopPath);

                if (selectedRow != null && fileExists)
                {
                    File.Copy(selectedRow["Path"].ToString(), DesktopPath + "\\" + name + ".wcst");
                    show_alert("Template Created, Check the desktop for a file called:" + " " + name + " " + ".wcst");
                }

            }
            catch (Exception err)
            {
                throw_error(err);
            }
        }

        //Add a New Template path to the DataTable
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                String path = TemplateNameBox.Text;

                // do nothing if there is no path
                if (path == null)
                {
                    Exception err = new Exception("Template Path cannot be empty.");
                    throw_error(err);
                    return;
                }

                if (FilePathDisplay.Text == "(No File)" || FilePathDisplay == null)
                {
                    Exception err = new Exception("File path Cannot be empty.");
                    throw_error(err);
                    return;
                }

                DataRow newRow = AppData.NewRow();

                newRow["Template Name"] = path;
                newRow["Path"] = FilePathDisplay.Text;

                AppData.Rows.Add(newRow);

                TemplateNameBox.Text = "";
            }
            catch (Exception err)
            {
                throw_error(err);
            }

        }

        // Write out settings to XML file
        private void SaveButton_Click(Object sender, EventArgs e)
        {
            write_config_file();
            Update_TemplateList();
        }

        //Copy and Export Config file to chosen directory
        private void Export_Settings()
        {
            try
            {

                OpenFileDialog dialog_box = new OpenFileDialog();


                if (dialog_box.ShowDialog() == DialogResult.OK)
                {
                    var pickedFile = dialog_box.FileName;

                    //Read config file
                    if (File.Exists("Config.xml"))
                    {
                        var config = AppData.ReadXml("Config.xml");

                        AppData.WriteXml(pickedFile + ".xml");
                    }
                }
                
            } catch(Exception err)
            {
                throw_error(err);
            }
        }

        private void Import_Settings()
        {
            Exception err = new Exception("TODO");
            throw_error(err);
        }


        private void TemplateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String v = TemplateList.GetItemText(TemplateList.SelectedItem).ToString();
      
                SelectedTemplateBox.Text = v;

            }
            catch (Exception err)
            {
                throw_error(err);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rowIndex = TemplateDisplay.CurrentRow.Index;

                AppData.Rows[rowIndex].Delete();
            }
            catch (Exception err)
            {
                throw_error(err);
            }
        }

        // show file picker dialog and set the text text of the button to the path of the file chosen
        private void FilePicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog_box = new OpenFileDialog();


            if (dialog_box.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var pickedFile = dialog_box.FileName;
                    var file_ok = dialog_box.CheckFileExists;
                    FilePathDisplay.Text = pickedFile;
                    Debug.WriteLine(pickedFile);
                }
                catch (Exception err)
                {
                    throw_error(err);
                }
            }
        }

        private void throw_error(Exception err)
        {
            Console.WriteLine(err.ToString());
            System.Windows.Forms.MessageBox.Show("There was an error:" + " " + err.Message);
        }

        private void show_alert(String msg)
        {
            System.Windows.Forms.MessageBox.Show(msg);
        }

        private void CreateTemplateButton_Click(object sender, EventArgs e)
        {
            Create_New_Template();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Export_Settings();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            Import_Settings();
        }
    }
}
