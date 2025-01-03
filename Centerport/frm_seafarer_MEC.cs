﻿//using Centerport.Accounting;
using MedicalManagementSoftware.Class;
using Ini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MedicalManagementSoftware.Model;


namespace MedicalManagementSoftware
{
    public partial class frm_seafarer_MEC : Form, MyInter
    {
        Main fmain; public static bool NewSeabase, isEdit; public static TextBox pin; public static TextBox LabID; public static string Action; public static bool Count;
        public static string cn_SeabaseResultMain;
        private string rb_head_;
        private string rb_freqHead_;
        private string rb_dizziness_;
        private string rb_spells_;
        private string rb_Insomia_;
        private string rb_depression_;
        private string rb_trachoma_;
        private string rb_deaf_;
        private string rb_nose_;
        private string rb_tuberculosis_;
        private string rb_lung_;
        private string rb_HighBlood_;
        private string rb_Heart_;
        private string rb_fever_;
        private string rb_diabetes_;
        private string rb_endocrine_;
        private string rb_cancer_;
        private string rb_blood_;
        private string rb_stomach_;
        private string rb_abdominal_;
        private string rb_kidney_;
        private string rb_back_;
        private string rb_Genetic_;
        private string rb_sexual_;
        private string rb_last_;
        private string rb_tropical_;
        private string rb_schis_;
        private string rb_asthma_;
        private string rb_allergies_;
        private string rb_gyn_;
        private string rb_operational_;
        private string cb_consulted_;
        private string operations_tag_;
        private string q7_Y_;
        private string VisualRequired;
        private string q1_;
        private string q2_;
        private string q3_;
        private string q4_;
        private string q5_;
        private string q6_;
        private string q7_;
        private string q8_;
        private string MedtectLicence;


        private string cb_skin_;
        private string cb_neck_;
        private string cb_eyes_;
        private string cb_pupils_;
        private string cb_ears_;
        private string cb_nose_;
        private string cb_mought_;
        private string cb_thyroid_;
        private string cb_breast_;
        private string cb_lungs_;
        private string cb_heart_;
        private string cb_abdomen_;
        private string cb_back_;
        private string cb_anus_;
        private string cb_gu_;
        private string cb_inguinals_;
        private string cb_reflexes_;
        private string cb_extremeties_;
        private string cb_dental_;

        private string cxr_normal_;
        private string ecg_normal_;
        private string cbd_normal_;
        private string urinal_normal_;
        private string stool_normal_;
        private string hb_Nonreactive_;
        private string hiv_NonReactive_;
        private string rpr_NonReactive_;
        private string psychological_exam_;

        private string rb_doh_pass_;
        private string rb_ladTest_pass_;
        private string rb_flag_pass_;

        private string ISHIHARA_U_;
        private string SPEECH_;
        private string FIT_FOR_LOOKOUT_;
        private string HEARING_RIGHT_;
        private string HEARING_LEFT_;
        private string CLARITY_OF_SPEECH_;
        private string VISUAL_AIDS_REQUIRED_;
        private string VISUAL_AIDS_WORN_;
        private string IDENTITY_CONFIRMED_;

        private string deck_srvc_flag_;
        private string engine_srvc_flag_;
        private string catering_srvc_flag_;
        private string other_srvc_flag_;
        public DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
        public List<Seabase_SearchList_Model> Seabase_SearchList_Model = new List<Seabase_SearchList_Model>();
        public List<QueueSearchList_Model> SeabaseAdd_model = new List<QueueSearchList_Model>();

        public frm_seafarer_MEC(Main mainn)
        {
            InitializeComponent();
            fmain = mainn;
            pin = txt_Papin; LabID = txt_resultID;
        }

        private void frm_seaferer_MEC_Load(object sender, EventArgs e)
        {
            //ClassSql.DbConnect();
            Cursor.Current = Cursors.Default;
            Availability(false);
            txt_Papin.Select();
            Load_Medical();

            //if (!Directory.Exists(ClassSql.SeabaseImage))
            //{
            //    DirectoryInfo di = Directory.CreateDirectory(ClassSql.SeabaseImage);
            //}


            //if (!backgroundWorker2.IsBusy)
            //{ backgroundWorker2.RunWorkerAsync(); }
        }


        public void checkedNo()
        {
            rb_head_N.Checked = true;
            rb_freqHead_N.Checked = true;
            rb_dizziness_N.Checked = true;
            rb_spells_N.Checked = true;
            rb_Insomia_N.Checked = true;
            rb_depression_N.Checked = true;
            rb_trachoma_N.Checked = true;
            rb_deaf_N.Checked = true;
            rb_nose_N.Checked = true;
            rb_tuberculosis_N.Checked = true;
            rb_lung_N.Checked = true;
            rb_HighBlood_N.Checked = true;
            rb_Heart_N.Checked = true;
            rb_fever_N.Checked = true;
            rb_diabetes_N.Checked = true;
            rb_endocrine_N.Checked = true;
            rb_cancer_N.Checked = true;
            rb_blood_N.Checked = true;
            rb_stomach_N.Checked = true;
            rb_abdominal_N.Checked = true;
            rb_kidney_N.Checked = true;
            rb_back_N.Checked = true;
            rb_Genetic_N.Checked = true;
            rb_sexual_N.Checked = true;
            rb_last_N.Checked = true;
            rb_tropical_N.Checked = true;
            rb_schis_N.Checked = true;
            rb_asthma_N.Checked = true;
            rb_allergies_N.Checked = true;
            rb_gyn_N.Checked = true;
            rb_operational_N.Checked = true;
            q1_N.Checked = true;
            q2_N.Checked = true;
            q3_N.Checked = true;
            q4_N.Checked = true;
            q5_N.Checked = true;
            q6_N.Checked = true;
            q7_N.Checked = true;
            q8_N.Checked = true;


            cb_skin.Checked = true;
            cb_thyroid.Checked = true;
            cb_neck.Checked = true;
            cb_eyes.Checked = true;
            cb_pupils.Checked = true;
            cb_ears.Checked = true;
            cb_nose.Checked = true;
            cb_mought.Checked = true;
            cb_thyroid.Checked = true;
            cb_breast.Checked = true;
            cb_lungs.Checked = true;
            cb_heart.Checked = true;
            cb_abdomen.Checked = true;
            cb_back.Checked = true;
            cb_anus.Checked = true;
            cb_gu.Checked = true;
            cb_inguinals.Checked = true;
            cb_extremeties.Checked = true;
            cb_reflexes.Checked = true;
            cb_dental.Checked = true;

        }
        void Load_Medical()
        {
            IniFile ini = new IniFile(ClassSql.MMS_Path);
            List<string> list = new List<string>();
            // ArrayList list = new ArrayList();
            list.Add(ini.IniReadValue("MEDICAL", "PEME_Physician"));
            list.Add(ini.IniReadValue("MEDICAL", "PEME MedicalDirector"));
            cbo_medtech.Items.Clear();
            txt_medDir_Cbo.Items.Clear();
            foreach (string item in list)
            {
                cbo_medtech.Items.Add(item);
                txt_medDir_Cbo.Items.Add(item);
            }




           

        }



        public void New()
        {
            isEdit = false;
            IniFile ini = new IniFile(ClassSql.MMS_Path);
            cbo_medtech.Text = ini.IniReadValue("MEDICAL", "PEME_Physician");
            txt_medDir_Cbo.Text = ini.IniReadValue("MEDICAL", "PEME MedicalDirector");
            MedtectLicence = ini.IniReadValue("[MEDICAL]", "PEME_Physician_license");
            cbo_recomendation.Text = "FIT FOR SEA DUTY";
            //cbo_bloodType.Text = "+";

        }
        public void Save()
        {



            if (NewSeabase)
            {
                insert();

            }
            else
            {


                Update_MedHistory();

                //Update_Others();





            }




        }


