namespace Models
{
    public class PersonService : IPersonServiceContract
    {
        public Person registerPerson(int age, string? gender, double height, double weight, int numberOfTimesExercisePerWeek)
        {
            return new Person(age, gender, height, weight, numberOfTimesExercisePerWeek);   
        }
        public double calculateProteinIntake(Person person) 
        {
            switch (person.NumberOfTimesExercisePerWeek)
            {
                case <= 2:
                    return person.Weight * 1;
                case <= 4:
                    return person.Weight * 1.3;
                case >= 5:
                    return person.Weight * 1.6;
            }
        }   

        public double calculateMaintenanceCalories(Person person)
        {
            if (person.Gender == null || person.Gender.ToLower() == "male" || person.Gender.ToLower() == "m")
                return 66 + (13.7 * person.Weight) + (5 * person.Height) - (6.8 * person.Age);
            else 
                return 665 + (9.6 * person.Weight) + (1.8 * person.Height) - (4.7 * person.Age);   
        }

        public double calculateBMI(Person person)
        {
            return (person.Weight / Math.Pow(person.Height, 2)) * 10000;
        }

    }
}