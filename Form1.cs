using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net;
using System.Windows.Forms.DataVisualization.Charting;

/*
 * Anne-Marie Oelschlager
 * Assign6
 * 
 * The purpose of this program is to call an api and download the Json data.
 * Then the data is converted from Json into an objects. The program then loops
 * through the objects to pull the data out and display the inforamtion on two
 * charts.
 * 
 * The api is from openFDA. It's created by the U.S. Food and Drug Administration.
 * The data is of reported adverse drug events from 2004 to present.
 * https://open.fda.gov/drug/event
 * 
 * To aid in parsing the Json data I used Json.NET by Newtonsoft. The package was
 * downloaded and included in this project.
 * 
 * Glossary:
 * 
 * Hypertension - also known as high blood pressure, is a long-term medical 
 *          condition in which the blood pressure in the arteries is persistently elevated.
 * Atrial fibrillation - is an abnormal heart rhythm characterized by rapid and 
 *          irregular beating of the atria.
 * Deep vein thrombosis - is the formation of a blood clot in a deep vein, 
 *          most commonly the legs.
 * Anticoagulants - commonly referred to as blood thinners, are chemical substances that prevent
 *          or reduce coagulation of blood, prolonging the clotting time.
 * Stimulant laxatives - are substances that act on the intestinal mucosa or nerve plexus,
 *          altering water and electrolyte secretion.
 * Insulin - is a peptide hormone produced by beta cells of the pancreatic 
 *          islets, and it is considered to be the main anabolic hormone of the body.
 *          
*/

namespace Assign6
{
    public partial class Form1 : Form
    {
        // Flag to keep track of chart type for gender chart
        bool doughnut = true;

        // String to hold the value of the limit amount
        String limit = "5";

        String apiKey = "YOUR API KEY GOES HERE";
        String beginningApi = @"https://api.fda.gov/drug/event.json?api_key=";
        String hyperReactionApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.drugindication:hypertension&count=patient.reaction.reactionmeddrapt.exact&limit=";
        String hyperGenderApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.drugindication:hypertension&count=patient.patientsex";
        String dvtReactionApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.drugindication:deep+vein+thrombosis&count=patient.reaction.reactionmeddrapt.exact&limit=";
        String dvtGenderApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.drugindication:deep+vein+thrombosis&count=patient.patientsex";
        String afibReactionApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.drugindication:atrial+fibrillation&count=patient.reaction.reactionmeddrapt.exact&limit=";
        String afibGenderApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.drugindication:atrial+fibrillation&count=patient.patientsex";
        String anticoagulantReactionApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.openfda.pharm_class_epc:""anti-coagulant""&count=patient.reaction.reactionmeddrapt.exact&limit=";
        String anticoagulantGenderApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.openfda.pharm_class_epc:""anti-coagulant""&count=patient.patientsex";
        String stimulantlaxReactionApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.openfda.pharm_class_epc:""stimulant+laxative""&count=patient.reaction.reactionmeddrapt.exact&limit=";
        String stimulantlaxGenderApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.openfda.pharm_class_epc:""stimulant+laxative""&count=patient.patientsex";
        String insulinReactionApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.openfda.pharm_class_epc:""insulin""&count=patient.reaction.reactionmeddrapt.exact&limit=";
        String insulinGenderApi = @"&search=receivedate:[20040101+TO+20180427]+AND+patient.drug.openfda.pharm_class_epc:""insulin""&count=patient.patientsex";

        public Form1()
        {
            InitializeComponent();
        }

        // Performs a function based on a radio button the user chooses. 
        private void ReactionRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            this.ReactionChart.Titles.Clear();

            if (hypertentionRB.Checked)
            {
                this.ReactionChart.Titles.Add("Reaction with Hypertention");
                retrieveJsonResults(hyperReactionApi, 1);
                hypertentionRB.Checked = false;
            }
            else if (dvtRB.Checked)
            {
                this.ReactionChart.Titles.Add("Reaction with DVT");
                retrieveJsonResults(dvtReactionApi, 1);
                dvtRB.Checked = false;
            }
            else if (afibRB.Checked)
            {
                this.ReactionChart.Titles.Add("Reaction with Afib");
                retrieveJsonResults(afibReactionApi, 1);
                afibRB.Checked = false;
            }
            else if (antiCoRB.Checked)
            {
                this.ReactionChart.Titles.Add("Reaction with Anti-coagulant");
                retrieveJsonResults(anticoagulantReactionApi, 1);
                antiCoRB.Checked = false;
            }
            else if (stimLaxRB.Checked)
            {
                this.ReactionChart.Titles.Add("Reaction with Stimulant Laxative");
                retrieveJsonResults(stimulantlaxReactionApi, 1);
                stimLaxRB.Checked = false;
            }
            else if (insulinRB.Checked)
            {
                this.ReactionChart.Titles.Add("Reaction with Insulin");
                retrieveJsonResults(insulinReactionApi, 1);
                insulinRB.Checked = false;
            }
        }

