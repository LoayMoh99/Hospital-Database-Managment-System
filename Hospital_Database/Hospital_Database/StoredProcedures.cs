using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Database
{
	class StoredProcedures
	{
		//Patient data
        public static string PasswordUpdate = "PasswordUpdate";
        public static string CheckPatientExistance = "CheckPatientExistance";
        public static string CheckPatientExistance2 = "CheckPatientExistance2";
		public static string GetPatientName = "GetPatientName";
		public static string GetPatientDob = "GetPatientDob";
		public static string GetPatientGender = "GetPatientGender";
		public static string GetPatientWeight = "GetPatientWeight";
		public static string GetPatientHeight = "GetPatientHeight";
		public static string GetPatientBloodType = "GetPatientBloodType";
		public static string GetChronicDiseases = "GetChronicDiseases";
		public static string GetRecords = "GetRecords";
		public static string GetPrescription = "GetPrescription";
		public static string GetMedicineNameAndID = "GetMedicineNameAndID";
        public static string GetHospitalNameAndID = "GetHospitalNameAndID";

        public static string AddMedToPat = "AddMedToPat";
        public static string DeleteFromPresc = "DeleteFromPresc";
        public static string AddMedRecord = "AddMedRecord";
        public static string AddChronicDisease = "AddChronicDisease";
        /////////////////////////////////////////////////////////////////////
        public static string RetrieveForgottenPass = "RetrieveForgottenPass";
        public static string RetrieveSSN = "RetrieveSSN";
        public static string RetrieveUserandPass = "RetrieveUserandPass";
        public static string RetrieveCertainSSN = "RetrieveCertainSSN";
        public static string GetUserType = "GetUserType";
        public static string HowManyDoesHeManage = "HowManyDoesHeManage";
        public static string HospitalsWithoutManagers = "HospitalsWithoutManagers";
        public static string RetrieveHosID = "RetrieveHosID";
        public static string InsertPatientInfo = "InsertPatientInfo";
        public static string InsertDoctorInfo = "InsertDoctorInfo";
        public static string InsertNurseInfo = "InsertNurseInfo";
        public static string InsertManagerInfo = "InsertManagerInfo";
        public static string AddHospital = "AddHospital";
        public static string Register = "Register";
        public static string AssignManagerToHospital = "AssignManagerToHospital";
        public static string IsDocInADep = "IsDocInADep";
        public static string AssignDoctorToDepartment = "AssignDoctorToDepartment";
        public static string IsNurseInAHospital = "IsNurseInAHospital";
        public static string AssignNurseToHospital = "AssignNurseToHospital";
        public static string NULLIT = "NULLIT";
        public static string RegisterUpdate = "RegisterUpdate";

        public static string Ubloodtype = "Ubloodytype";
        public static string UWeight = "UWeight";
        public static string UHeight = "UHieght";

        ////////////////////////
        public static string AddComplaint = "AddComplaint";
        public static string AddXrayImage = "AddXrayImage";
        public static string GetXrayImage = "GetXrayImage";
    }
}
