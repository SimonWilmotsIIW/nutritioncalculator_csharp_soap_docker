using System.ServiceModel;

namespace Models
{
    [ServiceContract]
    public interface IPersonServiceContract
    {
        [OperationContract]
        public Person registerPerson(int age, string? gender, double height, double weight, int numberOfTimesExercisePerWeek);

        [OperationContract]
        public double calculateProteinIntake(Person person);

        [OperationContract]
        public double calculateMaintenanceCalories(Person person);

        [OperationContract]
        public double calculateBMI(Person person);

        

    }
}