        // Performs a function based on a radio button the user chooses. 
        private void GenderRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            this.GenderChart.Titles.Clear();

            if (hypertentionGRB.Checked)
            {
                this.GenderChart.Titles.Add("Hypertention by Gender");
                retrieveJsonResults(hyperGenderApi, 2);
                hypertentionGRB.Checked = false;
            }
            else if (dvtGRB.Checked)
            {
                this.GenderChart.Titles.Add("DVT by Gender");
                retrieveJsonResults(dvtGenderApi, 2);
                dvtGRB.Checked = false;
            }
            else if (afibGRB.Checked)
            {
                this.GenderChart.Titles.Add("Afib by Gender");
                retrieveJsonResults(afibGenderApi, 2);
                afibGRB.Checked = false;
            }
            else if (antiCoGRB.Checked)
            {
                this.GenderChart.Titles.Add("Anti-coagulant by Gender");
                retrieveJsonResults(anticoagulantGenderApi, 2);
                antiCoGRB.Checked = false;
            }
            else if (stimLaxGRB.Checked)
            {
                this.GenderChart.Titles.Add("Stimulant Laxative by Gender");
                retrieveJsonResults(stimulantlaxGenderApi, 2);
                stimLaxGRB.Checked = false;
            }
            else if (insulinGRB.Checked)
            {
                this.GenderChart.Titles.Add("Insulin by Gender");
                retrieveJsonResults(insulinGenderApi, 2);
                insulinGRB.Checked = false;
            }
        }

       
        // Retrieve the Json results from the API
        private void retrieveJsonResults(String apiString, int num)
        {
            if(num == 1)
            {
                String temp = beginningApi + apiKey + apiString + limit;
                string json = new WebClient().DownloadString(temp);
                deserialiseReactionJson(json);
            }
            else
            {
                String temp = beginningApi + apiKey + apiString;
                string json = new WebClient().DownloadString(temp);
                deserialiseGenderJson(json);
            }
        }

        // Deserialize the json returned by the api call using Json .Net and populate the reaction chart
        private void deserialiseReactionJson(String strJson)
        {
            // Clear out all the series in the reaction chart
            ReactionChart.Series.Clear();
            try
            {
                // Convert the json data returned from the api call into a ResultsJson object
                var jData = JsonConvert.DeserializeObject<ResultsJson>(strJson);

                // Loop through the ResultsJson object to populate the chart
                foreach (var res in jData.results)
                {
                    // Add series.
                    Series series = this.ReactionChart.Series.Add(res.term.ToString());
                    
                    // Add point.
                    series.Points.Add(res.count);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Deserialize the json returned by the api call using Json .Net and populate the gender chart
        private void deserialiseGenderJson(String strJson)
        {
            // Clear out all the points in the gender chart
            GenderChart.Series["GenderSeries"].Points.Clear();
            try
            {
                // Convert the json data returned from the api call into a ResultsJson object
                var jData = JsonConvert.DeserializeObject<ResultsJson>(strJson);

                // Loop through the ResultsJson object to populate the chart
                foreach (var res in jData.results)
                {
                    // Put the data in the chart with their three gender types 
                    if (res.term.ToString().Equals("2"))
                    {
                        this.GenderChart.Series["GenderSeries"].Points.AddXY("Women", res.count);
                    }
                    else if (res.term.ToString().Equals("1"))
                    {
                        this.GenderChart.Series["GenderSeries"].Points.AddXY("Men", res.count);
                    }
                    else
                    {
                        this.GenderChart.Series["GenderSeries"].Points.AddXY("Unknown", res.count);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Loads intitial values and titles in the charts
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set palette.
            this.GenderChart.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.GenderChart.Titles.Add("Gender");

            // Set title.
            this.ReactionChart.Titles.Add("Reaction");

            // Dummy values at begining of program
            this.GenderChart.Series["GenderSeries"].Points.AddXY("Women",19999);
            this.ReactionChart.Series["ReactionSeries"].Points.AddXY("Drug Reaction", 200000);
        }

        // Changes gender chart from a doughnut chart to a column chart
        private void changeChartBtn_Click(object sender, EventArgs e)
        {
            if (doughnut)
            {
                this.GenderChart.Series["GenderSeries"].ChartType = SeriesChartType.Column;
                this.GenderChart.Series["GenderSeries"].IsVisibleInLegend = false;
                doughnut = false;
            }
            else
            {
                this.GenderChart.Series["GenderSeries"].ChartType = SeriesChartType.Doughnut;
                this.GenderChart.Series["GenderSeries"].IsVisibleInLegend = true;
                doughnut = true;
            }
        }

        // Exit the program
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Changes the the amount returned in the json results
        private void limitSearchCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (limitSearchCB.SelectedIndex == 0)
            {
                limit = "5";
            }
            else
            {
                limit = "10";
            }
        }
    }
}
