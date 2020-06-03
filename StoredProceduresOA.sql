USE HMDS

---------------------------------------------
-----		Patient data retrieval		-----
---------------------------------------------

--Check Patient Existance
GO
CREATE PROCEDURE CheckPatientExistence 
@Patient_SSN int
AS
BEGIN
SELECT count(*)
FROM Patient
WHERE P_SSN = @Patient_SSN
END

--Name
GO
CREATE PROCEDURE GetPatientName @Patient_SSN int
AS
BEGIN
SELECT Name
FROM Patient
WHERE P_SSN = @Patient_SSN
END

--Date of birth
Go
CREATE PROCEDURE GetPatientDob @Patient_SSN int
AS
BEGIN
SELECT DOB
FROM Patient
WHERE P_SSN = @Patient_SSN
END

--Gender
Go
CREATE PROCEDURE GetPatientGender @Patient_SSN int
AS
BEGIN
SELECT Gender
FROM Patient
WHERE P_SSN = @Patient_SSN
END

--Weight
Go
CREATE PROCEDURE GetPatientWeight @Patient_SSN int
AS
BEGIN
SELECT PWeight
FROM Patient
WHERE P_SSN = @Patient_SSN
END

--Height
Go
CREATE PROCEDURE GetPatientHeight @Patient_SSN int
AS
BEGIN
SELECT Height
FROM Patient
WHERE P_SSN = @Patient_SSN
END

--Blood Type
Go
CREATE PROCEDURE GetPatientBloodType @Patient_SSN int
AS
BEGIN
SELECT Blood_Type
FROM Patient
WHERE P_SSN = @Patient_SSN
END


--Chronic Disease
GO
CREATE PROCEDURE GetChronicDiseases @Patient_SSN int
AS
BEGIN
SELECT Disease_Name
FROM (MR_CronDisease AS MC JOIN Medical_Record AS MR ON MC.MR_ID = MR.MR_ID) JOIN Patient ON Pat_SSN = P_SSN
WHERE P_SSN = @Patient_SSN
END

GO
CREATE PROCEDURE AddChronicDisease
	@PatSSN  int, 
	@CHD_Name varchar(50)
AS
BEGIN
DECLARE  @R INT
SELECT @R = MR_ID
FROM Medical_Record
WHERE Pat_SSN = @PatSSN
INSERT INTO MR_CronDisease(MR_ID,Disease_Name)
Values (@R,@CHD_Name)
END

--Add X-ray to Patient
GO
CREATE PROCEDURE AddXrayImage
	@PatSSN  int, 
	@imgSrc image
AS
BEGIN
DECLARE  @R INT
SELECT @R = MR_ID
FROM Medical_Record
WHERE Pat_SSN = @PatSSN
INSERT INTO MR_xray_Analysis(MR_ID,XrA_Data)
Values (@R,@imgSrc)
END

--Records
GO
CREATE PROCEDURE GetRecords @Patient_SSN int
AS
BEGIN
SELECT D.Name,R_Date,Description
FROM ((MR_Recds AS MC JOIN Medical_Record AS MR ON MC.MR_ID = MR.MR_ID) JOIN Patient ON Pat_SSN = P_SSN) join Doctor As D ON Doc_SSN = D_SSN
WHERE P_SSN = @Patient_SSN
END

--Add Medical Record
GO
CREATE PROCEDURE AddMedRecord
	@PatSSN  int, 
	@R_Date date,
	@Description varchar(MAX), 
	@DocSSN int
AS
BEGIN
DECLARE  @R INT
SELECT @R = MR_ID
FROM Medical_Record
WHERE Pat_SSN = @PatSSN
INSERT INTO MR_Recds(MR_ID,R_Date,Description,Doc_SSN)
Values (@R,@R_Date,@Description,@DocSSN)
END

--Prescription
GO
CREATE PROCEDURE GetPrescription @Patient_SSN int
AS
BEGIN
SELECT M.Name,NoTimes,Notes
FROM Medicine AS M JOIN Pat_Takes_Med ON M_ID = Med_ID
WHERE Pat_SSN = @Patient_SSN
END

GO
CREATE PROCEDURE GetMedicineNameAndID
AS
BEGIN
SELECT Name,M_ID
FROM Medicine
END

--Update Prescription
GO
CREATE PROCEDURE AddMedToPat
	@PatSSN  int, 
	@MedID int,
	@NumOfTime varchar(50), 
	@Note varchar(50)
