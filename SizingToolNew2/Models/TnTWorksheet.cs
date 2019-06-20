﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SizingToolNew2.Models
{
    public class TnTWorksheet
    {


        public TnTWorksheet()

        {

            #region " Start of default values "

            // Setting Field default values Start Here.


            // AcctName = "Select an Account";
            ExecuteTransitionPlan_Count = 1;
            ExecuteTransitionPlan_TransitionHoursItem = (0.30952380952381 * TotalTransitionHoursItem);
            // ExecuteTransitionPlan_TransitionHours = 300;
            ExecuteTransitionPlan_TransformationHoursItem = 250;
            // ExecuteTransitionPlan_TransformationHours = 250;


            CreateBestPracticeCustom_Count = 1;
            CreateBestPracticeCustom_TransitionHoursItem = 40;
            // CreateBestPracticeCustom_TransitionHours = 40;
            CreateBestPracticeCustom_TransformationHoursItem = 33;
            // CreateBestPracticeCustom_TransformationHours = 33;

            TestInfrastructurePOC_Count = 1;
            TestInfrastructurePOC_TransitionHoursItem = 40;
            TestInfrastructurePOC_TransitionHours = 40;
            TestInfrastructurePOC_TransformationHoursItem = 33;
            TestInfrastructurePOC_TransformationHours = 33;

            TroubleshootTune_Count = 1;
            TroubleshootTune_TransitionHoursItem = 40;
            TroubleshootTune_TransitionHours = 40;
            TroubleshootTune_TransformationHoursItem = 33;
            TroubleshootTune_TransformationHours = 33;

            InstallConfigure_Count = 1;
            InstallConfigure_TransitionHoursItem = 40;
            InstallConfigure_TransitionHours = 40;
            InstallConfigure_TransformationHoursItem = 33;
            InstallConfigure_TransformationHours = 33;

            AdministratorTraining_Count = 1;
            AdministratorTraining_TransitionHoursItem = 20;
            AdministratorTraining_TransitionHours = 20;
            AdministratorTraining_TransformationHoursItem = 17;
            AdministratorTraining_TransformationHours = 17;

            DevelopServiceResponsibilityMatrix_Count = 1;
            DevelopServiceResponsibilityMatrix_TransitionHoursItem = 16;
            DevelopServiceResponsibilityMatrix_TransitionHours = 16;
            DevelopServiceResponsibilityMatrix_TransformationHoursItem = 13;
            DevelopServiceResponsibilityMatrix_TransformationHours = 13;

            EstablishAnyNeededServiceAccounts_Count = 1;
            EstablishAnyNeededServiceAccounts_TransitionHoursItem = 16;
            EstablishAnyNeededServiceAccounts_TransitionHours = 16;
            EstablishAnyNeededServiceAccounts_TransformationHoursItem = 13;
            EstablishAnyNeededServiceAccounts_TransformationHours = 13;

            ResearchAndSetupEmailAutomation_Count = 1;
            ResearchAndSetupEmailAutomation_TransitionHoursItem = 16;
            ResearchAndSetupEmailAutomation_TransitionHours = 16;
            ResearchAndSetupEmailAutomation_TransformationHoursItem = 13;

            ResearchAndSetupEmailAutomation_TransformationHours = 13;
            InstallConfigureRemoteConsoles_Count = 1;
            InstallConfigureRemoteConsoles_TransitionHoursItem = 16;
            InstallConfigureRemoteConsoles_TransitionHours = 16;
            InstallConfigureRemoteConsoles_TransformationHoursItem = 13;
            InstallConfigureRemoteConsoles_TransformationHours = 13;

            WorkWithSECOPS_Count = 1;
            WorkWithSECOPS_TransitionHoursItem = 16;
            WorkWithSECOPS_TransitionHours = 16;
            WorkWithSECOPS_TransformationHoursItem = 13;
            WorkWithSECOPS_TransformationHours = 13;

            StaffingCcoordinating_Count = 1;
            StaffingCcoordinating_TransitionHoursItem = 10;
            StaffingCcoordinating_TransitionHours = 10;
            StaffingCcoordinating_TransformationHoursItem = 8;
            StaffingCcoordinating_TransformationHours = 8;

            IdentifyTestDocument_Count = 1;
            IdentifyTestDocument_TransitionHoursItem = 10;
            IdentifyTestDocument_TransitionHours = 10;
            IdentifyTestDocument_TransformationHoursItem = 8;
            IdentifyTestDocument_TransformationHours = 8;

            ObtainNetworkAndOsAccessWave1_Count = 1;
            ObtainNetworkAndOsAccessWave1_TransitionHoursItem = 10;
            ObtainNetworkAndOsAccessWave1_TransitionHours = 10;
            ObtainNetworkAndOsAccessWave1_TransformationHoursItem = 8;
            ObtainNetworkAndOsAccessWave1_TransformationHours = 8;

            ObtainNetworkAndOsAccessWave2_Count = 1;
            ObtainNetworkAndOsAccessWave2_TransitionHoursItem = 10;
            ObtainNetworkAndOsAccessWave2_TransitionHours = 10;
            ObtainNetworkAndOsAccessWave2_TransformationHoursItem = 8;
            ObtainNetworkAndOsAccessWave2_TransformationHours = 8;

            DevelopProvideAgentSoftware_Count = 1;
            DevelopProvideAgentSoftware_TransitionHoursItem = 10;
            DevelopProvideAgentSoftware_TransitionHours = 10;
            DevelopProvideAgentSoftware_TransformationHoursItem = 8;
            DevelopProvideAgentSoftware_TransformationHours = 8;

            InstallConfigureODBC_Count = 1;
            InstallConfigureODBC_TransitionHoursItem = 10;
            InstallConfigureODBC_TransitionHours = 10;
            InstallConfigureODBC_TransformationHoursItem = 8;
            InstallConfigureODBC_TransformationHours = 8;

            CustomerReviewSignoff_Count = 1;
            CustomerReviewSignoff_TransitionHoursItem = 10;
            CustomerReviewSignoff_TransitionHours = 10;
            CustomerReviewSignoff_TransformationHoursItem = 8;
            CustomerReviewSignoff_TransformationHours = 8;

            EstablishHealthCheck_Count = 1;
            EstablishHealthCheck_TransitionHoursItem = 10;
            EstablishHealthCheck_TransitionHours = 10;
            EstablishHealthCheck_TransformationHoursItem = 8;
            EstablishHealthCheck_TransformationHours = 8;

            DevelopWorkFlows_Count = 1;
            DevelopWorkFlows_TransitionHoursItem = 10;
            DevelopWorkFlows_TransitionHours = 10;
            DevelopWorkFlows_TransformationHoursItem = 8;
            DevelopWorkFlows_TransformationHours = 8;

            OperationalDocumentation_Count = 1;
            OperationalDocumentation_TransitionHoursItem = 10;
            OperationalDocumentation_TransitionHours = 10;
            OperationalDocumentation_TransformationHoursItem = 8;
            OperationalDocumentation_TransformationHours = 8;

            ShadowEstablishReviewAllProcedures_Count = 1;
            ShadowEstablishReviewAllProcedures_TransitionHoursItem = 60;
            ShadowEstablishReviewAllProcedures_TransitionHours = 60;
            ShadowEstablishReviewAllProcedures_TransformationHoursItem = 50;
            ShadowEstablishReviewAllProcedures_TransformationHours = 50;

            OtherDetail_Count = 1;
            OtherDetail_TransitionHoursItem = 249;
            OtherDetail_TransitionHours = 249;
            OtherDetail_TransformationHoursItem = 208;
            OtherDetail_TransformationHours = 208;

            SpecialItem1_Count = 0.01;
            SpecialItem1_TransitionHoursItem = 0.01;
            SpecialItem1_TransitionHours = 0.01;
            SpecialItem1_TransformationHoursItem = 0.01;
            SpecialItem1_TransformationHours = 0.01;

            SpecialItem2_Count = 0.01;
            SpecialItem2_TransitionHoursItem = 0.01;
            SpecialItem2_TransitionHours = 0.01;
            SpecialItem2_TransformationHoursItem = 0.01;
            SpecialItem2_TransformationHours = 0.01;

            SpecialItem3_Count = 0.01;
            SpecialItem3_TransitionHoursItem = 0.01;
            SpecialItem3_TransitionHours = 0.01;
            SpecialItem3_TransformationHoursItem = 0.01;
            SpecialItem3_TransformationHours = 0.01;

            SpecialItem4_Count = 0.01;
            SpecialItem4_TransitionHoursItem = 0.01;
            SpecialItem4_TransitionHours = 0.01;
            SpecialItem4_TransformationHoursItem = 0.01;
            SpecialItem4_TransformationHours = 0.01;

            SpecialItem5_Count = 0.01;
            SpecialItem5_TransitionHoursItem = 0.01;
            SpecialItem5_TransitionHours = 0.01;
            SpecialItem5_TransformationHoursItem = 0.01;
            SpecialItem5_TransformationHours = 0.01;

            TransitionFirstLineManagementBand8 = (0);
            TransitionSecondLineManagementBand8 = (0);


            // Management Modifiers
            ManagementMod1stLine = (0.05);
            ManagementMod2ndLine = (.0083);


            // TotalTransitionHoursItem = SpecialItem1_TransitionHours + SpecialItem2_TransitionHours + SpecialItem3_TransitionHours + SpecialItem4_TransitionHours + SpecialItem5_TransitionHours;
            // TotalTransformationHoursItem = (SpecialItem1_TransformationHours + SpecialItem2_TransformationHours + SpecialItem3_TransformationHours + SpecialItem4_TransformationHours + SpecialItem5_TransformationHours);

            #endregion

        }



        [Key]
        public int? TnTId { get; set; }
        public int? SizingId { get; set; }
        public string TnTDescription { get; set; }

        public virtual ICollection<Sizing> Sizings { get; set; }



        // Management Modifiers (Variable)
        public double ManagementMod1stLine { get { return (0.05); } set { } }
        public double ManagementMod2ndLine { get { return (0.0083); } set { } }

        // Project Totals section of Calculate FTE Form
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransitionTotalFTE { get { return (TotalTransitionTotalBand8 + TotalTransitionTotal1stLineMgr + TotalTransitionTotal2ndLineMgr); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransitionTotalHours { get { return (TotalTransitionHoursItem); } set { } }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double TotalTransitionTotalBand8 { get { return (TransitionHoursFTE); } set { } }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double TotalTransitionTotal1stLineMgr { get { return (TransitionFirstLineManagementBand8Weeks); } set { } }
        [DisplayFormat(DataFormatString = "{0:n3}", ApplyFormatInEditMode = true)]
        public double TotalTransitionTotal2ndLineMgr { get { return (TransitionSecondLineManagementBand8Weeks); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransitionTotals { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransformationTotalFTE { get { return (TotalTransformationTotalBand8 + TotalTransformationTotal1stLineMgr + TotalTransformationTotal2ndLineMgr); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransformationTotalHours { get { return (TotalTransformationHoursItem); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransformationTotalBand8 { get { return (TransfortionHoursFTE); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransformationTotal1stLineMgr { get { return (TransformationFirstLineManagementBand8Weeks); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransformationTotal2ndLineMgr { get { return (TransformationSecondLineManagementBand8Weeks); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransformationTotals { get; set; }


        #region T and T Worksheet Start 
        // ****** Start T and T Worksheet
        // Transition and Transformation Calc for 1st and 2nd Line
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionHoursFTE { get { return ((ManagementMod2ndLine * TotalTransitionHoursItem) / 100); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionFirstLineManagementBand8 { get { return (ManagementMod1stLine * TotalTransitionHoursItem); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionSecondLineManagementBand8 { get { return (ManagementMod2ndLine * TotalTransitionHoursItem); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionFirstLineManagementBand8Weeks { get { return ((ManagementMod1stLine * TotalTransitionHoursItem) / 1000); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionSecondLineManagementBand8Weeks { get { return ((ManagementMod2ndLine * TotalTransitionHoursItem) / 100); } set { } }

        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double TransitionSubTotalsHours { get { return (TransitionFirstLineManagementBand8 + TransitionSecondLineManagementBand8 + TotalTransitionHoursItem); } set { } }

      

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransitionFirstLineManagementBand8Hours { get { return (ManagementMod1stLine * TotalTransitionHoursItem); } set { } }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransfortionHoursFTE { get { return ((ManagementMod2ndLine * TotalTransformationHoursItem) / 100); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransformationFirstLineManagementBand8 { get { return (ManagementMod1stLine * TotalTransformationHoursItem); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransformationSecondLineManagementBand8 { get { return (ManagementMod2ndLine * TotalTransformationHoursItem); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransformationFirstLineManagementBand8Weeks { get { return ((ManagementMod1stLine * TotalTransformationHoursItem) / 1000); } set { } }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TransformationSecondLineManagementBand8Weeks { get { return ((ManagementMod2ndLine * TotalTransformationHoursItem) / 100); } set { } }

        [DisplayFormat(DataFormatString = "{0:n0}", ApplyFormatInEditMode = true)]
        public double TranformationSubTotalsHours { get { return (TransformationFirstLineManagementBand8 + TransformationSecondLineManagementBand8 + TotalTransformationHoursItem); } set { } }
        public double TransformationFirstLineManagementBand8Hours { get { return (ManagementMod1stLine * TotalTransformationHoursItem); } set { } }


        public double TransitionSubTotalsHoursItems { get { return (ExecuteTransitionPlan_TransitionHours + CreateBestPracticeCustom_TransitionHours +
TestInfrastructurePOC_TransitionHours
+
TroubleshootTune_TransitionHours
+
InstallConfigure_TransitionHours
+
AdministratorTraining_TransitionHours
+
DevelopServiceResponsibilityMatrix_TransitionHours
+
EstablishAnyNeededServiceAccounts_TransitionHours
+
ResearchAndSetupEmailAutomation_TransitionHours
+
InstallConfigureRemoteConsoles_TransitionHours
+
WorkWithSECOPS_TransitionHours
+
StaffingCcoordinating_TransitionHours
+
IdentifyTestDocument_TransitionHours
+
ObtainNetworkAndOsAccessWave1_TransitionHours
+
ObtainNetworkAndOsAccessWave2_TransitionHours
+
DevelopProvideAgentSoftware_TransitionHours
+
InstallConfigureODBC_TransitionHours
+
CustomerReviewSignoff_TransitionHours
+
EstablishHealthCheck_TransitionHours
+
DevelopWorkFlows_TransitionHours
+
OperationalDocumentation_TransitionHours
+
ShadowEstablishReviewAllProcedures_TransitionHours
+
OtherDetail_TransitionHours
+
SpecialItem1_TransitionHours
+
SpecialItem2_TransitionHours
+
SpecialItem3_TransitionHours
+
SpecialItem4_TransitionHours
+
SpecialItem5_TransitionHours); } set { } }

public double TransformationSubTotalsHoursItems { get { return (ExecuteTransitionPlan_TransformationHours
+
CreateBestPracticeCustom_TransformationHours
+
TestInfrastructurePOC_TransformationHours
+
TroubleshootTune_TransformationHours
+
InstallConfigure_TransformationHours
+
AdministratorTraining_TransformationHours
+
DevelopServiceResponsibilityMatrix_TransformationHours
+
EstablishAnyNeededServiceAccounts_TransformationHours
+
ResearchAndSetupEmailAutomation_TransformationHours
+
InstallConfigureRemoteConsoles_TransformationHours
+
WorkWithSECOPS_TransformationHours
+
StaffingCcoordinating_TransformationHours
+
IdentifyTestDocument_TransformationHours
+
ObtainNetworkAndOsAccessWave1_TransformationHours
+
ObtainNetworkAndOsAccessWave2_TransformationHours
+
DevelopProvideAgentSoftware_TransformationHours
+
InstallConfigureODBC_TransformationHours
+
CustomerReviewSignoff_TransformationHours
+
EstablishHealthCheck_TransformationHours
+
DevelopWorkFlows_TransformationHours
+
 OperationalDocumentation_TransformationHours
+
ShadowEstablishReviewAllProcedures_TransformationHours
+
OtherDetail_TransformationHours
+
SpecialItem1_TransformationHours
+
SpecialItem2_TransformationHours
+
SpecialItem3_TransformationHours
+
SpecialItem4_TransformationHours
+
SpecialItem5_TransformationHours); } set { } }


        public double ExecuteTransitionPlan_Count { get; set; }
        public double ExecuteTransitionPlan_TransitionHoursItem { get; set; }
        public double ExecuteTransitionPlan_TransitionHours { get { return ExecuteTransitionPlan_TransitionHoursItem * ExecuteTransitionPlan_Count; } set { } }
        //  public double ExecuteTransitionPlan_TransitionHours => ExecuteTransitionPlan_Count * ExecuteTransitionPlan_TransitionHoursItem;
        public double ExecuteTransitionPlan_TransformationHoursItem { get; set; }
        public double ExecuteTransitionPlan_TransformationHours { get { return ExecuteTransitionPlan_Count * ExecuteTransitionPlan_TransformationHoursItem; } set { } }

        // T and T - CreateBestPracticeCustom
        public double CreateBestPracticeCustom_Count { get; set; }
        public double CreateBestPracticeCustom_TransitionHoursItem { get; set; }
        public double CreateBestPracticeCustom_TransitionHours { get { return CreateBestPracticeCustom_Count * CreateBestPracticeCustom_TransitionHoursItem; } set { } }
        public double CreateBestPracticeCustom_TransformationHoursItem { get; set; }
        public double CreateBestPracticeCustom_TransformationHours { get { return CreateBestPracticeCustom_Count * CreateBestPracticeCustom_TransformationHoursItem; } set { } }

        //  T and T - TestInfrastructurePOC
        public double TestInfrastructurePOC_Count { get; set; }
        public double TestInfrastructurePOC_TransitionHoursItem { get; set; }
        public double TestInfrastructurePOC_TransitionHours { get { return TestInfrastructurePOC_Count * TestInfrastructurePOC_TransitionHoursItem; } set { } }
        public double TestInfrastructurePOC_TransformationHoursItem { get; set; }
        public double TestInfrastructurePOC_TransformationHours { get { return TestInfrastructurePOC_Count * TestInfrastructurePOC_TransformationHoursItem; } set { } }

        //  T and T - TroubleshootTune
        public double TroubleshootTune_Count { get; set; }
        public double TroubleshootTune_TransitionHoursItem { get; set; }
        public double TroubleshootTune_TransitionHours { get { return TroubleshootTune_Count * TroubleshootTune_TransitionHoursItem; } set { } }
        public double TroubleshootTune_TransformationHoursItem { get; set; }
        public double TroubleshootTune_TransformationHours { get { return TroubleshootTune_Count * TroubleshootTune_TransformationHoursItem; } set { } }

        // T and T - InstallConfigure
        public double InstallConfigure_Count { get; set; }
        public double InstallConfigure_TransitionHoursItem { get; set; }
        public double InstallConfigure_TransitionHours { get { return InstallConfigure_Count * InstallConfigure_TransitionHoursItem; } set { } }
        public double InstallConfigure_TransformationHoursItem { get; set; }
        public double InstallConfigure_TransformationHours { get { return InstallConfigure_Count * InstallConfigure_TransformationHoursItem; } set { } }

        // T and T - AdministratorTraining
        public double AdministratorTraining_Count { get; set; }
        public double AdministratorTraining_TransitionHoursItem { get; set; }
        public double AdministratorTraining_TransitionHours { get { return AdministratorTraining_Count * AdministratorTraining_TransitionHoursItem; } set { } }
        public double AdministratorTraining_TransformationHoursItem { get; set; }
        public double AdministratorTraining_TransformationHours { get { return AdministratorTraining_Count * AdministratorTraining_TransformationHoursItem; } set { } }

        // T and T - DevelopServiceResponsibilityMatrix
        public double DevelopServiceResponsibilityMatrix_Count { get; set; }
        public double DevelopServiceResponsibilityMatrix_TransitionHoursItem { get; set; }
        public double DevelopServiceResponsibilityMatrix_TransitionHours { get { return DevelopServiceResponsibilityMatrix_Count * DevelopServiceResponsibilityMatrix_TransitionHoursItem; } set { } }
        public double DevelopServiceResponsibilityMatrix_TransformationHoursItem { get; set; }
        public double DevelopServiceResponsibilityMatrix_TransformationHours { get { return DevelopServiceResponsibilityMatrix_Count * DevelopServiceResponsibilityMatrix_TransformationHoursItem; } set { } }

        // T and T - EstablishAnyNeededServiceAccounts
        public double EstablishAnyNeededServiceAccounts_Count { get; set; }
        public double EstablishAnyNeededServiceAccounts_TransitionHoursItem { get; set; }
        public double EstablishAnyNeededServiceAccounts_TransitionHours { get { return EstablishAnyNeededServiceAccounts_Count * EstablishAnyNeededServiceAccounts_TransitionHoursItem; } set { } }
        public double EstablishAnyNeededServiceAccounts_TransformationHoursItem { get; set; }
        public double EstablishAnyNeededServiceAccounts_TransformationHours { get { return EstablishAnyNeededServiceAccounts_Count * EstablishAnyNeededServiceAccounts_TransformationHoursItem; } set { } }

        // T and T - ResearchAndSetupEmailAutomation
        public double ResearchAndSetupEmailAutomation_Count { get; set; }
        public double ResearchAndSetupEmailAutomation_TransitionHoursItem { get; set; }
        public double ResearchAndSetupEmailAutomation_TransitionHours { get { return ResearchAndSetupEmailAutomation_Count * ResearchAndSetupEmailAutomation_TransitionHoursItem; } set { } }
        public double ResearchAndSetupEmailAutomation_TransformationHoursItem { get; set; }
        public double ResearchAndSetupEmailAutomation_TransformationHours { get { return ResearchAndSetupEmailAutomation_Count * ResearchAndSetupEmailAutomation_TransformationHoursItem; } set { } }

        // T and T - InstallConfigureRemoteConsoles
        public double InstallConfigureRemoteConsoles_Count { get; set; }
        public double InstallConfigureRemoteConsoles_TransitionHoursItem { get; set; }
        public double InstallConfigureRemoteConsoles_TransitionHours { get { return InstallConfigureRemoteConsoles_Count * InstallConfigureRemoteConsoles_TransitionHoursItem; } set { } }
        public double InstallConfigureRemoteConsoles_TransformationHoursItem { get; set; }
        public double InstallConfigureRemoteConsoles_TransformationHours { get { return InstallConfigureRemoteConsoles_Count * InstallConfigureRemoteConsoles_TransformationHoursItem; } set { } }

        // T and T - WorkWithSECOPS
        public double WorkWithSECOPS_Count { get; set; }
        public double WorkWithSECOPS_TransitionHoursItem { get; set; }
        public double WorkWithSECOPS_TransitionHours { get { return WorkWithSECOPS_Count * WorkWithSECOPS_TransitionHoursItem; } set { } }
        public double WorkWithSECOPS_TransformationHoursItem { get; set; }
        public double WorkWithSECOPS_TransformationHours { get { return WorkWithSECOPS_Count * WorkWithSECOPS_TransformationHoursItem; } set { } }

        // T and T - StaffingCcoordinating
        public double StaffingCcoordinating_Count { get; set; }
        public double StaffingCcoordinating_TransitionHoursItem { get; set; }
        public double StaffingCcoordinating_TransitionHours { get { return StaffingCcoordinating_Count * StaffingCcoordinating_TransitionHoursItem; } set { } }
        public double StaffingCcoordinating_TransformationHoursItem { get; set; }
        public double StaffingCcoordinating_TransformationHours { get { return StaffingCcoordinating_Count * StaffingCcoordinating_TransformationHoursItem; } set { } }

        // T and T - IdentifyTestDocument
        public double IdentifyTestDocument_Count { get; set; }
        public double IdentifyTestDocument_TransitionHoursItem { get; set; }
        public double IdentifyTestDocument_TransitionHours { get { return IdentifyTestDocument_Count * IdentifyTestDocument_TransitionHoursItem; } set { } }
        public double IdentifyTestDocument_TransformationHoursItem { get; set; }
        public double IdentifyTestDocument_TransformationHours { get { return IdentifyTestDocument_Count * IdentifyTestDocument_TransformationHoursItem; } set { } }

        // T and T - ObtainNetworkAndOsAccessWave1
        public double ObtainNetworkAndOsAccessWave1_Count { get; set; }
        public double ObtainNetworkAndOsAccessWave1_TransitionHoursItem { get; set; }
        public double ObtainNetworkAndOsAccessWave1_TransitionHours { get { return ObtainNetworkAndOsAccessWave1_Count * ObtainNetworkAndOsAccessWave1_TransitionHoursItem; } set { } }
        public double ObtainNetworkAndOsAccessWave1_TransformationHoursItem { get; set; }
        public double ObtainNetworkAndOsAccessWave1_TransformationHours { get { return ObtainNetworkAndOsAccessWave1_Count * ObtainNetworkAndOsAccessWave1_TransformationHoursItem; } set { } }

        // T and T - ObtainNetworkAndOsAccessWave2
        public double ObtainNetworkAndOsAccessWave2_Count { get; set; }
        public double ObtainNetworkAndOsAccessWave2_TransitionHoursItem { get; set; }
        public double ObtainNetworkAndOsAccessWave2_TransitionHours { get { return ObtainNetworkAndOsAccessWave2_Count * ObtainNetworkAndOsAccessWave2_TransitionHoursItem; } set { } }
        public double ObtainNetworkAndOsAccessWave2_TransformationHoursItem { get; set; }
        public double ObtainNetworkAndOsAccessWave2_TransformationHours { get { return ObtainNetworkAndOsAccessWave2_Count * ObtainNetworkAndOsAccessWave2_TransformationHoursItem; } set { } }


        // Develop/provide agent to software deployment
        public double DevelopProvideAgentSoftware_Count { get; set; }
        public double DevelopProvideAgentSoftware_TransitionHoursItem { get; set; }
        public double DevelopProvideAgentSoftware_TransitionHours { get { return DevelopProvideAgentSoftware_Count * DevelopProvideAgentSoftware_TransitionHoursItem; } set { } }
        public double DevelopProvideAgentSoftware_TransformationHoursItem { get; set; }
        public double DevelopProvideAgentSoftware_TransformationHours { get { return DevelopProvideAgentSoftware_Count * DevelopProvideAgentSoftware_TransformationHoursItem; } set { } }

        // Install/configure ODBC or other connectors to metaconsoles
        public double InstallConfigureODBC_Count { get; set; }
        public double InstallConfigureODBC_TransitionHoursItem { get; set; }
        public double InstallConfigureODBC_TransitionHours { get { return InstallConfigureODBC_Count * InstallConfigureODBC_TransitionHoursItem; } set { } }
        public double InstallConfigureODBC_TransformationHoursItem { get; set; }
        public double InstallConfigureODBC_TransformationHours { get { return InstallConfigureODBC_Count * InstallConfigureODBC_TransformationHoursItem; } set { } }


        //Customer review and sign-off on infrastructure set up
        public double CustomerReviewSignoff_Count { get; set; }
        public double CustomerReviewSignoff_TransitionHoursItem { get; set; }
        public double CustomerReviewSignoff_TransitionHours { get { return CustomerReviewSignoff_Count * CustomerReviewSignoff_TransitionHoursItem; } set { } }
        public double CustomerReviewSignoff_TransformationHoursItem { get; set; }
        public double CustomerReviewSignoff_TransformationHours { get { return CustomerReviewSignoff_Count * CustomerReviewSignoff_TransformationHoursItem; } set { } }



        // T and T - EstablishHealthCheck
        public double EstablishHealthCheck_Count { get; set; }
        public double EstablishHealthCheck_TransitionHoursItem { get; set; }
        public double EstablishHealthCheck_TransitionHours { get { return EstablishHealthCheck_Count * EstablishHealthCheck_TransitionHoursItem; } set { } }
        public double EstablishHealthCheck_TransformationHoursItem { get; set; }
        public double EstablishHealthCheck_TransformationHours { get { return EstablishHealthCheck_Count * EstablishHealthCheck_TransformationHoursItem; } set { } }

        // T and T - DevelopWorkFlows
        public double DevelopWorkFlows_Count { get; set; }
        public double DevelopWorkFlows_TransitionHoursItem { get; set; }
        public double DevelopWorkFlows_TransitionHours { get { return DevelopWorkFlows_Count * DevelopWorkFlows_TransitionHoursItem; } set { } }
        public double DevelopWorkFlows_TransformationHoursItem { get; set; }
        public double DevelopWorkFlows_TransformationHours { get { return DevelopWorkFlows_Count * DevelopWorkFlows_TransformationHoursItem; } set { } }

        // T and T - OperationalDocumentation
        public double OperationalDocumentation_Count { get; set; }
        public double OperationalDocumentation_TransitionHoursItem { get; set; }
        public double OperationalDocumentation_TransitionHours { get { return OperationalDocumentation_Count * OperationalDocumentation_TransitionHoursItem; } set { } }
        public double OperationalDocumentation_TransformationHoursItem { get; set; }
        public double OperationalDocumentation_TransformationHours { get { return OperationalDocumentation_Count * OperationalDocumentation_TransformationHoursItem; } set { } }

        // T and T - ShadowEstablishReviewAllProcedures
        public double ShadowEstablishReviewAllProcedures_Count { get; set; }
        public double ShadowEstablishReviewAllProcedures_TransitionHoursItem { get; set; }
        public double ShadowEstablishReviewAllProcedures_TransitionHours { get { return ShadowEstablishReviewAllProcedures_Count * ShadowEstablishReviewAllProcedures_TransitionHoursItem; } set { } }
        public double ShadowEstablishReviewAllProcedures_TransformationHoursItem { get; set; }
        public double ShadowEstablishReviewAllProcedures_TransformationHours { get { return ShadowEstablishReviewAllProcedures_Count * ShadowEstablishReviewAllProcedures_TransformationHoursItem; } set { } }

        // T and T - OtherDetail
        public double OtherDetail_Count { get; set; }
        public double OtherDetail_TransitionHoursItem { get; set; }
        public double OtherDetail_TransitionHours { get { return OtherDetail_Count * OtherDetail_TransitionHoursItem; } set { } }
        public double OtherDetail_TransformationHoursItem { get; set; }
        public double OtherDetail_TransformationHours { get { return OtherDetail_Count * OtherDetail_TransformationHoursItem; } set { } }

        // T and T - SpecialItem1
        public double SpecialItem1_Count { get; set; }
        public double SpecialItem1_TransitionHoursItem { get; set; }
        public double SpecialItem1_TransitionHours { get { return SpecialItem1_Count * SpecialItem1_TransitionHoursItem; } set { } }
        public double SpecialItem1_TransformationHoursItem { get; set; }
        public double SpecialItem1_TransformationHours { get { return SpecialItem1_Count * SpecialItem1_TransformationHoursItem; } set { } }

        // T and T - SpecialItem2
        public double SpecialItem2_Count { get; set; }
        public double SpecialItem2_TransitionHoursItem { get; set; }
        public double SpecialItem2_TransitionHours { get { return SpecialItem2_Count * SpecialItem2_TransitionHoursItem; } set { } }
        public double SpecialItem2_TransformationHoursItem { get; set; }
        public double SpecialItem2_TransformationHours { get { return SpecialItem2_Count * SpecialItem2_TransformationHoursItem; } set { } }

        // T and T - SpecialItem3
        public double SpecialItem3_Count { get; set; }
        public double SpecialItem3_TransitionHoursItem { get; set; }
        public double SpecialItem3_TransitionHours { get { return SpecialItem3_Count * SpecialItem3_TransitionHoursItem; } set { } }
        public double SpecialItem3_TransformationHoursItem { get; set; }
        public double SpecialItem3_TransformationHours { get { return SpecialItem3_Count * SpecialItem3_TransformationHoursItem; } set { } }

        // T and T - SpecialItem4
        public double SpecialItem4_Count { get; set; }
        public double SpecialItem4_TransitionHoursItem { get; set; }
        public double SpecialItem4_TransitionHours { get { return SpecialItem4_Count * SpecialItem4_TransitionHoursItem; } set { } }
        public double SpecialItem4_TransformationHoursItem { get; set; }
        public double SpecialItem4_TransformationHours { get { return SpecialItem4_Count * SpecialItem4_TransformationHoursItem; } set { } }

        // T and T - SpecialItem5
        public double SpecialItem5_Count { get; set; }
        public double SpecialItem5_TransitionHoursItem { get; set; }
        public double SpecialItem5_TransitionHours { get { return SpecialItem5_Count * SpecialItem5_TransitionHoursItem; } set { } }
        public double SpecialItem5_TransformationHoursItem { get; set; }
        public double SpecialItem5_TransformationHours { get { return SpecialItem5_Count * SpecialItem5_TransformationHoursItem; } set { } }

        //Calc Total Count
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalCount => ExecuteTransitionPlan_Count + TestInfrastructurePOC_Count + TroubleshootTune_Count + InstallConfigure_Count + AdministratorTraining_Count + DevelopServiceResponsibilityMatrix_Count + EstablishAnyNeededServiceAccounts_Count + ResearchAndSetupEmailAutomation_Count + InstallConfigureRemoteConsoles_Count + WorkWithSECOPS_Count + StaffingCcoordinating_Count + IdentifyTestDocument_Count + ObtainNetworkAndOsAccessWave1_Count + ObtainNetworkAndOsAccessWave2_Count + DevelopProvideAgentSoftware_Count + InstallConfigureODBC_Count + CustomerReviewSignoff_Count + EstablishHealthCheck_Count + DevelopWorkFlows_Count + ShadowEstablishReviewAllProcedures_Count + OtherDetail_Count + SpecialItem1_Count + SpecialItem2_Count + SpecialItem4_Count + SpecialItem5_Count;

        [DisplayFormat(DataFormatString = "{0:n4}", ApplyFormatInEditMode = true)]
        // public double TotalTransitionHoursItem  { get { return TransitionWeeks * Labor); } set { } }
        public double TotalTransitionHoursItem { get; set; }

        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransitionHours => ExecuteTransitionPlan_TransitionHours + TestInfrastructurePOC_TransitionHours + TroubleshootTune_TransitionHours + InstallConfigure_TransitionHours + AdministratorTraining_TransitionHours + DevelopServiceResponsibilityMatrix_TransitionHours + EstablishAnyNeededServiceAccounts_TransitionHours + ResearchAndSetupEmailAutomation_TransitionHours + InstallConfigureRemoteConsoles_TransitionHours + WorkWithSECOPS_TransitionHours + StaffingCcoordinating_TransitionHours + IdentifyTestDocument_TransitionHours + ObtainNetworkAndOsAccessWave1_TransitionHours + ObtainNetworkAndOsAccessWave2_TransitionHours + DevelopProvideAgentSoftware_TransitionHours + InstallConfigureODBC_TransitionHours + CustomerReviewSignoff_TransitionHours + EstablishHealthCheck_TransitionHours + DevelopWorkFlows_TransitionHours + ShadowEstablishReviewAllProcedures_TransitionHours + OtherDetail_TransitionHours + SpecialItem1_TransitionHours + SpecialItem2_TransitionHours + SpecialItem4_TransitionHours + SpecialItem5_TransitionHours;

        [DisplayFormat(DataFormatString = "{0:n4}", ApplyFormatInEditMode = true)]
        // public double TotalTransformationHoursItem => ExecuteTransitionPlan_TransformationHoursItem + TestInfrastructurePOC_TransformationHoursItem + TroubleshootTune_TransformationHoursItem + InstallConfigure_TransformationHoursItem + AdministratorTraining_TransformationHoursItem + DevelopServiceResponsibilityMatrix_TransformationHoursItem + EstablishAnyNeededServiceAccounts_TransformationHoursItem + ResearchAndSetupEmailAutomation_TransformationHoursItem + InstallConfigureRemoteConsoles_TransformationHoursItem + WorkWithSECOPS_TransformationHoursItem + StaffingCcoordinating_TransformationHoursItem + IdentifyTestDocument_TransformationHoursItem + ObtainNetworkAndOsAccessWave1_TransformationHoursItem + ObtainNetworkAndOsAccessWave2_TransformationHoursItem + DevelopProvideAgentSoftware_TransformationHoursItem + InstallConfigureODBC_TransformationHoursItem + CustomerReviewSignoff_TransformationHoursItem + EstablishHealthCheck_TransformationHoursItem + DevelopWorkFlows_TransformationHoursItem + ShadowEstablishReviewAllProcedures_TransformationHoursItem + OtherDetail_TransformationHoursItem + SpecialItem1_TransformationHoursItem + SpecialItem2_TransformationHoursItem + SpecialItem4_TransformationHoursItem + SpecialItem5_TransformationHoursItem;
        public double TotalTransformationHoursItem { get; set; }


        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public double TotalTransformationHours => ExecuteTransitionPlan_TransformationHours + TestInfrastructurePOC_TransformationHours + TroubleshootTune_TransformationHours + InstallConfigure_TransformationHours + AdministratorTraining_TransformationHours + DevelopServiceResponsibilityMatrix_TransformationHours + EstablishAnyNeededServiceAccounts_TransformationHours + ResearchAndSetupEmailAutomation_TransformationHours + InstallConfigureRemoteConsoles_TransformationHours + WorkWithSECOPS_TransformationHours + StaffingCcoordinating_TransformationHours + IdentifyTestDocument_TransformationHours + ObtainNetworkAndOsAccessWave1_TransformationHours + ObtainNetworkAndOsAccessWave2_TransformationHours + DevelopProvideAgentSoftware_TransformationHours + InstallConfigureODBC_TransformationHours + CustomerReviewSignoff_TransformationHours + EstablishHealthCheck_TransformationHours + DevelopWorkFlows_TransformationHours + ShadowEstablishReviewAllProcedures_TransformationHours + OtherDetail_TransformationHours + SpecialItem1_TransformationHours + SpecialItem2_TransformationHours + SpecialItem4_TransformationHours + SpecialItem5_TransformationHours;




        // Transition weeks
        public double NumTransitionWeeks { get; set; }
        public double NumTransformationWeeks { get; set; }

        // ****** End T and T Worksheet
        #endregion T and T

    }
}