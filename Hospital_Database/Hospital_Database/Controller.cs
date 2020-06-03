using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Hospital_Database
{
	class Controller
	{
		DBManager dbMan;
		public Controller()
		{
			dbMan = new DBManager();
		}


		public void TerminateConnection()
		{
			dbMan.CloseConnection();
		}

        public int PasswordUpdate(string pass, string fh)
        {
            String StoredProcedureName = StoredProcedures.PasswordUpdate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NewPass", pass);
            Parameters.Add("@FavHob", fh);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

		public object CheckPatientExistance(int PSSN)
		{
            String StoredProcedureName = StoredProcedures.CheckPatientExistance2;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
		}
		public object GetPatientName(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetPatientName;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
		}
		public object GetPatientDob(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetPatientDob;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
		}
		public object GetPatientGender(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetPatientGender;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
		}
		public object GetPatientWeight(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetPatientWeight;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
		}
		public object GetPatientHeight(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetPatientHeight;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
		}
		public object GetPatientBloodType(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetPatientBloodType;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
		}
		
		public DataTable GetChronicDisease(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetChronicDiseases;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}

		public DataTable GetRecords(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetRecords;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}

		public DataTable GetPrescription(int PSSN)
		{
			String StoredProcedureName = StoredProcedures.GetPrescription;
			Dictionary<string, object> Parameters = new Dictionary<string, object>();
			Parameters.Add("@Patient_SSN", PSSN);
			return dbMan.ExecuteReader(StoredProcedureName, Parameters);
		}

        public DataTable GetMedicineNameAndID()
        {
            String StoredProcedureName = StoredProcedures.GetMedicineNameAndID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddMedToPat(int PSSN, int Med_Id, string numoftimes, string note)
        {
            String StoredProcedureName = StoredProcedures.AddMedToPat;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatSSN", PSSN);
            Parameters.Add("@MedID", Med_Id);
            Parameters.Add("@NumOfTime", numoftimes);
            Parameters.Add("@Note", note);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteFromPresc(int PSSN, int Med_Id)
        {
            String StoredProcedureName = StoredProcedures.DeleteFromPresc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PSSN", PSSN);
            Parameters.Add("@MID", Med_Id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddMedRecord(int PSSN, string Description, int DSSN)
        {
            String StoredProcedureName = StoredProcedures.AddMedRecord;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatSSN", PSSN);
            Parameters.Add("@R_Date", DateTime.Today);
            Parameters.Add("@Description", Description);
            Parameters.Add("@DocSSN", DSSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddChronicDisease(int PSSN, string ChroniDis_Name)
        {
            String StoredProcedureName = StoredProcedures.AddChronicDisease;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatSSN", PSSN);
            Parameters.Add("@CHD_Name", ChroniDis_Name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ////////////////////////////////////////////////////////////////////
        public object RetrievePassword(string UserName, string FavHob)
        {
            String StoredProcedureName = StoredProcedures.RetrieveForgottenPass;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@User_name", UserName);
            Parameters.Add("@FavHobby", FavHob);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int InsertPatientInfo(int PSSN,string Name, string City, string District, string AddLine, string gender, int PH_Number, string date, int weight, int height, string bloodtype)
        {
            String StoredProcedureName = StoredProcedures.InsertPatientInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@P_SSN", PSSN);
            Parameters.Add("@Name", Name);
            Parameters.Add("@City", City);
            Parameters.Add("@District", District);
            Parameters.Add("@Add_Line", AddLine);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@PH_Number", PH_Number);
            Parameters.Add("@DOB", date);
            Parameters.Add("@Weight", weight);
            Parameters.Add("@Height", height);
            Parameters.Add("@BloodType", bloodtype);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertDoctorInfo(int DSSN, string Name, string City, string District, string AddLine, string gender, int PH_Number, string date)
        {
            String StoredProcedureName = StoredProcedures.InsertDoctorInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@D_SSN", DSSN);
            Parameters.Add("@Name", Name);
            Parameters.Add("@City", City);
            Parameters.Add("@District", District);
            Parameters.Add("@Add_Line", AddLine);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@PH_Number", PH_Number);
            Parameters.Add("@DOB", date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertNurseInfo(int NSSN, string Name, string City, string District, string AddLine, string gender, int PH_Number, string date, int experience)
        {
            String StoredProcedureName = StoredProcedures.InsertNurseInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@N_SSN", NSSN);
            Parameters.Add("@Name", Name);
            Parameters.Add("@City", City);
            Parameters.Add("@District", District);
            Parameters.Add("@Add_Line", AddLine);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@PH_Number", PH_Number);
            Parameters.Add("@DOB", date);
            Parameters.Add("@Experience", experience);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertManagerInfo(int MSSN, string Name, string City, string District, string AddLine, string gender, int PH_Number, string date)
        {
            String StoredProcedureName = StoredProcedures.InsertManagerInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@M_SSN", MSSN);
            Parameters.Add("@Name", Name);
            Parameters.Add("@City", City);
            Parameters.Add("@District", District);
            Parameters.Add("@Add_Line", AddLine);
            Parameters.Add("@Gender", gender);
            Parameters.Add("@PH_Number", PH_Number);
            Parameters.Add("@DOB", date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddHospital(int id, string Name, string City, string District, string AddLine)
        {
            String StoredProcedureName = StoredProcedures.AddHospital;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@HID", id);
            Parameters.Add("@name", Name);
            Parameters.Add("@city", City);
            Parameters.Add("@district", District);
            Parameters.Add("@address", AddLine);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable RetrieveSSN()
        {
            String StoredProcedureName = StoredProcedures.RetrieveSSN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable RetrieveUserandPass()
        {
            String StoredProcedureName = StoredProcedures.RetrieveUserandPass;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public object RetrieveCertainSSN(string username)
        {
            String StoredProcedureName = StoredProcedures.RetrieveCertainSSN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UsernameI", username);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Register(int SSN, string Username, string UT, string PC, string FH)
        {
            String StoredProcedureName = StoredProcedures.Register;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@USSN", SSN);
            Parameters.Add("@UsertypeI", UT);
            Parameters.Add("@FavHob", FH);
            Parameters.Add("@UserNameI", Username);
            Parameters.Add("@PassCodeI", PC);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object GetUserType(int SSN)
        {
            String StoredProcedureName = StoredProcedures.GetUserType;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object HowManyDoesHeManage(int SSN)
        {
            String StoredProcedureName = StoredProcedures.HowManyDoesHeManage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable HospitalsWithoutManagers()
        {
            String StoredProcedureName = StoredProcedures.HospitalsWithoutManagers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable RetrieveHosID()
        {
            String StoredProcedureName = StoredProcedures.RetrieveHosID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AssignManagerToHospital(int MSSN, int HID)
        {
            String StoredProcedureName = StoredProcedures.AssignManagerToHospital;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MSSN", MSSN);
            Parameters.Add("@HID", HID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object IsDocInADep(int SSN)
        {
            String StoredProcedureName = StoredProcedures.IsDocInADep;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int AssignDoctorToDepartment(int DSSN, int DID)
        {
            String StoredProcedureName = StoredProcedures.AssignDoctorToDepartment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DSSN", DSSN);
            Parameters.Add("@DID", DID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object IsNurseInAHospital(int SSN)
        {
            String StoredProcedureName = StoredProcedures.IsNurseInAHospital;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int AssignNurseToHospital(int NSSN, int HID)
        {
            String StoredProcedureName = StoredProcedures.AssignNurseToHospital;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NSSN", NSSN);
            Parameters.Add("@HID", HID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int NULLIT(int SSN)
        {
            String StoredProcedureName = StoredProcedures.NULLIT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int RegisterUpdate(int SSN, string UT, string PC, string UN, string FH)
        {
            String StoredProcedureName = StoredProcedures.RegisterUpdate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@USSN", SSN);
            Parameters.Add("@UsertypeI", UT);
            Parameters.Add("@PassCodeI", PC);
            Parameters.Add("@UserNameI", UN);
            Parameters.Add("@FavHob", FH);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ///////
        public int UpdateWeight(int PSSN, int Weight)
        {
            String StoredProcedureName = StoredProcedures.UWeight;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Weight", Weight);
            Parameters.Add("@PSSN", PSSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateHeight(int PSSN, int height)
        {
            String StoredProcedureName = StoredProcedures.UHeight;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@height", height);
            Parameters.Add("@PSSN", PSSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateBloodyType(int PSSN, String Bloodtype)
        {
            String StoredProcedureName = StoredProcedures.Ubloodtype;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bloodtype", Bloodtype);
            Parameters.Add("@PSSN", PSSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //////////////////////////////////////////////////////////////////
        public int AddComplaint(int HID, string complaint)
        {
            String StoredProcedureName = StoredProcedures.AddComplaint;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@HosID", HID);
            Parameters.Add("@complaint", complaint);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddXrayImage(int PSSN, byte[] imgSrc)
        {
            String StoredProcedureName = StoredProcedures.AddXrayImage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatSSN", PSSN);
            Parameters.Add("@imgSrc", imgSrc);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetXrayImage(int PSSN)
        {
            String StoredProcedureName = StoredProcedures.GetXrayImage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PatSSN", PSSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetHospitalNameAndID()
        {
            String StoredProcedureName = StoredProcedures.GetHospitalNameAndID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
    }
}