        void insert()
        {
            try
            {

                if (rb_doh_pass.Checked == true) { rb_doh_pass_ = "Y"; } else if (this.rb_basic_doh_with.Checked == true) { rb_doh_pass_ = "N"; } else rb_doh_pass_ = "-";
                if (rb_ladTest_pass.Checked == true) { rb_ladTest_pass_ = "Y"; } else if (this.rb_add_lab_test_With.Checked == true) { rb_ladTest_pass_ = "N"; } else { rb_ladTest_pass_ = "-"; }
                if (rb_flag_pass.Checked == true) { rb_flag_pass_ = "Y"; } else if (this.rb_flag_with.Checked == true) { rb_flag_pass_ = "N"; } else { rb_flag_pass_ = "-"; }

                if (rb_deck_fit.Checked == true) { deck_srvc_flag_ = "Y"; } else if (this.rb_deck_UFit.Checked == true) { deck_srvc_flag_ = "N"; } else { deck_srvc_flag_ = "-"; }
                if (rb_engine_Fit.Checked == true) { engine_srvc_flag_ = "Y"; } else if (this.rb_engine_Ufit.Checked == true) { engine_srvc_flag_ = "N"; } else { engine_srvc_flag_ = "-"; }
                if (rb_catering_fit.Checked == true) { catering_srvc_flag_ = "Y"; } else if (this.rb_catering_Ufit.Checked == true) { catering_srvc_flag_ = "N"; } else catering_srvc_flag_ = "-";
                if (rb_other_Fit.Checked == true) { other_srvc_flag_ = "Y"; } else if (this.rb_other_uFit.Checked == true) { other_srvc_flag_ = "N"; } else other_srvc_flag_ = "-";


                if (rb_head_Y.Checked == true) { rb_head_ = "Y"; } else if (rb_head_N.Checked == true) { rb_head_ = "N"; } else { rb_head_ = "-"; }
                if (rb_freqHead_Y.Checked == true) { rb_freqHead_ = "Y"; } else if (rb_freqHead_N.Checked == true) { rb_freqHead_ = "N"; } else { rb_freqHead_ = "-"; }
                if (rb_dizziness_Y.Checked == true) { rb_dizziness_ = "Y"; } else if (rb_dizziness_N.Checked == true) { rb_dizziness_ = "N"; } else { rb_dizziness_ = "-"; }
                if (rb_spells_Y.Checked == true) { rb_spells_ = "Y"; } else if (rb_spells_N.Checked == true) { rb_spells_ = "N"; } else { rb_spells_ = "-"; }
                if (rb_Insomia_Y.Checked == true) { rb_Insomia_ = "Y"; } else if (rb_Insomia_N.Checked == true) { rb_Insomia_ = "N"; } else { rb_Insomia_ = "-"; }
                if (rb_depression_Y.Checked == true) { rb_depression_ = "Y"; } else if (rb_depression_N.Checked == true) { rb_depression_ = "N"; } else { rb_depression_ = "-"; }
                if (rb_trachoma_Y.Checked == true) { rb_trachoma_ = "Y"; } else if (rb_trachoma_N.Checked == true) { rb_trachoma_ = "N"; } else { rb_trachoma_ = "-"; }
                if (rb_deaf_Y.Checked == true) { rb_deaf_ = "Y"; } else if (rb_deaf_N.Checked == true) { rb_deaf_ = "N"; } else { rb_deaf_ = "-"; }
                if (rb_nose_Y.Checked == true) { rb_nose_ = "Y"; } else if (rb_nose_N.Checked == true) { rb_nose_ = "N"; } else { rb_nose_ = "-"; }
                if (rb_tuberculosis_Y.Checked == true) { rb_tuberculosis_ = "Y"; } else if (rb_tuberculosis_N.Checked == true) { rb_tuberculosis_ = "N"; } else { rb_tuberculosis_ = "-"; }
                if (rb_lung_Y.Checked == true) { rb_lung_ = "Y"; } else if (rb_lung_N.Checked == true) { rb_lung_ = "N"; } else { rb_lung_ = "-"; }
                if (rb_HighBlood_Y.Checked == true) { rb_HighBlood_ = "Y"; } else if (rb_HighBlood_N.Checked == true) { rb_HighBlood_ = "N"; } else { rb_HighBlood_ = "-"; }
                if (rb_Heart_Y.Checked == true) { rb_Heart_ = "Y"; } else if (rb_Heart_N.Checked == true) { rb_Heart_ = "N"; } else { rb_Heart_ = "-"; }
                if (rb_fever_Y.Checked == true) { rb_fever_ = "Y"; } else if (rb_fever_N.Checked == true) { rb_fever_ = "N"; } else { rb_fever_ = "-"; }
                if (rb_diabetes_Y.Checked == true) { rb_diabetes_ = "Y"; } else if (rb_diabetes_N.Checked == true) { rb_diabetes_ = "N"; } else { rb_diabetes_ = "-"; }
                if (rb_endocrine_Y.Checked == true) { rb_endocrine_ = "Y"; } else if (rb_endocrine_N.Checked == true) { rb_endocrine_ = "N"; } else { rb_endocrine_ = "-"; }
                if (rb_cancer_Y.Checked == true) { rb_cancer_ = "Y"; } else if (rb_cancer_N.Checked == true) { rb_cancer_ = "N"; } else { rb_cancer_ = "-"; }
                if (rb_blood_Y.Checked == true) { rb_blood_ = "Y"; } else if (rb_blood_N.Checked == true) { rb_blood_ = "N"; } else { rb_blood_ = "-"; }
                if (rb_stomach_Y.Checked == true) { rb_stomach_ = "Y"; } else if (rb_stomach_N.Checked == true) { rb_stomach_ = "N"; } else { rb_stomach_ = "-"; }
                if (rb_abdominal_Y.Checked == true) { rb_abdominal_ = "Y"; } else if (rb_abdominal_N.Checked == true) { rb_abdominal_ = "N"; } else { rb_abdominal_ = "-"; }
                if (rb_kidney_Y.Checked == true) { rb_kidney_ = "Y"; } else if (rb_kidney_N.Checked == true) { rb_kidney_ = "N"; } else { rb_kidney_ = "-"; }
                if (rb_back_Y.Checked == true) { rb_back_ = "Y"; } else if (rb_back_N.Checked == true) { rb_back_ = "N"; } else { rb_back_ = "-"; }
                if (rb_Genetic_Y.Checked == true) { rb_Genetic_ = "Y"; } else if (rb_Genetic_N.Checked == true) { rb_Genetic_ = "N"; } else { rb_Genetic_ = "-"; }
                if (rb_sexual_Y.Checked == true) { rb_sexual_ = "Y"; } else if (rb_sexual_N.Checked == true) { rb_sexual_ = "N"; } else { rb_sexual_ = "-"; }
                if (rb_last_Y.Checked == true) { rb_last_ = "Y"; } else if (rb_last_N.Checked == true) { rb_last_ = "N"; } else { rb_last_ = "-"; }
                if (rb_tropical_Y.Checked == true) { rb_tropical_ = "Y"; } else if (rb_tropical_N.Checked == true) { rb_tropical_ = "N"; } else { rb_tropical_ = "-"; }
                if (rb_schis_Y.Checked == true) { rb_schis_ = "Y"; } else if (rb_schis_N.Checked == true) { rb_schis_ = "N"; } else { rb_schis_ = "-"; }
                if (rb_asthma_Y.Checked == true) { rb_asthma_ = "Y"; } else if (rb_asthma_N.Checked == true) { rb_asthma_ = "N"; } else { rb_asthma_ = "-"; }
                if (rb_allergies_Y.Checked == true) { rb_allergies_ = "Y"; } else if (rb_allergies_N.Checked == true) { rb_allergies_ = "N"; } else { rb_allergies_ = "-"; }
                if (rb_gyn_Y.Checked == true) { rb_gyn_ = "Y"; } else if (rb_gyn_N.Checked == true) { rb_gyn_ = "N"; } else { rb_gyn_ = "-"; }
                if (rb_operational_Y.Checked == true) { rb_operational_ = "Y"; } else if (rb_operational_N.Checked == true) { rb_operational_ = "N"; } else { rb_operational_ = "-"; }
                if (cb_consulted.Checked == true) { cb_consulted_ = "Y"; } else { cb_consulted_ = "N"; }
                if (rb_operational_N.Checked == true) { operations_tag_ = "N"; } else if (rb_operational_Y.Checked == true) { operations_tag_ = "Y"; } else { operations_tag_ = "-"; }
                //if (operations_tag_ == "N") { rb_operational_N.Checked = true; } else { rb_operational_Y.Checked = true; }

                if (q1_Y.Checked == true) { q1_ = "Y"; } else if (q1_N.Checked == true) { q1_ = "N"; } else { q1_ = "-"; }
                if (q2_Y.Checked == true) { q2_ = "Y"; } else if (q2_N.Checked == true) { q2_ = "N"; } else { q2_ = "-"; }
                if (q3_Y.Checked == true) { q3_ = "Y"; } else if (q3_N.Checked == true) { q3_ = "N"; } else { q3_ = "-"; }
                if (q4_Y.Checked == true) { q4_ = "Y"; } else if (q4_N.Checked == true) { q4_ = "N"; } else { q4_ = "-"; }
                if (q5_Y.Checked == true) { q5_ = "Y"; } else if (q5_N.Checked == true) { q5_ = "N"; } else { q5_ = "-"; }
                if (q6_Y.Checked == true) { q6_ = "Y"; } else if (q6_N.Checked == true) { q6_ = "N"; } else { q6_ = "-"; }
                if (q7_Y.Checked == true) { q7_ = "Y"; } else if (q7_N.Checked == true) { q7_ = "N"; } else { q7_ = "-"; }
                if (q8_Y.Checked == true) { q8_ = "Y"; } else if (q8_N.Checked == true) { q8_ = "N"; } else { q8_ = "-"; }


                if (cb_ishihara_u.Checked == true) { ISHIHARA_U_ = "1"; } else { ISHIHARA_U_ = "0"; }

                if (rb_clarity_Speech_AD.Checked == true) { CLARITY_OF_SPEECH_ = "A"; } else if (rb_clarity_Speech_IN.Checked == true) { CLARITY_OF_SPEECH_ = "I"; } else { CLARITY_OF_SPEECH_ = "-"; }
                if (rb_fit_lookOut_Y.Checked == true) { FIT_FOR_LOOKOUT_ = "YES"; } else if (rb_fit_lookOut_N.Checked == true) { FIT_FOR_LOOKOUT_ = "NO"; } else { FIT_FOR_LOOKOUT_ = "-"; }

                if (rb_hearingRight_AD.Checked == true) { HEARING_RIGHT_ = "A"; } else if (rb_hearingRight_IA.Checked == true) { HEARING_RIGHT_ = "I"; } else { HEARING_RIGHT_ = "-"; }
                if (rb_hearingLeft_AD.Checked == true) { HEARING_LEFT_ = "A"; } else if (rb_hearingLeft_IA.Checked == true) { HEARING_LEFT_ = "I"; } else { HEARING_LEFT_ = "-"; }
                if (rb_visualReq_Y.Checked == true) { VISUAL_AIDS_REQUIRED_ = "YES"; } else if (rb_visualReq_N.Checked == true) { VISUAL_AIDS_REQUIRED_ = "NO"; } else { VISUAL_AIDS_REQUIRED_ = "-"; }

                if (rb_visual_worn_Spectacles.Checked == true) { VISUAL_AIDS_WORN_ = "SPECTACLES"; } else if (rb_visual_worn_ContactLenses.Checked == true) { VISUAL_AIDS_WORN_ = "CONTACTLENS"; } else { VISUAL_AIDS_WORN_ = "-"; }
                if (rb_indentity_Confirm_Y.Checked == true) { IDENTITY_CONFIRMED_ = "YES"; } else if (rb_indentity_Confirm_N.Checked == true) { IDENTITY_CONFIRMED_ = "NO"; } else { IDENTITY_CONFIRMED_ = "-"; }

                string con_as;
                if (cb_con_as.Checked == true) { con_as = "1"; } else { con_as = "0"; }



                if (cb_skin.Checked == true) { cb_skin_ = "1"; } else { cb_skin_ = "0"; }
                if (cb_neck.Checked == true) { cb_neck_ = "1"; } else { cb_neck_ = "0"; }
                if (cb_eyes.Checked == true) { cb_eyes_ = "1"; } else { cb_eyes_ = "0"; }
                if (cb_pupils.Checked == true) { cb_pupils_ = "1"; } else { cb_pupils_ = "0"; }
                if (cb_ears.Checked == true) { cb_ears_ = "1"; } else { cb_ears_ = "0"; }
                if (cb_nose.Checked == true) { cb_nose_ = "1"; } else { cb_nose_ = "0"; }
                if (cb_mought.Checked == true) { cb_mought_ = "1"; } else { cb_mought_ = "0"; }
                if (cb_thyroid.Checked == true) { cb_thyroid_ = "1"; } else { cb_thyroid_ = "0"; }
                if (cb_breast.Checked == true) { cb_breast_ = "1"; } else { cb_breast_ = "0"; }
                if (cb_lungs.Checked == true) { cb_lungs_ = "1"; } else { cb_lungs_ = "0"; }
                if (cb_heart.Checked == true) { cb_heart_ = "1"; } else { cb_heart_ = "0"; }
                if (cb_abdomen.Checked == true) { cb_abdomen_ = "1"; } else { cb_abdomen_ = "0"; }
                if (cb_back.Checked == true) { cb_back_ = "1"; } else { cb_back_ = "0"; }
                if (cb_anus.Checked == true) { cb_anus_ = "1"; } else { cb_anus_ = "0"; }
                if (cb_gu.Checked == true) { cb_gu_ = "1"; } else { cb_gu_ = "0"; }
                if (cb_inguinals.Checked == true) { cb_inguinals_ = "1"; } else { cb_inguinals_ = "0"; }
                if (cb_reflexes.Checked == true) { cb_reflexes_ = "1"; } else { cb_reflexes_ = "0"; }
                if (cb_extremeties.Checked == true) { cb_extremeties_ = "1"; } else { cb_extremeties_ = "0"; }
                if (cb_dental.Checked == true) { cb_dental_ = "1"; } else { cb_dental_ = "0"; }


                if (rb_cxr_normal.Checked == true) { cxr_normal_ = "NORMAL"; } else if (this.rb_cxr_with.Checked == true) { cxr_normal_ = "WITH_F"; } else { cxr_normal_ = "-"; }
                if (rb_ecg_normal.Checked == true) { ecg_normal_ = "NORMAL"; } else if (this.rb_ecg_with.Checked == true) { ecg_normal_ = "WITH_F"; } else { ecg_normal_ = "-"; }
                if (rb_cbd_normal.Checked == true) { cbd_normal_ = "NORMAL"; } else if (this.rb_cbc_with.Checked == true) { cbd_normal_ = "WITH_F"; } else { cbd_normal_ = "-"; }
                if (rb_urinal_normal.Checked == true) { urinal_normal_ = "NORMAL"; } else if (this.rb_urinal_with.Checked == true) { urinal_normal_ = "WITH_F"; } else { urinal_normal_ = "-"; }
                if (rb_stool_normal.Checked == true) { stool_normal_ = "NORMAL"; } else if (this.rb_stool_with.Checked == true) { stool_normal_ = "WITH_F"; } else { stool_normal_ = "-"; }

                if (rb_hb_reactive.Checked == true) { hb_Nonreactive_ = "REACTIVE"; } else if (rb_hb_Nonreactive.Checked == true) { hb_Nonreactive_ = "NON REACTIVE"; } else { hb_Nonreactive_ = "-"; }
                if (rb_hiv_Reactive.Checked == true) { hiv_NonReactive_ = "REACTIVE"; } else if (rb_hiv_NonReactive.Checked == true) { hiv_NonReactive_ = "Nonreactive"; } else { hiv_NonReactive_ = "-"; }
                if (rb_rpr_Reactive.Checked == true) { rpr_NonReactive_ = "REACTIVE"; } else if (rb_rpr_NonReactive.Checked == true) { rpr_NonReactive_ = "NONREACTIVE"; } else { rpr_NonReactive_ = "-"; }

                if (rb_psych_recomend.Checked == true) { psychological_exam_ = "RECOMMEND"; }
                else if (rb_psych_NR.Checked == true) { psychological_exam_ = "NR"; }
                else if (rb_psych_ND.Checked == true) { psychological_exam_ = "ND"; }
                else if (rb_psych_RecWithRes.Checked == true) { psychological_exam_ = "RESERVE"; } else { psychological_exam_ = "-"; }


                //ClassSql a = new ClassSql();     
                //INSERT INTO `t_result_main` (`resultid`,     `resulttype`,     `papin`,             `result_date`,                        `pathologist`,                          `status`,       `fitness_date`,                           `valid_until`,                           `remarks`,                                                                     `recommendation`,                `repeat_test_requestby`,                     `specimen_no`,                                               `medtech`,                          `medtech_license`, `pathologist_license`,        `reference_no`,                                `restriction`,                                              sic_doh_exam`,                                  `add_lab_tests`,                                     `flag_medlab_req`,                         `deck_srvc_flag`,                                  `engine_srvc_flag`,                                  `catering_srvc_flag`                  , `other_srvc_flag`
                // string a = "INSERT INTO `t_result_main` (`resultid`, `resulttype`, `papin`, `result_date`, `pathologist`, `status`, `fitness_date`, `valid_until`, `remarks`, `recommendation`, `repeat_test_requestby`, `specimen_no`, `medtech`, `medtech_license`, `pathologist_license`, `reference_no`, `restriction`, `basic_doh_exam`, `add_lab_tests`, `flag_medlab_req`, `deck_srvc_flag`, `engine_srvc_flag`, `catering_srvc_flag`, `other_srvc_flag`) VALUES ('" + LabID.Text + "', 'SEA', '" + pin.Text + "', '" + dt_resultDate.Text + "', '" + Tool.ReplaceString(txt_medDir_Cbo.Text) + "',     'PENDING',   '" + dt_fitness_Date.Text + "',      '" + dt_validUntil.Text + "',            '" + Tool.ReplaceString(x_remark_rec.Text) + "',                  '" + Tool.ReplaceString(cbo_recomendation.Text) + "',               '',                 '" + Tool.ReplaceString(x_speciment.Text) + "',               '" + Tool.ReplaceString(cbo_medtech.Text) + "',            '"+MedtectLicence.ToString()+"',                '',                 '" + LabID.Text + "',              '" + Tool.ReplaceString(x_restriction.Text) + "',             '" + rb_doh_pass_.ToString() + "',                  '" + rb_ladTest_pass_ .ToString()+ "',            '"+rb_flag_pass_.ToString() +"',             '"+deck_srvc_flag_.ToString()+"',                 '"+engine_srvc_flag_.ToString()+"',                 '"+catering_srvc_flag_.ToString()+"',                     '"+other_srvc_flag_.ToString()+"')";
                //resultid`,     `head_injury`,             `frequent_headaches`,          `frequent_dizziness`,             `fainting_spells`,           `insomnia`,                    `depression`,                    `trachoma`,                  `deafness`,               `nose_throat_disorder`,     `tuberculosis`,                         `high_blood_pressure`,  `heart_disease`,        `rheumatic_fever`,                `diabetes_mellitus`,         `other_endocrine_disorder`,         `cancer_tumor`,     `blood_disorders`,          `stomach_pain`,                 `other_abdominal_disorder`,         `kidney_bladder_disorder`,  `back_injury`,                  `genetic_hereditary`,        `sexually_transmit_disease`, `tropical_disease`,              `asthma`,                 `allergies`,                      `gynecological_disorder`, `operations`,                                  `operations_specify`,                                                    `others`,               `consulted`,            `consulted_specify`,                    `maintenance_meds`,                                                  `operations_tag`,                `schistosomiasis`,            `last_menstrual_period`, `allergies_specify`, `other_abdominal_specify`
                //  string b = "INSERT INTO `t_med_history` (`resultid`, `head_injury`, `frequent_headaches`, `frequent_dizziness`, `fainting_spells`, `insomnia`, `depression`, `trachoma`, `deafness`, `nose_throat_disorder`, `tuberculosis`,  `other_lung_disorder`,`high_blood_pressure`, `heart_disease`, `rheumatic_fever`, `diabetes_mellitus`, `other_endocrine_disorder`, `cancer_tumor`, `blood_disorders`, `stomach_pain`, `other_abdominal_disorder`, `kidney_bladder_disorder`, `back_injury`, `genetic_hereditary`, `sexually_transmit_disease`, `tropical_disease`, `asthma`, `allergies`, `gynecological_disorder`, `operations`, `operations_specify`, `others`, `consulted`, `consulted_specify`, `maintenance_meds`, `operations_tag`, `schistosomiasis`, `last_menstrual_period`, `allergies_specify`, `other_abdominal_specify`) VALUES ('" + LabID.Text + "', '" + rb_head_.ToString() + "', '" + rb_freqHead_.ToString() + "', '" + rb_dizziness_.ToString() + "', '" + rb_spells_.ToString() + "', '" + rb_Insomia_.ToString() + "', '" + rb_depression_.ToString() + "', '" + rb_trachoma_.ToString() + "', '" + rb_deaf_.ToString() + "', '" + rb_nose_.ToString() + "', '" + rb_tuberculosis_.ToString() + "', '" + rb_lung_.ToString() + "','" + rb_HighBlood_.ToString() + "', '" + rb_Heart_.ToString() + "', '" + rb_fever_.ToString() + "', '" + rb_diabetes_.ToString() + "', '" + rb_endocrine_.ToString() + "', '" + rb_cancer_.ToString() + "', '" + rb_blood_.ToString() + "', '" + rb_stomach_.ToString() + "', '" + rb_abdominal_.ToString() + "', '" + rb_kidney_.ToString() + "', '" + rb_back_.ToString() + "', '" + rb_Genetic_.ToString() + "', '" + rb_sexual_.ToString() + "', '" + rb_tropical_.ToString() + "', '" + rb_asthma_.ToString() + "', '" + rb_allergies_.ToString() + "', '" + rb_gyn_.ToString() + "', '" + rb_operational_.ToString() + "', '" + Tool.ReplaceString(txt_operational_specify.Text) + "', '" + Tool.ReplaceString(tx_other_History.Text) + "', '" + cb_consulted_.ToString() + "', '" + Tool.ReplaceString(txt_consulted.Text) + "', '" + Tool.ReplaceString(txt_maintenance.Text) + "', '" + operations_tag_.ToString() + "', '" + rb_schis_.ToString() + "', '" + rb_last_.ToString() + "', '" + Tool.ReplaceString(txt_allergies_specify.Text) + "', '" + Tool.ReplaceString(txt_abdominal_specify.Text) + "')";
                //resultid`,       `column1`,           `column2`,              `column3`,             `column4`,            `column5`,                 `column6`,             `column7`,                   `column7_comment`, `            column8`,       `column8_comment`
                // string c = "INSERT INTO `t_med_history2` (`resultid`, `column1`, `column2`, `column3`, `column4`, `column5`, `column6`, `column7`, `column7_comment`, `column8`, `column8_comment`) VALUES ('" + LabID.Text + "', '" + q1_.ToString() + "', '" + q2_.ToString() + "', '" + q3_.ToString() + "', '" + q4_.ToString() + "', '" + q5_.ToString() + "', '" + q6_.ToString() + "', '" + q7_.ToString() + "', '" + Tool.ReplaceString(txt_q7_Comment.Text) + "', '" + q8_.ToString() + "', '" + Tool.ReplaceString(txt_q8_comment.Text) + "')";
                //resultid`,                  `HEIGHT`,                                    `WEIGHT`,                                                   `BP`,                       `PULSE`,                                    `RESPIRATION`,                                       `BODY_BUILD`,                                                 `FAR_OD_U`,                             `FAR_OD_C`,                                 `FAR_OS_U`,                                          `FAR_OS_C`,                                               `NEAR_ODJ_U`,                               `NEAR_ODJ_C`,                                           `NEAR_OSJ_U`,                                                                `NEAR_OSJ_C`,                      `ISHIHARA_U`,                        `ISHIHARA_C`,                                          `HEARING_AD`,                                                `HEARING_AS`,                       `SPEECH`,          `CONVERSATIONAL_AD`,                        `CONVERSATIONAL_AS`,                    `SATISFACTORY_HEARING`,                                     `SATISFACTORY_SIGHT_AID`,           `SATISFACTORY_SIGHT_UNAID`,                                              `SATISFACTORY_PSYCHO`,                      `VISUAL_AIDS`,                      `FIT_FOR_LOOKOUT`,                   `HEARING_RIGHT`,                           `HEARING_LEFT`,                                         `CLARITY_OF_SPEECH`,                        `VISUAL_AIDS_REQUIRED`,                          `BP_DIASTOLIC`,                                                        `RHYTHM`,                               `VISUAL_AIDS_WORN`,                        `COLOR_VISION_DATE_TAKEN`, `UNAIDED_HEARING_SATISFACTORY`, `IDENTITY_CONFIRMED
                // string d = "INSERT INTO `t_phy_exam` (`resultid`, `HEIGHT`, `WEIGHT`, `BP`, `PULSE`, `RESPIRATION`, `BODY_BUILD`, `FAR_OD_U`, `FAR_OD_C`, `FAR_OS_U`, `FAR_OS_C`, `NEAR_ODJ_U`, `NEAR_ODJ_C`, `NEAR_OSJ_U`, `NEAR_OSJ_C`, `ISHIHARA_U`, `ISHIHARA_C`, `HEARING_AD`, `HEARING_AS`, `SPEECH`, `CONVERSATIONAL_AD`, `CONVERSATIONAL_AS`, `SATISFACTORY_HEARING`, `SATISFACTORY_SIGHT_AID`, `SATISFACTORY_SIGHT_UNAID`, `SATISFACTORY_PSYCHO`, `VISUAL_AIDS`, `FIT_FOR_LOOKOUT`, `HEARING_RIGHT`, `HEARING_LEFT`, `CLARITY_OF_SPEECH`, `VISUAL_AIDS_REQUIRED`, `BP_DIASTOLIC`, `RHYTHM`, `VISUAL_AIDS_WORN`, `COLOR_VISION_DATE_TAKEN`, `UNAIDED_HEARING_SATISFACTORY`, `IDENTITY_CONFIRMED`) VALUES ('" + LabID.Text + "', '" + Tool.ReplaceString(x_height.Text) + "',      '" + Tool.ReplaceString(x_weight.Text) + "',        '" + Tool.ReplaceString(x_bp.Text) + "',   '" + Tool.ReplaceString(x_pulse.Text) + "',         '" + Tool.ReplaceString(x_respiration.Text) + "',            '" + Tool.ReplaceString(x_body_Build.Text) + "',          '" + Tool.ReplaceString(x_far_u.Text) + "',        '" + Tool.ReplaceString(x_far_c.Text) + "',         '" + Tool.ReplaceString(x_far_os_u.Text) + "',         '" + Tool.ReplaceString(x_far_os_c.Text) + "',         '" + Tool.ReplaceString(x_Near_odj_u.Text) + "',             '" + Tool.ReplaceString(x_near_odj_c.Text) + "',          '" + Tool.ReplaceString(x_near_osj_u.Text) + "',             '" + Tool.ReplaceString(x_near_osj_c.Text) + "',        '" + ISHIHARA_U_.ToString() + "',          '" + cbo_ishihara_c.Text + "',                 '" + Tool.ReplaceString(x_hearing_Ad.Text) + "',          '" + Tool.ReplaceString(x_hearing_as.Text) + "',          '',          '" + Tool.ReplaceString(x_Con_ad.Text) + "',        '" + con_as.ToString() + "',          '" + Tool.ReplaceString(cb_satisfactory_Hearing.Text) + "',            '',                        '" + Tool.ReplaceString(cbo_satisfactory_Unaided.Text) + "',                          '',               '" + Tool.ReplaceString(cbo_visual_Aids.Text) + "', '" + FIT_FOR_LOOKOUT_.ToString() + "',  '" + HEARING_RIGHT_.ToString() + "',               '" + HEARING_LEFT_.ToString() + "',                    '" + CLARITY_OF_SPEECH_.ToString() + "',      '" + VISUAL_AIDS_REQUIRED_.ToString() + "',          '" + Tool.ReplaceString(x_bp_dias.Text) + "',                   '" + Tool.ReplaceString(x_rhythm.Text) + "',       '" + VISUAL_AIDS_WORN_.ToString() + "',                       '',               '',                              '" + IDENTITY_CONFIRMED_.ToString() + "')";
                //`resultid`,              `SKIN_TAG`,                          `SKIN`,                         `HEAD_NECK_SCALP_TAG`,            `HEAD_NECK_SCALP`,                        `EYES_TAG`,                    `EYES`,                          `PUPILS_TAG`,                           `PUPILS`,                        `EARS_EARDRUM_TAG`,        `EARS_EARDRUM`,                     `NOSE_SINUSES_TAG`,     `NOSE_SINUSES`,                          `MOUTH_THROAT_TAG`,           `MOUTH_THROAT`,                `NECK_LN_THYROID_TAG`,                `NECK_LN_THYROID`,                 `CHEST_BREAST_AXILLA_TAG`,          `CHEST_BREAST_AXILLA`,                       `LUNGS_TAG`,                         `LUNGS`,                       `HEART_TAG`,               `HEART`,                           `ABDOMEN_TAG`,                                `ABDOMEN`,                   `BACK_FLANK_TAG`,                         `BACK_FLANK`,            `ANUS_RECTUM_TAG`,                   `ANUS_RECTUM`,         `GU_SYSTEM_TAG`,               `GU_SYSTEM`,                         `INGUINALS_GENITALS_TAG`,              `INGUINALS_GENITALS`,            `REFLEXES_TAG`,                          `REFLEXES`,                           `EXTREMITIES_TAG`,                       `EXTREMITIES`,               `DENTAL`, `DENTAL_TAG
                // string e = "INSERT INTO `t_others` (`resultid`, `SKIN_TAG`, `SKIN`, `HEAD_NECK_SCALP_TAG`, `HEAD_NECK_SCALP`, `EYES_TAG`, `EYES`, `PUPILS_TAG`, `PUPILS`, `EARS_EARDRUM_TAG`, `EARS_EARDRUM`, `NOSE_SINUSES_TAG`, `NOSE_SINUSES`, `MOUTH_THROAT_TAG`, `MOUTH_THROAT`, `NECK_LN_THYROID_TAG`, `NECK_LN_THYROID`, `CHEST_BREAST_AXILLA_TAG`, `CHEST_BREAST_AXILLA`, `LUNGS_TAG`, `LUNGS`, `HEART_TAG`, `HEART`, `ABDOMEN_TAG`, `ABDOMEN`, `BACK_FLANK_TAG`, `BACK_FLANK`, `ANUS_RECTUM_TAG`, `ANUS_RECTUM`, `GU_SYSTEM_TAG`, `GU_SYSTEM`, `INGUINALS_GENITALS_TAG`, `INGUINALS_GENITALS`, `REFLEXES_TAG`, `REFLEXES`, `EXTREMITIES_TAG`, `EXTREMITIES`, `DENTAL`, `DENTAL_TAG`) VALUES ('" + LabID.Text + "', '" + cb_skin_.ToString() + "', '" + Tool.ReplaceString(x_skin.Text) + "',             '" + cb_neck_.ToString() + "','" + Tool.ReplaceString(x_neck.Text) + "', '" + cb_eyes_.ToString() + "', '" + Tool.ReplaceString(x_eyes.Text) + "', '" + cb_pupils_.ToString() + "', '" + Tool.ReplaceString(x_pupils.Text) + "', '" + cb_ears_.ToString() + "', '" + Tool.ReplaceString(x_ears.Text) + "', '" + cb_nose_.ToString() + "', '" + Tool.ReplaceString(x_nose.Text) + "', '" + cb_mought_.ToString() + "', '" + Tool.ReplaceString(x_mouth.Text) + "', '" + cb_thyroid_.ToString() + "', '" + Tool.ReplaceString(x_thyroid.Text) + "', '" + cb_breast_.ToString() + "', '" + Tool.ReplaceString(x_breast.Text) + "', '" + cb_lungs_.ToString() + "', '" + Tool.ReplaceString(x_lungs.Text) + "', '" + cb_heart_.ToString() + "', '" + Tool.ReplaceString(x_heart.Text) + "', '" + cb_abdomen_.ToString() + "', '" + Tool.ReplaceString(x_abdomen.Text) + "', '" + cb_back_.ToString() + "', '" + Tool.ReplaceString(x_back.Text) + "', '" + cb_anus_.ToString() + "', '" + Tool.ReplaceString(x_anus.Text) + "', '" + cb_gu_.ToString() + "', '" + Tool.ReplaceString(x_gu.Text) + "', '" + cb_inguinals_.ToString() + "', '" + Tool.ReplaceString(x_inguinals.Text) + "', '" + cb_reflexes_.ToString() + "', '" + Tool.ReplaceString(x_reflexes.Text) + "', '" + cb_extremeties_.ToString() + "', '" + Tool.ReplaceString(x_extremeties.Text) + "', '" + Tool.ReplaceString(x_dental.Text) + "', '" + cb_dental_.ToString() + "')";
                //result_id`,                       `cxr`,                           `ecg`,                             `cbc`,                           `pregnancy_test`,                             `urinalysis`,                     `stool_exam`,                   `hbsag`,                                `hiv`,                         `rpr`,                               `blood_type`,                  `blood_chemistries`,                    `psychological_exam`,               `additional_test`,                   `remarks`, `recommendation`, `additional_test2`
                //  string f = "INSERT INTO `t_ancillary` (`result_id`, `cxr`, `ecg`, `cbc`, `pregnancy_test`, `urinalysis`, `stool_exam`, `hbsag`, `hiv`, `rpr`, `blood_type`, `blood_chemistries`, `psychological_exam`, `additional_test`, `remarks`, `recommendation`, `additional_test2`) VALUES ('" + Tool.ReplaceString(LabID.Text) + "', '" + cxr_normal_.ToString() + "', '" + ecg_normal_.ToString() + "', '" + cbd_normal_.ToString() + "', '" + Tool.ReplaceString(cbo_pregnancyTest.Text) + "', '" + urinal_normal_.ToString() + "', '" + stool_normal_.ToString() + "', '" + hb_Nonreactive_.ToString() + "', '" + hiv_NonReactive_.ToString() + "', '" + rpr_NonReactive_.ToString() + "', '" + Tool.ReplaceString(cbo_bloodType.Text) + "', '',                    '" + psychological_exam_.ToString() + "', '" + Tool.ReplaceString(x_add_test1.Text) + "', '" + Tool.ReplaceString(x_remark.Text) + "', '', '" + Tool.ReplaceString(x_add_test2.Text) + "')";


                db.ExecuteCommand("INSERT INTO t_result_main (resultid, resulttype, papin, result_date, pathologist, status, fitness_date, valid_until, remarks, recommendation, repeat_test_requestby, specimen_no, medtech, medtech_license, pathologist_license, reference_no, restriction, basic_doh_exam, add_lab_tests, flag_medlab_req, deck_srvc_flag, engine_srvc_flag, catering_srvc_flag, other_srvc_flag) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23})", LabID.Text, "SEA", pin.Text, dt_resultDate.Text, txt_medDir_Cbo.Text, "PENDING", dt_fitness_Date.Text, dt_validUntil.Text, x_remark_rec.Text, cbo_recomendation.Text, "", x_speciment.Text, cbo_medtech.Text, MedtectLicence.ToString(), "", LabID.Text, x_restriction.Text, rb_doh_pass_.ToString(), rb_ladTest_pass_.ToString(), rb_flag_pass_.ToString(), deck_srvc_flag_.ToString(), engine_srvc_flag_.ToString(), catering_srvc_flag_.ToString(), other_srvc_flag_.ToString());
                db.ExecuteCommand("INSERT INTO t_med_history (resultid, head_injury, frequent_headaches, frequent_dizziness, fainting_spells, insomnia, depression, trachoma, deafness, nose_throat_disorder, tuberculosis,  other_lung_disorder,high_blood_pressure, heart_disease, rheumatic_fever, diabetes_mellitus, other_endocrine_disorder, cancer_tumor, blood_disorders, stomach_pain, other_abdominal_disorder, kidney_bladder_disorder, back_injury, genetic_hereditary, sexually_transmit_disease, tropical_disease, asthma, allergies, gynecological_disorder, operations, operations_specify, others, consulted, consulted_specify, maintenance_meds, operations_tag, schistosomiasis, last_menstrual_period, allergies_specify, other_abdominal_specify) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38},{39})", LabID.Text, rb_head_.ToString(), rb_freqHead_.ToString(), rb_dizziness_.ToString(), rb_spells_.ToString(), rb_Insomia_.ToString(), rb_depression_.ToString(), rb_trachoma_.ToString(), rb_deaf_.ToString(), rb_nose_.ToString(), rb_tuberculosis_.ToString(), rb_lung_.ToString(), rb_HighBlood_.ToString(), rb_Heart_.ToString(), rb_fever_.ToString(), rb_diabetes_.ToString(), rb_endocrine_.ToString(), rb_cancer_.ToString(), rb_blood_.ToString(), rb_stomach_.ToString(), rb_abdominal_.ToString(), rb_kidney_.ToString(), rb_back_.ToString(), rb_Genetic_.ToString(), rb_sexual_.ToString(), rb_tropical_.ToString(), rb_asthma_.ToString(), rb_allergies_.ToString(), rb_gyn_.ToString(), rb_operational_.ToString(), txt_operational_specify.Text, tx_other_History.Text, cb_consulted_.ToString(), txt_consulted.Text, txt_maintenance.Text, operations_tag_.ToString(), rb_schis_.ToString(), rb_last_.ToString(), txt_allergies_specify.Text, txt_abdominal_specify.Text);
                db.ExecuteCommand("INSERT INTO t_med_history2 (resultid, column1, column2, column3, column4, column5, column6, column7, column7_comment, column8, column8_comment,column1_comment,column2_comment,column3_comment,column4_comment,column5_comment,column6_comment) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})", LabID.Text, q1_.ToString(), q2_.ToString(), q3_.ToString(), q4_.ToString(), q5_.ToString(), q6_.ToString(), q7_.ToString(), txt_q7_Comment.Text, q8_.ToString(), txt_q8_comment.Text, txt_comment_1.Text, txt_comment_2.Text, txt_comment_3.Text, txt_comment_4.Text, txt_comment_5.Text, txt_comment_6.Text);
                db.ExecuteCommand("INSERT INTO t_phy_exam (resultid, HEIGHT, WEIGHT, BP, PULSE, RESPIRATION, BODY_BUILD, FAR_OD_U, FAR_OD_C, FAR_OS_U, FAR_OS_C, NEAR_ODJ_U, NEAR_ODJ_C, NEAR_OSJ_U, NEAR_OSJ_C, ISHIHARA_U, ISHIHARA_C, HEARING_AD, HEARING_AS, SPEECH, CONVERSATIONAL_AD, CONVERSATIONAL_AS, SATISFACTORY_HEARING, SATISFACTORY_SIGHT_AID, SATISFACTORY_SIGHT_UNAID, SATISFACTORY_PSYCHO, VISUAL_AIDS, FIT_FOR_LOOKOUT, HEARING_RIGHT, HEARING_LEFT, CLARITY_OF_SPEECH, VISUAL_AIDS_REQUIRED, BP_DIASTOLIC, RHYTHM, VISUAL_AIDS_WORN, COLOR_VISION_DATE_TAKEN, UNAIDED_HEARING_SATISFACTORY, IDENTITY_CONFIRMED) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37})", LabID.Text, x_height.Text, x_weight.Text, x_bp.Text, x_pulse.Text, x_respiration.Text, x_body_Build.Text, x_far_u.Text, x_far_c.Text, x_far_os_u.Text, x_far_os_c.Text, x_Near_odj_u.Text, x_near_odj_c.Text, x_near_osj_u.Text, x_near_osj_c.Text, ISHIHARA_U_.ToString(), cbo_ishihara_c.Text, x_hearing_Ad.Text, x_hearing_as.Text, "", x_Con_ad.Text, con_as.ToString(), cb_satisfactory_Hearing.Text, "", cbo_satisfactory_Unaided.Text, "", cbo_visual_Aids.Text, FIT_FOR_LOOKOUT_.ToString(), HEARING_RIGHT_.ToString(), HEARING_LEFT_.ToString(), CLARITY_OF_SPEECH_.ToString(), VISUAL_AIDS_REQUIRED_.ToString(), x_bp_dias.Text, x_rhythm.Text, VISUAL_AIDS_WORN_.ToString(), "", "", IDENTITY_CONFIRMED_.ToString());
                db.ExecuteCommand("INSERT INTO t_others (resultid, SKIN_TAG, SKIN, HEAD_NECK_SCALP_TAG, HEAD_NECK_SCALP, EYES_TAG, EYES, PUPILS_TAG, PUPILS, EARS_EARDRUM_TAG, EARS_EARDRUM, NOSE_SINUSES_TAG, NOSE_SINUSES, MOUTH_THROAT_TAG, MOUTH_THROAT, NECK_LN_THYROID_TAG, NECK_LN_THYROID, CHEST_BREAST_AXILLA_TAG, CHEST_BREAST_AXILLA, LUNGS_TAG, LUNGS, HEART_TAG, HEART, ABDOMEN_TAG, ABDOMEN, BACK_FLANK_TAG, BACK_FLANK, ANUS_RECTUM_TAG, ANUS_RECTUM, GU_SYSTEM_TAG, GU_SYSTEM, INGUINALS_GENITALS_TAG, INGUINALS_GENITALS, REFLEXES_TAG, REFLEXES, EXTREMITIES_TAG, EXTREMITIES, DENTAL, DENTAL_TAG) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38})", LabID.Text, cb_skin_.ToString(), x_skin.Text, cb_neck_.ToString(), x_neck.Text, cb_eyes_.ToString(), x_eyes.Text, cb_pupils_.ToString(), x_pupils.Text, cb_ears_.ToString(), x_ears.Text, cb_nose_.ToString(), x_nose.Text, cb_mought_.ToString(), x_mouth.Text, cb_thyroid_.ToString(), x_thyroid.Text, cb_breast_.ToString(), x_breast.Text, cb_lungs_.ToString(), x_lungs.Text, cb_heart_.ToString(), x_heart.Text, cb_abdomen_.ToString(), x_abdomen.Text, cb_back_.ToString(), x_back.Text, cb_anus_.ToString(), x_anus.Text, cb_gu_.ToString(), x_gu.Text, cb_inguinals_.ToString(), x_inguinals.Text, cb_reflexes_.ToString(), x_reflexes.Text, cb_extremeties_.ToString(), x_extremeties.Text, x_dental.Text, cb_dental_.ToString());
                db.ExecuteCommand("INSERT INTO t_ancillary (result_id, cxr, ecg, cbc, pregnancy_test ,urinalysis, stool_exam, hbsag, hiv ,rpr, blood_type, blood_chemistries, psychological_exam, additional_test ,remarks, recommendation ,additional_test2) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})", LabID.Text, cxr_normal_.ToString(), ecg_normal_.ToString(), cbd_normal_.ToString(), cbo_pregnancyTest.Text, urinal_normal_.ToString(), stool_normal_.ToString(), hb_Nonreactive_.ToString(), hiv_NonReactive_.ToString(), rpr_NonReactive_.ToString(), cbo_bloodType.Text.Replace("+", ""), "", psychological_exam_.ToString(), x_add_test1.Text, x_remark.Text, "", x_add_test2.Text);
                //  db.ExecuteCommand("INSERT INTO [Centerport_Medical].[dbo].[tbl_krpan] ([Resultid], [BloodDisorder], [MentalDisorder], [Cardiovascular], [CircumferenceChest], [Infection], [NervousSystem], [Digestive], [Liver], [Anemia], [UrineSyphilisis]) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", LabID.Text, BloodDisorder, MentalDisorder, Cardiovascular, CircumferenceChest, Infection, NervousSystem, NervousSystem, Liver, Anemia, UrineSyphilisis);

                //Search_MedicalHistory();
                //Search_medicalHistory2();
                //search_Recomendation();
                //Search_PhyExam();
                //Search_others();
                //search_Ancillary();  

                //  var arr = new[] { a, b, c, d, e, f };
                //  File.WriteAllLines(ClassSql.tmp_path, arr);
                Seabase_SearchList_Model.Clear();
                SeabaseAdd_model.Clear();
                if (!backgroundWorker1.IsBusy)
                { backgroundWorker1.RunWorkerAsync(); }


                //Tool.MessageBoxSave();
                Availability(false);
                pin.Select();
                fmain.ts_add_sea.Enabled = true; fmain.ts_edit_sea.Enabled = true; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = false; fmain.ts_cancel_sea.Enabled = false; fmain.ts_search_sea.Enabled = true; fmain.ts_print_sea.Enabled = true;




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}





        }




