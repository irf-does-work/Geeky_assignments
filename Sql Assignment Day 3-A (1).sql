-- Healthcare System Schema

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY,
    PatientName VARCHAR(100),
    DateOfBirth DATE,
    Gender VARCHAR(10)
);

CREATE TABLE Doctors (
    DoctorID INT PRIMARY KEY,
    DoctorName VARCHAR(100),
    Specialty VARCHAR(100)
);

CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY,
    PatientID INT,
    DoctorID INT,
    AppointmentDate DATE,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);

CREATE TABLE Medications (
    MedicationID INT PRIMARY KEY,
    MedicationName VARCHAR(200),
    DosageForm VARCHAR(50)
);

CREATE TABLE Prescriptions (
    PrescriptionID INT PRIMARY KEY,
    PatientID INT,
    MedicationID INT,
    PrescriptionDate DATE,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (MedicationID) REFERENCES Medications(MedicationID)
);



-- 1. List all patients and their appointments, including patients who have never had an appointment.
SELECT * FROM Patients p LEFT JOIN Appointments a ON p.PatientID = a.PatientID;

-- 2. Display all doctors and their scheduled appointments, including doctors without any appointments.
SELECT * FROM Doctors d LEFT JOIN Appointments a ON d.DoctorID = a.DoctorID;

-- 3. Show all medications and the patients they've been prescribed to, including medications that haven't been prescribed.
SELECT * FROM Medications m LEFT JOIN Prescriptions p ON p.MedicationID = m.MedicationID;

-- 4. List all possible patient-doctor combinations, regardless of whether an appointment has occurred.
SELECT * FROM Patients CROSS JOIN Doctors;

-- 5. Display all prescriptions with patient and medication information, including prescriptions where either the patient or medication information is missing.
SELECT * FROM Prescriptions pr LEFT JOIN Medications m ON pr.MedicationID =m.MedicationID LEFT JOIN Patients pa ON pr.PatientID=pa.PatientID ;

-- 6. Show all patients who have never been prescribed any medication, along with their appointment history.
SELECT * FROM Patients pa LEFT JOIN Prescriptions pr ON pa.PatientID = pr.PatientID LEFT JOIN Appointments a ON pa.PatientID = a.PatientID WHERE pr.PrescriptionID IS NULL;

-- 7. List all doctors who have appointments in the next week, along with the patients they're scheduled to see.
SELECT * FROM Doctors d JOIN Appointments a ON d.DoctorID = a.DoctorID JOIN Patients p ON p.PatientID = a.PatientID WHERE (datepart(week,a.AppointmentDate)=datepart(week,GETDATE())+1);

-- 8. Display all medications prescribed to patients over 60 years old, including medications not prescribed to this age group.
SELECT pr.PatientID,pa.PatientName,m.MedicationID,m.MedicationName FROM  Prescriptions pr JOIN Medications m ON pr.MedicationID = m.MedicationID JOIN Patients pa ON pa.PatientID = pr.PatientID WHERE YEAR(pa.DateOfBirth)<YEAR(GETDATE())-60;

-- 9. Show all appointments from last year and any associated prescription information.
SELECT * FROM Appointments a JOIN Prescriptions pr ON a.PatientID = pr.PatientID WHERE YEAR(AppointmentDate) = YEAR(GETDATE())-1;

-- 10. List all possible specialty-medication combinations, regardless of whether a doctor of that specialty has prescribed that medication.
SELECT d.DoctorName, d.Specialty, m.MedicationName FROM Medications m CROSS JOIN Doctors d;
