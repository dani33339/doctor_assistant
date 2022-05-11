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
            dataGridView.Columns.Add("HCT", "HCT");
            dataGridView.Columns.Add("Urea", "Urea");
            dataGridView.Columns.Add("Hb", "Hb");
            dataGridView.Columns.Add("Crtn", "Crtn");
            dataGridView.Columns.Add("HDL", "HDL");
            dataGridView.Columns.Add("AP", "AP");

            dataGridView[0, 0].Value = bloodtest.WBC;
            dataGridView[1, 0].Value = bloodtest.Neut;
            dataGridView[2, 0].Value = bloodtest.Lymph;
            dataGridView[3, 0].Value = bloodtest.HCT;
            dataGridView[4, 0].Value = bloodtest.UREA;
            dataGridView[5, 0].Value = bloodtest.Hb;
            dataGridView[6, 0].Value = bloodtest.Crtn;
            dataGridView[7, 0].Value = bloodtest.HDL;
            dataGridView[8, 0].Value = bloodtest.AP;

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

        private  void diagnosis_btn_Click(object sender, EventArgs e)
        {





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
            
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;


            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(save.FileName);
            xlWorkSheet = xlWorkBook.Worksheets["MainReport"];

            String box = xlWorkSheet.Cells[1,"A1"].value;

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


            if (Questions[0].status == true)
            {

                xlWorkSheet.Cells[row, column_diagnosis].value = "Smokers";
                xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Smokers"];
                row++;
            }
            //WBC
            if ((Convert.ToDouble(bloodtest.WBC) > 11000 && patient.Age >= 18) ||
                (Convert.ToDouble(bloodtest.WBC) > 15500 && patient.Age > 3 && patient.Age < 17) ||
                (Convert.ToDouble(bloodtest.WBC) > 17500 && patient.Age < 3))
            {
                xlWorkSheet.Cells[row, column_diagnosis].value = "Infection";
                xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Infection"];
                row++;
            }
            if ((bloodtest.WBC < 4500 && patient.Age >= 18) ||
                (bloodtest.WBC < 5500 && patient.Age > 3 && patient.Age < 17) ||
                (bloodtest.WBC < 6000 && patient.Age < 3))
            {
                xlWorkSheet.Cells[row, column_diagnosis].value = "Viral disease" ;
                xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Viral disease"];
                row++;
            }

            //Neut
            if (bloodtest.Neut > 54)
            {
                if (!SearchInDiagnosis("Infection", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].value = "Infection";
                    xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Infection"];
                    row++;
                }
            }
            if (bloodtest.Neut < 28)
            {
                xlWorkSheet.Cells[row, column_diagnosis].value = "Disruption of blood / blood cell formation";
                xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Disruption of blood / blood cell formation"];
                row++;
            }

            //Lymph
            if (bloodtest.Lymph > 52)
            {
                if (!SearchInDiagnosis("Infection", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].value = "Infection";
                    xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Infection"] + "or" + " ";
                    row++;
                }
                if (!SearchInDiagnosis("cancer", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].value = "cancer";
                    xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["cancer"];
                    row++;
                }
            }
            if (bloodtest.Lymph < 36)
            {
                if (!SearchInDiagnosis("Disruption of blood / blood cell formation", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].value = "Disruption of blood / blood cell formation";
                    xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Disruption of blood / blood cell formation"];
                    row++;
                }
            }

            //RBC
            if (bloodtest.RBC > 6)
            {
                if (!SearchInDiagnosis("Disruption of blood / blood cell formation", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].value = "Disruption of blood / blood cell formation";
                    xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Infection"] ;
                    row++;
                    
                }
                if (!SearchInDiagnosis("Smokers", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].value = "Smokers";
                    xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Smokers"] ;
                    row++;
                }
                if (!SearchInDiagnosis("Lung disease", xlWorkSheet))
                {
                    xlWorkSheet.Cells[row, column_diagnosis].value = "Lung disease";
                    xlWorkSheet.Cells[row, column_Recomendation].value = Recomendation["Lung disease"];
                    row++;
                }
            }
            //if (bloodtest.RBC < 4.5)
            //{
            //    if (!diagnosis.Contains("anemia"))
            //    {
            //        diagnosis = diagnosis + "anemia";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["anemia"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("bleeding"))
            //    {
            //        diagnosis = diagnosis + "bleeding";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
            //    }
            //}

            ////HCT
            //double Mmaxhct = 54;
            //double Fmaxhct = 47;
            //double Mminhct = 37;
            //double Fminhct = 33;

            //if (Questions[1].status == true)
            //{
            //    Mmaxhct = Mmaxhct + Mmaxhct * 0.1;
            //    Fmaxhct = Fmaxhct + Fmaxhct * 0.1;
            //    Mminhct = Mminhct + Mminhct * 0.1;
            //    Fminhct = Fminhct + Fminhct * 0.1;
            //}

            //if ((bloodtest.HCT > Mmaxhct && patient.Gender == "זכר") ||
            //    (bloodtest.HCT > Fmaxhct && patient.Gender == "נקבה"))
            //{
            //    if (!diagnosis.Contains("Smokers"))
            //    {
            //        diagnosis = diagnosis + "Smokers";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Smokers"];
            //    }
            //}

            //if ((bloodtest.HCT < Mminhct && patient.Gender == "זכר") ||
            //    (bloodtest.HCT < Fminhct && patient.Gender == "נקבה"))
            //{
            //    if (!diagnosis.Contains("anemia"))
            //    {
            //        diagnosis = diagnosis + "anemia";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["anemia"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("bleeding"))
            //    {
            //        diagnosis = diagnosis + "bleeding";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
            //    }
            //}

            ////Urea
            //if (bloodtest.UREA > 43)
            //{
            //    if (!diagnosis.Contains("Kidney disease"))
            //    {
            //        diagnosis = diagnosis + "Kidney disease";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Kidney disease"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Dehydration"))
            //    {
            //        diagnosis = diagnosis + "Dehydration";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Dehydration"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("diet"))
            //    {
            //        diagnosis = diagnosis + "diet";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
            //    }
            //}

            //if (bloodtest.UREA < 17)
            //{            
            //    if (Questions.Length > 4)
            //    {
            //        if (Questions[4].status == true)
            //        {
            //            diagnosis = diagnosis + "low Urea is normal for pregnant woman";
            //        }
            //    }
            //    if (!diagnosis.Contains("Malnutrition"))
            //    {
            //        diagnosis = diagnosis + "Malnutrition";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Malnutrition"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("diet"))
            //    {
            //        diagnosis = diagnosis + "diet";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["diet"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Liver disease"))
            //    {
            //        diagnosis = diagnosis + "Liver disease";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Liver disease"];
            //    }
            //}

            ////Hb
            //if ((bloodtest.Hb < 12 && patient.Age >= 18) ||
            //    (bloodtest.Hb < 11.5 && patient.Age < 18))
            //{
            //    if (!diagnosis.Contains("anemia"))
            //    {
            //        diagnosis = diagnosis + "anemia";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["anemia"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Hematological disorder"))
            //    {
            //        diagnosis = diagnosis + "diet";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Hematological disorder"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Iron deficiency"))
            //    {
            //        diagnosis = diagnosis + "Iron deficiency";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Iron deficiency"];
            //    }
            //    if (!diagnosis.Contains("bleeding"))
            //    {
            //        diagnosis = diagnosis + "bleeding";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
            //    }
            //}

            ////Crtn
            //if ((bloodtest.Crtn > 1 && patient.Age >= 3 && patient.Age <= 59) ||
            //    (bloodtest.Crtn < 1.2 && patient.Age >= 60) ||
            //    (bloodtest.Crtn < 0.5 && patient.Age < 3))
            //{
            //    if (!diagnosis.Contains("Kidney disease"))
            //    {
            //        diagnosis = diagnosis + "Kidney disease";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Kidney disease"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Muscle diseases"))
            //    {
            //        diagnosis = diagnosis + "Muscle diseases";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Muscle diseases"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Increased consumption of meat"))
            //    {
            //        diagnosis = diagnosis + "Increased consumption of meat";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Increased consumption of meat"];
            //    }
            //}

            //if ((bloodtest.Crtn < 0.6 && patient.Age >= 18) ||
            //    (bloodtest.Crtn < 0.5 && patient.Age >= 3 && patient.Age >= 17) ||
            //    (bloodtest.Crtn < 0.2 && patient.Age < 3))
            //{
            //    if (!diagnosis.Contains("Muscle diseases"))
            //    {
            //        diagnosis = diagnosis + "Muscle diseases";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Muscle diseases"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Malnutrition"))
            //    {
            //        diagnosis = diagnosis + "Muscle diseases";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Malnutrition"];
            //    }
            //}

            ////Iron
            //if ((bloodtest.iron > 160 && patient.Gender == "זכר") ||
            //    (bloodtest.iron > 160 - 160 * 0.2 && patient.Gender == "נקבה"))
            //{
            //    if (!diagnosis.Contains("Iron poisoning"))
            //    {
            //        diagnosis = diagnosis + "Iron poisoning";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Iron poisoning"];
            //    }
            //}

            //if ((bloodtest.iron < 60 && patient.Gender == "זכר") ||
            //    (bloodtest.iron < 60 - 60 * 0.2 && patient.Gender == "נקבה"))
            //{
            //    if (!diagnosis.Contains("Malnutrition"))
            //    {
            //        diagnosis = diagnosis + "Malnutrition";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Malnutrition"] + "or" + " ";
            //    }
            //    if (Questions.Length > 4)
            //    {
            //        if (Questions[3].status == true)
            //        {
            //            if (!diagnosis.Contains("Iron deficiency"))
            //            {
            //                diagnosis = diagnosis + "Iron deficiency";
            //                OutRecomendation = OutRecomendation + "," + Recomendation["Iron deficiency"] + "or" + " ";
            //            }
            //        }
            //    }
            //    if (!diagnosis.Contains("bleeding"))
            //    {
            //        diagnosis = diagnosis + "bleeding";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["bleeding"];
            //    }
            //}

            ////HDL
            //double MminHDL = 29;
            //double FminHDL = 34;
            //if (Questions[2].status == true)
            //{
            //    MminHDL = MminHDL + MminHDL * 0.2;
            //    FminHDL = FminHDL + FminHDL * 0.2;
            //}

            //if ((bloodtest.HDL < MminHDL && patient.Gender == "זכר") ||
            //   (bloodtest.HDL < FminHDL && patient.Gender == "נקבה"))
            //{
            //    if (!diagnosis.Contains("Heart disease"))
            //    {
            //        diagnosis = diagnosis + "Heart disease";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Heart disease"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Hyperlipidemia"))
            //    {
            //        diagnosis = diagnosis + "Hyperlipidemia";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Hyperlipidemia"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Adult diabetes"))
            //    {
            //        diagnosis = diagnosis + "Adult diabetes";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Adult diabetes"];
            //    }
            //}

            ////AP
            //double minAP = 30;
            //double maxAP = 90;
            //if (Questions[1].status == true)
            //{
            //    minAP = 60;
            //    maxAP = 120;
            //}


            //if (bloodtest.AP > maxAP)
            //{
            //    if (!diagnosis.Contains("Liver disease"))
            //    {
            //        diagnosis = diagnosis + "Heart disease";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Heart disease"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Diseases of the biliary tract"))
            //    {
            //        diagnosis = diagnosis + "Diseases of the biliary tract";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Diseases of the biliary tract"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Overactive thyroid gland"))
            //    {
            //        diagnosis = diagnosis + "Overactive thyroid gland";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Overactive thyroid gland"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Use of various medications"))
            //    {
            //        diagnosis = diagnosis + "Use of various medications";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Use of various medications"] + "or" + " ";
            //    }
            //}

            //if (bloodtest.AP < minAP)
            //{
            //    if (!diagnosis.Contains("Malnutrition"))
            //    {
            //        diagnosis = diagnosis + "Malnutrition";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Malnutrition"] + "or" + " ";
            //    }
            //    if (!diagnosis.Contains("Vitamin deficiency"))
            //    {
            //        diagnosis = diagnosis + "Vitamin deficiency";
            //        OutRecomendation = OutRecomendation + "," + Recomendation["Vitamin deficiency"];
            //    }
            //}

            xlWorkBook.Close();
            xlApp.Quit();


        }
        public bool SearchInDiagnosis(String diagnosis, Microsoft.Office.Interop.Excel.Worksheet x) 
        {
            int column_diagnosis = 24;
            int row = 1;
            while (x.Cells[row, column_diagnosis].value != "")
            {
                if (x.Cells[row, column_diagnosis].value = diagnosis)
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