        public void Update_MedHistory()
        {
            try
            {


                //if (rb_head_Y.Checked == true) { rb_head_ = "Y"; } else { rb_head_ = "N"; }
                //if (rb_freqHead_Y.Checked == true) { rb_freqHead_ = "Y"; } else { rb_freqHead_ = "N"; }
                //if (rb_dizziness_Y.Checked == true) { rb_dizziness_ = "Y"; } else { rb_dizziness_ = "N"; }
                //if (rb_spells_Y.Checked == true) { rb_spells_ = "Y"; } else { rb_spells_ = "N"; }
                //if (rb_Insomia_Y.Checked == true) { rb_Insomia_ = "Y"; } else { rb_Insomia_ = "N"; }
                //if (rb_depression_Y.Checked == true) { rb_depression_ = "Y"; } else { rb_depression_ = "N"; }
                //if (rb_trachoma_Y.Checked == true) { rb_trachoma_ = "Y"; } else { rb_trachoma_ = "N"; }
                //if (rb_deaf_Y.Checked == true) { rb_deaf_ = "Y"; } else { rb_deaf_ = "N"; }
                //if (rb_nose_Y.Checked == true) { rb_nose_ = "Y"; } else { rb_nose_ = "N"; }
                //if (rb_tuberculosis_Y.Checked == true) { rb_tuberculosis_ = "Y"; } else { rb_tuberculosis_ = "N"; }
                //if (rb_lung_Y.Checked == true) { rb_lung_ = "Y"; } else { rb_lung_ = "N"; }
                //if (rb_HighBlood_Y.Checked == true) { rb_HighBlood_ = "Y"; } else { rb_HighBlood_ = "N"; }
                //if (rb_Heart_Y.Checked == true) { rb_Heart_ = "Y"; } else { rb_Heart_ = "N"; }
                //if (rb_fever_Y.Checked == true) { rb_fever_ = "Y"; } else { rb_fever_ = "N"; }
                //if (rb_diabetes_Y.Checked == true) { rb_diabetes_ = "Y"; } else { rb_diabetes_ = "N"; }
                //if (rb_endocrine_Y.Checked == true) { rb_endocrine_ = "Y"; } else { rb_endocrine_ = "N"; }
                //if (rb_cancer_Y.Checked == true) { rb_cancer_ = "Y"; } else { rb_cancer_ = "N"; }
                //if (rb_blood_Y.Checked == true) { rb_blood_ = "Y"; } else { rb_blood_ = "N"; }
                //if (rb_stomach_Y.Checked == true) { rb_stomach_ = "Y"; } else { rb_stomach_ = "N"; }
                //if (rb_abdominal_Y.Checked == true) { rb_abdominal_ = "Y"; } else { rb_abdominal_ = "N"; }
                //if (rb_kidney_Y.Checked == true) { rb_kidney_ = "Y"; } else { rb_kidney_ = "N"; }
                //if (rb_back_Y.Checked == true) { rb_back_ = "Y"; } else { rb_back_ = "N"; }
                //if (rb_Genetic_Y.Checked == true) { rb_Genetic_ = "Y"; } else { rb_Genetic_ = "N"; }
                //if (rb_sexual_Y.Checked == true) { rb_sexual_ = "Y"; } else { rb_sexual_ = "N"; }
                //if (rb_last_Y.Checked == true) { rb_last_ = "Y"; } else { rb_last_ = "N"; }
                //if (rb_tropical_Y.Checked == true) { rb_tropical_ = "Y"; } else { rb_tropical_ = "N"; }
                //if (rb_schis_Y.Checked == true) { rb_schis_ = "Y"; } else { rb_schis_ = "N"; }
                //if (rb_asthma_Y.Checked == true) { rb_asthma_ = "Y"; } else { rb_asthma_ = "N"; }
                //if (rb_allergies_Y.Checked == true) { rb_allergies_ = "Y"; } else { rb_allergies_ = "N"; }
                //if (rb_gyn_Y.Checked == true) { rb_gyn_ = "Y"; } else { rb_gyn_ = "N"; }
                //if (rb_operational_Y.Checked == true) { rb_operational_ = "Y"; } else { rb_operational_ = "N"; }
                //if (cb_consulted.Checked == true) { cb_consulted_ = "Y"; } else { cb_consulted_ = "N"; }            
                //if (operations_tag_ == "N") { rb_operational_N.Checked = true; } else { rb_operational_Y.Checked = true; }
                if (rb_head_Y.Checked == true) { rb_head_ = "Y"; } else if (rb_head_N.Checked == true) { rb_head_ = "N"; } else { rb_head_ = "-"; }
                if (rb_freqHead_Y.Checked == true) { rb_freqHead_ = "Y"; } else if (rb_freqHead_N.Checked == true) { rb_freqHead_ = "N"; } else { rb_freqHead_ = "-"; }
                if (rb_dizziness_Y.Checked == true) { rb_dizziness_ = "Y"; } else if (rb_dizziness_N.Checked == true) { rb_dizziness_ = "N"; } else { rb_dizziness_ = "-"; }
                if (rb_spells_Y.Checked == true) { rb_spells_ = "Y"; } else if (rb_spells_N.Checked == true) { rb_spells_ = "N"; } else { rb_spells_ = "-"; }
                if (rb_Insomia_Y.Checked == true) { rb_Insomia_ = "Y"; } else if (rb_Insomia_N.Checked == true) { rb_Insomia_ = "N"; } else { rb_Insomia_ = "-"; }
                if (rb_depression_Y.Checked == true) { rb_depression_ = "Y"; } else if (rb_depression_N.Checked == true) { rb_depression_ = "N"; } else { rb_depression_ = "-"; }
                if (rb_trachoma_Y.Checked == true) { rb_trachoma_ = "Y"; } else if (rb_trachoma_N.Checked == true) { rb_trachoma_ = "N"; } else { rb_trachoma_ = "-"; }
                if (rb_deaf_Y.Checked == true) { rb_deaf_ = "Y"; } else if (rb_deaf_N.Checked == true) { rb_deaf_ = "N"; } else { rb_deaf_ = "-"; }
                if (rb_nose_Y.Checked == true) { rb_nose_ = "Y"; } else if (rb_nose_N.Checked == true) { rb_nose_ = "N"; } else { rb_nose_ = "-"; }
                if (rb_tuberculosis_Y.Checked == true) { rb_tuberculosis_ = "Y"; } else if (rb_tuberculosis_N.Checked == true) { rb_tuberculosis_ = "N"; } else { rb_tuberculosis_ = "-"; }
                if (rb_lung_Y.Checked == true) { rb_lung_ = "Y"; } else if (rb_lung_N.Checked == true) { rb_lung_ = "N"; } else { rb_lung_ = "-"; }
                if (rb_HighBlood_Y.Checked == true) { rb_HighBlood_ = "Y"; } else if (rb_HighBlood_N.Checked == true) { rb_HighBlood_ = "N"; } else { rb_HighBlood_ = "-"; }
                if (rb_Heart_Y.Checked == true) { rb_Heart_ = "Y"; } else if (rb_Heart_N.Checked == true) { rb_Heart_ = "N"; } else { rb_Heart_ = "-"; }
                if (rb_fever_Y.Checked == true) { rb_fever_ = "Y"; } else if (rb_fever_N.Checked == true) { rb_fever_ = "N"; } else { rb_fever_ = "-"; }
                if (rb_diabetes_Y.Checked == true) { rb_diabetes_ = "Y"; } else if (rb_diabetes_N.Checked == true) { rb_diabetes_ = "N"; } else { rb_diabetes_ = "-"; }
                if (rb_endocrine_Y.Checked == true) { rb_endocrine_ = "Y"; } else if (rb_endocrine_N.Checked == true) { rb_endocrine_ = "N"; } else { rb_endocrine_ = "-"; }
                if (rb_cancer_Y.Checked == true) { rb_cancer_ = "Y"; } else if (rb_cancer_N.Checked == true) { rb_cancer_ = "N"; } else { rb_cancer_ = "-"; }
                if (rb_blood_Y.Checked == true) { rb_blood_ = "Y"; } else if (rb_blood_N.Checked == true) { rb_blood_ = "N"; } else { rb_blood_ = "-"; }
                if (rb_stomach_Y.Checked == true) { rb_stomach_ = "Y"; } else if (rb_stomach_N.Checked == true) { rb_stomach_ = "N"; } else { rb_stomach_ = "-"; }
                if (rb_abdominal_Y.Checked == true) { rb_abdominal_ = "Y"; } else if (rb_abdominal_N.Checked == true) { rb_abdominal_ = "N"; } else { rb_abdominal_ = "-"; }
                if (rb_kidney_Y.Checked == true) { rb_kidney_ = "Y"; } else if (rb_kidney_N.Checked == true) { rb_kidney_ = "N"; } else { rb_kidney_ = "-"; }
                if (rb_back_Y.Checked == true) { rb_back_ = "Y"; } else if (rb_back_N.Checked == true) { rb_back_ = "N"; } else { rb_back_ = "-"; }
                if (rb_Genetic_Y.Checked == true) { rb_Genetic_ = "Y"; } else if (rb_Genetic_N.Checked == true) { rb_Genetic_ = "N"; } else { rb_Genetic_ = "-"; }
                if (rb_sexual_Y.Checked == true) { rb_sexual_ = "Y"; } else if (rb_sexual_N.Checked == true) { rb_sexual_ = "N"; } else { rb_sexual_ = "-"; }
                if (rb_last_Y.Checked == true) { rb_last_ = "Y"; } else if (rb_last_N.Checked == true) { rb_last_ = "N"; } else { rb_last_ = "-"; }
                if (rb_tropical_Y.Checked == true) { rb_tropical_ = "Y"; } else if (rb_tropical_N.Checked == true) { rb_tropical_ = "N"; } else { rb_tropical_ = "-"; }
                if (rb_schis_Y.Checked == true) { rb_schis_ = "Y"; } else if (rb_schis_N.Checked == true) { rb_schis_ = "N"; } else { rb_schis_ = "-"; }
                if (rb_asthma_Y.Checked == true) { rb_asthma_ = "Y"; } else if (rb_asthma_N.Checked == true) { rb_asthma_ = "N"; } else { rb_asthma_ = "-"; }
                if (rb_allergies_Y.Checked == true) { rb_allergies_ = "Y"; } else if (rb_allergies_N.Checked == true) { rb_allergies_ = "N"; } else { rb_allergies_ = "-"; }
                if (rb_gyn_Y.Checked == true) { rb_gyn_ = "Y"; } else if (rb_gyn_N.Checked == true) { rb_gyn_ = "N"; } else { rb_gyn_ = "-"; }
                if (rb_operational_Y.Checked == true) { rb_operational_ = "Y"; } else if (rb_operational_N.Checked == true) { rb_operational_ = "N"; } else { rb_operational_ = "-"; }
                if (cb_consulted.Checked == true) { cb_consulted_ = "Y"; } else if (cb_consulted.Checked == false) { cb_consulted_ = "N"; } else { cb_consulted_ = "-"; }
                if (rb_operational_N.Checked == true) { operations_tag_ = "N"; } else if (rb_operational_Y.Checked == true) { operations_tag_ = "Y"; } else { operations_tag_ = "-"; }

                if (q1_Y.Checked == true) { q1_ = "Y"; } else if (q1_N.Checked == true) { q1_ = "N"; } else { q1_ = "-"; }
                if (q2_Y.Checked == true) { q2_ = "Y"; } else if (q2_N.Checked == true) { q2_ = "N"; } else { q2_ = "-"; }
                if (q3_Y.Checked == true) { q3_ = "Y"; } else if (q3_N.Checked == true) { q3_ = "N"; } else { q3_ = "-"; }
                if (q4_Y.Checked == true) { q4_ = "Y"; } else if (q4_N.Checked == true) { q4_ = "N"; } else { q4_ = "-"; }
                if (q5_Y.Checked == true) { q5_ = "Y"; } else if (q5_N.Checked == true) { q5_ = "N"; } else { q5_ = "-"; }
                if (q6_Y.Checked == true) { q6_ = "Y"; } else if (q6_N.Checked == true) { q6_ = "N"; } else { q6_ = "-"; }
                if (q7_Y.Checked == true) { q7_ = "Y"; } else if (q7_N.Checked == true) { q7_ = "N"; } else { q7_ = "-"; }
                if (q8_Y.Checked == true) { q8_ = "Y"; } else if (q8_N.Checked == true) { q8_ = "N"; } else { q8_ = "-"; }

                if (cb_ishihara_u.Checked == true) { ISHIHARA_U_ = "1"; } else { ISHIHARA_U_ = "0"; }
                if (rb_clarity_Speech_AD.Checked == true) { CLARITY_OF_SPEECH_ = "A"; } else if (rb_clarity_Speech_IN.Checked == true) { CLARITY_OF_SPEECH_ = "I"; } else { CLARITY_OF_SPEECH_ = "-"; }
                if (rb_fit_lookOut_Y.Checked == true) { FIT_FOR_LOOKOUT_ = "YES"; } else if (rb_fit_lookOut_N.Checked == true) { FIT_FOR_LOOKOUT_ = "NO"; } else { FIT_FOR_LOOKOUT_ = "-"; }
                if (rb_hearingRight_AD.Checked == true) { HEARING_RIGHT_ = "A"; } else if (rb_hearingRight_IA.Checked == true) { HEARING_RIGHT_ = "I"; } else { HEARING_RIGHT_ = "-"; }
                if (rb_hearingLeft_AD.Checked == true) { HEARING_LEFT_ = "A"; } else if (rb_hearingLeft_IA.Checked == true) { HEARING_LEFT_ = "I"; } else { HEARING_LEFT_ = "-"; }
                if (rb_visualReq_Y.Checked == true) { VISUAL_AIDS_REQUIRED_ = "YES"; } else if (rb_visualReq_N.Checked == true) { VISUAL_AIDS_REQUIRED_ = "NO"; } else { VISUAL_AIDS_REQUIRED_ = "-"; }
                if (rb_visual_worn_Spectacles.Checked == true) { VISUAL_AIDS_WORN_ = "SPECTACLES"; } else if (rb_visual_worn_ContactLenses.Checked == true) { VISUAL_AIDS_WORN_ = "CONTACTLENS"; } else { VISUAL_AIDS_WORN_ = "-"; }
                if (rb_indentity_Confirm_Y.Checked == true) { IDENTITY_CONFIRMED_ = "YES"; } else if (rb_indentity_Confirm_N.Checked == true) { IDENTITY_CONFIRMED_ = "NO"; } else { IDENTITY_CONFIRMED_ = "-"; }
                string con_as;
                if (cb_con_as.Checked == true) { con_as = "1"; } else { con_as = "0"; }

                if (cb_skin.Checked == true) { cb_skin_ = "1"; } else { cb_skin_ = "0"; }
                if (cb_neck.Checked == true) { cb_neck_ = "1"; } else { cb_neck_ = "0"; }
                if (cb_eyes.Checked == true) { cb_eyes_ = "1"; } else { cb_eyes_ = "0"; }
                if (cb_pupils.Checked == true) { cb_pupils_ = "1"; } else { cb_pupils_ = "0"; }
                if (cb_ears.Checked == true) { cb_ears_ = "1"; } else { cb_ears_ = "0"; }
                if (cb_nose.Checked == true) { cb_nose_ = "1"; } else { cb_nose_ = "0"; }
                if (cb_mought.Checked == true) { cb_mought_ = "1"; } else { cb_mought_ = "0"; }
                if (cb_thyroid.Checked == true) { cb_thyroid_ = "1"; } else { cb_thyroid_ = "0"; }
                if (cb_breast.Checked == true) { cb_breast_ = "1"; } else { cb_breast_ = "0"; }
                if (cb_lungs.Checked == true) { cb_lungs_ = "1"; } else { cb_lungs_ = "0"; }
                if (cb_heart.Checked == true) { cb_heart_ = "1"; } else { cb_heart_ = "0"; }
                if (cb_abdomen.Checked == true) { cb_abdomen_ = "1"; } else { cb_abdomen_ = "0"; }
                if (cb_back.Checked == true) { cb_back_ = "1"; } else { cb_back_ = "0"; }
                if (cb_anus.Checked == true) { cb_anus_ = "1"; } else { cb_anus_ = "0"; }
                if (cb_gu.Checked == true) { cb_gu_ = "1"; } else { cb_gu_ = "0"; }
                if (cb_inguinals.Checked == true) { cb_inguinals_ = "1"; } else { cb_inguinals_ = "0"; }
                if (cb_reflexes.Checked == true) { cb_reflexes_ = "1"; } else { cb_reflexes_ = "0"; }
                if (cb_extremeties.Checked == true) { cb_extremeties_ = "1"; } else { cb_extremeties_ = "0"; }
                if (cb_dental.Checked == true) { cb_dental_ = "1"; } else { cb_dental_ = "0"; }


                if (rb_cxr_normal.Checked == true) { cxr_normal_ = "NORMAL"; } else if (this.rb_cxr_with.Checked == true) { cxr_normal_ = "WITH_F"; } else { cxr_normal_ = "-"; }
                if (rb_ecg_normal.Checked == true) { ecg_normal_ = "NORMAL"; } else if (this.rb_ecg_with.Checked == true) { ecg_normal_ = "WITH_F"; } else { ecg_normal_ = "-"; }
                if (rb_cbd_normal.Checked == true) { cbd_normal_ = "NORMAL"; } else if (this.rb_cbc_with.Checked == true) { cbd_normal_ = "WITH_F"; } else { cbd_normal_ = "-"; }
                if (rb_urinal_normal.Checked == true) { urinal_normal_ = "NORMAL"; } else if (this.rb_urinal_with.Checked == true) { urinal_normal_ = "WITH_F"; } else { urinal_normal_ = "-"; }
                if (rb_stool_normal.Checked == true) { stool_normal_ = "NORMAL"; } else if (this.rb_stool_with.Checked == true) { stool_normal_ = "WITH_F"; } else { stool_normal_ = "-"; }
                if (rb_hb_reactive.Checked == true) { hb_Nonreactive_ = "REACTIVE"; } else if (rb_hb_Nonreactive.Checked == true) { hb_Nonreactive_ = "NON REACTIVE"; } else { hb_Nonreactive_ = "-"; }
                if (rb_hiv_Reactive.Checked == true) { hiv_NonReactive_ = "REACTIVE"; } else if (rb_hiv_NonReactive.Checked == true) { hiv_NonReactive_ = "Nonreactive"; } else { hiv_NonReactive_ = "-"; }
                if (rb_rpr_Reactive.Checked == true) { rpr_NonReactive_ = "REACTIVE"; } else if (rb_rpr_NonReactive.Checked == true) { rpr_NonReactive_ = "NONREACTIVE"; } else { rpr_NonReactive_ = "-"; }
                if (rb_psych_recomend.Checked == true) { psychological_exam_ = "RECOMMEND"; }
                else if (rb_psych_NR.Checked == true) { psychological_exam_ = "NR"; }
                else if (rb_psych_ND.Checked == true) { psychological_exam_ = "ND"; }
                else if (rb_psych_RecWithRes.Checked == true) { psychological_exam_ = "RESERVE"; } else { psychological_exam_ = "-"; }

                if (rb_doh_pass.Checked == true) { rb_doh_pass_ = "Y"; } else if (rb_basic_doh_with.Checked == true) { rb_doh_pass_ = "N"; } else { rb_doh_pass_ = "-"; }
                if (rb_ladTest_pass.Checked == true) { rb_ladTest_pass_ = "Y"; } else if (this.rb_add_lab_test_With.Checked == true) { rb_ladTest_pass_ = "N"; } else { rb_ladTest_pass_ = "-"; }
                if (rb_flag_pass.Checked == true) { rb_flag_pass_ = "Y"; } else if (this.rb_flag_with.Checked == true) { rb_flag_pass_ = "N"; } else { rb_flag_pass_ = "-"; }
                if (rb_deck_fit.Checked == true) { deck_srvc_flag_ = "Y"; } else if (this.rb_deck_UFit.Checked == true) { deck_srvc_flag_ = "N"; } else { deck_srvc_flag_ = "-"; }
                if (rb_engine_Fit.Checked == true) { engine_srvc_flag_ = "Y"; } else if (this.rb_engine_Ufit.Checked == true) { engine_srvc_flag_ = "N"; } else { engine_srvc_flag_ = "-"; }
                if (rb_catering_fit.Checked == true) { catering_srvc_flag_ = "Y"; } else if (this.rb_catering_Ufit.Checked == true) { catering_srvc_flag_ = "N"; } else { catering_srvc_flag_ = "-"; }
                if (rb_other_Fit.Checked == true) { other_srvc_flag_ = "Y"; } else if (this.rb_other_uFit.Checked == true) { other_srvc_flag_ = "N"; } else { other_srvc_flag_ = "-"; }

                //ClassSql a = new ClassSql();           //rb_head_;                                             rb_freqHead_;                                             rb_dizziness_;                                          rb_spells_;                                rb_Insomia_;                                    rb_depression_;                                               rb_trachoma_;                    rb_deaf_;                                                             rb_nose_;                               rb_tuberculosis_;                                           rb_lung_;                                          rb_HighBlood_;                                          rb_Heart_;                                  rb_fever_;                                          rb_diabetes_;                                rb_endocrine_;                                                      rb_cancer_;                                rb_blood_;                                      rb_stomach_;                                                                    rb_abdominal_;                                      rb_kidney_;                                         rb_back_;                                         rb_Genetic_;                                         rb_sexual_;                                                      rb_last_;                                                                            rb_tropical_;                      rb_schis_; rb_asthma_; ; ; rb_operational
                // string a =  "UPDATE `t_med_history` SET `head_injury`={0}, `frequent_headaches`={1}, `frequent_dizziness`={2}, `fainting_spells`={3}, `insomnia`={4}, `depression`={5}, `trachoma`={6}, `deafness`={7}, `nose_throat_disorder`={8}, `tuberculosis`={9}, `other_lung_disorder`={10}, `high_blood_pressure`={11}, `heart_disease`={12}, `rheumatic_fever`={13}, `diabetes_mellitus`={14}, `other_endocrine_disorder`={15}, `cancer_tumor`={16}, `blood_disorders`={17}, `stomach_pain`={18}, `other_abdominal_disorder`={19}, `kidney_bladder_disorder`={20}, `back_injury`={21}, `genetic_hereditary`={22}, `sexually_transmit_disease`={23}, `tropical_disease`={24}, `asthma`={25}, `allergies`={26}, `gynecological_disorder`={27}, `operations`={28}, `operations_specify`={29}, `others`={30}, `consulted`={31}, `consulted_specify`={32}, `maintenance_meds`={33}, `operations_tag`={34}, `schistosomiasis`={35}, `last_menstrual_period`={36}, `allergies_specify`={37}, `other_abdominal_specify`={38} WHERE (`cn`={39})";
                // string b =  "UPDATE `t_med_history2` SET `column1`='" + q1_.ToString() + "', `column2`='" + q2_.ToString() + "', `column3`='" + q3_.ToString() + "', `column4`='" + q4_.ToString() + "', `column5`='" + q5_.ToString() + "', `column6`='" + q6_.ToString() + "', `column7`='" + q7_.ToString() + "', `column7_comment`='" + Tool.ReplaceString(txt_q7_Comment.Text) + "', `column8`='" + q8_.ToString() + "', `column8_comment`='" + Tool.ReplaceString(txt_q8_comment.Text) + "' WHERE (`cn`='" + lbl_history2_cn.Tag.ToString() + "') LIMIT 1";
                //string c =  "UPDATE `t_phy_exam` SET `HEIGHT`='" + Tool.ReplaceString(x_height.Text) + "', `WEIGHT`='" + Tool.ReplaceString(x_weight.Text) + "', `BP`='" + Tool.ReplaceString(this.x_bp.Text) + "', `PULSE`='" + Tool.ReplaceString(this.x_pulse.Text) + "', `RESPIRATION`='" + Tool.ReplaceString(this.x_respiration.Text) + "', `BODY_BUILD`='" + Tool.ReplaceString(this.x_body_Build.Text) + "', `FAR_OD_U`='" + Tool.ReplaceString(this.x_far_u.Text) + "', `FAR_OD_C`='" + Tool.ReplaceString(this.x_far_c.Text) + "', `FAR_OS_U`='" + Tool.ReplaceString(this.x_far_os_u.Text) + "', `FAR_OS_C`='" + Tool.ReplaceString(this.x_far_os_c.Text) + "', `NEAR_ODJ_U`='" + Tool.ReplaceString(this.x_Near_odj_u.Text) + "', `NEAR_ODJ_C`='" + Tool.ReplaceString(this.x_near_odj_c.Text) + "', `NEAR_OSJ_U`='" + Tool.ReplaceString(this.x_near_osj_u.Text) + "', `NEAR_OSJ_C`='" + Tool.ReplaceString(this.x_near_osj_c.Text) + "', `ISHIHARA_U`='" + ISHIHARA_U_.ToString() + "', `ISHIHARA_C`='" + Tool.ReplaceString(cbo_ishihara_c.Text) + "', `HEARING_AD`='" + Tool.ReplaceString(this.x_hearing_Ad.Text) + "', `HEARING_AS`='" + Tool.ReplaceString(this.x_hearing_as.Text) + "',  `CONVERSATIONAL_AD`='" + Tool.ReplaceString(this.x_Con_ad.Text) + "', `CONVERSATIONAL_AS`='"+con_as.ToString() +"',`SATISFACTORY_HEARING`='" + Tool.ReplaceString(this.cb_satisfactory_Hearing.Text) + "',  `SATISFACTORY_SIGHT_UNAID`='" + Tool.ReplaceString(cbo_satisfactory_Unaided.Text) + "',  `VISUAL_AIDS`='" + Tool.ReplaceString(cbo_visual_Aids.Text) + "', `FIT_FOR_LOOKOUT`='" + FIT_FOR_LOOKOUT_.ToString() + "', `HEARING_RIGHT`='" + HEARING_RIGHT_.ToString() + "', `HEARING_LEFT`='" + HEARING_LEFT_.ToString() + "', `CLARITY_OF_SPEECH`='" + CLARITY_OF_SPEECH_.ToString() + "', `VISUAL_AIDS_REQUIRED`='" + VISUAL_AIDS_REQUIRED_.ToString() + "', `BP_DIASTOLIC`='" + Tool.ReplaceString(x_bp_dias.Text) + "', `RHYTHM`='" + Tool.ReplaceString(x_rhythm.Text) + "', `VISUAL_AIDS_WORN`='" + VISUAL_AIDS_WORN_.ToString() + "', `COLOR_VISION_DATE_TAKEN`='" + Tool.ReplaceString(dt_dateTaken.Text) + "', `UNAIDED_HEARING_SATISFACTORY`='" + Tool.ReplaceString(cbo_unaided_hearing.Text) + "', `IDENTITY_CONFIRMED`='" + IDENTITY_CONFIRMED_.ToString() + "' WHERE (`cn`='" + lbl_physicalExam_cn.Tag.ToString() + "') LIMIT 1";

                // string d =    "UPDATE `t_others` SET `SKIN_TAG`='" + cb_skin_.ToString() + "', `SKIN`='" + Tool.ReplaceString(x_skin.Text) + "', `HEAD_NECK_SCALP_TAG`='" + cb_neck_.ToString() + "', `HEAD_NECK_SCALP`='" + Tool.ReplaceString(x_neck.Text) + "', `EYES_TAG`='" + cb_eyes_.ToString() + "', `EYES`='" + Tool.ReplaceString(x_eyes.Text) + "', `PUPILS_TAG`='" + cb_pupils_.ToString() + "', `PUPILS`='" + Tool.ReplaceString(x_pupils.Text) + "', `EARS_EARDRUM_TAG`='" + cb_ears_.ToString() + "', `EARS_EARDRUM`='" + Tool.ReplaceString(x_ears.Text) + "', `NOSE_SINUSES_TAG`='" + cb_nose_.ToString() + "', `NOSE_SINUSES`='" + Tool.ReplaceString(x_nose.Text) + "', `MOUTH_THROAT_TAG`='" + cb_mought_.ToString() + "', `MOUTH_THROAT`='" + Tool.ReplaceString(x_mouth.Text) + "', `NECK_LN_THYROID_TAG`='" + cb_neck_.ToString() + "', `NECK_LN_THYROID`='" + Tool.ReplaceString(x_thyroid.Text) + "', `CHEST_BREAST_AXILLA_TAG`='" + cb_breast_.ToString() + "', `CHEST_BREAST_AXILLA`='" + Tool.ReplaceString(x_breast.Text) + "', `LUNGS_TAG`='" + cb_lungs_.ToString() + "', `LUNGS`='" + Tool.ReplaceString(x_lungs.Text) + "', `HEART_TAG`='" + cb_heart_.ToString() + "', `HEART`='" + Tool.ReplaceString(x_heart.Text) + "', `ABDOMEN_TAG`='" + cb_abdomen_.ToString() + "', `ABDOMEN`='" + Tool.ReplaceString(x_abdomen.Text) + "', `BACK_FLANK_TAG`='" + cb_back_.ToString() + "', `BACK_FLANK`='" + Tool.ReplaceString(x_back.Text) + "', `ANUS_RECTUM_TAG`='" + cb_anus_.ToString() + "', `ANUS_RECTUM`='" + Tool.ReplaceString(x_anus.Text) + "', `GU_SYSTEM_TAG`='" + cb_gu_.ToString() + "', `GU_SYSTEM`='" + Tool.ReplaceString(x_gu.Text) + "', `INGUINALS_GENITALS_TAG`='" + cb_inguinals_.ToString() + "', `INGUINALS_GENITALS`='" + Tool.ReplaceString(x_inguinals.Text) + "', `REFLEXES_TAG`='" + cb_reflexes_.ToString() + "', `REFLEXES`='" + Tool.ReplaceString(x_reflexes.Text) + "', `EXTREMITIES_TAG`='" + cb_extremeties_.ToString() + "', `EXTREMITIES`='" + Tool.ReplaceString(x_extremeties.Text) + "', `DENTAL`='" + Tool.ReplaceString(x_dental.Text) + "', `DENTAL_TAG`='" + cb_dental_.ToString() + "' WHERE (`cn`='" + lbl_other_cn.Tag.ToString() + "') LIMIT 1";
                // string e =    "UPDATE `t_ancillary` SET `cxr`='" + cxr_normal_.ToString() + "', `ecg`='" + ecg_normal_.ToString() + "', `cbc`='" + cbd_normal_.ToString() + "', `pregnancy_test`='" + Tool.ReplaceString(cbo_pregnancyTest.Text) + "', `urinalysis`='" + urinal_normal_.ToString() + "', `stool_exam`='" + stool_normal_.ToString() + "', `hbsag`='" + hb_Nonreactive_.ToString() + "', `hiv`='" + hiv_NonReactive_.ToString() + "', `rpr`='" + rpr_NonReactive_.ToString() + "', `blood_type`='" + Tool.ReplaceString(cbo_bloodType.Text) + "',  `psychological_exam`='" + psychological_exam_.ToString() + "', `additional_test`='" + Tool.ReplaceString(x_add_test1.Text) + "', `remarks`='" + Tool.ReplaceString(x_remark.Text) + "', `additional_test2`='" + Tool.ReplaceString(x_add_test2.Text) + "' WHERE (`cn`='" + lbl_cn_acillary.Tag.ToString() + "') LIMIT 1";
                // string f =    "UPDATE `t_result_main` SET `result_date`='" + dt_resultDate.Text + "', `pathologist`='" + Tool.ReplaceString(txt_medDir_Cbo.Text) + "', `fitness_date`='" + dt_fitness_Date.Text + "', `valid_until`='" + dt_validUntil.Text + "', `remarks`='" + Tool.ReplaceString(x_remark_rec.Text) + "', `restriction`='" + Tool.ReplaceString(x_restriction.Text) + "', `specimen_no`='" + Tool.ReplaceString(x_speciment.Text) + "', `medtech`='" + Tool.ReplaceString(cbo_medtech.Text) + "', medtech_license ='" + MedtectLicence.ToString() + "', `basic_doh_exam`='" + rb_doh_pass_.ToString() + "', `add_lab_tests`='" + rb_ladTest_pass_.ToString() + "', `flag_medlab_req`='" + rb_flag_pass_.ToString() + "',`deck_srvc_flag`='" + deck_srvc_flag_.ToString() + "', `engine_srvc_flag`='" + engine_srvc_flag_.ToString() + "', `catering_srvc_flag`='" + catering_srvc_flag_.ToString() + "', `other_srvc_flag`='" + other_srvc_flag_.ToString() + "' ,`recommendation`='" + Tool.ReplaceString(cbo_recomendation.Text) + "' WHERE (`cn`='" + lbl_recomendation_cn.Tag.ToString() + "') LIMIT 1";

                //Search_MedicalHistory(); search_Ancillary(); Search_medicalHistory2(); Search_others();  Search_PhyExam(); search_Recomendation();
                //    var arr = new[] { a,b,c,d,e,f };`
                // File.WriteAllLines(ClassSql.tmp_path, arr);

                db.ExecuteCommand("UPDATE t_med_history SET head_injury={0}, frequent_headaches={1}, frequent_dizziness={2}, fainting_spells={3}, insomnia={4}, depression={5}, trachoma={6}, deafness={7}, nose_throat_disorder={8}, tuberculosis={9}, other_lung_disorder={10}, high_blood_pressure={11}, heart_disease={12}, rheumatic_fever={13}, diabetes_mellitus={14}, other_endocrine_disorder={15}, cancer_tumor={16}, blood_disorders={17}, stomach_pain={18}, other_abdominal_disorder={19}, kidney_bladder_disorder={20}, back_injury={21}, genetic_hereditary={22}, sexually_transmit_disease={23}, tropical_disease={24}, asthma={25}, allergies={26}, gynecological_disorder={27}, operations={28}, operations_specify={29}, others={30}, consulted={31}, consulted_specify={32}, maintenance_meds={33}, operations_tag={34}, schistosomiasis={35}, last_menstrual_period={36}, allergies_specify={37}, other_abdominal_specify={38} WHERE (cn={39})", rb_head_.ToString(), rb_freqHead_.ToString(), rb_dizziness_.ToString(), rb_spells_.ToString(), rb_Insomia_.ToString(), rb_depression_.ToString(), rb_trachoma_.ToString(), rb_deaf_.ToString(), rb_nose_.ToString(), rb_tuberculosis_.ToString(), rb_lung_.ToString(), rb_HighBlood_.ToString(), rb_Heart_.ToString(), rb_fever_.ToString(), rb_diabetes_.ToString(), rb_endocrine_.ToString(), rb_cancer_.ToString(), rb_blood_.ToString(), rb_stomach_.ToString(), rb_abdominal_.ToString(), rb_kidney_.ToString(), rb_back_.ToString(), rb_Genetic_.ToString(), rb_sexual_.ToString(), rb_tropical_.ToString(), rb_asthma_.ToString(), rb_allergies_.ToString(), rb_gyn_.ToString(), rb_operational_.ToString(), Tool.ReplaceString(txt_operational_specify.Text), Tool.ReplaceString(tx_other_History.Text), cb_consulted_.ToString(), Tool.ReplaceString(txt_consulted.Text), Tool.ReplaceString(txt_maintenance.Text), rb_operational_.ToString(), rb_schis_.ToString(), rb_last_.ToString(), Tool.ReplaceString(txt_allergies_specify.Text), Tool.ReplaceString(txt_abdominal_specify.Text), lbl_history1_cn.Tag.ToString());
                db.ExecuteCommand("UPDATE t_med_history2 SET column1={0}, column2={1}, column3={2}, column4={3}, column5={4}, column6={5}, column7={6}, column7_comment={7}, column8={8}, column8_comment={9},column1_comment={10},column2_comment={11},column3_comment={12},column4_comment={13},column5_comment={14},column6_comment={15} WHERE cn={16}", q1_.ToString(), q2_.ToString(), q3_.ToString(), q4_.ToString(), q5_.ToString(), q6_.ToString(), q7_.ToString(), txt_q7_Comment.Text, q8_.ToString(), txt_q8_comment.Text, txt_comment_1.Text, txt_comment_2.Text, txt_comment_3.Text, txt_comment_4.Text, txt_comment_5.Text, txt_comment_6.Text, lbl_history2_cn.Tag.ToString());
                db.ExecuteCommand("UPDATE t_phy_exam SET HEIGHT={0}, WEIGHT={1}, BP={2}, PULSE={3}, RESPIRATION={4}, BODY_BUILD={5}, FAR_OD_U={6}, FAR_OD_C={7}, FAR_OS_U={8}, FAR_OS_C={9}, NEAR_ODJ_U={10}, NEAR_ODJ_C={11}, NEAR_OSJ_U={12}, NEAR_OSJ_C={13}, ISHIHARA_U={14}, ISHIHARA_C={15}, HEARING_AD={16}, HEARING_AS={17},  CONVERSATIONAL_AD={18}, CONVERSATIONAL_AS={19},SATISFACTORY_HEARING={20},  SATISFACTORY_SIGHT_UNAID={21},  VISUAL_AIDS={22}, FIT_FOR_LOOKOUT={23}, HEARING_RIGHT={24}, HEARING_LEFT={25}, CLARITY_OF_SPEECH={26}, VISUAL_AIDS_REQUIRED={27}, BP_DIASTOLIC={28}, RHYTHM={29}, VISUAL_AIDS_WORN={30}, COLOR_VISION_DATE_TAKEN={31}, UNAIDED_HEARING_SATISFACTORY={32}, IDENTITY_CONFIRMED={33} WHERE cn={34}", x_height.Text, x_weight.Text, x_bp.Text, x_pulse.Text, x_respiration.Text, x_body_Build.Text, x_far_u.Text, x_far_c.Text, x_far_os_u.Text, x_far_os_c.Text, x_Near_odj_u.Text, x_near_odj_c.Text, x_near_osj_u.Text, x_near_osj_c.Text, ISHIHARA_U_.ToString(), cbo_ishihara_c.Text, x_hearing_Ad.Text, x_hearing_as.Text, x_Con_ad.Text, con_as.ToString(), cb_satisfactory_Hearing.Text, cbo_satisfactory_Unaided.Text, cbo_visual_Aids.Text, FIT_FOR_LOOKOUT_.ToString(), HEARING_RIGHT_.ToString(), HEARING_LEFT_.ToString(), CLARITY_OF_SPEECH_.ToString(), VISUAL_AIDS_REQUIRED_.ToString(), x_bp_dias.Text, x_rhythm.Text, VISUAL_AIDS_WORN_.ToString(), dt_dateTaken.Text, cbo_unaided_hearing.Text, IDENTITY_CONFIRMED_.ToString(), lbl_physicalExam_cn.Tag.ToString());
                db.ExecuteCommand("UPDATE t_others SET SKIN_TAG={0}, SKIN={1}, HEAD_NECK_SCALP_TAG={2}, HEAD_NECK_SCALP={3}, EYES_TAG={4}, EYES={5}, PUPILS_TAG={6}, PUPILS={7}, EARS_EARDRUM_TAG={8}, EARS_EARDRUM={9}, NOSE_SINUSES_TAG={10}, NOSE_SINUSES={11}, MOUTH_THROAT_TAG={12}, MOUTH_THROAT={13}, NECK_LN_THYROID_TAG={14}, NECK_LN_THYROID={15}, CHEST_BREAST_AXILLA_TAG={16}, CHEST_BREAST_AXILLA={17}, LUNGS_TAG={18}, LUNGS={19}, HEART_TAG={20}, HEART={21}, ABDOMEN_TAG={22}, ABDOMEN={23}, BACK_FLANK_TAG={24}, BACK_FLANK={25}, ANUS_RECTUM_TAG={26}, ANUS_RECTUM={27}, GU_SYSTEM_TAG={28}, GU_SYSTEM={29}, INGUINALS_GENITALS_TAG={30}, INGUINALS_GENITALS={31}, REFLEXES_TAG={32}, REFLEXES={33}, EXTREMITIES_TAG={34}, EXTREMITIES={35}, DENTAL={36}, DENTAL_TAG={37} WHERE cn= {38}", cb_skin_.ToString(), x_skin.Text, cb_neck_.ToString(), x_neck.Text, cb_eyes_.ToString(), x_eyes.Text, cb_pupils_.ToString(), x_pupils.Text, cb_ears_.ToString(), x_ears.Text, cb_nose_.ToString(), x_nose.Text, cb_mought_.ToString(), x_mouth.Text, cb_neck_.ToString(), x_thyroid.Text, cb_breast_.ToString(), x_breast.Text, cb_lungs_.ToString(), x_lungs.Text, cb_heart_.ToString(), x_heart.Text, cb_abdomen_.ToString(), x_abdomen.Text, cb_back_.ToString(), x_back.Text, cb_anus_.ToString(), x_anus.Text, cb_gu_.ToString(), x_gu.Text, cb_inguinals_.ToString(), x_inguinals.Text, cb_reflexes_.ToString(), x_reflexes.Text, cb_extremeties_.ToString(), x_extremeties.Text, x_dental.Text, cb_dental_.ToString(), lbl_other_cn.Tag.ToString());
                db.ExecuteCommand("UPDATE t_ancillary SET cxr={0}, ecg={1}, cbc={2}, pregnancy_test={3}, urinalysis={4}, stool_exam={5}, hbsag={6}, hiv={7}, rpr={8}, blood_type={9},  psychological_exam={10}, additional_test={11}, remarks={12}, additional_test2={13} WHERE cn={14}", cxr_normal_.ToString(), ecg_normal_.ToString(), cbd_normal_.ToString(), cbo_pregnancyTest.Text, urinal_normal_.ToString(), stool_normal_.ToString(), hb_Nonreactive_.ToString(), hiv_NonReactive_.ToString(), rpr_NonReactive_.ToString(), cbo_bloodType.Text.Replace("+", ""), psychological_exam_.ToString(), x_add_test1.Text, x_remark.Text, x_add_test2.Text, lbl_cn_acillary.Tag.ToString());
                db.ExecuteCommand("UPDATE t_result_main SET result_date={0},     pathologist={1},    fitness_date={2},   valid_until={3},    remarks={4},        restriction={5},    specimen_no={6}, medtech={7},     medtech_license ={8},       basic_doh_exam={9},        add_lab_tests={10},        flag_medlab_req={11},        deck_srvc_flag={12},          engine_srvc_flag={13},       catering_srvc_flag={14},       other_srvc_flag={15} ,   recommendation={16} WHERE cn={17}", dt_resultDate.Text, txt_medDir_Cbo.Text, dt_fitness_Date.Text, dt_validUntil.Text, x_remark_rec.Text, x_restriction.Text, x_speciment.Text, cbo_medtech.Text, MedtectLicence.ToString(), rb_doh_pass_.ToString(), rb_ladTest_pass_.ToString(), rb_flag_pass_.ToString(), deck_srvc_flag_.ToString(), engine_srvc_flag_.ToString(), catering_srvc_flag_.ToString(), other_srvc_flag_.ToString(), cbo_recomendation.Text, lbl_recomendation_cn.Tag.ToString());


                //dt_resultDate.Text, txt_medDir_Cbo.Text, dt_fitness_Date.Text, dt_validUntil.Text, x_remark_rec.Text, x_restriction.Text, x_speciment.Text, cbo_medtech.Text, MedtectLicence.ToString(), rb_doh_pass_.ToString(), rb_ladTest_pass_.ToString(), deck_srvc_flag_.ToString(), engine_srvc_flag_.ToString(), catering_srvc_flag_.ToString(), other_srvc_flag_.ToString(), cbo_recomendation.Text, lbl_recomendation_cn.Tag.ToString()
                //Tool.MessageBoxUpdate();
                pin.Select();
                NewSeabase = true;
                Availability(false);
                fmain.ts_add_sea.Enabled = true; fmain.ts_edit_sea.Enabled = true; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = false; fmain.ts_cancel_sea.Enabled = false; fmain.ts_search_sea.Enabled = true; fmain.ts_print_sea.Enabled = true;

                txt_operational_specify.Enabled = false;
                tx_other_History.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}


        }
        //public void Update_MedHistory2()
        //{
        //    try
        //    {





