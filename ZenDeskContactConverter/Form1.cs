using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;

namespace ZenDeskContactConverter
{
    public partial class Form1 : Form
    {
        private int refreshing = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // intialize file locations

            txtInputJSON.Text = Application.StartupPath + "\\input\\input.json";
            txtOutputCSV.Text = Application.StartupPath + "\\output\\output.csv";
            txtOutputLog.Text = Application.StartupPath + "\\output\\conversion.log";

        }


        private void btnGO_Click(object sender, EventArgs e)
        {
            int errors = 0;

            // prevent double clicks of the button
            if (refreshing != 0) { return; }

            refreshing++;
            try
            {
                // initialize the progressbar
                pbarProgress.Minimum = 0;
                pbarProgress.Maximum = 100;
                pbarProgress.Value = 0;

                // ensure the file exists and other checks
                if (!PreconditionsCheck())
                {
                    return;
                }

                // initialize the progressbar bounds
                pbarProgress.Minimum = 1;
                pbarProgress.Maximum = LinesInAFile(txtInputJSON.Text) + 1;

                //
                // read the file line by line and convert to CSV
                //
                using (StreamReader reader = File.OpenText(txtInputJSON.Text))
                {
                    
                    string l = string.Empty;

                    while ((l = reader.ReadLine()) != null)
                    {
                        // update the GUI
                        pbarProgress.Value = pbarProgress.Value + 1;

                        try
                        {

                            // convert the JSON string using external library
                            dynamic json = JsonConvert.DeserializeObject(l);

                            string name = json.name;
                            string email = json.email;
                            string external_id = json.external_id;
                            string details = json.details;
                            string notes = json.notes;
                            string phone = json.phone;
                            string rule = json.role;
                            string restriction = json.restriction;

                            dynamic jsonOrg = JsonConvert.DeserializeObject(json.organization.ToString());
                            string organization = jsonOrg != null ? jsonOrg.name : string.Empty;
                            string tags = "client"; // json.tags;

                            WriteCSV(txtOutputCSV.Text, name, email, external_id, details, notes, phone, rule, restriction, organization, tags);
                        }
                        catch
                        {
                            errors = errors + 1;
                        }
                    }
                }

            }
            finally
            {
                refreshing--;
            }

            // final gui refresh
            lblErrors.Text = "Errors: " + errors.ToString();
        }

        private void WriteCSV(string path, string name, string email, string external_id, string details, string notes, 
            string phone, string rule, string restriction, string organization, string tags)
        {
            name = escapeCSV(name);
            email = escapeCSV(email);
            external_id = escapeCSV(external_id);
            details = escapeCSV(details);
            notes = escapeCSV(notes);
            phone = escapeCSV(phone);
            rule = escapeCSV(rule);
            restriction = escapeCSV(restriction);
            organization = escapeCSV(organization);
            tags = escapeCSV(tags);

            string s = "\"" + name + "\",\"" + email + "\",\"" + external_id + "\",\"" + details + "\",\"" + notes + "\",\"" + phone + "\",\"" + rule + "\",\"" + restriction + "\",\"" + organization + "\",\"" + tags + "\"";

            Console.WriteLine(s);

            File.AppendAllText(path, s + System.Environment.NewLine);
        }

        private string escapeCSV(string field)
        {
            if (string.IsNullOrEmpty(field)) { return string.Empty; }

            field = field.Replace("\"", "\"\"");
            return field;
        }

        private bool PreconditionsCheck()
        {
            if (!FileExists(txtInputJSON.Text))
            {
                MessageBox.Show("Input file not found");
                return false;
            }

            return true;
        }

        private bool FileExists(string path)
        {
            return string.IsNullOrEmpty(path) ? false : File.Exists(path);
        }
        private int LinesInAFile(string path)
        {
            int c = 0;
            using (StreamReader reader = File.OpenText(path))
            {
                while (reader.ReadLine() != null)
                {
                    c++;
                }
            }

            return c;
        }


    }
}
