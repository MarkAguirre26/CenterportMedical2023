using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSoftware
{
    public partial class FrmPanama : Form, MyInter
    {
        Main fmain;
        public FrmPanama(Main main)
        {
            InitializeComponent();
            //HideAllTabsOnTabControl(tabControl1);
            fmain = main;
        }

        public void New()
        {
            this.Text = "New";
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {

        }




        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        private void FrmPanama_Load(object sender, EventArgs e)
        {

        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pnlClientArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPatients_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //FillDataGridView("");


        }








        private void btnNext_Click(object sender, EventArgs e)
        {
            //fmain.OpenChildForm(() => new FormPatients(), sender);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox106_CheckedChanged(object sender, EventArgs e)
        {
            setDateFormat((CheckBox)sender, dtCovidDateTest);
        }




        private void setDateFormat(CheckBox cb, DateTimePicker dt)
        {
            dt.Format = DateTimePickerFormat.Custom;
            dt.CustomFormat = "dd/MM/yyyy";

            if (cb.Checked)
            {
                dt.CustomFormat = "00/00/0000";
            }
        }



        private void checkBox109_CheckedChanged(object sender, EventArgs e)
        {

            setDateFormat((CheckBox)sender, dtXrayDate);
        }

        private void checkBox110_CheckedChanged(object sender, EventArgs e)
        {

            setDateFormat((CheckBox)sender, dtEkg);
        }



        //public void printPreview()
        //{
        //    if (txtPapin.Text == "")
        //    {
        //        RJMessageBox.Show("No Data to be print", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {

        //        savePatient(false);
        //        using (FormPrintReport formPrint = new FormPrintReport())
        //        {
        //            formPrint.physicianName = txtPhysicianName.Text;
        //            formPrint.NameOfWitness1 = txtNameOfWitness.Text;
        //            formPrint.Tag = txtPapin.Text;
        //            formPrint.ShowDialog();
        //        }
        //    }
        //}


        void newItem()
        {

            rbWorldWide.Checked = true;
            cbNormalColorVision.Checked = true;

            setCheckBoxValue(cbHighBloodPressureYes, cbHighBloodPressureNo, "No");
            setCheckBoxValue(cbEyeproblemYes, cbEyeproblemNo, "No");
            setCheckBoxValue(cbEarNoseThroatYes, cbEarNoseThroatNo, "No");
            setCheckBoxValue(cbHeartSurgeryYes, cbHeartSurgeryNo, "No");
            setCheckBoxValue(cbVaricoseveinsYes, cbVaricoseveinsNo, "No");
            setCheckBoxValue(cbAsthmaBronchitisYes, cbAsthmaBronchitisNo, "No");
            setCheckBoxValue(cbBloodDisorderYes, cbBloodDisorderNo, "No");
            setCheckBoxValue(cbDiabetesYes_, cbDiabetesNo, "No");
            setCheckBoxValue(cbThyroidProblemYes, cbThyroidProblemNo, "No");
            setCheckBoxValue(cbDigestiveDisordersYes, cbDigestiveDisordersNo, "No");
            setCheckBoxValue(cbKidneyDisordersYes, cbKidneyDisordersNo_, "No");
            setCheckBoxValue(cbSkinProblemYes, cbSkinProblemNo, "No");
            setCheckBoxValue(cbAllergiesYes, cbAllergiesNo, "No");
            setCheckBoxValue(cbEpilipsyYes, cbEpilipsyNo, "No");
            setCheckBoxValue(cbSickleCellYes, cbSickleCellNo, "No");
            setCheckBoxValue(cbHerinasYes, cbHerinasNo, "No");
            setCheckBoxValue(cbGenitalDisordersYes, cbGenitalDisordersNo, "No");
            setCheckBoxValue(cbPregnancyYes, cbPregnancyNo, "No");

            setCheckBoxValue(cbSleepproblemYes, cbSleepproblemNo, "No");
            setCheckBoxValue(cbDoyouSmokeYes, cbDoyouSmokeNo, "No");
            setCheckBoxValue(cbSurgeriesYes, cbSurgeriesNo, "No");
            setCheckBoxValue(cbInfectiousYes, cbInfectiousNo, "No");
            setCheckBoxValue(cbDigestiveDisordersYes, cbDigestiveDisordersNo, "No");
            setCheckBoxValue(cbLossofconsciousnessYes, cbLossofconsciousnessNo, "No");
            setCheckBoxValue(cbPsychiatricProblemYes, cbPsychiatricProblemNo, "No");
            setCheckBoxValue(cbDepressionYes, cbDepressionNo, "No");
            setCheckBoxValue(cbAttemptedsuicideYes, cbAttemptedsuicideNo, "No");
            setCheckBoxValue(cbLossofmemoryYes, cbLossofmemoryNo, "No");
            setCheckBoxValue(cbBalanceProblemsYes, cbBalanceProblemsNo, "No");
            setCheckBoxValue(cbSevereHeadAchesYes, cbSevereHeadAchesNo, "No");



            setCheckBoxValue(cbRestrictedMobilityYes, cbRestrictedMobilityNo, "No");
            setCheckBoxValue(cbBackJointProblemYes, cbBackJointProblemNo, "No");
            setCheckBoxValue(cbAmputationYes, cbAmputationNo, "No");
            setCheckBoxValue(cbFracturesDislocationYes, cbFracturesDislocationNo, "No");
            setCheckBoxValue(cbCovidYes, cbCovidNo, "No");
            setCheckBoxValue(cbRepatriatedYes, cbRepatriatedNo, "No");
            setCheckBoxValue(cbHospitalizedYes, cbHospitalizedNo, "No");
            //setCheckBoxValue(cbSeaDutyYes, cbSeaDutyNo, "No");
            //setCheckBoxValue(cbRevokeYes, cbRevokeNo, "No");
            //setCheckBoxValue(cbConsiderDiseaseYes, cbConsiderDiseaseNo, "No");
            //setCheckBoxValue(cbFitToPerformDuriesYes, cbFitToPerformDuriesNo, "Yes");

            //setCheckBoxValue(cbAllergicToAnyMedicationYes, cbAllergicToAnyMedicationNo, "No");
            //setCheckBoxValue(cbAllergicAlternativeSuplimentYes, cbAllergicAlternativeSuplimentNo, "No");


            //PHYSICAL EXPLORATION


            setCheckBoxValue(cbHeadYes, cbHeadNo, "Yes");
            setCheckBoxValue(cbMouthYes, cbMouthNo, "Yes");
            setCheckBoxValue(cbDental, cbDentalNo, "Yes");
            setCheckBoxValue(cbEars, cbEarsNo, "Yes");
            setCheckBoxValue(cbTympanic, cbTympanicNo, "Yes");
            setCheckBoxValue(cbEyes, cbEyesNo, "Yes");
            setCheckBoxValue(cbPupils, cbPupilsNo, "Yes");
            setCheckBoxValue(cbOfThalmoscopy, cbOfThalmoscopyNo, "Yes");
            setCheckBoxValue(cbEyeMovement, cbEyeMovementNo, "Yes");
            setCheckBoxValue(cbLungs, cbLungsNo, "Yes");
            setCheckBoxValue(cbBreast, cbBreastNo, "Yes");
            setCheckBoxValue(cbHeart, cbHeartNo, "Yes");
            setCheckBoxValue(cbSkin, cbSkinNo, "Yes");
            setCheckBoxValue(cbVaricoseVenis, cbVaricoseVenisNo, "Yes");
            setCheckBoxValue(cbVascular, cbVascularNo, "Yes");
            setCheckBoxValue(cbAbnomen, cbAbnomenNo, "Yes");
            setCheckBoxValue(cbHernias, cbHerniasNo, "Yes");
            setCheckBoxValue(cbAnus, cbAnusNo, "Yes");
            setCheckBoxValue(cbGu, cbGuNo, "Yes");
            setCheckBoxValue(cbUpper, cbUpperNo, "Yes");
            setCheckBoxValue(cbSpine, cbSpineNo, "Yes");
            setCheckBoxValue(cbNeurologic, cbNeurologicNo, "Yes");
            setCheckBoxValue(cbPsychiatric, cbPsychiatricNo, "Yes");
            setCheckBoxValue(cbGeneralAppearance, cbGeneralAppearanceNo, "Yes");


            //DIAGNOSTIC TEST AND RESULTS 
            setCheckBoxValue(cbHemogram, cbHidden, "Yes");
            txtHemogramNormal.Text = "X";

            setCheckBoxValue(cbLipid, cbHidden, "Yes");
            txtLipidNormal.Text = "X";

            setCheckBoxValue(cbCreatinine, cbHidden, "Yes");
            txtCreatinineNormal.Text = "X";

            setCheckBoxValue(cbCholesterol, cbHidden, "Yes");
            txtCholesterolNormal.Text = "X";

            setCheckBoxValue(cbTriglycerides, cbHidden, "Yes");
            txtTriglyceridesNormal.Text = "X";

            setCheckBoxValue(cbGlucose, cbHidden, "Yes");
            txtGlucoseNormal.Text = "X";

            setCheckBoxValue(cbNitrogen, cbHidden, "Yes");
            txtNitrogenNormal.Text = "X";

            setCheckBoxValue(cbRhTyping, cbHidden, "No");
            txtRhTypingNormal.Text = "+";

            setCheckBoxValue(cbHiv, cbHidden, "Yes");
            txtHivNormal.Text = "X";

            setCheckBoxValue(cbVdrl, cbHidden, "Yes"); ;
            txtVdrlNormal.Text = "X";

            setCheckBoxValue(cbGch, cbHidden, "Yes");
            txtGchNormal.Text = "N/A";

            setCheckBoxValue(cbGeneralUrien, cbHidden, "Yes");
            txtGeneralUrineNormal.Text = "X";

            setCheckBoxValue(cbStool, cbHidden, "Yes");
            txtStoolNormal.Text = "X";

            setCheckBoxValue(cbDrugtest, cbHidden, "Yes");
            txtDrugTestNormal.Text = "X";

            setCheckBoxValue(cbAlcohol, cbHidden, "Yes");
            txtAlcoholNormal.Text = "X";

            setCheckBoxValue(cbBreast, cbHidden, "No");
            txtBreastExaminationNormal.Text = "N/A";

            setCheckBoxValue(cbPapTest, cbHidden, "NO");
            txtPaptestJNormal.Text = "N/A";

            setCheckBoxValue(cbPsa, cbHidden, "No");
            txtPsaNormal.Text = "N/A";
            setCheckBoxValue(cbXray, cbHidden, "No");
            txtXrayObservation.Text = "NORMAL";
            setCheckBoxValue(cbEkg, cbHidden, "Yes");

            txtEkgObservation.Text = "NORMAL";

            txtSarsCovidByAntigens.Text = "";

            txtNameOfWitness.Text = "MARIA VICTORIA T. NOHAY";

            txtNameOfWitness2.Text = "MARIA VICTORIA T. NOHAY";


            txtPhysicianName.Text = "MA. LUCIA B. LAGUIMUN, M.D.  -  License No. 0077460";

            //

            dtXrayDate.Value = DateTime.Now;
            checkBox109.Checked = false;


            dtEkg.Value = DateTime.Now;
            checkBox110.Checked = false;


            //dtUndergoingExamination.Value = DateTime.Now;
            //checkBox107.Checked = false;

            txtStaetementDay.Text = "";
            txtStaetementMonth.Text = "";
            txtStaetementYear.Text = "";


            txtp4Day.Text = "";
            txtp4Month.Text = "";
            txtp4Year.Text = "";

            setRadioButtonValue(rbFitForLookOut, "Yes");

        }


        //public void searchPatient(string keyWord)
        //{
        //    try
        //    {

        //        DataClasses1DataContext db = new DataClasses1DataContext(Database.connectionString);
        //        var i = db.PANAMA_SELECT(keyWord).FirstOrDefault();


        //        if (i != null)
        //        {

        //            txtFullaname.Text = i.Fullname;
        //            txtPersonundergoingExamination.Text = i.Fullname;
        //            txtUndergoingExamination.Text = i.Fullname;

        //            txtSpecimenNo.Text = i.specimen_no;


        //            txtHomeAddress.Text = i.HomeAddress;
        //            txtDepartment.Text = i.Department;
        //            txtPosition.Text = i.position;
        //            txtSex.Text = i.gender;
        //            //dateBirth.Text = i.birthdate;
        //            //
        //            DateTime bdate = Convert.ToDateTime(i.birthdate);
        //            txtbDay.Text = bdate.Day.ToString();
        //            txtBMonth.Text = bdate.ToString("MMM");
        //            txtBYear.Text = bdate.Year.ToString();

        //            txtPassportNumber.Text = i.PassportSeamanBookNo;
        //            PatientPicture.Image = ImageUtil.bytetoimage(i.picture.ToArray());

        //            txtPerformLookout.Text = i.LookOutDuties;
        //            txtRoutine.Text = i.EmergencyDuties;


        //            newItem();


        //            if (i.countvalidator > 0)
        //            {

        //                txtRhType.Text = i.RhTypingProfile;

        //                if (i.TypeOfShip != null)
        //                {

        //                    switch (i.TypeOfShip.ToLower())
        //                    {
        //                        case "container":
        //                            rbContainer.Checked = true;
        //                            break;
        //                        case "tanker":
        //                            rbTanker.Checked = true;
        //                            break;
        //                        case "passenger":
        //                            rbPassener.Checked = true;
        //                            break;

        //                        default:
        //                            rbTypeOfShipOther.Checked = true;
        //                            txtTypeShipOther.Text = i.TypeOfShip;
        //                            break;
        //                    }

        //                }


        //                if (txtTypeShipOther.Text != "")
        //                {
        //                    rbContainer.Checked = false;
        //                    rbTanker.Checked = false;
        //                    rbPassener.Checked = false;
        //                    rbTypeOfShipOther.Checked = true;
        //                }



        //                if (i.TradeArea != null)
        //                {
        //                    switch (i.TradeArea.ToLower())
        //                    {
        //                        case "coastal":
        //                            rbCoastal.Checked = true;
        //                            break;
        //                        case "tropical":
        //                            rbTropical.Checked = true;
        //                            break;
        //                        case "worldwide":
        //                            rbWorldWide.Checked = true;
        //                            break;
        //                        default:
        //                            // TO DO
        //                            break;
        //                    }
        //                }
        //                //EXAMINEE PERSONAL DECLARATION
        //                setCheckBoxValue(cbHighBloodPressureYes, cbHighBloodPressureNo, i.HighBloodPressure);
        //                setCheckBoxValue(cbEyeproblemYes, cbEyeproblemNo, i.Eyeproblem);
        //                setCheckBoxValue(cbEarNoseThroatYes, cbEarNoseThroatNo, i.EarNoseThroat);
        //                setCheckBoxValue(cbHeartSurgeryYes, cbHeartSurgeryNo, i.HeartSurgery);
        //                setCheckBoxValue(cbVaricoseveinsYes, cbVaricoseveinsNo, i.Varicoseveins);
        //                setCheckBoxValue(cbAsthmaBronchitisYes, cbAsthmaBronchitisNo, i.AsthmaBronchitis);
        //                setCheckBoxValue(cbBloodDisorderYes, cbBloodDisorderNo, i.BloodDisorder);
        //                setCheckBoxValue(cbDiabetesYes_, cbDiabetesNo, i.Diabetes);
        //                setCheckBoxValue(cbThyroidProblemYes, cbThyroidProblemNo, i.ThyroidProblem);
        //                setCheckBoxValue(cbDigestiveDisordersYes, cbDigestiveDisordersNo, i.DigestiveDisorders);
        //                setCheckBoxValue(cbKidneyDisordersYes, cbKidneyDisordersNo_, i.KidneyDisorders);
        //                setCheckBoxValue(cbSkinProblemYes, cbSkinProblemNo, i.SkinProblem);
        //                setCheckBoxValue(cbAllergiesYes, cbAllergiesNo, i.Allergies);
        //                setCheckBoxValue(cbEpilipsyYes, cbEpilipsyNo, i.Epilipsy);
        //                setCheckBoxValue(cbSickleCellYes, cbSickleCellNo, i.SickleCell);
        //                setCheckBoxValue(cbHerinasYes, cbHerinasNo, i.Herinas);
        //                setCheckBoxValue(cbGenitalDisordersYes, cbGenitalDisordersNo, i.GenitalDisorders);
        //                setCheckBoxValue(cbPregnancyYes, cbPregnancyNo, i.Pregnancy);

        //                setCheckBoxValue(cbSleepproblemYes, cbSleepproblemNo, i.Sleepproblem);
        //                setCheckBoxValue(cbDoyouSmokeYes, cbDoyouSmokeNo, i.DoyouSmoke);
        //                setCheckBoxValue(cbSurgeriesYes, cbSurgeriesNo, i.Surgeries);
        //                setCheckBoxValue(cbInfectiousYes, cbInfectiousNo, i.Infectious);
        //                setCheckBoxValue(cbDigestiveDisordersYes, cbDigestiveDisordersNo, i.DizzinessFainting);
        //                setCheckBoxValue(cbLossofconsciousnessYes, cbLossofconsciousnessNo, i.Lossofconsciousness);
        //                setCheckBoxValue(cbPsychiatricProblemYes, cbPsychiatricProblemNo, i.PsychiatricProblem);
        //                setCheckBoxValue(cbDepressionYes, cbDepressionNo, i.Depression);
        //                setCheckBoxValue(cbLossofmemoryYes, cbLossofmemoryNo, i.Attemptedsuicide);


        //                setCheckBoxValue(cbRestrictedMobilityYes, cbRestrictedMobilityNo, i.RestrictedMobility);
        //                setCheckBoxValue(cbBackJointProblemYes, cbBackJointProblemNo, i.BackJointProblem);
        //                setCheckBoxValue(cbAmputationYes, cbAmputationNo, i.Amputation);
        //                setCheckBoxValue(cbFracturesDislocationYes, cbFracturesDislocationNo, i.FracturesDislocation);
        //                setCheckBoxValue(cbCovidYes, cbCovidNo, i.Covid19);
        //                setCheckBoxValue(cbRepatriatedYes, cbRepatriatedNo, i.Repatriated);
        //                setCheckBoxValue(cbHospitalizedYes, cbHospitalizedNo, i.Hospitalized);
        //                setCheckBoxValue(cbSeaDutyYes, cbSeaDutyNo, i.SeaDuty);
        //                setCheckBoxValue(cbRevokeYes, cbRevokeNo, i.Revoke);
        //                setCheckBoxValue(cbConsiderDiseaseYes, cbConsiderDiseaseNo, i.ConsiderDisease);
        //                setCheckBoxValue(cbFitToPerformDuriesYes, cbFitToPerformDuriesNo, i.FitToPerformDuries);

        //                setCheckBoxValue(cbAllergicToAnyMedicationYes, cbAllergicToAnyMedicationNo, i.AllergicToAnyMedication);
        //                setCheckBoxValue(cbAllergicAlternativeSuplimentYes, cbAllergicAlternativeSuplimentNo, i.AlternativeSupliment);

        //                txtAlternativeComment1.Text = i.AlternativeSuplimentComment1;
        //                txtAlternativeComment2.Text = i.AlternativeSuplimentComment2;
        //                txtAlternativeComment3.Text = i.AlternativeSuplimentComment3;
        //                txtAlternativeComment4.Text = i.AlternativeSuplimentComment4;
        //                txtAlternativeComment5.Text = i.AlternativeSuplimentComment5;
        //                txtAlternativeComment6.Text = i.AlternativeSuplimentComment6;
        //                setCheckBoxValue(cbTakenMedicationsYes, cbTakenMedicationsNo, i.TakenMedications);
        //                txtmedicationsComment1.Text = i.TakenMedicationsComment1;
        //                txtmedicationsComment2.Text = i.TakenMedicationsComment2;
        //                txtmedicationsComment3.Text = i.TakenMedicationsComment3;
        //                txtmedicationsComment4.Text = i.TakenMedicationsComment4;
        //                txtmedicationsComment5.Text = i.TakenMedicationsComment5;
        //                //txtmedicationsComment6.Text = i.TakenMedicationsComment6;
        //                txtExamineeComment1.Text = i.Comment1;
        //                txtExamineeComment2.Text = i.Comment2;
        //                txtExamineeComment3.Text = i.Comment3;
        //                txtExamineeComment4.Text = i.Comment4;
        //                txtExamineeComment5.Text = i.Comment5;


        //                // Data Related  to covid
        //                setCheckBoxValue(cbContactInCovidPositiveYes, cbContactInCovidPositiveNo, i.ContactInCovidPositive);
        //                setCheckBoxValue(cbCovidTestYes, cbCovidTestNo, i.CovidTest);
        //                validateDate(i.CovidDateTest, dtCovidDateTest, checkBox106);
        //                setCheckBoxValue(cbHadFeverLast30DaysYes, cbHadFeverLast30DaysNo, i.HadFeverLast30Days);
        //                setCheckBoxValue(cbVaccinationCovidYes, cbVaccinationCovidNo, i.VaccinationCovid);
        //                txtVaccineType.Text = i.VaccineType;
        //                txtNumberofDoses.Text = i.NumberofDoses;
        //                txtBooster.Text = i.Booster;

        //                //STATEMENT
        //                //txtPersonundergoingExamination.Text = i.PersonundergoingExamination;
        //                //validateDate(i.UndergoingExaminationDate, dtUndergoingExamination, checkBox107);
        //                string s = i.fitness_date;
        //                string[] d = s.Split('/');

        //                txtStaetementDay.Text = d[0];
        //                txtStaetementMonth.Text = Convert.ToDateTime(i.fitness_date).ToString("MMM");
        //                txtStaetementYear.Text = d[2];


        //                txtNameOfWitness.Text = i.NameOfWitness;
        //                txtDoctorName.Text = i.DoctorName;
        //                //txtUndergoingExamination.Text = i.UndergoingExamination;
        //                //validateDate(i.UndergoingExaminationDate2, dtUndergoingExamination2, checkBox108);

        //                string p4 = i.fitness_date;
        //                string[] d4 = s.Split('/');

        //                txtp4Day.Text = d4[0];
        //                txtp4Month.Text = Convert.ToDateTime(i.fitness_date).ToString("MMM");
        //                txtp4Year.Text = d4[2];






        //                txtNameOfWitness2.Text = i.NameOfWitness2;
        //                txtPreviousMedical.Text = i.PreviousMedical;

        //                //MEDICAL EXAMINATION
        //                txtHeight.Text = i.Height;
        //                txtWeight.Text = i.Weight;
        //                txtBMI.Text = i.BMI;
        //                txtOxygen.Text = i.Oxygen;
        //                txtHeartRate.Text = i.HeartRate;
        //                txtRespiratory.Text = i.Respiratory;
        //                txtBloodPressure.Text = i.BloodPressure;
        //                txtDiastolic.Text = i.Diatolic;
        //                txtUnaidedRightEyeDistant.Text = i.UnaidedRightEyeDistant;
        //                txtUnAidedLeftEyeDistant.Text = i.UnAidedLeftEyeDistant;
        //                txtUnAidedBonocularDistant.Text = i.UnAidedBonocularDistant;
        //                txtAidedRightEyeDistant.Text = i.AidedRightEyeDistant;
        //                txtAidedLeftEyeDistant.Text = i.AidedLeftEyeDistant;
        //                txtAidedBinocularDistant.Text = i.AidedBinocularDistant;
        //                txtUnaidedRightEyeShort.Text = i.UnaidedRightEyeShort;
        //                txtUnAidedLeftEyeShort.Text = i.UnAidedLeftEyeShort;
        //                txtUnAidedBonocularShort.Text = i.UnAidedBonocularShort;
        //                txtAidedRightEyeShort.Text = i.AidedRightEyeShort;
        //                txtAidedLeftEyeShort.Text = i.AidedLeftEyeShort;
        //                txtAidedBinocularShort.Text = i.AidedBinocularShort;


        //                setCheckBoxValue(cbNonTestedColorVision, cbHidden, i.NonTestedColorVision);
        //                setCheckBoxValue(cbNormalColorVision, cbHidden, i.NormalColorVision);
        //                setCheckBoxValue(cbDoubtfulColorVision, cbHidden, i.DoubtfulColorVision);
        //                setCheckBoxValue(cbDefectiveColorVision, cbHidden, i.DefectiveColorVision);


        //                txtNormalRightEye.Text = i.NormalRightEye;
        //                txtNormalLeftEye.Text = i.NormalLeftEye;
        //                txtDefectiveRightEye.Text = i.DefectiveRightEye;
        //                txtDefectiveLeftEye.Text = i.DefectiveLeftEye;
        //                txtSightComment.Text = "ISHIHARA 38";
        //                txt500HzRightEar.Text = i._500HzRightEar;
        //                txt1kRightEar.Text = i._1kRightEar;
        //                txt2kRightEar.Text = i._2kRightEar;
        //                txt3kRightEar.Text = i._3kRightEar;
        //                txt500HzLeftEar.Text = i._500HzLeftEar;
        //                txt1kLeftEar.Text = i._1kLeftEar;
        //                txt2kLeftEar.Text = i._2kLeftEar;
        //                txt3kLeftEar.Text = i._3kLeftEar;

        //                //PHYSICAL EXPLORATION
        //                setCheckBoxValue(cbHeadYes, cbHeadNo, i.Head);
        //                setCheckBoxValue(cbMouthYes, cbMouthNo, i.Mouth);
        //                setCheckBoxValue(cbDental, cbDentalNo, i.Dental);
        //                setCheckBoxValue(cbEars, cbEarsNo, i.Ears);
        //                setCheckBoxValue(cbTympanic, cbTympanicNo, i.Tympanic);
        //                setCheckBoxValue(cbEyes, cbEyesNo, i.Eyes);
        //                setCheckBoxValue(cbPupils, cbPupilsNo, i.Pupils);
        //                setCheckBoxValue(cbOfThalmoscopy, cbOfThalmoscopyNo, i.OfThalmoscopy);
        //                setCheckBoxValue(cbEyeMovement, cbEyeMovementNo, i.EyeMovement);
        //                setCheckBoxValue(cbLungs, cbLungsNo, i.Lungs);
        //                setCheckBoxValue(cbBreast, cbBreastNo, i.Breast);
        //                setCheckBoxValue(cbHeart, cbHeartNo, i.Heart);
        //                setCheckBoxValue(cbSkin, cbSkinNo, i.Skin);
        //                setCheckBoxValue(cbVaricoseVenis, cbVaricoseVenisNo, i.VaricoseVenis);
        //                setCheckBoxValue(cbVascular, cbVascularNo, i.Vascular);
        //                setCheckBoxValue(cbAbnomen, cbAbnomenNo, i.Abdomen);
        //                setCheckBoxValue(cbHernias, cbHerniasNo, i.Hernias);
        //                setCheckBoxValue(cbAnus, cbAnusNo, i.Anus);
        //                setCheckBoxValue(cbGu, cbGuNo, i.Gu);
        //                setCheckBoxValue(cbUpper, cbUpperNo, i.Upper);
        //                setCheckBoxValue(cbSpine, cbSpineNo, i.Spine);
        //                setCheckBoxValue(cbNeurologic, cbNeurologicNo, i.Neurologic);
        //                setCheckBoxValue(cbPsychiatric, cbPsychiatricNo, i.Psychiatric);
        //                setCheckBoxValue(cbGeneralAppearance, cbGeneralAppearanceNo, i.GeneralAppearance);
        //                txtPhysicalExploration1.Text = i.PhysicalExplorationComment1;

        //                //DIAGNOSTIC TEST AND RESULTS 
        //                setCheckBoxValue(cbHemogram, cbHidden, i.Hemogram);
        //                txtHemogramNormal.Text = i.HemogramNormal;
        //                txtHemogramAbNormal.Text = i.HemogramAbNormal;
        //                txtHemogramOservation.Text = i.HemogramOservation;
        //                setCheckBoxValue(cbLipid, cbHidden, i.Lipid);
        //                txtLipidNormal.Text = i.LipidNormal;
        //                txtLipidAbNormal.Text = i.LipidAbNormal; ;
        //                txtLipidObservation.Text = i.LipidObservation;
        //                setCheckBoxValue(cbCreatinine, cbHidden, i.Creatinine);
        //                txtCreatinineNormal.Text = i.CreatinineNormal;
        //                txtCreatinineAbnormal.Text = i.CreatinineAbnormal;
        //                txtCreatinineObservation.Text = i.CreatinineObservation;
        //                setCheckBoxValue(cbCholesterol, cbHidden, i.Cholesterol);
        //                txtCholesterolNormal.Text = i.CholesterolNormal;
        //                txtCholesterolAbnormal.Text = i.CholesterolAbnormal;
        //                txtCholesterolObservation.Text = i.CholesterolObservation;
        //                setCheckBoxValue(cbTriglycerides, cbHidden, i.Triglycerides);
        //                txtTriglyceridesNormal.Text = i.TriglyceridesNormal;
        //                txtTriglyceridesAbnormal.Text = i.TriglyceridesAbnormal;
        //                txtTriglyceridesObservation.Text = i.TriglyceridesObservation;
        //                setCheckBoxValue(cbGlucose, cbHidden, i.Glucose);
        //                txtGlucoseNormal.Text = i.GlucoseNormal;
        //                txtGlucoseAbNormal.Text = i.GlucoseAbNormal;
        //                txtGlucoseObservation.Text = i.GlucoseObservation;
        //                setCheckBoxValue(cbNitrogen, cbHidden, i.Nitrogen);
        //                txtNitrogenNormal.Text = i.NitrogenNormal;
        //                txtNitrogenAbnormal.Text = i.NitrogenAbnormal;
        //                txtNitrogenObservation.Text = i.NitrogenObservation;
        //                setCheckBoxValue(cbRhTyping, cbHidden, i.RhTyping);
        //                txtRhTypingNormal.Text = i.RhTypingNormal;
        //                txtRhTypingAbnormal.Text = i.RhTypingAbnormal;
        //                txtRhTypingObservation.Text = i.RhTypingObservation;
        //                setCheckBoxValue(cbHiv, cbHidden, i.Hiv);
        //                txtHivNormal.Text = i.HivNormal;
        //                txtHivAbnormal.Text = i.HivAbnormal;
        //                txtHivObservation.Text = i.HivObservation;
        //                setCheckBoxValue(cbVdrl, cbHidden, i.Vdrl);
        //                txtVdrlNormal.Text = i.VdrlNormal;
        //                txtVdrlAbnormal.Text = i.VdrlAbnormal;
        //                txtVdrlObservation.Text = i.VdrlObservation;
        //                setCheckBoxValue(cbGch, cbHidden, i.Gch);
        //                txtGchNormal.Text = i.GchNormal.Replace("NA", "N/A");
        //                txtGchAbnormal.Text = i.GchAbnormal;
        //                txtGchObservation.Text = i.GchObservation;
        //                setCheckBoxValue(cbGeneralUrien, cbHidden, i.GeneralUrien);
        //                txtGeneralUrineNormal.Text = i.GeneralUrineNormal;
        //                txtGeneralUrineAbNormal.Text = i.GeneralUrineAbNormal;
        //                txtGeneralUrineObservation.Text = i.GeneralUrineObservation;
        //                setCheckBoxValue(cbStool, cbHidden, i.Stool);
        //                txtStoolNormal.Text = i.StoolNormal;
        //                txtStoolAbNormal.Text = i.StoolAbNormal;
        //                txtStoolObservation.Text = i.StoolObservation;
        //                setCheckBoxValue(cbDrugtest, cbHidden, i.Drugtest);
        //                txtDrugTestNormal.Text = i.DrugTestNormal;
        //                txtDrugTestAbNormal.Text = i.DrugTestAbNormal;
        //                txtDrugTestObservation.Text = i.DrugTestObservation;
        //                setCheckBoxValue(cbAlcohol, cbHidden, i.Alcohol);
        //                txtAlcoholNormal.Text = i.AlcoholNormal;
        //                txtAlcoholAbNormal.Text = i.AlcoholAbNormal;
        //                txtAlcoholObservation.Text = i.AlcoholObservation;
        //                setCheckBoxValue(cbBreast, cbHidden, i.Breast);
        //                txtBreastExaminationNormal.Text = i.BreastExaminationNormal.Replace("NA", "N/A");
        //                txtBreastExaminationAbNormal.Text = i.BreastExaminationAbNormal;
        //                txtBreastExaminationObservation.Text = i.BreastExaminationObservation;
        //                setCheckBoxValue(cbPapTest, cbHidden, i.PapTest);
        //                txtPaptestJNormal.Text = i.PaptestJNormal.Replace("NA", "N/A");
        //                txtPapAbnormal.Text = i.PapAbnormal;
        //                txtPapObservation.Text = i.PapObservation;
        //                setCheckBoxValue(cbPsa, cbHidden, i.Psa);
        //                txtPsaNormal.Text = i.PsaNormal.Replace("NA", "N/A");
        //                txtPsaAbNormal.Text = i.PsaAbNormal;
        //                txtPsaObservation.Text = i.PsaObservation;
        //                setCheckBoxValue(cbXray, cbHidden, i.Xray);

        //                validateDate(i.XrayDate, dtXrayDate, checkBox109);
        //                txtXrayObservation.Text = i.XrayObservation;
        //                setCheckBoxValue(cbEkg, cbHidden, i.Ekg);
        //                validateDate(i.Ekg, dtEkg, checkBox110);
        //                txtEkgObservation.Text = i.EkgObservation;


        //                txtSarsCovidByPcr.Text = i.SarsCovidByPcr;
        //                txtSarsCovidByAntigens.Text = i.SarsCovidByAntigens;


        //                txtOtherDiagnosticTest.Text = i.OtherTest;
        //                txtOtherDiagnosticResult.Text = i.OtherTestResult;
        //                txtOtherDiagnosticComment1.Text = i.DiagnosticComment1;
        //                txtOtherDiagnosticComment2.Text = i.DiagnosticComment2;
        //                txtOtherDiagnosticComment3.Text = i.DiagnosticComment3;
        //                txtOtherDiagnosticComment4.Text = i.DiagnosticComment4;


        //                //ASSESSMENT OF FITNESS FOR SERVICE AT SEA  /// RESULT MAIN
        //                string reco = "";
        //                if (i.recommendation.ToLower().Equals("FIT FOR SEA DUTY"))
        //                {
        //                    reco = "Yes";
        //                }
        //                else
        //                {
        //                    reco = "No";
        //                }
        //                setRadioButtonValue(rbFitForLookOut, reco);


        //                string deck_srvc_flag_ = i.deck_srvc_flag.ToString();
        //                if (deck_srvc_flag_ == "Y") { cbDeckServiceFit.Checked = true; } else if (deck_srvc_flag_ == "N") { cbDeckServiceUnFit.Checked = true; } else { cbDeckServiceFit.Checked = false; cbDeckServiceUnFit.Checked = false; }

        //                string t_engine_srvc_flag_ = i.engine_srvc_flag.ToString();
        //                if (t_engine_srvc_flag_ == "Y") { this.cbEngineFit.Checked = true; } else if (t_engine_srvc_flag_ == "N") { this.cbEngineUnFit.Checked = true; } else { cbEngineFit.Checked = false; cbEngineUnFit.Checked = false; }

        //                string t_catering_srvc_flag_ = i.catering_srvc_flag.ToString();
        //                if (t_catering_srvc_flag_ == "Y") { this.cbCateringFit.Checked = true; } else if (t_catering_srvc_flag_ == "N") { this.cbCateringUnFit.Checked = true; } else { cbCateringFit.Checked = false; cbCateringUnFit.Checked = false; }

        //                string t_other_srvc_flag_ = i.other_srvc_flag.ToString();
        //                if (t_other_srvc_flag_ == "Y") { this.cbOtherServiceFit.Checked = true; } else if (t_other_srvc_flag_ == "N") { this.cbOtherUnFit.Checked = true; } else { cbOtherServiceFit.Checked = false; cbOtherUnFit.Checked = false; }



        //                setCheckBoxValue(cbWithOutRestrictions, cbHidden, i.WithOutRestrictions);
        //                setCheckBoxValue(cbWithRestrictions, cbHidden, i.WithRestrictions);
        //                setCheckBoxValue(cbVisualAidYes, cbHidden, i.cbVisualAidRequiredYes);
        //                setCheckBoxValue(cbVisualAidRequiredNo, cbHidden, i.cbVisualAidRequiredNo);
        //                txtAssessmentComment1.Text = i.assessmentComment1;
        //                txtAssessmentComment2.Text = i.assessmentComment2;
        //                txtAssessmentComment3.Text = i.assessmentComment3;
        //                txtAssessmentComment4.Text = i.assessmentComment4;
        //                txtAssessmentComment5.Text = i.assessmentComment5;
        //                //validateDate(i.MedicalCertificateExpiration, dtMedicalCertificateExpiration, checkBox111);
        //                //validateDate(i.MedicalCertificateIssued, dtMedicalCertificateIssued, checkBox112);

        //                string[] e = i.valid_until.Split('/');
        //                expirateDay.Text = e[0];
        //                expirateMonth.Text = Convert.ToDateTime(i.fitness_date).ToString("MMM");
        //                expirateYear.Text = e[2];


        //                string[] iss = i.fitness_date.Split('/');
        //                issuedDay.Text = iss[0];
        //                issuedMonth.Text = Convert.ToDateTime(i.fitness_date).ToString("MMM");
        //                issuedYear.Text = iss[2];




        //                txtNumberOfMedicalCertificate.Text = i.NumberOfMedicalCertificate;
        //                txtPhysicianName.Text = "MA. LUCIA B. LAGUIMUN, M.D.  -  License No. 77460";

        //            }

        //        }
        //        else
        //        {
        //            RJMessageBox.Show("This patient have no record yet from medical software", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
        //        RJMessageBox.Show(string.Format("An error occured {0}", ex.Message), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public void savePatient(bool isfromBtnSave)
        {
            //string uID = Utils.UID.Generate();

            //if (txtPapin.Text != "")
            //{
            //    string typeOfShip = "";
            //    if (rbContainer.Checked)
            //    {
            //        typeOfShip = "Container";
            //    }
            //    else if (rbTanker.Checked)
            //    {
            //        typeOfShip = "Tanker";
            //    }
            //    else if (rbPassener.Checked)
            //    {
            //        typeOfShip = "Passenger";
            //    }
            //    else if (rbTypeOfShipOther.Checked)
            //    {
            //        typeOfShip = txtTypeShipOther.Text;
            //    }


            //    string tradeArea = "";
            //    if (rbCoastal.Checked)
            //    {
            //        tradeArea = "Coastal";
            //    }
            //    else if (rbTropical.Checked)
            //    {
            //        tradeArea = "Tropical";
            //    }
            //    else if (rbWorldWide.Checked)
            //    {
            //        tradeArea = "WorldWide";
            //    }

            //    string papin = txtPapin.Text; //Get the papin  fron tag of txtFullaname;

            //    Patients_Model patientModel = new Patients_Model();
            //    patientModel.SavePatient(papin, txtRhType.Text, txtPerformLookout.Text, txtRoutine.Text, typeOfShip, tradeArea);
            //    PanamaExamineeSave(papin, uID);
            //    PanamaDataRelatedCovidSave(papin, uID);
            //    PanamaStatementsSave(papin, uID);
            //    PanamaMedicalExaminationSave(papin, uID);
            //    PanamaPhysicalExplorationSave(papin, uID);
            //    PanamaDiagnosticTestSave(papin, uID);
            //    PanamaResultMainSave(papin, uID);//Assesment Table

            //    if (isfromBtnSave)
            //    {
            //        RJMessageBox.Show(txtFullaname.Text + "\n Data Successfully Save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}
        }

        //private void PanamaExamineeSave(string papin, string uid)
        //{
        //    PanamaExamineeModel examinee = new PanamaExamineeModel();
        //    examinee.Save(papin,
        //                   uid,
        //                   getCheckBoxValue(cbHighBloodPressureYes, cbHighBloodPressureNo),
        //                   getCheckBoxValue(cbEyeproblemYes, cbEyeproblemNo),
        //                   getCheckBoxValue(cbEarNoseThroatYes, cbEarNoseThroatNo),
        //                   getCheckBoxValue(cbHeartSurgeryYes, cbHeartSurgeryNo),
        //                   getCheckBoxValue(cbVaricoseveinsYes, cbVaricoseveinsNo),
        //                   getCheckBoxValue(cbAsthmaBronchitisYes, cbAsthmaBronchitisNo),
        //                   getCheckBoxValue(cbBloodDisorderYes, cbBloodDisorderNo),
        //                   getCheckBoxValue(cbDiabetesYes_, cbDiabetesNo),
        //                   getCheckBoxValue(cbThyroidProblemYes, cbThyroidProblemNo),
        //                   getCheckBoxValue(cbDigestiveDisordersYes, cbDigestiveDisordersNo),

        //                   getCheckBoxValue(cbKidneyDisordersYes, cbKidneyDisordersNo_),
        //                   getCheckBoxValue(cbSkinProblemYes, cbSkinProblemNo),
        //                   getCheckBoxValue(cbAllergiesYes, cbAllergiesNo),
        //                   getCheckBoxValue(cbEpilipsyYes, cbEpilipsyNo),
        //                   getCheckBoxValue(cbSickleCellYes, cbSickleCellNo),
        //                   getCheckBoxValue(cbHerinasYes, cbHerinasNo),
        //                   getCheckBoxValue(cbGenitalDisordersYes, cbGenitalDisordersNo),
        //                   getCheckBoxValue(cbPregnancyYes, cbPregnancyNo),

        //                   getCheckBoxValue(cbSleepproblemYes, cbSleepproblemNo),
        //                   getCheckBoxValue(cbDoyouSmokeYes, cbDoyouSmokeNo),
        //                   getCheckBoxValue(cbSurgeriesYes, cbSurgeriesNo),
        //                   getCheckBoxValue(cbInfectiousYes, cbInfectiousNo),
        //                   getCheckBoxValue(cbDigestiveDisordersYes, cbDigestiveDisordersNo),
        //                   getCheckBoxValue(cbLossofconsciousnessYes, cbLossofconsciousnessNo),
        //                   getCheckBoxValue(cbPsychiatricProblemYes, cbPsychiatricProblemNo),
        //                   getCheckBoxValue(cbDepressionYes, cbDepressionNo),
        //                   getCheckBoxValue(cbAttemptedsuicideYes, cbAttemptedsuicideNo),
        //                   getCheckBoxValue(cbLossofmemoryYes, cbLossofmemoryNo),
        //                   getCheckBoxValue(cbBalanceProblemsYes, cbBalanceProblemsNo),

        //                   getCheckBoxValue(cbSevereHeadAchesYes, cbSevereHeadAchesNo),
        //                   getCheckBoxValue(cbVasculardiseaseYes, cbVasculardiseaseNo),
        //                   getCheckBoxValue(cbRestrictedMobilityYes, cbRestrictedMobilityNo),
        //                   getCheckBoxValue(cbBackJointProblemYes, cbBackJointProblemNo),
        //                   getCheckBoxValue(cbAmputationYes, cbAmputationNo),
        //                   getCheckBoxValue(cbFracturesDislocationYes, cbFracturesDislocationNo),
        //                   getCheckBoxValue(cbCovidYes, cbCovidNo),
        //                   getCheckBoxValue(cbRepatriatedYes, cbRepatriatedNo),
        //                   getCheckBoxValue(cbHospitalizedYes, cbHospitalizedNo),
        //                   getCheckBoxValue(cbSeaDutyYes, cbSeaDutyNo),
        //                   getCheckBoxValue(cbRevokeYes, cbRevokeNo),
        //                   getCheckBoxValue(cbConsiderDiseaseYes, cbConsiderDiseaseNo),
        //                   getCheckBoxValue(cbFitToPerformDuriesYes, cbFitToPerformDuriesNo),
        //                   getCheckBoxValue(cbAllergicToAnyMedicationYes, cbAllergicToAnyMedicationNo),
        //                   getCheckBoxValue(cbAllergicAlternativeSuplimentYes, cbAllergicAlternativeSuplimentNo),
        //                   txtAlternativeComment1.Text,
        //                   getCheckBoxValue(cbTakenMedicationsYes, cbTakenMedicationsNo),
        //                   txtmedicationsComment1.Text,
        //                                 txtExamineeComment1.Text,
        //                                 txtExamineeComment2.Text,
        //                                 txtExamineeComment3.Text,
        //                                 txtExamineeComment4.Text,
        //                                 txtExamineeComment5.Text,
        //                                 txtAlternativeComment2.Text,
        //                                 txtAlternativeComment3.Text,
        //                                 txtAlternativeComment4.Text,
        //                                 txtAlternativeComment5.Text,
        //                                 txtmedicationsComment2.Text,
        //                                 txtmedicationsComment3.Text,
        //                                txtmedicationsComment4.Text,
        //    txtmedicationsComment5.Text,
        //    txtAlternativeComment6.Text);
        //}

        //private void PanamaDataRelatedCovidSave(string papin, string uid)
        //{
        //    PanamaDataRelatedCovidModel dataRelatedCovid = new PanamaDataRelatedCovidModel();
        //    dataRelatedCovid.Save(papin,
        //        uid,
        //        getCheckBoxValue(cbContactInCovidPositiveYes, cbContactInCovidPositiveNo),
        //        getCheckBoxValue(cbCovidTestYes, cbCovidTestNo),
        //        dtCovidDateTest.Text,
        //        getCheckBoxValue(cbHadFeverLast30DaysYes, cbHadFeverLast30DaysNo),
        //        getCheckBoxValue(cbVaccinationCovidYes, cbVaccinationCovidNo),
        //        txtVaccineType.Text,
        //        txtNumberofDoses.Text,
        //        txtBooster.Text);
        //}

        //private void PanamaStatementsSave(string papin, string uid)
        //{
        //    string d = string.Concat(txtStaetementDay.Text, "/", txtStaetementMonth.Text, "/", txtStaetementYear.Text);
        //    string p = string.Concat(txtp4Day.Text, "/", txtp4Month.Text, "/", txtp4Year.Text);
        //    PanamaStatementsModel statement = new PanamaStatementsModel();
        //    statement.Save(papin,
        //        uid,
        //        txtPersonundergoingExamination.Text,
        //       d,
        //        txtNameOfWitness.Text,
        //        txtDoctorName.Text,
        //        txtUndergoingExamination.Text,
        //        p,
        //        txtNameOfWitness2.Text,
        //        txtPreviousMedical.Text);
        //}

        //private void PanamaMedicalExaminationSave(string papin, string uid)
        //{
        //    PanamaMedicalExaminationModel medicalExamination = new PanamaMedicalExaminationModel();
        //    medicalExamination.Save(papin,
        //        uid,
        //        txtHeight.Text,
        //        txtWeight.Text,
        //        txtBMI.Text,
        //        txtOxygen.Text,
        //        txtHeartRate.Text,
        //        txtRespiratory.Text,
        //        txtBloodPressure.Text,
        //        txtDiastolic.Text,
        //        txtUnaidedRightEyeDistant.Text,
        //        txtUnAidedLeftEyeDistant.Text,
        //        txtUnAidedBonocularDistant.Text,
        //        txtAidedRightEyeDistant.Text,
        //        txtAidedLeftEyeDistant.Text,
        //        txtAidedBinocularDistant.Text,
        //        txtUnaidedRightEyeShort.Text,
        //        txtUnAidedLeftEyeShort.Text,
        //        txtUnAidedBonocularShort.Text,
        //        txtAidedRightEyeShort.Text,
        //        txtAidedLeftEyeShort.Text,
        //        txtAidedBinocularShort.Text,
        //        getCheckBoxValue(cbNonTestedColorVision, cbHidden),
        //        getCheckBoxValue(cbNormalColorVision, cbHidden),
        //        getCheckBoxValue(cbDoubtfulColorVision, cbHidden),
        //        getCheckBoxValue(cbDefectiveColorVision, cbHidden),
        //        txtNormalRightEye.Text,
        //        txtNormalLeftEye.Text,
        //        txtDefectiveRightEye.Text,
        //        txtDefectiveLeftEye.Text,
        //        txtSightComment.Text,
        //        txt500HzRightEar.Text,
        //        txt1kRightEar.Text,
        //        txt2kRightEar.Text,
        //        txt3kRightEar.Text,
        //        txt500HzLeftEar.Text,
        //        txt1kLeftEar.Text,
        //        txt2kLeftEar.Text,
        //        txt3kLeftEar.Text);

        //}

        //public void PanamaPhysicalExplorationSave(string papin, string uid)
        //{
        //    PanamaPhysicalExplorationModel physicalExploration = new PanamaPhysicalExplorationModel();
        //    physicalExploration.Save(papin, uid,
        //        getCheckBoxValue(cbHeadYes, cbHeadNo),
        //        getCheckBoxValue(cbMouthYes, cbMouthNo),
        //        getCheckBoxValue(cbDental, cbDentalNo),
        //        getCheckBoxValue(cbEars, cbEarsNo),
        //        getCheckBoxValue(cbTympanic, cbTympanicNo),
        //        getCheckBoxValue(cbEyes, cbEyesNo),
        //        getCheckBoxValue(cbPupils, cbPupilsNo),
        //        getCheckBoxValue(cbOfThalmoscopy, cbOfThalmoscopyNo),
        //        getCheckBoxValue(cbEyeMovement, cbEyeMovementNo),
        //        getCheckBoxValue(cbLungs, cbLungsNo),
        //        getCheckBoxValue(cbBreast, cbBreastNo),
        //        getCheckBoxValue(cbHeart, cbHeartNo),
        //        getCheckBoxValue(cbSkin, cbSkinNo),
        //        getCheckBoxValue(cbVaricoseVenis, cbVaricoseVenisNo),
        //        getCheckBoxValue(cbVascular, cbVascularNo),
        //        getCheckBoxValue(cbAbnomen, cbAbnomenNo),
        //        getCheckBoxValue(cbHernias, cbHerniasNo),
        //        getCheckBoxValue(cbAnus, cbAnusNo),
        //        getCheckBoxValue(cbGu, cbGuNo),
        //        getCheckBoxValue(cbUpper, cbUpperNo),
        //        getCheckBoxValue(cbSpine, cbSpineNo),
        //        getCheckBoxValue(cbNeurologic, cbNeurologicNo),
        //        getCheckBoxValue(cbPsychiatric, cbPsychiatricNo),
        //        getCheckBoxValue(cbGeneralAppearance, cbGeneralAppearanceNo),
        //        txtPhysicalExploration1.Text,
        //        txtPhysicalExploration2.Text,
        //        txtPhysicalExploration3.Text,
        //        txtPhysicalExploration4.Text);
        //}

        //public void PanamaDiagnosticTestSave(string papin, string uid)
        //{
        //    PanamaDiagnosticTestModel diagnostic = new PanamaDiagnosticTestModel();
        //    diagnostic.Save(papin, uid,
        //        getCheckBoxValue(cbHemogram, cbHidden),
        //        txtHemogramNormal.Text,
        //        txtHemogramAbNormal.Text,
        //        txtHemogramOservation.Text,
        //        getCheckBoxValue(cbLipid, cbHidden),
        //        txtLipidNormal.Text,
        //        txtLipidAbNormal.Text,
        //        txtLipidObservation.Text,
        //        getCheckBoxValue(cbCreatinine, cbHidden),
        //        txtCreatinineNormal.Text,
        //        txtCreatinineAbnormal.Text,
        //        txtCreatinineObservation.Text,
        //        getCheckBoxValue(cbCholesterol, cbHidden),
        //        txtCholesterolNormal.Text,
        //        txtCholesterolAbnormal.Text,
        //        txtCholesterolObservation.Text,
        //        getCheckBoxValue(cbTriglycerides, cbHidden),
        //        txtTriglyceridesNormal.Text,
        //        txtTriglyceridesAbnormal.Text,
        //        txtTriglyceridesObservation.Text,
        //        getCheckBoxValue(cbGlucose, cbHidden),
        //        txtGlucoseNormal.Text,
        //        txtGlucoseAbNormal.Text,
        //        txtGlucoseObservation.Text,
        //        getCheckBoxValue(cbNitrogen, cbHidden),
        //        txtNitrogenNormal.Text,
        //        txtNitrogenAbnormal.Text,
        //        txtNitrogenObservation.Text,
        //        getCheckBoxValue(cbRhTyping, cbHidden),
        //        txtRhTypingNormal.Text,
        //        txtRhTypingAbnormal.Text,
        //        txtRhTypingObservation.Text,
        //        getCheckBoxValue(cbHiv, cbHidden),
        //        txtHivNormal.Text,
        //        txtHivAbnormal.Text,
        //        txtHivObservation.Text,
        //        getCheckBoxValue(cbVdrl, cbHidden),
        //        txtVdrlNormal.Text,
        //        txtVdrlAbnormal.Text,
        //        txtVdrlObservation.Text,
        //        getCheckBoxValue(cbGch, cbHidden),
        //        txtGchNormal.Text.Replace("/", ""),
        //        txtGchAbnormal.Text,
        //        txtGchObservation.Text,
        //        getCheckBoxValue(cbGeneralUrien, cbHidden),
        //        txtGeneralUrineNormal.Text,
        //        txtGeneralUrineAbNormal.Text,
        //        txtGeneralUrineObservation.Text,
        //        getCheckBoxValue(cbStool, cbHidden),
        //        txtStoolNormal.Text,
        //        txtStoolAbNormal.Text,
        //        txtStoolObservation.Text,
        //        getCheckBoxValue(cbDrugtest, cbHidden),
        //        txtDrugTestNormal.Text,
        //        txtDrugTestAbNormal.Text,
        //        txtDrugTestObservation.Text,
        //        getCheckBoxValue(cbAlcohol, cbHidden),
        //        txtAlcoholNormal.Text,
        //        txtAlcoholAbNormal.Text,
        //        txtAlcoholObservation.Text,
        //        getCheckBoxValue(cbBreast, cbHidden),
        //        txtBreastExaminationNormal.Text.Replace("/", ""),
        //        txtBreastExaminationAbNormal.Text,
        //        txtBreastExaminationObservation.Text,
        //        getCheckBoxValue(cbPapTest, cbHidden),
        //        txtPaptestJNormal.Text.Replace("/", ""),
        //        txtPapAbnormal.Text,
        //        txtPapObservation.Text,
        //        getCheckBoxValue(cbPsa, cbHidden),
        //        txtPsaNormal.Text.Replace("/", ""),
        //        txtPsaAbNormal.Text,
        //        txtPsaObservation.Text,
        //        getCheckBoxValue(cbXray, cbHidden),
        //        dtXrayDate.Text,
        //        txtXrayObservation.Text,
        //        getCheckBoxValue(cbEkg, cbHidden),
        //        dtEkg.Text,
        //        txtEkgObservation.Text,
        //        txtSarsCovidByPcr.Text,
        //        txtSarsCovidByAntigens.Text,
        //        txtOtherDiagnosticTest.Text,
        //        txtOtherDiagnosticResult.Text,
        //        txtOtherDiagnosticComment1.Text,
        //        txtOtherDiagnosticComment2.Text,
        //        txtOtherDiagnosticComment3.Text,
        //        txtOtherDiagnosticComment4.Text);

        //}

        //private void PanamaResultMainSave(string papin, string uid)
        //{
        //    string expiration = string.Concat(expirateDay.Text, "-", expirateMonth.Text, "-", expirateYear.Text);
        //    string issued = string.Concat(issuedDay.Text, "-", issuedMonth.Text, "-", issuedYear.Text);

        //    PanamaResultMainModel resultMain = new PanamaResultMainModel();
        //    resultMain.Save(uid,
        //                    papin,
        //                   getRadioButtonValue(rbFitForLookOut),
        //                   getRadioButtonValue(rbNonFitForLookOut),
        //                   getCheckBoxValue(cbDeckServiceFit, cbHidden),
        //                   getCheckBoxValue(cbEngineFit, cbHidden),
        //                   getCheckBoxValue(cbCateringFit, cbHidden),
        //                   getCheckBoxValue(cbOtherServiceFit, cbHidden),
        //                   getCheckBoxValue(cbDeckServiceUnFit, cbHidden),
        //                   getCheckBoxValue(cbEngineUnFit, cbHidden),
        //                   getCheckBoxValue(cbCateringUnFit, cbHidden),
        //                   getCheckBoxValue(cbOtherUnFit, cbHidden),
        //                   getCheckBoxValue(cbWithOutRestrictions, cbHidden),
        //                   getCheckBoxValue(cbWithRestrictions, cbHidden),
        //                   getCheckBoxValue(cbVisualAidYes, cbHidden),
        //                   getCheckBoxValue(cbVisualAidYes, cbVisualAidRequiredNo),
        //                    txtAssessmentComment1.Text,
        //                    expiration,
        //                   issued,
        //                    txtNumberOfMedicalCertificate.Text,
        //                    txtPhysicianName.Text,
        //                    txtAssessmentComment2.Text,
        //                    txtAssessmentComment3.Text,
        //                    txtAssessmentComment4.Text,
        //                     txtAssessmentComment5.Text);
        //}



        private void rbCoastal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private string getCheckBoxValue(RadioButton cbYes, RadioButton cbNo)
        {
            string val = "No";
            if (cbYes.Checked == true)
            {
                val = "Yes";
            }
            else if (cbNo.Checked == true)
            {
                val = "No";
            }

            return val;
        }



        private void setCheckBoxValue(RadioButton cbYes, RadioButton cbNo, string val)
        {
            if (val == "Yes")
            {
                cbYes.Checked = true;
                cbNo.Checked = false;

            }
            else
            {
                cbYes.Checked = false;
                cbNo.Checked = true;
            }

        }


        private void validateDate(string dt, DateTimePicker dtp, CheckBox cb)
        {


            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";

            DateTime val;
            if (DateTime.TryParse(dt, out val) == true)
            {
                dtp.CustomFormat = "dd/MM/yyyy";
                dtp.Value = Convert.ToDateTime(dt).Date;
                cb.Checked = false;

            }
            else
            {
                dtp.CustomFormat = "00/00/0000";
                cb.Checked = true; ;
            }
        }



        private string getRadioButtonValue(CheckBox cb)
        {
            string val = "No";
            if (cb.Checked)
            {
                val = "Yes";
            }
            return val;
        }

        private void setRadioButtonValue(CheckBox rb, string val)
        {
            rb.Checked = true;
            if (val == "Yes")
            {
                rb.Checked = true;
            }
            else
            {
                rb.Checked = false;
            }

        }


        public void navigateNextPage()
        {
            ////(Application.OpenForms["MainForm"] as MainForm).btnNextPage.Enabled = true;
            //if (tabControl1.SelectedTab == tabPage1)
            //{
            //    tabControl1.SelectedTab = tabPage2;
            //    (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 2";
            //}
            //else if (tabControl1.SelectedTab == tabPage2)
            //{
            //    tabControl1.SelectedTab = tabPage3;
            //    (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 3";
            //}
            //else if (tabControl1.SelectedTab == tabPage3)
            //{
            //    tabControl1.SelectedTab = tabPage4;

            //    (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 4";
            //}
            //else if (tabControl1.SelectedTab == tabPage4)
            //{
            //    tabControl1.SelectedTab = tabPage5;
            //    (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 5";
            //}
            //else if (tabControl1.SelectedTab == tabPage5)
            //{
            //    tabControl1.SelectedTab = tabPage6;
            //    (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 6";
            //}
            //else if (tabControl1.SelectedTab == tabPage6)
            //{
            //    tabControl1.SelectedTab = tabPage7;
            //    (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 7";
            //}
            //else if (tabControl1.SelectedTab == tabPage7)
            //{
            //    tabControl1.SelectedTab = tabPage8;
            //    (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 8";
            //    //(Application.OpenForms["MainForm"] as MainForm).btnNextPage.Enabled = false;
            //}
            ////else if (tabControl1.SelectedTab == tabPage8)
            ////{
            ////    tabControl1.SelectedTab = tabPage1;
            ////    (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 1";
            ////}





        }

        //public void navigatePreviousPage()
        //{
        //    //(Application.OpenForms["MainForm"] as MainForm).btnPreviousPage.Enabled = true;
        //    if (tabControl1.SelectedTab == tabPage8)
        //    {
        //        tabControl1.SelectedTab = tabPage7;
        //        (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 7";
        //    }
        //    else if (tabControl1.SelectedTab == tabPage7)
        //    {
        //        tabControl1.SelectedTab = tabPage6;
        //        (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 6";
        //    }
        //    else if (tabControl1.SelectedTab == tabPage6)
        //    {
        //        tabControl1.SelectedTab = tabPage5;
        //        (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 5";
        //    }
        //    else if (tabControl1.SelectedTab == tabPage5)
        //    {
        //        tabControl1.SelectedTab = tabPage4;
        //        (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 4";
        //    }
        //    else if (tabControl1.SelectedTab == tabPage4)
        //    {
        //        tabControl1.SelectedTab = tabPage3;
        //        (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 3";
        //    }
        //    else if (tabControl1.SelectedTab == tabPage3)
        //    {
        //        tabControl1.SelectedTab = tabPage2;

        //        (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 2";

        //    }
        //    else if (tabControl1.SelectedTab == tabPage2)
        //    {
        //        tabControl1.SelectedTab = tabPage1;
        //        (Application.OpenForms["MainForm"] as MainForm).lblPageLabel.Text = "Page 1";
        //        //(Application.OpenForms["MainForm"] as MainForm).btnPreviousPage.Enabled =  false;


        //    }

        //}
        private void FormPanama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                savePatient(true);
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
            {
                OpenSearchList();
            }





        }

        public void OpenSearchList()
        {
            //using (FromSearchPanama frmSearch = new FromSearchPanama(this))
            //{
            //    frmSearch.ShowDialog();
            //}
        }

        private void txtNumberOfMedicalCertificate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSeaDutyYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPsaNormal_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_onTextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel55_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel34_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPanama_Load_1(object sender, EventArgs e)
        {

        }

        private void HideAllTabsOnTabControl(TabControl theTabControl)
        {
            theTabControl.Appearance = TabAppearance.FlatButtons;
            theTabControl.ItemSize = new Size(0, 1);
            theTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void cbLipid_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