        //        ClassSql a = new ClassSql();             
        //             Search_medicalHistory2();
        //        //Tool.MessageBoxUpdate();


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        if (ClassSql.cnn != null) { ClassSql.DbClose(); }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }


        //}

        //public void Update_Physical_Exam()
        //{
        //    try
        //    {

        //        //if (cb_ishihara_u.Checked == true) { ISHIHARA_U_ = "1"; } else { ISHIHARA_U_ = "0"; }
        //        //if (rb_clarity_Speech_AD.Checked == true) { CLARITY_OF_SPEECH_ = "A"; } else { CLARITY_OF_SPEECH_ = "I"; }
        //        //if (rb_fit_lookOut_Y.Checked == true) { FIT_FOR_LOOKOUT_ = "YES"; } else { FIT_FOR_LOOKOUT_ = "NO"; }
        //        //if (rb_hearingRight_AD.Checked == true) { HEARING_RIGHT_ = "A"; } else { HEARING_RIGHT_ = "I"; }
        //        //if (rb_hearingLeft_AD.Checked == true) { HEARING_LEFT_ = "A"; } else { HEARING_LEFT_ = "I"; }
        //        //if (rb_visualReq_Y.Checked == true) { VISUAL_AIDS_REQUIRED_ = "YES"; } else { VISUAL_AIDS_REQUIRED_ = "NO"; }
        //        //if (rb_visual_worn_Spectacles.Checked == true) { VISUAL_AIDS_WORN_ = "SPECTACLES"; } else { VISUAL_AIDS_WORN_ = "CONTACTLENS"; }
        //        //if (rb_indentity_Confirm_Y.Checked == true) { IDENTITY_CONFIRMED_ = "YES"; } else { IDENTITY_CONFIRMED_ = "NO"; }