AS
BEGIN
INSERT INTO Pat_Takes_Med(Pat_SSN,Med_ID,NoTimes,Notes)
Values (@PatSSN,@MedID,@NumOfTime,@Note)
END

--Delete from Prescription
GO	
CREATE PROCEDURE DeleteFromPresc @PSSN int, @MID int
AS
BEGIN
Delete Pat_Takes_Med
WHERE Pat_SSN = @PSSN AND Med_ID = @MID
END

--Password Retrieval
GO
CREATE PROCEDURE RetrieveForgottenPass
@User_name varchar(50),
@FavHobby varchar(50)
AS
BEGIN
SELECT PassCode
FROM Registeration
WHERE @User_name=Username and @FavHobby=FavouriteHobby
END

--SSN Retrieval
GO
CREATE PROCEDURE RetrieveSSN
AS
BEGIN
SELECT SSN
FROM Registeration
END

--Username&Password Retrieval
GO
CREATE PROCEDURE RetrieveUserandPass
AS
BEGIN
SELECT Username,PassCode,SSN
FROM Registeration
END


--RetrieveCertainSSN
GO
CREATE PROCEDURE RetrieveCertainSSN
@UsernameI varchar(50)
AS
BEGIN
SELECT SSN
FROM Registeration
WHERE @UsernameI=Username
END

--Password Update
GO
CREATE PROCEDURE PasswordUpdate
@NewPass varchar(max),
@FavHob varchar(50)
AS
BEGIN
UPDATE Registeration
SET PassCode=@NewPass
WHERE FavouriteHobby = @FavHob
END
-------------Insertion-------------------
--Patient Info Insertion
GO
CREATE PROCEDURE InsertPatientInfo
@P_SSN int,
@Name varchar(50),
@City varchar(50),
@District varchar(50),
@Add_Line varchar(50),
@Gender char(1),
@PH_Number int,
@DOB date,
@Weight int,
@Height int,
@BloodType varchar(10)
AS
BEGIN
INSERT INTO Patient VALUES (@P_SSN,@Name,@City,@District,@Add_Line,@Gender,@PH_Number,@DOB,@Weight,@Height,@BloodType)
END

--Doctor Info Insertion
GO
CREATE PROCEDURE InsertDoctorInfo
@D_SSN int,
@Name varchar(50),
@City varchar(50),
@District varchar(50),
@Add_Line varchar(50),
@Gender char(1),
@PH_Number int,
@DOB date
AS
BEGIN
INSERT INTO Doctor (D_SSN,Name,City,District,Add_Line,Gender,Ph_number,DOB)
VALUES (@D_SSN,@Name,@City,@District,@Add_Line,@Gender,@PH_Number,@DOB)
END

--Nurse Info Insertion
GO
CREATE PROCEDURE InsertNurseInfo
@N_SSN int,
@Name varchar(50),
@City varchar(50),
@District varchar(50),
@Add_Line varchar(50),
@Gender char(1),
@PH_Number int,
@DOB date,
@Experience int
AS
BEGIN
INSERT INTO Nurse(N_SSN,Name,City,District,Add_Line,Gender,Ph_number,DOB,Experience)
VALUES (@N_SSN,@Name,@City,@District,@Add_Line,@Gender,@PH_Number,@DOB,@Experience)
END

--Manager Info Insertion
GO
CREATE PROCEDURE InsertManagerInfo
@M_SSN int,
@Name varchar(50),
@City varchar(50),
@District varchar(50),
@Add_Line varchar(50),
@Gender char(1),
@PH_Number int,
@DOB date
AS
BEGIN
INSERT INTO Manager(M_SSN,Name,City,District,Add_Line,Gender,Ph_number,DOB)
VALUES (@M_SSN,@Name,@City,@District,@Add_Line,@Gender,@PH_Number,@DOB)
END

--Register
GO
CREATE PROCEDURE Register
@USSN int,
@UsertypeI varchar(50),
@PassCodeI varchar(50),
@UserNameI varchar(50),
@FavHob varchar(50)
AS
BEGIN
INSERT INTO Registeration
VALUES(@USSN,@UsertypeI,@FavHob, @UserNameI, @PassCodeI)
END

--GetUserType
GO
CREATE PROCEDURE GetUserType
@SSN int
AS
BEGIN
SELECT UserType
FROM Registeration
WHERE SSN=@SSN
END

