public class Patient
{
    private string fullName;
    private int age;
    private List<string> medicalHistory;

    public Patient(string fullName, int age, List<string> medicalHistory = null)
    {
        this.fullName = fullName;
        this.age = age;
        this.medicalHistory = medicalHistory ?? new List<string>();
    }

    public string GetFullName()
    {
        return fullName;
    }

    public void AddMedicalRecord(string record)
    {
        if (!string.IsNullOrWhiteSpace(record))
        {
            medicalHistory.Add(record);
        }
    }

    public List<string> GetMedicalHistory()
    {
        return new List<string>(medicalHistory); // копия списка
    }
}

public class Doctor
{
    private string fullName;
    private string specialty;
    private int experience;
    private List<Patient> patients;

    public Doctor()
    {
        fullName = "";
        specialty = "";
        experience = 0;
        patients = new List<Patient>();
    }

    public Doctor(string fullName, string specialty) : this()
    {
        this.fullName = fullName;
        this.specialty = specialty;
    }

    public Doctor(string fullName, string specialty, int experience) : this(fullName, specialty)
    {
        this.experience = experience;
    }

    private void RegisterPatient(Patient patient)
    {
        if (patient != null && !patients.Contains(patient))
        {
            patients.Add(patient);
        }
    }

    public string TreatPatient(Patient patient)
    {
        RegisterPatient(patient);
        return $"{fullName}, {specialty}, лечит пациента {patient.GetFullName()}";
    }

    public string PerformMedicalExamination(Patient patient)
    {
        RegisterPatient(patient);
        return $"{fullName} проводит медицинское обследование для пациента {patient.GetFullName()}";
    }

    public string PrescribeMedication(Patient patient, string medication)
    {
        RegisterPatient(patient);
        return $"{fullName} назначает {medication} пациенту {patient.GetFullName()}";
    }

    public void SetExperience(int years)
    {
        experience = years;
    }

    public int GetExperience()
    {
        return experience;
    }
}