        //        ClassSql a = new ClassSql();

        //           Search_PhyExam();



        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        if (ClassSql.cnn != null) { ClassSql.DbClose(); }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }


        //}
        //public void Update_Others()
        //{
        //    try
        //    {







        //        //ClassSql a = new ClassSql();

        //        Search_others();



        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }


        //}
        //public void Update_Ancillary()
        //{
        //    try
        //    {






        //        ClassSql a = new ClassSql();
        //             search_Ancillary();



        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        if (ClassSql.cnn != null) { ClassSql.DbClose(); }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }


        //}
        //    public void Update_ResultMain()
        //    {
        //        try
        //        {
        //ClassSql a = new ClassSql();

        //                  search_Recomendation();



        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //        }
        //        finally
        //        {
        //            if (ClassSql.cnn != null) { ClassSql.DbClose(); }
        //            if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //        }


        //    }

        public void Edit()
        {
            isEdit = true;

            if (fmain.UserLevel == 1 || fmain.UserLevel == 2)
            {
                NewSeabase = false;
                Availability(true);
                fmain.ts_add_sea.Enabled = false; fmain.ts_edit_sea.Enabled = false; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = true; fmain.ts_cancel_sea.Enabled = true; fmain.ts_search_sea.Enabled = false; fmain.ts_print_sea.Enabled = false;

            }
            else
            {
                MessageBox.Show("You do not have enough access privileges for this operation.", "Action Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void Delete()
        {



        }
        public void Cancel()
        {
            if (NewSeabase)
            {
                Tool.ClearFields(groupBox5);
                this.txt_Papin.Clear();
                ClearAll();
                Availability(false);
                fmain.ts_add_sea.Enabled = true; fmain.ts_edit_sea.Enabled = false; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = false; fmain.ts_search_sea.Enabled = true; fmain.ts_print_sea.Enabled = false; fmain.ts_cancel_sea.Enabled = false;
            }
            else
            {
                Availability(false);
                ClearAll();
                Search_Patient(); Search_MedicalHistory(); Search_medicalHistory2(); Search_PhyExam(); Search_others(); search_Ancillary(); search_RecomendationFromSearch();
                fmain.ts_add_sea.Enabled = true; fmain.ts_edit_sea.Enabled = true; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = false; fmain.ts_search_sea.Enabled = true; fmain.ts_print_sea.Enabled = true; fmain.ts_cancel_sea.Enabled = false;
            }

        }
        public void Print()
        {

            frm_Seabase_Print_Choice print = new frm_Seabase_Print_Choice();
            print.Resultid = LabID.Text;
            print.recomendation = cbo_recomendation.Text;
            print.MedCertNumber = x_speciment.Text;
            print.bloodType = cbo_bloodType.Text;
            print.age = txt_age.Text;
            print.Tag = LabID.Text;
            print.ShowDialog();
        }
        public void Search()
        {


        }




        private void frm_seaferer_MEC_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ClassSql.DbClose();
            //fmain.bseaferer = true;
            ////fmain.Strip_sub.Visible = false;
            //fmain.ts_add_sea.Enabled = true; fmain.ts_edit_sea.Enabled = false; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = false; fmain.ts_search_sea.Enabled = true; fmain.ts_print_sea.Enabled = false; fmain.ts_cancel_sea.Enabled = false;
        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void label109_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void label118_Click(object sender, EventArgs e)
        {

        }

        private void label120_Click(object sender, EventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_seaferer_MEC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fmain.ts_cancel_sea.Enabled == true)
                { Cancel(); }
                else
                { this.Close(); }

            }
            else if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_add_sea.Enabled == true)
                {

                    fmain.add_Seabase();
                }
            }

            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_save_sea.Enabled == true)
                {
                    Save();

                }

            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_print_sea.Enabled == true)
                {
                    Print();
                }
            }
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {

                if (fmain.ts_search_sea.Enabled == true)
                {
                    fmain.Search_seabase();
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (fmain.ts_edit_sea.Enabled == true)
                {
                    Edit();

                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (fmain.ts_delete_sea.Enabled == true)
                {

                    Delete();
                }

            }
        }

        //void Search_Patient_sub()
        //{
        //    try
        //    {

        //        ClassSql a = new ClassSql(); DataTable dt;

        //        dt = a.Table("SELECT t_result_main.cn, t_result_main.resultid, t_result_main.resulttype, t_result_main.papin, m_patient.lastname, m_patient.firstname, m_patient.middlename, m_patient.address_1, m_patient.address_2, m_patient.contact_1, m_patient.contact_2,   m_patient.`position`, m_patient.marital_status,  m_patient.gender, m_patient.place_of_birth, m_patient.employer, m_patient.passport_no, m_patient.nationality, m_patient.religion FROM t_result_main  Inner Join m_patient ON t_result_main.papin = m_patient.papin Where t_result_main.papin =  '" + Tool.ReplaceString(this.txt_Papin.Text) + "'");

        //        foreach (DataRow dr in dt.Rows)
        //        {

        //            LabID.Text = dr["resultid"].ToString();
        //            txtlastname.Text = dr["lastname"].ToString();
        //            txtFirstname.Text = dr["firstname"].ToString();
        //            txtMiddleName.Text = dr["middlename"].ToString();
        //            txt_pBirth.Text = dr["place_of_birth"].ToString();
        //            txt_nationality.Text = dr["nationality"].ToString();
        //            txt_add.Text = dr["address_1"].ToString();
        //            txt_employer.Text = dr["employer"].ToString();
        //            txt_passno.Text = dr["passport_no"].ToString();
        //            txt_gender.Text = dr["gender"].ToString();
        //            txt_position.Text = dr["position"].ToString();
        //            txt_rel.Text = dr["religion"].ToString();
        //            txt_status.Text = dr["marital_status"].ToString();
        //            txt_contact.Text = dr["contact_1"].ToString();


        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }


        //}

        public void Search_Patient()
        {
            try
            {

                // ClassSql a = new ClassSql(); DataTable dt;

                //  // dt = a.Table("SELECT * FROM m_patient  WHERE  papin LIKE   '%" + Tool.ReplaceString(pin.Text) + "%'");
                // dt = a.Mytable_Proc("Seabase_patient", "@ID", pin.Text);
                var i = db.sp_Seabase_Patient(pin.Text).FirstOrDefault();
                //foreach (var i in list)
                //{

                txtlastname.Text = i.lastname.ToString();
                txtFirstname.Text = i.firstname.ToString();
                txtMiddleName.Text = i.middlename.ToString();
                txt_pBirth.Text = i.place_of_birth.ToString();
                txt_nationality.Text = i.nationality.ToString();
                txt_add.Text = i.address_1.ToString();
                txt_employer.Text = i.employer.ToString();
                txt_passno.Text = i.passport_no.ToString();
                txt_gender.Text = i.gender.ToString();
                txt_position.Text = i.position.ToString();
                txt_rel.Text = i.religion.ToString();
                txt_status.Text = i.marital_status.ToString();
                txt_contact.Text = i.contact_1.ToString();
                txt_bday.Text = i.birthdate.ToString();

                //if (i.picture != null)
                //{
                //    byte[] b = i.picture.ToArray();
                //    MemoryStream ms = new MemoryStream(b);
                //    Image img = Image.FromStream(ms);
                //    using (var newImg = Tool.ScaleImage(img, 150, 200))
                //    {
                //        img.Save(ClassSql.SeabaseImage + "\\tmp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //    }

                //}

                // }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}


        }

        public void Availability(bool bl)
        {
           

            if (bl == true)
            { overlayShadow1.Visible = false; overlayShadow1.SendToBack(); }
            else
            { overlayShadow1.Visible = true; overlayShadow1.BringToFront(); }

        }
        public void ClearAll()
        {

            Tool.ClearFields(panel35);
            Tool.ClearFields(panel40);
            Tool.ClearFields(panel41);
            Tool.ClearFields(panel39);
            Tool.ClearFields(panel38);
            Tool.ClearFields(panel62);
            Tool.ClearFields(panel33);
            Tool.ClearFields(panel64);
            Tool.ClearFields(panel36);           
            Tool.ClearFields(panel34);
            Tool.ClearFields(panel63);
            Tool.ClearFields(panel26);
            Tool.ClearFields(panel65);
            Tool.ClearFields(panel27);
            Tool.ClearFields(groupBox3);
            Tool.ClearFields(panel25);
            Tool.ClearFields(panel24);
            Tool.ClearFields(panel23);
            Tool.ClearFields(panel22);
            Tool.ClearFields(panel21);
            Tool.ClearFields(panel13);
            Tool.ClearFields(panel12);
            Tool.ClearFields(panel10);
            Tool.ClearFields(panel9);
            Tool.ClearFields(panel8);
            Tool.ClearFields(panel14);
            Tool.ClearFields(panel15);
            Tool.ClearFields(panel16);
            Tool.ClearFields(panel17);
            Tool.ClearFields(panel18);
            Tool.ClearFields(panel19);
            Tool.ClearFields(panel20);
            Tool.ClearFields(panel7);
            Tool.ClearFields(panel4);
            Tool.ClearFields(panel43);
            Tool.ClearFields(panel42);
            Tool.ClearFields(panel44);
            Tool.ClearFields(panel45);
            Tool.ClearFields(panel46);
            Tool.ClearFields(panel61);
            Tool.ClearFields(panel52);
            Tool.ClearFields(panel54);
            Tool.ClearFields(panel54);
            Tool.ClearFields(panel56);
            Tool.ClearFields(panel49);
            Tool.ClearFields(panel50);
            Tool.ClearFields(panel51);
            Tool.ClearFields(panel57);
            Tool.ClearFields(panel11);
            Tool.ClearFields(panel55);
            Tool.ClearFields(panel6);
            Tool.ClearFields(panel37);
            Tool.ClearFields(panel3);
            Tool.ClearFields(panel58);
            Tool.ClearFields(panel47);
            Tool.ClearFields(panel48);
            Tool.ClearFields(panel59);
            Tool.ClearFields(groupBox2);
            Tool.ClearFields(panel53);
            Tool.ClearFields(panel68);
            Tool.ClearFields(panel66);
            Tool.ClearFields(panel74);
            Tool.ClearFields(panel73);
            Tool.ClearFields(panel71);
            Tool.ClearFields(panel70);
            Tool.ClearFields(panel69);
            Tool.ClearFields(panel5);
            Tool.ClearFields(panel72);
            Tool.ClearFields(panel60);
           


        }
        //void Delete_Record()
        //{

        //    try
        //    {


        //        ClassSql a = new ClassSql();
        //        a.ExecuteQuery("Delete from t_med_history where resultid = '" + LabID.Text + "' and resulttype= 'SEA'");
        //        a.ExecuteQuery("Delete from t_med_history2 where resultid = '" + LabID.Text + "' and resulttype= 'SEA'");
        //        a.ExecuteQuery("Delete from t_phy_exam where resultid = '" + LabID.Text + "' and resulttype= 'SEA'");
        //        a.ExecuteQuery("Delete from t_others where resultid = '" + LabID.Text + "' and resulttype= 'SEA'");
        //        a.ExecuteQuery("Delete from t_ancillary where resultid = '" + LabID.Text + "' and resulttype= 'SEA'");
        //        a.ExecuteQuery("Delete from t_result_main where resultid = '" + LabID.Text + "' and resulttype= 'SEA'");

        //        Tool.MessageBoxDelete();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

        //    }
        //    finally
        //    {
        //        //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
        //        if (ClassSql.dr != null) { ClassSql.dr.Close(); }
        //    }

        //}

        private void txt_resultID_TextChanged(object sender, EventArgs e)
        {


            //if (NewSeabase)
            //{
            //    MessageBox.Show("HERE");
            //    fmain.ts_add_sea.Enabled = true; fmain.ts_edit_sea.Enabled = false; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = false; fmain.ts_search_sea.Enabled = true; fmain.ts_print_sea.Enabled = false; fmain.ts_cancel_sea.Enabled = false;

            //}
            //else
            //{

            //    Search_MedicalHistory();
            //    Search_medicalHistory2();
            //    Search_PhyExam();
            //    Search_others();
            //    search_Ancillary();
            //    search_Recomendation();
            //    fmain.ts_add_sea.Enabled = true; fmain.ts_edit_sea.Enabled = true; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = false; fmain.ts_search_sea.Enabled = true; fmain.ts_print_sea.Enabled = true; fmain.ts_cancel_sea.Enabled = false;

            //}


        }
        public void Search_MedicalHistory()
        {

            try
            {

                // ClassSql a = new ClassSql(); DataTable dt;
                //// dt = a.Table("SELECT * FROM t_med_history WHERE  resultid LIKE  '%" + LabID.Text + "%'");
                // dt = a.Mytable_Proc("Seabase_medicalHistory1", "@ID", LabID.Text);
                var i = db.sp_Seabase_MedHistory1(LabID.Text).FirstOrDefault();
                //foreach (var i in list)
                //{



                lbl_history1_cn.Tag = i.cn.ToString();
                string head_injury = i.head_injury.ToString();
                if (head_injury == "N") { rb_head_N.Checked = true; } else if (head_injury == "Y") { rb_head_Y.Checked = true; }

                string frequent_headaches = i.frequent_headaches.ToString();
                if (frequent_headaches == "N") { rb_freqHead_N.Checked = true; } else if (frequent_headaches == "Y") { rb_freqHead_Y.Checked = true; }

                string frequent_dizziness = i.frequent_dizziness.ToString();
                if (frequent_dizziness == "N") { rb_dizziness_N.Checked = true; } else if (frequent_dizziness == "Y") { rb_dizziness_Y.Checked = true; }

                string fainting_spells = i.fainting_spells.ToString();
                if (fainting_spells == "N") { rb_spells_N.Checked = true; } else if (fainting_spells == "Y") { rb_spells_Y.Checked = true; }

                string insomnia = i.insomnia.ToString();
                if (insomnia == "N") { rb_Insomia_N.Checked = true; } else if (insomnia == "Y") { rb_Insomia_Y.Checked = true; }

                string depression = i.depression.ToString();
                if (depression == "N") { rb_depression_N.Checked = true; } else if (depression == "Y") { rb_depression_Y.Checked = true; }

                string trachoma = i.trachoma.ToString();
                if (trachoma == "N") { rb_trachoma_N.Checked = true; } else if (trachoma == "Y") { rb_trachoma_Y.Checked = true; }

                string deafness = i.deafness.ToString();
                if (deafness == "N") { rb_deaf_N.Checked = true; } else if (deafness == "Y") { rb_deaf_Y.Checked = true; }

                string nose_throat_disorder = i.nose_throat_disorder.ToString();
                if (nose_throat_disorder == "N") { rb_nose_N.Checked = true; } else if (nose_throat_disorder == "Y") { rb_nose_Y.Checked = true; }

                string tuberculosis = i.tuberculosis.ToString();
                if (tuberculosis == "N") { rb_tuberculosis_N.Checked = true; } else if (tuberculosis == "Y") { rb_tuberculosis_Y.Checked = true; }

                string other_lung_disorder = i.other_lung_disorder.ToString();
                if (other_lung_disorder == "N") { rb_lung_N.Checked = true; } else if (other_lung_disorder == "Y") { rb_lung_Y.Checked = true; }

                string high_blood_pressure = i.high_blood_pressure.ToString();
                if (high_blood_pressure == "N") { rb_HighBlood_N.Checked = true; } else if (high_blood_pressure == "Y") { rb_HighBlood_Y.Checked = true; }

                string heart_disease = i.heart_disease.ToString();
                if (heart_disease == "N") { rb_Heart_N.Checked = true; } else if (heart_disease == "Y") { rb_Heart_Y.Checked = true; }

                string rheumatic_fever = i.rheumatic_fever.ToString();
                if (rheumatic_fever == "N") { rb_fever_N.Checked = true; } else if (rheumatic_fever == "Y") { rb_fever_Y.Checked = true; }

                string diabetes_mellitus = i.diabetes_mellitus.ToString();
                if (diabetes_mellitus == "N") { rb_diabetes_N.Checked = true; } else if (diabetes_mellitus == "Y") { rb_diabetes_Y.Checked = true; }

                string other_endocrine_disorder = i.other_endocrine_disorder.ToString();
                if (other_endocrine_disorder == "N") { rb_endocrine_N.Checked = true; } else if (other_endocrine_disorder == "Y") { rb_endocrine_Y.Checked = true; }

                string cancer_tumor = i.cancer_tumor.ToString();
                if (cancer_tumor == "N") { rb_cancer_N.Checked = true; } else if (cancer_tumor == "Y") { rb_cancer_Y.Checked = true; }

                string blood_disorders = i.blood_disorders.ToString();
                if (blood_disorders == "N") { rb_blood_N.Checked = true; } else if (blood_disorders == "Y") { rb_blood_Y.Checked = true; }

                string stomach_pain = i.stomach_pain.ToString();
                if (stomach_pain == "N") { rb_stomach_N.Checked = true; } else if (stomach_pain == "Y") { rb_stomach_Y.Checked = true; }

                string other_abdominal_disorder = i.other_abdominal_disorder.ToString();
                if (other_abdominal_disorder == "N") { rb_abdominal_N.Checked = true; } else if (other_abdominal_disorder == "Y") { rb_abdominal_Y.Checked = true; }

                string kidney_bladder_disorder = i.kidney_bladder_disorder.ToString();
                if (kidney_bladder_disorder == "N") { rb_kidney_N.Checked = true; } else if (kidney_bladder_disorder == "Y") { rb_kidney_Y.Checked = true; }

                string back_injury = i.back_injury.ToString();
                if (back_injury == "N") { rb_back_N.Checked = true; } else if (back_injury == "Y") { rb_back_Y.Checked = true; }

                string genetic_hereditary = i.genetic_hereditary.ToString();
                if (genetic_hereditary == "N") { rb_Genetic_N.Checked = true; } else if (genetic_hereditary == "Y") { rb_Genetic_Y.Checked = true; }

                string sexually_transmit_disease = i.sexually_transmit_disease.ToString();
                if (sexually_transmit_disease == "N") { rb_sexual_N.Checked = true; } else if (sexually_transmit_disease == "Y") { rb_sexual_Y.Checked = true; }

                string tropical_disease = i.tropical_disease.ToString();
                if (tropical_disease == "N") { rb_tropical_N.Checked = true; } else if (tropical_disease == "Y") { rb_tropical_Y.Checked = true; }

                string asthma = i.asthma.ToString();
                if (asthma == "N") { rb_asthma_N.Checked = true; } else if (asthma == "Y") { rb_asthma_Y.Checked = true; }

                string allergies = i.allergies.ToString();
                if (allergies == "N") { rb_allergies_N.Checked = true; } else if (allergies == "Y") { rb_allergies_Y.Checked = true; }

                string gynecological_disorder = i.gynecological_disorder.ToString();
                if (gynecological_disorder == "N") { rb_gyn_N.Checked = true; } else if (gynecological_disorder == "Y") { rb_gyn_Y.Checked = true; }

                string operations = i.operations.ToString();
                if (operations == "N") { rb_operational_N.Checked = true; } else if (operations == "Y") { rb_operational_Y.Checked = true; }

                txt_operational_specify.Text = i.operations_specify.ToString();

                tx_other_History.Text = i.others.ToString();

                string consulted = i.consulted.ToString();
                if (consulted == "N") { cb_consulted.Checked = false; } else { cb_consulted.Checked = true; }

                txt_consulted.Text = i.consulted_specify.ToString();
                txt_maintenance.Text = i.maintenance_meds.ToString();

                string operations_tag = i.operations_tag.ToString();
                if (operations_tag == "N") { rb_operational_N.Checked = true; } else if (operations_tag == "Y") { rb_operational_Y.Checked = true; }

                string schistosomiasis = i.schistosomiasis.ToString();
                if (schistosomiasis == "N") { rb_schis_N.Checked = true; } else if (schistosomiasis == "Y") { rb_schis_Y.Checked = true; }

                string last_menstrual_period = i.last_menstrual_period.ToString();
                if (last_menstrual_period == "N") { rb_last_N.Checked = true; } else if (last_menstrual_period == "Y") { rb_last_Y.Checked = true; }

                txt_allergies_specify.Text = i.allergies_specify.ToString();
                txt_abdominal_specify.Text = i.other_abdominal_specify.ToString();


                //}




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }


        }
        public void Search_medicalHistory2()
        {
            try
            {

                //ClassSql a = new ClassSql(); DataTable dt;

                ////dt = a.Table("SELECT * FROM t_med_history2 WHERE  resultid =  '" + Tool.ReplaceString(LabID.Text) + "' ");
                //dt = a.Mytable_Proc("Seabase_medicalHistory2", "@ID", LabID.Text);
                DataClasses2DataContext db2 = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
                var i = db2.sp_Seabase_MedHistory2(LabID.Text).FirstOrDefault();

                //foreach (var i in list)
                //{

                lbl_history2_cn.Tag = i.cn.ToString();
                string column1 = i.column1.ToString();
                if (column1 == "N") { q1_N.Checked = true; } else if (column1 == "Y") { q1_Y.Checked = true; }
                string column2 = i.column2.ToString();
                if (column2 == "N") { q2_N.Checked = true; } else if (column2 == "Y") { q2_Y.Checked = true; }
                string column3 = i.column3.ToString();
                if (column3 == "N") { q3_N.Checked = true; } else if (column3 == "Y") { q3_Y.Checked = true; }
                string column4 = i.column4.ToString();
                if (column4 == "N") { q4_N.Checked = true; } else if (column4 == "Y") { q4_Y.Checked = true; }
                string column5 = i.column5.ToString();
                if (column5 == "N") { q5_N.Checked = true; } else if (column5 == "Y") { q5_Y.Checked = true; }
                string column6 = i.column6.ToString();
                if (column6 == "N") { q6_N.Checked = true; } else if (column6 == "Y") { q6_Y.Checked = true; }
                string column7 = i.column7.ToString();
                if (column7 == "N") { q7_N.Checked = true; } else if (column7 == "Y") { q7_Y.Checked = true; }
                txt_q7_Comment.Text = i.column7_comment.ToString();
                string column8 = i.column8.ToString();
                if (column8 == "N") { q8_N.Checked = true; } else if (column8 == "Y") { q8_Y.Checked = true; }
                txt_q8_comment.Text = i.column8_comment.ToString();
                txt_comment_1.Text = i.column1_comment.ToString();
                txt_comment_2.Text = i.column2_comment.ToString();
                txt_comment_3.Text = i.column3_comment.ToString();
                txt_comment_4.Text = i.column4_comment.ToString();
                txt_comment_5.Text = i.column5_comment.ToString();
                txt_comment_6.Text = i.column6_comment.ToString();

                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}


        }
        public void Search_PhyExam()
        {
            try
            {

                //    ClassSql a = new ClassSql(); DataTable dt;

                ////    dt = a.Table("SELECT * FROM t_phy_exam WHERE  resultid =  '" + Tool.ReplaceString(LabID.Text) + "' ");
                //    dt = a.Mytable_Proc("Seabase_PhyExam", "@ID", LabID.Text);
                var i = db.sp_Seabase_PhyExam(LabID.Text).FirstOrDefault();
                //foreach (var i in list)
                //{
                lbl_physicalExam_cn.Tag = i.cn.ToString();
                x_height.Text = i.HEIGHT.ToString();
                x_weight.Text = i.WEIGHT.ToString();
                x_body_Build.Text = i.BODY_BUILD.ToString();
                x_pulse.Text = i.PULSE.ToString();
                x_bp.Text = i.BP.ToString();
                x_bp_dias.Text = i.BP_DIASTOLIC.ToString();
                x_respiration.Text = i.RESPIRATION.ToString();
                x_rhythm.Text = i.RHYTHM.ToString();
                x_far_u.Text = i.FAR_OD_U.ToString();
                x_far_c.Text = i.FAR_OD_C.ToString();
                x_Con_ad.Text = i.CONVERSATIONAL_AD.ToString();
                x_far_os_u.Text = i.FAR_OS_U.ToString();
                x_far_os_c.Text = i.FAR_OS_C.ToString();
                x_Near_odj_u.Text = i.NEAR_ODJ_U.ToString();
                x_near_odj_c.Text = i.NEAR_ODJ_C.ToString();
                x_near_osj_u.Text = i.NEAR_OSJ_U.ToString();
                x_near_osj_c.Text = i.NEAR_OSJ_C.ToString();
                string ISHIHARA_U = i.ISHIHARA_U.ToString();
                if (ISHIHARA_U == "1") { cb_ishihara_u.Checked = true; } else { cb_ishihara_u.Checked = false; }


                cbo_ishihara_c.Text = i.ISHIHARA_C.ToString();


                x_hearing_Ad.Text = i.HEARING_AD.ToString();
                x_hearing_as.Text = i.HEARING_AS.ToString();


                //string VisualAid = dr["VISUAL_AIDS_REQUIRED"].ToString();
                //if (VisualAid == "YES") { rb_V_aids_Y.Checked = true; } else if (VisualAid == "NO") { rb_V_aids_N.Checked = true; }

                cb_satisfactory_Hearing.Text = i.SATISFACTORY_HEARING.ToString();

                cbo_satisfactory_Unaided.Text = i.SATISFACTORY_SIGHT_UNAID.ToString();
                cbo_unaided_hearing.Text = i.UNAIDED_HEARING_SATISFACTORY.ToString();
                cbo_visual_Aids.Text = i.VISUAL_AIDS.ToString();

                string CLARITY_OF_SPEECH = i.CLARITY_OF_SPEECH.ToString();
                if (CLARITY_OF_SPEECH == "A") { this.rb_clarity_Speech_AD.Checked = true; } else if (CLARITY_OF_SPEECH == "I") { this.rb_clarity_Speech_IN.Checked = true; }

                string HEARING_RIGHT = i.HEARING_RIGHT.ToString();
                if (HEARING_RIGHT == "A") { this.rb_hearingRight_AD.Checked = true; } else if (HEARING_RIGHT == "I") { this.rb_hearingRight_IA.Checked = true; }

                string HEARING_LEFT = i.HEARING_LEFT.ToString();
                if (HEARING_LEFT == "A") { this.rb_hearingLeft_AD.Checked = true; } else if (HEARING_LEFT == "I") { this.rb_hearingLeft_IA.Checked = true; }

                string VISUAL_AIDS_REQUIRED_ = i.VISUAL_AIDS_REQUIRED.ToString();
                if (VISUAL_AIDS_REQUIRED_ == "YES") { rb_visualReq_Y.Checked = true; } else if (VISUAL_AIDS_REQUIRED_ == "NO") { rb_visualReq_N.Checked = true; }

                string IDENTITY_CONFIRMED_ = i.IDENTITY_CONFIRMED.ToString();
                if (IDENTITY_CONFIRMED_ == "YES") { rb_indentity_Confirm_Y.Checked = true; } else if (IDENTITY_CONFIRMED_ == "NO") { rb_indentity_Confirm_N.Checked = true; }

                string FIT_FOR_LOOKOUT_ = i.FIT_FOR_LOOKOUT.ToString();
                if (FIT_FOR_LOOKOUT_ == "YES") { rb_fit_lookOut_Y.Checked = true; } else if (FIT_FOR_LOOKOUT_ == "NO") { rb_fit_lookOut_N.Checked = true; }

                //  dt_dateTaken.Text = dr["COLOR_VISION_DATE_TAKEN"].ToString();

                DateTime temp2;
                if (DateTime.TryParse(i.COLOR_VISION_DATE_TAKEN.ToString(), out temp2))
                {
                    this.dt_dateTaken.Format = DateTimePickerFormat.Custom;
                    dt_dateTaken.CustomFormat = "MM/dd/yyyy";
                    dt_dateTaken.Value = Convert.ToDateTime(i.COLOR_VISION_DATE_TAKEN.ToString()).Date;
                }
                else
                {
                    dt_dateTaken.Format = DateTimePickerFormat.Custom;
                    dt_dateTaken.CustomFormat = "00/00/0000";

                }







                string VISUAL_AIDS_WORN_ = i.VISUAL_AIDS_WORN.ToString();
                if (VISUAL_AIDS_WORN_ == "SPECTACLES") { rb_visual_worn_Spectacles.Checked = true; } else if (VISUAL_AIDS_WORN_ == "CONTACTLENS") { rb_visual_worn_ContactLenses.Checked = true; } else { rb_visual_worn_Spectacles.Checked = false; rb_visual_worn_ContactLenses.Checked = false; }
                string CONVERSATIONAL_AS_ = i.CONVERSATIONAL_AS.ToString();
                if (CONVERSATIONAL_AS_ == "1") { cb_con_as.Checked = true; } else if (CONVERSATIONAL_AS_ == "0") { cb_con_as.Checked = false; } else { cb_con_as.Checked = false; }

                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}


        }
        public void Search_others()
        {
            try
            {

                //   ClassSql a = new ClassSql(); DataTable dt;
                ////   dt = a.Table("SELECT * FROM t_others WHERE  resultid LIKE  '%" + Tool.ReplaceString(LabID.Text) + "%' ");
                //   dt = a.Mytable_Proc("Seabase_others", "@ID", LabID.Text);
                var i = db.sp_Seabase_Others(LabID.Text).FirstOrDefault();
                //foreach (var i in list)
                //{
                lbl_other_cn.Tag = i.cn.ToString();
                string SKIN_TAG = i.SKIN_TAG.ToString();
                if (SKIN_TAG == "1") { cb_skin.Checked = true; } else { cb_skin.Checked = false; }
                x_skin.Text = i.SKIN.ToString();
                string HEAD_NECK_SCALP_TAG = i.HEAD_NECK_SCALP_TAG.ToString();
                if (HEAD_NECK_SCALP_TAG == "1") { this.cb_neck.Checked = true; } else { cb_neck.Checked = false; }
                x_neck.Text = i.HEAD_NECK_SCALP.ToString();
                string EYES_TAG = i.EYES_TAG.ToString();
                if (EYES_TAG == "1") { this.cb_eyes.Checked = true; } else { cb_eyes.Checked = false; }
                x_eyes.Text = i.EYES.ToString();
                string PUPILS_TAG = i.PUPILS_TAG.ToString();
                if (PUPILS_TAG == "1") { this.cb_pupils.Checked = true; } else { cb_pupils.Checked = false; }
                x_pupils.Text = i.PUPILS.ToString();
                string EARS_EARDRUM_TAG = i.EARS_EARDRUM_TAG.ToString();
                if (EARS_EARDRUM_TAG == "1") { this.cb_ears.Checked = true; } else { cb_ears.Checked = false; }
                x_ears.Text = i.EARS_EARDRUM.ToString();
                string NOSE_SINUSES_TAG = i.NOSE_SINUSES_TAG.ToString();
                if (NOSE_SINUSES_TAG == "1") { this.cb_nose.Checked = true; } else { cb_nose.Checked = false; }
                x_nose.Text = i.NOSE_SINUSES.ToString();
                string MOUTH_THROAT_TAG = i.MOUTH_THROAT_TAG.ToString();
                if (MOUTH_THROAT_TAG == "1") { this.cb_mought.Checked = true; } else { cb_mought.Checked = false; }
                x_mouth.Text = i.MOUTH_THROAT.ToString();
                string NECK_LN_THYROID_TAG = i.NECK_LN_THYROID_TAG.ToString();
                if (NECK_LN_THYROID_TAG == "1") { this.cb_thyroid.Checked = true; } else { cb_thyroid.Checked = false; }
                x_thyroid.Text = i.NECK_LN_THYROID.ToString();
                string CHEST_BREAST_AXILLA_TAG = i.CHEST_BREAST_AXILLA_TAG.ToString();
                if (CHEST_BREAST_AXILLA_TAG == "1") { this.cb_breast.Checked = true; } else { cb_breast.Checked = false; }
                x_breast.Text = i.CHEST_BREAST_AXILLA.ToString();
                string LUNGS_TAG = i.LUNGS_TAG.ToString();
                if (LUNGS_TAG == "1") { this.cb_lungs.Checked = true; } else { cb_lungs.Checked = false; }
                x_lungs.Text = i.LUNGS.ToString();
                string HEART_TAG = i.HEART_TAG.ToString();
                if (HEART_TAG == "1") { this.cb_heart.Checked = true; } else { cb_heart.Checked = false; }
                x_heart.Text = i.HEART.ToString();
                string ABDOMEN_TAG = i.ABDOMEN_TAG.ToString();
                if (ABDOMEN_TAG == "1") { this.cb_abdomen.Checked = true; } else { cb_abdomen.Checked = false; }
                x_abdomen.Text = i.ABDOMEN.ToString();
                string BACK_FLANK_TAG = i.BACK_FLANK_TAG.ToString();
                if (BACK_FLANK_TAG == "1") { this.cb_back.Checked = true; } else { cb_back.Checked = false; }
                x_back.Text = i.BACK_FLANK.ToString();
                string ANUS_RECTUM_TAG = i.ANUS_RECTUM_TAG.ToString();
                if (ANUS_RECTUM_TAG == "1") { this.cb_anus.Checked = true; } else { cb_anus.Checked = false; }
                x_anus.Text = i.ANUS_RECTUM.ToString();
                string GU_SYSTEM_TAG = i.GU_SYSTEM_TAG.ToString();
                if (GU_SYSTEM_TAG == "1") { this.cb_gu.Checked = true; } else { cb_gu.Checked = false; }
                x_gu.Text = i.GU_SYSTEM.ToString();
                string INGUINALS_GENITALS_TAG = i.INGUINALS_GENITALS_TAG.ToString();
                if (INGUINALS_GENITALS_TAG == "1") { this.cb_inguinals.Checked = true; } else { cb_inguinals.Checked = false; }
                x_inguinals.Text = i.INGUINALS_GENITALS.ToString();
                string REFLEXES_TAG = i.REFLEXES_TAG.ToString();
                if (REFLEXES_TAG == "1") { this.cb_reflexes.Checked = true; } else { cb_reflexes.Checked = false; }
                x_reflexes.Text = i.REFLEXES.ToString();
                string EXTREMITIES_TAG = i.EXTREMITIES_TAG.ToString();
                if (EXTREMITIES_TAG == "1") { this.cb_extremeties.Checked = true; } else { cb_extremeties.Checked = false; }
                x_extremeties.Text = i.EXTREMITIES.ToString();
                x_dental.Text = i.DENTAL.ToString();
                string DENTAL_TAG = i.DENTAL_TAG.ToString();
                if (DENTAL_TAG == "1") { this.cb_dental.Checked = true; } else { cb_dental.Checked = false; }
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}


        }

        public void search_Ancillary()
        {


            try
            {


           
                var i = db.sp_Seabase_Anillary(LabID.Text).FirstOrDefault();
              
                lbl_cn_acillary.Tag = i.cn.ToString();

                string cxr = i.cxr.ToString();
                if (cxr == "NORMAL") { rb_cxr_normal.Checked = true; } else if (cxr == "WITH_F") { this.rb_cxr_with.Checked = true; }
                string ecg = i.ecg.ToString();
                if (ecg == "NORMAL") { this.rb_ecg_normal.Checked = true; } else if (ecg == "WITH_F") { this.rb_ecg_with.Checked = true; }

                string cbc = i.cbc.ToString();
                if (cbc == "NORMAL") { this.rb_cbd_normal.Checked = true; } else if (cbc == "WITH_F") { this.rb_cbc_with.Checked = true; }

                cbo_pregnancyTest.Text = i.pregnancy_test.ToString();

                string urinalysis = i.urinalysis.ToString();
                if (urinalysis == "NORMAL") { this.rb_urinal_normal.Checked = true; } else if (urinalysis == "WITH_F") { this.rb_urinal_with.Checked = true; }

                string stool_exam = i.stool_exam.ToString();
                if (stool_exam == "NORMAL") { this.rb_stool_normal.Checked = true; } else if (stool_exam == "WITH_F") { this.rb_stool_with.Checked = true; }

                string hbsag = i.hbsag.ToString();
                if (hbsag == "NON REACTIVE") { this.rb_hb_Nonreactive.Checked = true; } else if (hbsag == "REACTIVE") { this.rb_hb_reactive.Checked = true; }

                string hiv = i.hiv.ToString();
                if (hiv == "Nonreactive") { this.rb_hiv_NonReactive.Checked = true; } else if (hiv == "REACTIVE") { this.rb_hiv_Reactive.Checked = true; }

                string rpr = i.rpr.ToString();
                if (rpr == "NONREACTIVE") { this.rb_rpr_NonReactive.Checked = true; } else if (rpr == "REACTIVE") { this.rb_rpr_Reactive.Checked = true; }

                string blood = i.blood_type.ToString();
                if (!blood.Contains("-"))
                {
                    blood += "+";
                }
                cbo_bloodType.Text = blood;

              
                // string blood_chemistries = dr["blood_chemistries"].ToString();
                string psychological_exam = i.psychological_exam.ToString();
                if (psychological_exam == "RECOMMEND") { rb_psych_recomend.Checked = true; }
                else if (psychological_exam == "NR") { this.rb_psych_NR.Checked = true; }
                else if (psychological_exam == "ND") { this.rb_psych_ND.Checked = true; }
                else if (psychological_exam == "RESERVE") { this.rb_psych_RecWithRes.Checked = true; }
                x_remark.Text = i.remarks.ToString();
                //  string recommendation = dr["recommendation"].ToString();
                x_add_test1.Text = i.additional_test.ToString();
                x_add_test2.Text = i.additional_test2.ToString();



                //}



            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}




        }

        public void search_Recomendation()
        {

            try
            {


                //  ClassSql a = new ClassSql(); DataTable dt;
                //dt = a.Mytable_Proc("Seabase_recomendation", "@ID", LabID.Text);
                var i = db.sp_Seabase_RecomendationAdd(LabID.Text).FirstOrDefault();
                //foreach (DataRow dr in dt.Rows)
                //{

                lbl_recomendation_cn.Tag = i.cn.ToString();



                // dt_resultdate_rec.Text = dr["result_date"].ToString();                

                // dt_valid_until.Text = dr["valid_until"].ToString();               



                DateTime temp1;
                if (DateTime.TryParse(i.result_date.ToString(), out temp1))
                {
                    this.dt_resultDate.Format = DateTimePickerFormat.Custom;
                    dt_resultDate.CustomFormat = "MM/dd/yyyy";
                    dt_resultDate.Value = Convert.ToDateTime(i.result_date.ToString()).Date;
                }
                else
                {
                    dt_resultDate.Format = DateTimePickerFormat.Custom;
                    dt_resultDate.CustomFormat = "00/00/0000";

                }

                DateTime temp2;
                if (DateTime.TryParse(i.valid_until.ToString(), out temp2))
                {
                    this.dt_validUntil.Format = DateTimePickerFormat.Custom;
                    dt_validUntil.CustomFormat = "MM/dd/yyyy";
                    dt_validUntil.Value = Convert.ToDateTime(i.valid_until.ToString()).Date;
                }
                else
                {
                    dt_validUntil.Format = DateTimePickerFormat.Custom;
                    dt_validUntil.CustomFormat = "00/00/0000";

                }

                //   dt_fitness_date.Text = dr["fitness_date"].ToString();

                DateTime temp3;
                if (DateTime.TryParse(i.fitness_date.ToString(), out temp3))
                {
                    this.dt_fitness_Date.Format = DateTimePickerFormat.Custom;
                    dt_fitness_Date.CustomFormat = "MM/dd/yyyy";
                    dt_fitness_Date.Value = Convert.ToDateTime(i.fitness_date.ToString()).Date;
                }
                else
                {
                    dt_fitness_Date.Format = DateTimePickerFormat.Custom;
                    dt_fitness_Date.CustomFormat = "00/00/0000";

                }


                x_restriction.Text = i.restriction.ToString();



                x_remark_rec.Text = i.remarks.ToString();
                cbo_recomendation.Text = i.recommendation.ToString();
                cbo_medtech.Text = i.medtech.ToString();
                txt_medDir_Cbo.Text = i.pathologist.ToString();
                x_speciment.Text = i.specimen_no.ToString();
                string basic_doh_exam = i.basic_doh_exam.ToString();

                if (basic_doh_exam == "Y") { this.rb_doh_pass.Checked = true; } else if (basic_doh_exam == "N") { this.rb_basic_doh_with.Checked = true; } else { rb_doh_pass.Checked = false; rb_basic_doh_with.Checked = false; }
                string add_lab_tests = i.add_lab_tests.ToString();
                if (add_lab_tests == "Y") { this.rb_ladTest_pass.Checked = true; } else if (basic_doh_exam == "N") { this.rb_add_lab_test_With.Checked = true; } else { rb_ladTest_pass.Checked = false; rb_add_lab_test_With.Checked = false; }
                string flag_medlab_req = i.flag_medlab_req.ToString();
                if (flag_medlab_req == "Y") { this.rb_flag_pass.Checked = true; } else if (basic_doh_exam == "N") { this.rb_flag_with.Checked = true; } else { rb_flag_pass.Checked = false; rb_flag_with.Checked = false; }


                string deck_srvc_flag_ = i.deck_srvc_flag.ToString();
                if (deck_srvc_flag_ == "Y") { rb_deck_fit.Checked = true; } else if (deck_srvc_flag_ == "N") { rb_deck_UFit.Checked = true; } else { rb_deck_fit.Checked = false; rb_deck_UFit.Checked = false; }

                string t_engine_srvc_flag_ = i.engine_srvc_flag.ToString();
                if (t_engine_srvc_flag_ == "Y") { this.rb_engine_Fit.Checked = true; } else if (t_engine_srvc_flag_ == "N") { this.rb_engine_Ufit.Checked = true; } else { rb_engine_Fit.Checked = false; rb_engine_Ufit.Checked = false; }

                string t_catering_srvc_flag_ = i.catering_srvc_flag.ToString();
                if (t_catering_srvc_flag_ == "Y") { this.rb_catering_fit.Checked = true; } else if (t_catering_srvc_flag_ == "N") { this.rb_catering_Ufit.Checked = true; } else { rb_catering_fit.Checked = false; rb_catering_Ufit.Checked = false; }

                string t_other_srvc_flag_ = i.other_srvc_flag.ToString();
                if (t_other_srvc_flag_ == "Y") { this.rb_other_Fit.Checked = true; } else if (t_other_srvc_flag_ == "N") { this.rb_other_uFit.Checked = true; } else { rb_other_Fit.Checked = false; rb_other_uFit.Checked = false; }




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}




        }


        public void search_RecomendationFromSearch()
        {

            try
            {


                //ClassSql a = new ClassSql(); DataTable dt;
                //dt = a.Mytable_Proc("Seabase_recomendationFromSearch", "@ID", cn_SeabaseResultMain);
                var i = db.sp_Seabase_Recomendation(LabID.Text).FirstOrDefault();
                //foreach (var i in list)
                //{

                lbl_recomendation_cn.Tag = i.cn.ToString();

                DateTime temp1;
                if (DateTime.TryParse(i.result_date.ToString(), out temp1))
                {
                    this.dt_resultDate.Format = DateTimePickerFormat.Custom;
                    dt_resultDate.CustomFormat = "MM/dd/yyyy";
                    dt_resultDate.Value = Convert.ToDateTime(i.result_date.ToString()).Date;
                }
                else
                {
                    dt_resultDate.Format = DateTimePickerFormat.Custom;
                    dt_resultDate.CustomFormat = "00/00/0000";

                }

                DateTime temp2;
                if (DateTime.TryParse(i.valid_until.ToString(), out temp2))
                {
                    this.dt_validUntil.Format = DateTimePickerFormat.Custom;
                    dt_validUntil.CustomFormat = "MM/dd/yyyy";
                    dt_validUntil.Value = Convert.ToDateTime(i.valid_until.ToString()).Date;
                }
                else
                {
                    dt_validUntil.Format = DateTimePickerFormat.Custom;
                    dt_validUntil.CustomFormat = "00/00/0000";

                }

                //   dt_fitness_date.Text = dr["fitness_date"].ToString();

                DateTime temp3;
                if (DateTime.TryParse(i.fitness_date.ToString(), out temp3))
                {
                    this.dt_fitness_Date.Format = DateTimePickerFormat.Custom;
                    dt_fitness_Date.CustomFormat = "MM/dd/yyyy";
                    dt_fitness_Date.Value = Convert.ToDateTime(i.fitness_date.ToString()).Date;
                }
                else
                {
                    dt_fitness_Date.Format = DateTimePickerFormat.Custom;
                    dt_fitness_Date.CustomFormat = "00/00/0000";

                }


                x_restriction.Text = i.restriction.ToString();

                x_remark_rec.Text = i.remarks.ToString();
                cbo_recomendation.Text = i.recommendation.ToString();
                cbo_medtech.Text = i.medtech.ToString();
                txt_medDir_Cbo.Text = i.pathologist.ToString();
                x_speciment.Text = i.specimen_no.ToString();
                string basic_doh_exam = i.basic_doh_exam.ToString();

                if (basic_doh_exam == "Y") { this.rb_doh_pass.Checked = true; } else if (basic_doh_exam == "N") { this.rb_basic_doh_with.Checked = true; } else { rb_doh_pass.Checked = false; rb_basic_doh_with.Checked = false; }
                string add_lab_tests = i.add_lab_tests.ToString();
                if (add_lab_tests == "Y") { this.rb_ladTest_pass.Checked = true; } else if (basic_doh_exam == "N") { this.rb_add_lab_test_With.Checked = true; } else { rb_ladTest_pass.Checked = false; rb_add_lab_test_With.Checked = false; }
                string flag_medlab_req = i.flag_medlab_req.ToString();
                if (flag_medlab_req == "Y") { this.rb_flag_pass.Checked = true; } else if (basic_doh_exam == "N") { this.rb_flag_with.Checked = true; } else { rb_flag_pass.Checked = false; rb_flag_with.Checked = false; }


                string deck_srvc_flag_ = i.deck_srvc_flag.ToString();
                if (deck_srvc_flag_ == "Y") { rb_deck_fit.Checked = true; } else if (deck_srvc_flag_ == "N") { rb_deck_UFit.Checked = true; } else { rb_deck_fit.Checked = false; rb_deck_UFit.Checked = false; }

                string t_engine_srvc_flag_ = i.engine_srvc_flag.ToString();
                if (t_engine_srvc_flag_ == "Y") { this.rb_engine_Fit.Checked = true; } else if (t_engine_srvc_flag_ == "N") { this.rb_engine_Ufit.Checked = true; } else { rb_engine_Fit.Checked = false; rb_engine_Ufit.Checked = false; }

                string t_catering_srvc_flag_ = i.catering_srvc_flag.ToString();
                if (t_catering_srvc_flag_ == "Y") { this.rb_catering_fit.Checked = true; } else if (t_catering_srvc_flag_ == "N") { this.rb_catering_Ufit.Checked = true; } else { rb_catering_fit.Checked = false; rb_catering_Ufit.Checked = false; }

                string t_other_srvc_flag_ = i.other_srvc_flag.ToString();
                if (t_other_srvc_flag_ == "Y") { this.rb_other_Fit.Checked = true; } else if (t_other_srvc_flag_ == "N") { this.rb_other_uFit.Checked = true; } else { rb_other_Fit.Checked = false; rb_other_uFit.Checked = false; }

                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{
            //    //if (ClassSql.cnn != null) { ClassSql.DbClose(); }
            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }
            //}




        }


        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rb_abdominal_Y.Checked == true) { txt_abdominal_specify.Enabled = true; } else { txt_abdominal_specify.Enabled = false; txt_abdominal_specify.Clear(); }
            if (rb_allergies_Y.Checked == true) { txt_allergies_specify.Enabled = true; } else { txt_allergies_specify.Enabled = false; txt_allergies_specify.Clear(); }
            if (rb_operational_Y.Checked == true) { this.txt_operational_specify.Enabled = true; } else { txt_operational_specify.Enabled = false; txt_operational_specify.Clear(); }
            if (cb_consulted.Checked == true) { txt_consulted.Enabled = true; } else { txt_consulted.Enabled = false; txt_consulted.Clear(); }
            if (q1_Y.Checked == true) { this.txt_comment_1.Enabled = true; } else { txt_comment_1.Enabled = false; txt_comment_1.Clear(); }
            if (q2_Y.Checked == true) { this.txt_comment_2.Enabled = true; } else { txt_comment_2.Enabled = false; txt_comment_2.Clear(); }
            if (q3_Y.Checked == true) { this.txt_comment_3.Enabled = true; } else { txt_comment_3.Enabled = false; txt_comment_3.Clear(); }
            if (q4_Y.Checked == true) { this.txt_comment_4.Enabled = true; } else { txt_comment_4.Enabled = false; txt_comment_4.Clear(); }
            if (q5_Y.Checked == true) { this.txt_comment_5.Enabled = true; } else { txt_comment_5.Enabled = false; txt_comment_5.Clear(); }
            if (q6_Y.Checked == true) { this.txt_comment_6.Enabled = true; } else { txt_comment_6.Enabled = false; txt_comment_6.Clear(); }
            if (q7_Y.Checked == true) { txt_q7_Comment.Enabled = true; } else { txt_q7_Comment.Enabled = false; txt_q7_Comment.Clear(); }
            if (q8_Y.Checked == true) { this.txt_q8_comment.Enabled = true; } else { txt_q8_comment.Enabled = false; txt_q8_comment.Clear(); }
        }

        private void txt_Papin_TextChanged(object sender, EventArgs e)
        {
            //if (NewSeabase)
            //{
            //    //ClassSql a = new ClassSql(); long cnt;
            //    //cnt = a.CountColumn("SELECT Count(t_result_main.papin) AS `count` FROM t_result_main WHERE t_result_main.papin =  '" + Tool.ReplaceString(txt_Papin.Text) + "' and resulttype = 'SEA'");

            //    if (Count)
            //    {
            //       // DialogResult dialogResult = MessageBox.Show("Patient had previous laboratory examination! Would you like to update Hir/Her record?", Properties.Settings.Default.Systemname.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //        if (Action == "YES")
            //        {
            //            NewSeabase = false;
            //            Search_Patient();
            //            Search_MedicalHistory();
            //            Search_medicalHistory2();
            //            Search_PhyExam();
            //            Search_others();
            //            search_Ancillary();
            //            search_Recomendation();
            //            Availability(true);
            //            fmain.ts_add_sea.Enabled = false; fmain.ts_edit_sea.Enabled = false; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = true; fmain.ts_search_sea.Enabled = false; fmain.ts_print_sea.Enabled = false; fmain.ts_cancel_sea.Enabled = true;

            //        }
            //        else if(Action == "NO")
            //        {
            //            NewSeabase = true;
            //            Search_Patient();
            //            Availability(true);
            //            ClearAll();
            //            fmain.ts_add_sea.Enabled = true; fmain.ts_edit_sea.Enabled = false; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = false; fmain.ts_search_sea.Enabled = true; fmain.ts_print_sea.Enabled = false; fmain.ts_cancel_sea.Enabled = false;


            //        }


            //    }
            //    else
            //    {

            //        NewSeabase = true;
            //        Search_Patient();
            //        Availability(true);
            //        ClearAll();
            //        fmain.ts_add_sea.Enabled = false; fmain.ts_edit_sea.Enabled = false; fmain.ts_delete_sea.Enabled = false; fmain.ts_save_sea.Enabled = true; fmain.ts_search_sea.Enabled = false; fmain.ts_print_sea.Enabled = false; fmain.ts_cancel_sea.Enabled = true;


            //    }


            //}
            //else
            //{

            //  //  Search_Patient_sub();
            //    Search_Patient();
            //    //Search_MedicalHistory();
            //    //Search_medicalHistory2();
            //    //Search_PhyExam();
            //    //Search_others();
            //    //search_Ancillary();
            //    //search_Recomendation();

            //}


            //txt_Papin.Select();
            //Medical_personnel();
        }

        //void Medical_personnel()
        //{
        //    ClassSql b = new ClassSql();
        //    b.PutDataTOComboBox("SELECT 
        //.cn, tbl_medical.Name, tbl_medical.License, tbl_medical.Type FROM tbl_medical WHERE 


        //.Type =  'PEME Physician'", cbo_medtech, "Name", "cn");
        //    b.PutDataTOTextBox("SELECT tbl_medical.cn, tbl_medical.Name, tbl_medical.License, tbl_medical.Type FROM tbl_medical WHERE tbl_medical.Type =  'PEME MedicalDirector'", txt_medDir_Cbo, "Name");
        //    //

        //}

        private void cbo_recomendation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_recomendation.Text != "FIT WITH RESTRICTION") { x_restriction.Clear(); label163.Visible = false; x_restriction.Visible = false; } else { label163.Visible = true; x_restriction.Visible = true; }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // dt_resultdate_rec.Text = dt_resultDate.Text;
            SendKeys.Send("{RIGHT}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dt_fitness_date.Text = dt_fitness_Date.Text;SendKeys.Send("{RIGHT}");
            SendKeys.Send("{RIGHT}");
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            // dt_valid_until.Text = dt_validUntil.Text;
            SendKeys.Send("{RIGHT}");
        }

        private void dt_resultDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dt_resultDate.Format = DateTimePickerFormat.Custom;
                dt_resultDate.CustomFormat = "00/00/0000";
            }
        }

        private void dt_resultDate_MouseDown(object sender, MouseEventArgs e)
        {
            dt_resultDate.Format = DateTimePickerFormat.Custom;
            dt_resultDate.CustomFormat = "MM/dd/yyyy";
            //dt_resultDate.Value = DateTime.Now;

        }

        private void dt_fitness_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dt_fitness_Date.Format = DateTimePickerFormat.Custom;
                dt_fitness_Date.CustomFormat = "00/00/0000";
            }

        }

        private void dt_fitness_Date_MouseDown(object sender, MouseEventArgs e)
        {
            dt_fitness_Date.Format = DateTimePickerFormat.Custom;
            dt_fitness_Date.CustomFormat = "MM/dd/yyyy";
            //dt_fitness_Date.Value = DateTime.Now;

        }

        private void dt_validUntil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dt_validUntil.Format = DateTimePickerFormat.Custom;
                dt_validUntil.CustomFormat = "00/00/0000";
            }
        }

        private void dt_validUntil_MouseDown(object sender, MouseEventArgs e)
        {
            dt_validUntil.Format = DateTimePickerFormat.Custom;
            dt_validUntil.CustomFormat = "MM/dd/yyyy";
            //dt_validUntil.Value = DateTime.Now;
        }

        private void dt_dateTaken_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dt_dateTaken.Format = DateTimePickerFormat.Custom;
                dt_dateTaken.CustomFormat = "00/00/0000";
            }
        }

        private void dt_dateTaken_MouseDown(object sender, MouseEventArgs e)
        {
            dt_dateTaken.Format = DateTimePickerFormat.Custom;
            dt_dateTaken.CustomFormat = "MM/dd/yyyy";
            //dt_dateTaken.Value = DateTime.Now;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb_visual_worn_Spectacles.Checked = false;
            rb_visual_worn_ContactLenses.Checked = false;
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel66);
        }

        private void clearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel74);
        }

        private void clearToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel73);
        }

        private void clearToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel72);
        }

        private void clearToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel71);
        }

        private void clearToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel70);
        }

        private void clearToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel69);

        }

        private void clearToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel68);
        }

        private void clearToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel27);
        }

        private void contextMenuStrip11_Opening(object sender, CancelEventArgs e)
        {
            Tool.ClearFields(panel11);
        }

        private void contextMenuStrip12_Opening(object sender, CancelEventArgs e)
        {

        }

        private void clearToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel12);
        }

        private void clearToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel13);
        }

        private void clearToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel22);
        }

        private void clearToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel23);
        }

        private void clearToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel5);
        }

        private void clearToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel24);
        }

        private void clearToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel26);
        }

        private void clearToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(groupBox3);
        }

        private void clearToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel60);
        }

        private void clearToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Tool.ClearFields(panel11);
        }

        private void cbo_medtech_SelectedIndexChanged(object sender, EventArgs e)
        {
            string med1; string med2;
            IniFile ini = new IniFile(ClassSql.MMS_Path);
            med1 = ini.IniReadValue("MEDICAL", "PEME_Physician");
            med2 = ini.IniReadValue("MEDICAL", "PEME MedicalDirector");

            if (cbo_medtech.Text == med1)
            { MedtectLicence = ini.IniReadValue("MEDICAL", "PEME_Physician_license"); }
            else
            { MedtectLicence = ini.IniReadValue("MEDICAL", "PEME MedicalDirector_license"); }
        }

        private void txt_bday_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime CurrentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
                int Age = CurrentDate.Year - Convert.ToDateTime(txt_bday.Text).Year;// dtbday.Value.Year;// Convert.ToDateTime(dtbday.Text).Year;
                //this.txt_age.Text = Age.ToString();
                if (CurrentDate.Month < Convert.ToDateTime(txt_bday.Text).Month)
                {
                    Age--;
                }
                else if ((CurrentDate.Month == Convert.ToDateTime(txt_bday.Text).Month) && (CurrentDate.Day < Convert.ToDateTime(txt_bday.Text).Day))
                {

                    Age--;
                }
                this.txt_age.Text = Age.ToString();
            }
            catch
            { }



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                
                var list = db.sp_Seabase_SearchList("%");
                Cursor.Current = Cursors.WaitCursor;                
                foreach (var i in list)
                {
                    Seabase_SearchList_Model.Add(new Seabase_SearchList_Model
                    {
                        cn = i.cn,
                        papin = i.papin,
                        resultID = i.resultid,
                        patientName = i.PatientName,
                        resultDate = i.result_date,
                        recommendation = i.recommendation

                    });

                   

                }
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
           
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                var list = db.sp_LandbaseAddList("%").ToList();
                Cursor.Current = Cursors.WaitCursor;
                foreach (var i in list)
                {
                    SeabaseAdd_model.Add(new QueueSearchList_Model
                    {
                        cn = i.cn,
                        papin = i.papin,
                        PatientName = i.patientName,
                        gender = i.gender

                    });


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
            //finally
            //{

            //    if (ClassSql.dr != null) { ClassSql.dr.Close(); }

            //}
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (!backgroundWorker2.IsBusy)
                { backgroundWorker2.RunWorkerAsync(); }
                if ((Application.OpenForms["frm_search_SeaBase"] as frm_search_SeaBase) != null)
                { (Application.OpenForms["frm_search_SeaBase"] as frm_search_SeaBase).FillDataGridView(); }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }




           

        }

        private void frm_seafarer_MEC_Enter(object sender, EventArgs e)
        {
            Seabase_SearchList_Model.Clear();
            SeabaseAdd_model.Clear();
            if (!backgroundWorker1.IsBusy)
            { backgroundWorker1.RunWorkerAsync(); }
        }

        private void cmd_editname_Click(object sender, EventArgs e)
        {
            txtlastname.ReadOnly = false; txtFirstname.ReadOnly = false; txtMiddleName.ReadOnly = false;
        }

        public string Resultid, BloodDisorder, MentalDisorder, Cardiovascular, CircumferenceChest, Infection, NervousSystem, Digestive, Liver, Anemia, UrineSyphilisis;
        private void cmd_more_PhyExam_Click(object sender, EventArgs e)
        {
            using (frm_krpan f = new frm_krpan(this))
            {
                f.isEdit = isEdit;
                f.Tag = LabID.Text;
                f.ShowDialog();
            }
        }




    }
}
