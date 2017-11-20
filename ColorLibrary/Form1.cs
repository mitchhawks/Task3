using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ColorLibrary
{
    /// <summary>  
    ///  This class contains the methods poweing the main program.  
    /// </summary>  
    public partial class Form1 : Form
    {
        List<Colour> colourList;
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>  
        ///  Loads a predefined JSON file and adds them to a list view 
        /// </summary>  
        /// <param name="sender">sender object</param>
        /// <param name="e">eventargs</param>
        private void BtnLoad_Click(object sender, EventArgs e)
        {

            lstColors.Clear();

            string text = System.IO.File.ReadAllText(@"colors.json");

            try
            {
                colourList = JsonConvert.DeserializeObject<List<Colour>>(text);
            }
            catch(JsonException ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (Colour colour in colourList)
            {
                lstColors.Items.Add(colour.colourHex);
            }
            
        }

        /// <summary>
        /// handles displaying color info when listitem is clicked
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">eventargs</param>
        private void LstColors_ItemActivate(Object sender, EventArgs e)
        {
            string hex = lstColors.SelectedItems[0].Text;
            txtHexList.Text = hex;
            try
            {
                groupBox1.BackColor = ColorTranslator.FromHtml(hex);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }

        }

        /// <summary>  
        ///  Writes the contents of the listview to a predefined JSON file
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">eventargs</param>        
        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            string jsonToWrite = JsonConvert.SerializeObject(colourList, Formatting.Indented);
            System.IO.File.WriteAllText(@"output.json", jsonToWrite);
        }


        /// <summary>  
        ///  Checks the inputted value and adds it as a hex value.  
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">eventargs</param>        
        private void btnAddColour_Click(object sender, EventArgs e)
        {
            string hex = txtHexToAdd.Text;
            try
            {
                string s = ColorTranslator.FromHtml(hex).ToString();
                Colour toAdd = new Colour(hex);
                colourList.Add(toAdd);
                lstColors.Items.Add(toAdd.colourHex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! {0}", ex.Message);
            }
            
        }

        /// <summary>  
        ///  Displays the help message when F1 is pressed.  
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">eventargs</param>        
        private void txtHexToAdd_KeyUp(object sender, KeyEventArgs e)
        {
            // Determine whether the key entered is the F1 key. If it is, display Help.
            if (e.KeyCode == Keys.F1)
            {
                // Display a pop-up Help topic to assist the user.
                MessageBox.Show("Unhelpful Message");
            }
        }
    }
}