--HowManyDoesHeManage
GO
CREATE PROCEDURE HowManyDoesHeManage
@SSN int
AS
BEGIN
SELECT COUNT(*)
FROM Hospital
WHERE @SSN=Mang_SSN
END

--HospitalsWithoutManagers
GO
CREATE PROCEDURE HospitalsWithoutManagers
AS
BEGIN
SELECT Name,H_ID
FROM Hospital
WHERE Mang_SSN is null
END

--AddHospital
GO
CREATE PROCEDURE AddHospital
@HID int,
@name varchar(50),
@city varchar(50),
@district varchar(50),
@address varchar(50)
AS
BEGIN
INSERT INTO Hospital
VALUES(@HID,@name,@city,@district,@address,null)
END

--RetrieveHosID
GO
CREATE PROCEDURE RetrieveHosID
AS
BEGIN
SELECT H_ID
FROM Hospital
END

--AssignManagerToHospital
GO
CREATE PROCEDURE AssignManagerToHospital
@MSSN int,
@HID  int
AS
BEGIN
UPDATE Hospital
SET Mang_SSN=@MSSN
WHERE H_ID=@HID
END

--IsDocInADep
GO
CREATE PROCEDURE IsDocInADep
@SSN int
AS
BEGIN
SELECT COUNT(*)
FROM Doctor
WHERE @SSN=D_SSN and Dep_ID is not null
END

--AssignDoctorToDepartment
GO
CREATE PROCEDURE AssignDoctorToDepartment
@DSSN int,
@DID  int
AS
BEGIN
UPDATE Doctor
SET Dep_ID=@DID
WHERE @DSSN=D_SSN
END

--IsNurseInAHospital
GO
CREATE PROCEDURE IsNurseInAHospital
@SSN int
AS
BEGIN
SELECT COUNT(*)
FROM Nurse
WHERE @SSN=N_SSN and Hos_ID is not null
END

--AssignNurseToHospital
GO
CREATE PROCEDURE AssignNurseToHospital
@NSSN int,
@HID  int
AS
BEGIN
UPDATE Nurse
SET Hos_ID=@HID
WHERE @NSSN=N_SSN
END

--Nurse Staff (Functionalities)
GO
CREATE PROCEDURE Ubloodtype 
@bloodtype varchar(10),
@PSSN int
AS
BEGIN
Update Patient
Set  Blood_Type=@bloodtype
where P_SSN=@PSSN
END
GO

CREATE PROCEDURE UWeight 
@weight varchar(10),
@PSSN int
AS
BEGIN
Update Patient
Set  PWeight=@weight
where P_SSN=@PSSN
END
GO

CREATE PROCEDURE UHieght 
@height varchar(10),
@PSSN int
AS
BEGIN
Update Patient
Set  Height=@height
where P_SSN=@PSSN
END
GO

--Patient Sftaff (Functionalities)
GO
CREATE PROCEDURE AddComplaint
	@HosID  int, 
	@complaint varchar(50)
AS
BEGIN
DECLARE  @MangSSN INT
SELECT @MangSSN = Mang_SSN
FROM Hospital
WHERE H_ID = @HosID
INSERT INTO Hospital_Complaint(Mang_SSN,Complaint)
Values (@MangSSN,@complaint)
END

GO
CREATE PROCEDURE GetHospitalNameAndID
AS
BEGIN
SELECT Name,H_ID
FROM Hospital
END

GO
CREATE PROCEDURE GetXrayImage
	@PatSSN  int
AS
BEGIN
SELECT XrA_Data
FROM (MR_xray_Analysis as X inner join Medical_Record as M ON M.MR_ID = X.MR_ID) inner join Patient ON P_SSN = M.Pat_SSN
WHERE P_SSN = @PatSSN
END

--NULLIT
GO
CREATE PROCEDURE NULLIT
@SSN int
AS
BEGIN
UPDATE Registeration
SET Username=null
WHERE @SSN=SSN
END

--RegisterUpdate
GO
CREATE PROCEDURE RegisterUpdate
@USSN int,
@UsertypeI varchar(50),
@PassCodeI varchar(50),
@UserNameI varchar(50),
@FavHob varchar(50)
AS
BEGIN
UPDATE Registeration
SET Username=@UserNameI, PassCode=@PassCodeI, FavouriteHobby=@FavHob, UserType=@UsertypeI
WHERE @USSN=SSN
END