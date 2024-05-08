CREATE TABLE Patients (
    Id INT PRIMARY KEY,
    Name VARCHAR(255) -- Assuming a maximum length for the patient's name
);

CREATE TABLE Doctors (
    Id INT PRIMARY KEY,
    Name VARCHAR(255), -- Adjust length as needed
    InTime TIME, -- SQL Server TIME type to store the doctor's in time
    OutTime TIME -- SQL Server TIME type to store the doctor's out time
);

CREATE TABLE Appointments (
    Id INT PRIMARY KEY,
    AppointmentTime TIME, -- SQL Server TIME type to store the appointment time
    DoctorId INT, -- Foreign key referencing the Doctor table
    PatientId INT, -- Foreign key referencing the Patient table
    CONSTRAINT FK_DoctorId FOREIGN KEY (DoctorId) REFERENCES Doctors(Id),
    CONSTRAINT FK_PatientId FOREIGN KEY (PatientId) REFERENCES Patients(Id)
);

