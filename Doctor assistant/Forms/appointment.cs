using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using MongoDB.Driver;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using Excel = Microsoft.Office.Interop.Excel;
namespace Doctor_assistant.Forms
{
    
    public partial class appointment : Form
    {
        
        MongoClient Pm_Client, Bm_Client;
        IMongoDatabase Pm_Database,Bm_Database;
        IMongoCollection<Patientsinfo> Pm_Collection;
        IMongoCollection<BloodTestsInfo> Bm_Collection;


        public DoctorInfo doctor;
        public Patientsinfo patient;

        public appointment(DoctorInfo obj1, Patientsinfo obj2)
        {
            doctor = obj1;
            patient = obj2;

            InitializeComponent();


            Pm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Pm_Database = Pm_Client.GetDatabase("Patients");
            Pm_Collection = Pm_Database.GetCollection<Patientsinfo>("Data");

            Bm_Client = new MongoClient("mongodb+srv://antonvo:0nCdIz2V538QvyD1@cluster0.frcvr.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            Bm_Database = Bm_Client.GetDatabase("BloodTests");
            Bm_Collection = Bm_Database.GetCollection<BloodTestsInfo>("Data");

            docname_label.Text = "שלום דוקטור \n" + doctor.FullName;
            patientname_label.Text = patient.FirstName + " " + patient.LastName;
            pantientid_label.Text = patient.PId;
            dataGridView.Visible = false;
            testexists_label.Visible = false;
            appointment_label.Text = "צור ביקור ל" + patient.FirstName;

            //if patient have bloodtest in the db
            if (patient.BloodTests.Count() > 0)
                FilldataGridView();
            
        }

        /*import last test from the db*/
        public void FilldataGridView()
        {

            imortfile_btn.ButtonText = "ייבא קובץ בדיקות דם חדשות";
            dataGridView.Visible = true;
            testexists_label.Visible = true;
            MongoDB.Bson.ObjectId mostrecent = patient.BloodTests.Last();
            var bloodtest = BloodTestsInfoFinder(mostrecent);
            dataGridView.Columns.Add("WBC", "WBC");
            dataGridView.Columns.Add("Neut", "Neut");
            dataGridView.Columns.Add("Lymph", "Lymph");
            dataGridView.Columns.Add("RBC", "RBC");
            dataGridView.Columns.Add("HCT", "HCT");
            dataGridView.Columns.Add("Urea", "Urea");
            dataGridView.Columns.Add("Hb", "Hb");
            dataGridView.Columns.Add("Crtn", "Crtn");
            dataGridView.Columns.Add("Iron", "Iron");
            dataGridView.Columns.Add("HDL", "HDL");
            dataGridView.Columns.Add("AP", "AP");

            dataGridView[0, 0].Value = bloodtest.WBC;
            dataGridView[1, 0].Value = bloodtest.Neut;
            dataGridView[2, 0].Value = bloodtest.Lymph;
            dataGridView[3, 0].Value = bloodtest.RBC;
            dataGridView[4, 0].Value = bloodtest.HCT;
            dataGridView[5, 0].Value = bloodtest.UREA;
            dataGridView[6, 0].Value = bloodtest.Hb;
            dataGridView[7, 0].Value = bloodtest.Crtn;
            dataGridView[8, 0].Value = bloodtest.iron;
            dataGridView[9, 0].Value = bloodtest.HDL;
            dataGridView[10, 0].Value = bloodtest.AP;

        }


        public BloodTestsInfo BloodTestsInfoFinder(MongoDB.Bson.ObjectId Id)
        {
            var filter = Builders<BloodTestsInfo>.Filter;
            var idfilter = filter.Eq(x => x.Id, Id);
            var bloodtest = Bm_Collection.Find<BloodTestsInfo>(idfilter).FirstOrDefault();
            return bloodtest;
        }

        private void imortfile_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            //clear dataGridView from old test
                            dataGridView.DataSource = null;
                            dataGridView.Rows.Clear();
                            dataGridView.Columns.Clear();

                            //import the new data to the dataGridView
                            dataGridView.DataSource = result.Tables["גיליון1"];
                            dataGridView.Visible = true;
                            testexists_label.Visible = true;
                            BloodTestsInfo NewBloodTestsInfo = new BloodTestsInfo();
                            NewBloodTestsInfo.WBC = Convert.ToDouble(dataGridView[0,0].Value);
                            NewBloodTestsInfo.Neut = Convert.ToDouble(dataGridView[1, 0].Value);
                            NewBloodTestsInfo.Lymph = Convert.ToDouble(dataGridView[2, 0].Value);
                            NewBloodTestsInfo.RBC = Convert.ToDouble(dataGridView[3, 0].Value);
                            NewBloodTestsInfo.HCT = Convert.ToDouble(dataGridView[4, 0].Value);
                            NewBloodTestsInfo.UREA = Convert.ToDouble(dataGridView[5, 0].Value);
                            NewBloodTestsInfo.Hb = Convert.ToDouble(dataGridView[6, 0].Value);
                            NewBloodTestsInfo.Crtn = Convert.ToDouble(dataGridView[7, 0].Value);
                            NewBloodTestsInfo.iron = Convert.ToDouble(dataGridView[8, 0].Value);
                            NewBloodTestsInfo.HDL = Convert.ToDouble(dataGridView[9, 0].Value);
                            NewBloodTestsInfo.AP = Convert.ToDouble(dataGridView[10, 0].Value);
                            NewBloodTestsInfo.PatientId = patient.PId;
                            NewBloodTestsInfo.Patient = patient;
                            Bm_Collection.InsertOne(NewBloodTestsInfo);
                            patient.BloodTests.Add(NewBloodTestsInfo.Id);

                            var updateDfinition = Builders<Patientsinfo>.Update.Set(a => a.BloodTests, patient.BloodTests);
                            var filter = Builders<Patientsinfo>.Filter;
                            var patientfilter = filter.Eq(x => x.Id, patient.Id);
                            Pm_Collection.UpdateOne(patientfilter, updateDfinition);
                            MessageBox.Show("בדיקות הדם נשמרו בהצלחה");
                        }
                    }
                }
            }
        }

        private void docname_label_Click(object sender, EventArgs e)
        {
            
        }

        private void medicalindices_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appointment_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public bool HeatTest()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(heat_textbox.Text, "[^0-9]"))
            {
                MessageBox.Show("החום אינו תקין");
                heat_textbox.Text = heat_textbox.Text.Remove(heat_textbox.Text.Length - 1);
                return true;
            }

            if (Int32.Parse(heat_textbox.Text) > 45 && Int32.Parse(heat_textbox.Text) < 36)
            {
                MessageBox.Show("החום אינו תקין");
                heat_textbox.Text = heat_textbox.Text.Remove(heat_textbox.Text.Length - 1);
                return true;
            }
            return false;

        }

        private  void diagnosis_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(heat_textbox.Text) || String.IsNullOrEmpty(pulse_textBox.Text) || String.IsNullOrEmpty(bloodpressure_textBox.Text))
            {
                MessageBox.Show("הכנס את כל המדדים");
                return;
            }

             
            if (HeatTest())
                return;
            
            


            MongoDB.Bson.ObjectId mostrecent = patient.BloodTests.Last();
            var bloodtest = BloodTestsInfoFinder(mostrecent);
            //create qustions
            Question[] Questions = { new Question { name = "?האם המטופל מעשן", status=false },
            new Question { name = "?האם המטופל יוצא עדות המזרח", status=false },
            new Question { name = "?האם המטופל ממוצא אתיופי", status=false }};
            if (patient.Gender == "נקבה")
                Questions.Append(new Question { name = "?האם המטופלת בהריון", status = false });

            //send and get answers for the qustions
            foreach (Question q in Questions)
            {
                Diagnosis newForm = new Diagnosis(doctor , q);
                this.Hide();
                newForm.ShowDialog();
            }

            this.Show();
            MakeDiagnosis(bloodtest, Questions);

        }

        public async Task MakeDiagnosis(BloodTestsInfo bloodtest, Question[] Questions)
        {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //String filename = "D:\\" +  patient.FirstName + ".xlsx";
            //var file = new FileInfo(filename);
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "where to save";
            save.FileName = patient.FirstName + ".xlsx";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var file = new FileInfo(save.FileName);
                var Out = GetSetupData(bloodtest, patient);
                await SaveExcelFile(Out, file);
            }
            int column_diagnosis = 24;
            int column_Recomendation = 25;
            int row = 2;




            FileInfo fileInfo = new FileInfo(save.FileName);

            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet xlWorkSheet = package.Workbook.Worksheets.FirstOrDefault();



            Dictionary<string, string> Recomendation = new Dictionary<string, string>(){
            {"anemia","Two 10 mg B12 pills a day for a month"},
            {"diet","Schedule an appointment with Nutrition"},
            {"bleeding","To be rushed to the hospital urgently"},
            {"Hyperlipidemia", "Schedule an appointment with a nutritionist, a 5 mg pill of Simobil daily for a week"},
            {"Disruption of blood / blood cell formation", "10 mg pill of B12 a day for a month, 5 mg pill of folic acid a day for a month "},
            {"Hematological disorder", "An injection of a hormone to encourage red blood cell production"},
            {"Iron poisoning", "To be evacuated to the hospital"},
            {"Dehydration", "Complete rest while lying down, returning fluids to drinking"},
            {"Infection", "Dedicated antibiotics"},
            {"Vitamin deficiency", "Referral for a blood test to identify the missing vitamins"},
            {"Viral disease", "Rest at home"},
            {"Diseases of the biliary tract", "Referral to surgical treatment"},
            {"Heart disease", "Schedule an appointment with a nutritionist"},
            {"Blood disease", "A combination of cyclophosphamide and corticosteroids"},
            {"Liver disease", "Referral to a specific diagnosis for the purpose of determining treatment"},
            {"Kidney disease", "Balance blood sugar levels"},
            {"Iron deficiency", "Two 10 mg B12 pills a day for a month"},
            {"Muscle diseases", "Two 5 mg pills of Altman c3 turmeric a day for a month"},
            {"Smokers", "to stop smoking"},
            {"Lung disease", "Stop smoking / Refer to an X-ray of the lungs"},
            {"Overactive thyroid gland", "Propylthiouracil to reduce thyroid activity"},
            {"Adult Diabetes", "Insulin adjustment for the patient"},
            {"cancer", "Antarctinib - Entrectinib"},
            {"Increased consumption of meat", "Schedule an appointment with a nutritionist"},
            {"Use of various medications","Referral to a family doctor for a match between medications"},
            {"Malnutrition", "Schedule an appointment with Nutrition"}
            };

            Dictionary<string, string> Conclusion_Window = new Dictionary<string, string>();

            if (Questions[0].status == true)
            {

                xlWorkSheet.Cells[row, column_diagnosis].Value = "Smokers";
                xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Smokers"];
                row++;
                Conclusion_Window.Add("Smokers", Recomendation["Smokers"]);
            }
            //WBC
            if ((Convert.ToDouble(bloodtest.WBC) > 11000 && patient.Age >= 18) ||
                (Convert.ToDouble(bloodtest.WBC) > 15500 && patient.Age > 3 && patient.Age < 17) ||
                (Convert.ToDouble(bloodtest.WBC) > 17500 && patient.Age < 3))
            {
                xlWorkSheet.Cells[row, column_diagnosis].Value = "Infection";
                xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Infection"];
                row++;
                Conclusion_Window.Add("Infection", Recomendation["Infection"]);
            }
            if ((bloodtest.WBC < 4500 && patient.Age >= 18) ||
                (bloodtest.WBC < 5500 && patient.Age > 3 && patient.Age < 17) ||
                (bloodtest.WBC < 6000 && patient.Age < 3))
            {
                xlWorkSheet.Cells[row, column_diagnosis].Value = "Viral disease";
                xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Viral disease"];
                row++;
                Conclusion_Window.Add("Viral disease", Recomendation["Viral disease"]);
            }

            //Neut
            if (bloodtest.Neut > 54)
            {
                if (!SearchInDiagnosis("Infection", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Infection";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Infection"];
                    row++;
                    Conclusion_Window.Add("Infection", Recomendation["Infection"]);
                }
            }
            if (bloodtest.Neut < 28)
            {
                xlWorkSheet.Cells[row, column_diagnosis].Value = "Disruption of blood / blood cell formation";
                xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Disruption of blood / blood cell formation"];
                row++;
                Conclusion_Window.Add("Disruption of blood / blood cell formation", Recomendation["Disruption of blood / blood cell formation"]);
            }

            //Lymph
            if (bloodtest.Lymph > 52)
            {
                if (!SearchInDiagnosis("Infection", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Infection";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Infection"];
                    row++;
                    Conclusion_Window.Add("Infection", Recomendation["Infection"]);
                }
                if (!SearchInDiagnosis("cancer", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "cancer";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["cancer"];
                    row++;
                    Conclusion_Window.Add("cancer", Recomendation["cancer"]);
                }
            }
            if (bloodtest.Lymph < 36)
            {
                if (!SearchInDiagnosis("Disruption of blood / blood cell formation", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Disruption of blood / blood cell formation";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Disruption of blood / blood cell formation"];
                    row++;
                    Conclusion_Window.Add("Disruption of blood / blood cell formation", Recomendation["Disruption of blood / blood cell formation"]);
                }
            }

            //RBC
            if (bloodtest.RBC > 6)
            {
                if (!SearchInDiagnosis("Disruption of blood / blood cell formation", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Disruption of blood / blood cell formation";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Infection"];
                    row++;
                    Conclusion_Window.Add("Disruption of blood / blood cell formation", Recomendation["Disruption of blood / blood cell formation"]);
                }
                if (!SearchInDiagnosis("Smokers", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Smokers";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Smokers"];
                    row++;
                    Conclusion_Window.Add("Smokers", Recomendation["Smokers"]);
                }
                if (!SearchInDiagnosis("Lung disease", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Lung disease";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Lung disease"];
                    row++;
                    Conclusion_Window.Add("Lung disease", Recomendation["Lung disease"]);
                }
            }
            if (bloodtest.RBC < 4.5)
            {
                if (!SearchInDiagnosis("anemia", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "anemia";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["anemia"];
                    row++;
                    Conclusion_Window.Add("anemia", Recomendation["anemia"]);
                }
                if (!SearchInDiagnosis("bleeding", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "bleeding";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["bleeding"];
                    row++;
                    Conclusion_Window.Add("bleeding", Recomendation["bleeding"]);
                }
            }

            //HCT
            double Mmaxhct = 54;
            double Fmaxhct = 47;
            double Mminhct = 37;
            double Fminhct = 33;

            if (Questions[1].status == true)
            {
                Mmaxhct = Mmaxhct + Mmaxhct * 0.1;
                Fmaxhct = Fmaxhct + Fmaxhct * 0.1;
                Mminhct = Mminhct + Mminhct * 0.1;
                Fminhct = Fminhct + Fminhct * 0.1;
            }

            if ((bloodtest.HCT > Mmaxhct && patient.Gender == "זכר") ||
                (bloodtest.HCT > Fmaxhct && patient.Gender == "נקבה"))
            {
                if (!SearchInDiagnosis("Smokers", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Smokers";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Smokers"];
                    row++;
                    Conclusion_Window.Add("Smokers", Recomendation["Smokers"]);
                }
            }

            if ((bloodtest.HCT < Mminhct && patient.Gender == "זכר") ||
                (bloodtest.HCT < Fminhct && patient.Gender == "נקבה"))
            {
                if (!SearchInDiagnosis("anemia", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "anemia";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["anemia"];
                    row++;
                    Conclusion_Window.Add("anemia", Recomendation["anemia"]);
                }
                if (!SearchInDiagnosis("bleeding", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "bleeding";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["bleeding"];
                    row++;
                    Conclusion_Window.Add("bleeding", Recomendation["bleeding"]);
                }
            }

            //Urea
            if (bloodtest.UREA > 43)
            {
                if (!SearchInDiagnosis("Kidney disease", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Kidney disease";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Kidney disease"];
                    row++;
                    Conclusion_Window.Add("Kidney disease", Recomendation["Kidney disease"]);
                }
                if (!SearchInDiagnosis("Dehydration", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Dehydration";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Dehydration"];
                    row++;
                    Conclusion_Window.Add("Dehydration", Recomendation["Dehydration"]);
                }
                if (!SearchInDiagnosis("diet", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "diet";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["diet"];
                    row++;
                    Conclusion_Window.Add("diet", Recomendation["diet"]);
                }
            }

            if (bloodtest.UREA < 17)
            {
                if (Questions.Length > 4)
                {
                    if (Questions[4].status == true)
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "low Urea is normal for pregnant woman";
                        
                    }
                }
                if (!SearchInDiagnosis("Malnutrition", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Malnutrition";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Malnutrition"];
                    row++;
                }
                if (!SearchInDiagnosis("diet", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "diet";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["diet"];
                    row++;
                    Conclusion_Window.Add("diet", Recomendation["diet"]);
                }
                if (!SearchInDiagnosis("Liver disease", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Liver disease";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Liver disease"];
                    row++;
                    Conclusion_Window.Add("Liver disease", Recomendation["Liver disease"]);
                }
            }

            //Hb
            if ((bloodtest.Hb < 12 && patient.Age >= 18) ||
                (bloodtest.Hb < 11.5 && patient.Age < 18))
            {
                if (!SearchInDiagnosis("anemia", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "anemia";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["anemia"];
                    row++;
                    Conclusion_Window.Add("anemia", Recomendation["anemia"]);
                }
                if (!SearchInDiagnosis("Hematological disorder", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "diet";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Hematological disorder"];
                    row++;
                    Conclusion_Window.Add("Hematological disorder", Recomendation["Hematological disorder"]);
                }
                if (!SearchInDiagnosis("Iron deficiency", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Iron deficiency";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Iron deficiency"];
                    row++;
                    Conclusion_Window.Add("Iron deficiency", Recomendation["Iron deficiency"]);
                }
                if (!SearchInDiagnosis("bleeding", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "bleeding";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["bleeding"];
                    row++;
                    Conclusion_Window.Add("bleeding", Recomendation["bleeding"]);
                }
            }

            //Crtn
            if ((bloodtest.Crtn > 1 && patient.Age >= 3 && patient.Age <= 59) ||
                (bloodtest.Crtn < 1.2 && patient.Age >= 60) ||
                (bloodtest.Crtn < 0.5 && patient.Age < 3))
            {
                if (!SearchInDiagnosis("Kidney disease", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Kidney disease";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Kidney disease"];
                    row++;
                    Conclusion_Window.Add("Kidney disease", Recomendation["Kidney disease"]);
                }
                if (!SearchInDiagnosis("Muscle diseases", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Muscle diseases";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Muscle diseases"];
                    row++;
                    Conclusion_Window.Add("Muscle diseases", Recomendation["Muscle diseases"]);
                }
                if (!SearchInDiagnosis("Increased consumption of meat", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Increased consumption of meat";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Increased consumption of meat"];
                    row++;
                    Conclusion_Window.Add("Increased consumption of meat", Recomendation["Increased consumption of meat"]);
                }
            }

            if ((bloodtest.Crtn < 0.6 && patient.Age >= 18) ||
                (bloodtest.Crtn < 0.5 && patient.Age >= 3 && patient.Age >= 17) ||
                (bloodtest.Crtn < 0.2 && patient.Age < 3))
            {
                if (!SearchInDiagnosis("Muscle diseases", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Muscle diseases";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Muscle diseases"];
                    row++;
                    Conclusion_Window.Add("Muscle diseases", Recomendation["Muscle diseases"]);
                }
                if (!SearchInDiagnosis("Malnutrition", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Malnutrition";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Malnutrition"];
                    row++;
                    Conclusion_Window.Add("Malnutrition", Recomendation["Malnutrition"]);
                }
            }

            //Iron
            if ((bloodtest.iron > 160 && patient.Gender == "זכר") ||
                (bloodtest.iron > 160 - 160 * 0.2 && patient.Gender == "נקבה"))
            {
                if (!SearchInDiagnosis("Iron poisoning", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Iron poisoning";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Iron poisoning"];
                    row++;
                    Conclusion_Window.Add("Iron poisoning", Recomendation["Iron poisoning"]);
                }
            }

            if ((bloodtest.iron < 60 && patient.Gender == "זכר") ||
                (bloodtest.iron < 60 - 60 * 0.2 && patient.Gender == "נקבה"))
            {
                if (!SearchInDiagnosis("Malnutrition", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Malnutrition";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Malnutrition"];
                    row++;
                    Conclusion_Window.Add("Malnutrition", Recomendation["Malnutrition"]);
                }
                if (Questions.Length > 4)
                {
                    if (Questions[3].status == true)
                    {
                        if (!SearchInDiagnosis("Iron deficiency", xlWorkSheet))
                        {
                            xlWorkSheet.Cells[row, column_diagnosis].Value = "Iron deficiency";
                            xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Iron deficiency"];
                            row++;
                            Conclusion_Window.Add("Iron deficiency", Recomendation["Iron deficiency"]);
                        }
                    }
                }
                if (!SearchInDiagnosis("bleeding", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "bleeding";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["bleeding"];
                    row++;
                    Conclusion_Window.Add("bleeding", Recomendation["bleeding"]);
                }
            }

            //HDL
            double MminHDL = 29;
            double FminHDL = 34;
            if (Questions[2].status == true)
            {
                MminHDL = MminHDL + MminHDL * 0.2;
                FminHDL = FminHDL + FminHDL * 0.2;
            }

            if ((bloodtest.HDL < MminHDL && patient.Gender == "זכר") ||
               (bloodtest.HDL < FminHDL && patient.Gender == "נקבה"))
            {
                if (!SearchInDiagnosis("Heart disease", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].Value = "Heart disease";
                    xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Heart disease"];
                    row++;
                    Conclusion_Window.Add("Heart disease", Recomendation["Heart disease"]);
                    if (!SearchInDiagnosis("Hyperlipidemia", xlWorkSheet))
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "Hyperlipidemia";
                        xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Hyperlipidemia"];
                        row++;
                        Conclusion_Window.Add("Hyperlipidemia", Recomendation["Hyperlipidemia"]);
                    }
                    if (!SearchInDiagnosis("Adult Diabetes", xlWorkSheet))
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "Adult Diabetes";
                        xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Adult Diabetes"];
                        row++;
                        Conclusion_Window.Add("Adult Diabetes", Recomendation["Adult Diabetes"]);
                    }
                }
            }
                //AP
                double minAP = 30;
                double maxAP = 90;
                if (Questions[1].status == true)
                {
                    minAP = 60;
                    maxAP = 120;
                }


                if (bloodtest.AP > maxAP)
                {
                    if (!SearchInDiagnosis("Liver disease", xlWorkSheet))
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "Liver disease";
                        xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Liver disease"];
                        row++;
                        Conclusion_Window.Add("Liver disease", Recomendation["Liver disease"]);
                    }
                    if (!SearchInDiagnosis("Diseases of the biliary tract", xlWorkSheet))
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "Diseases of the biliary tract";
                        xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Diseases of the biliary tract"];
                        row++;
                        Conclusion_Window.Add("Diseases of the biliary tract", Recomendation["Diseases of the biliary tract"]);
                    }
                    if (!SearchInDiagnosis("Overactive thyroid gland", xlWorkSheet))
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "Overactive thyroid gland";
                        xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Overactive thyroid gland"];
                        row++;
                        Conclusion_Window.Add("Overactive thyroid gland", Recomendation["Overactive thyroid gland"]);
                    }
                    if (!SearchInDiagnosis("Use of various medications", xlWorkSheet))
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "Use of various medications";
                        xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Use of various medications"];
                        row++;
                        Conclusion_Window.Add("Use of various medications", Recomendation["Use of various medications"]);
                    }
                }

                if (bloodtest.AP < minAP)
                {
                    if (!SearchInDiagnosis("Malnutrition", xlWorkSheet))
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "Malnutrition";
                        xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Malnutrition"];
                        row++;
                        Conclusion_Window.Add("Malnutrition", Recomendation["Malnutrition"]);
                    }
                    if (!SearchInDiagnosis("Vitamin deficiency", xlWorkSheet))
                    {
                        xlWorkSheet.Cells[row, column_diagnosis].Value = "Vitamin deficiency";
                        xlWorkSheet.Cells[row, column_Recomendation].Value = Recomendation["Vitamin deficiency"];
                        row++;
                        Conclusion_Window.Add("Vitamin deficiency", Recomendation["Vitamin deficiency"]);
                    }
                }
            package.Save();
            String[] Indices = { heat_textbox.Text, pulse_textBox.Text, bloodpressure_textBox.Text };
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            
            
            Diagnosis_Recomendation newForm = new Diagnosis_Recomendation(Conclusion_Window , patient , bloodtest , Indices);
            newForm.ShowDialog();

            
        }
        public bool SearchInDiagnosis(String diagnosis, ExcelWorksheet x) 
        {
            int column_diagnosis = 24;
            int row = 1;
            while (x.Cells[row, column_diagnosis].Value != null)
            {
                if (x.Cells[row, column_diagnosis].Value == diagnosis)
                    return true;
                row++;
            }
            return false;
        }
        private static async Task SaveExcelFile(List<OutPut> Out, FileInfo file)
        {
            DeleteIfExists(file);

            using var package = new ExcelPackage(file) ;

            var ws = package.Workbook.Worksheets.Add("MainReport");


            var range = ws.Cells["A1"].LoadFromCollection(Out, true);
            range.AutoFitColumns();

            await package.SaveAsync();

            
        }

        private static void DeleteIfExists(FileInfo file)
        {
            if(file.Exists)
            {
                file.Delete();
            }
        }

        private List<OutPut> GetSetupData(BloodTestsInfo bloodTests , Patientsinfo patient)
        {
            List<OutPut> output = new()
            {
                new()
                {
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    PhoneNumber = patient.PhoneNumber,
                    Gender = patient.Gender,
                    PId = patient.PId,
                    City = patient.City,
                    Street = patient.Street,
                    HouseNumber = patient.HouseNumber,
                    heat = Convert.ToInt32(heat_textbox.Text),
                    bloodpressure = bloodpressure_textBox.Text,
                    pulse = Convert.ToInt32(pulse_textBox.Text),
                    Age = patient.Age,
                    WBC = bloodTests.WBC,
                    Neut = bloodTests.Neut,
                    Lymph = bloodTests.Lymph,
                    RBC = bloodTests.RBC,
                    HCT = bloodTests.HCT,
                    UREA = bloodTests.UREA,
                    Hb = bloodTests.Hb,
                    Crtn = bloodTests.Crtn,
                    iron = bloodTests.iron,
                    HDL = bloodTests.HDL,
                    AP = bloodTests.AP,
                }
            };
            return output;
        }

        private void appointment_label_Click(object sender, EventArgs e)
        {

        }

        private void heat_Click(object sender, EventArgs e)
        {

        }

        private void name_heat_TextChanged(object sender, EventArgs e)
        {

        }

        private void pulse_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bloodpressure_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inset_btn_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AP_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void WBC_label_Click(object sender, EventArgs e)
        {

        }

        private void Iron_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crtn_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Urea_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HCT_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBC_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lymph_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Neut_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WBC_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hb_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HDL_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void WBC_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inset_btn_Click_1(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(WBC_textBox.Text) || String.IsNullOrEmpty(Neut_textBox.Text) || String.IsNullOrEmpty(Lymph_textBox.Text) ||
               String.IsNullOrEmpty(RBC_textBox.Text) || String.IsNullOrEmpty(HCT_textBox.Text) || String.IsNullOrEmpty(Urea_textBox.Text) ||
               String.IsNullOrEmpty(Hb_textBox.Text) || String.IsNullOrEmpty(Crtn_textBox.Text) || String.IsNullOrEmpty(Iron_textBox.Text) ||
               String.IsNullOrEmpty(HDL_textBox.Text) || String.IsNullOrEmpty(AP_textBox.Text)))
            {
                MessageBox.Show("עליך למלא את כל הערכים");
                return;
            }

            BloodTestsInfo NewBloodTestsInfo = new BloodTestsInfo();
            NewBloodTestsInfo.WBC = Convert.ToDouble(WBC_textBox.Text);
            NewBloodTestsInfo.Neut = Convert.ToDouble(Neut_textBox.Text);
            NewBloodTestsInfo.Lymph = Convert.ToDouble(Lymph_textBox.Text);
            NewBloodTestsInfo.RBC = Convert.ToDouble(RBC_textBox.Text);
            NewBloodTestsInfo.HCT = Convert.ToDouble(HCT_textBox.Text);
            NewBloodTestsInfo.UREA = Convert.ToDouble(Urea_textBox.Text);
            NewBloodTestsInfo.Hb = Convert.ToDouble(Hb_textBox.Text);
            NewBloodTestsInfo.Crtn = Convert.ToDouble(Crtn_textBox.Text);
            NewBloodTestsInfo.iron = Convert.ToDouble(Iron_textBox.Text);
            NewBloodTestsInfo.HDL = Convert.ToDouble(HDL_textBox.Text);
            NewBloodTestsInfo.AP = Convert.ToDouble(AP_textBox.Text);
            NewBloodTestsInfo.PatientId = patient.PId;
            NewBloodTestsInfo.Patient = patient;
            Bm_Collection.InsertOne(NewBloodTestsInfo);
            patient.BloodTests.Add(NewBloodTestsInfo.Id);

            var updateDfinition = Builders<Patientsinfo>.Update.Set(a => a.BloodTests, patient.BloodTests);
            var filter = Builders<Patientsinfo>.Filter;
            var patientfilter = filter.Eq(x => x.Id, patient.Id);
            Pm_Collection.UpdateOne(patientfilter, updateDfinition);
            MessageBox.Show("בדיקות הדם נשמרו בהצלחה");
            FilldataGridView();
        }

        private void AddPatients_btn_Click_1(object sender, EventArgs e)
        {
            Addpatients newForm = new Addpatients(doctor);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void MyPatients_btn_Click_1(object sender, EventArgs e)
        {
            Patients newForm = new Patients(doctor);
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }



    }

}
