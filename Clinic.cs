using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class Doctor
    {
        public string name = "DoctorWho";
        public virtual void Heal()
        {
        }
    }
    class Surgeon : Doctor
    {
        public Surgeon()
        {
            name = "Surgeon";
        }
        public override void Heal()
        {
            Console.WriteLine("Heal surgeon");
        }
    }
    class Therapist : Doctor
    {
        public Therapist()
        {
            name = "Therapist";
        }
        public override void Heal()
        {
            Console.WriteLine("Heal therapist");
        }
    }
    class Dentist : Doctor
    {
        public Dentist()
        {
            name = "Dentist";
        }
        public override void Heal()
        {
            Console.WriteLine("Heal dentist");
        }
    }


    public class Patient
    {
        string name;
        Plan plan;
        Doctor doc;

        public Patient(string name, int planValue)
        {
            this.name = name;
            plan = new Plan(planValue);
            plan.value = planValue;
        }
        public void AppointDoctor()
        {
            if (plan.value == 1)
            {
                doc = new Surgeon();
            }
            else if (plan.value == 2)
            {
                doc = new Dentist();
            }
            else
            {
                doc = new Therapist();
            }
            doc.Heal();
        }

        public string GetPatientInfo()
        {
            StringBuilder str = new StringBuilder();
            str.Append("Patient name: ").AppendLine(name);
            str.Append("Patient heal plan: ").AppendLine(plan.value.ToString());
            str.Append("Doctor: ").AppendLine(doc.name);
            return str.ToString();
        }

    }
    class Plan
    {
        public int value;
        public Plan(int value)
        {
            this.value = value;
        }
    }
}



