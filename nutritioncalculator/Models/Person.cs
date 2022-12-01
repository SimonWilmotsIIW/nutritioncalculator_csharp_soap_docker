using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Person
    {
        private int _age;
        private string? _gender;
        private double _height;
        private double _weight;
        private int _numberOfTimesExercisePerWeek;

        [DataMember]
        public int Age
        {
            get => _age;
            set {
                _age = value;
            }
        }

        [DataMember]
        public string? Gender
        {
            get => _gender;
            set {
                _gender = value;
            }
        }

        [DataMember]
        public double Height
        {
            get => _height;
            set {
                _height = value;
            }
        }

        [DataMember]
        public double Weight
        {
            get => _weight;
            set {
                _weight = value;
            }
        }
        

        [DataMember]
        public int NumberOfTimesExercisePerWeek
        {
            get => _numberOfTimesExercisePerWeek;
            set {
                _numberOfTimesExercisePerWeek = value;
            }
        }

        public Person(int age, string? gender, double height, double weight, int numberOfTimesExercisePerWeek)
        {
            this.Age = age;
            this.Gender = gender;
            this.Height = height;
            this.Weight = weight;
            this.NumberOfTimesExercisePerWeek = numberOfTimesExercisePerWeek;

        }
    }
}