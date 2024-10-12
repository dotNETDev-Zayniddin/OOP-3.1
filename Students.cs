using System;
namespace OOP
{
    class Students
    {
        private Guid[] Id = new Guid[10];
        private string[] Name =
        {
            "Abdulazizov", "Abdusattorov", "Alijonova", "Azimova", 
            "Egamberdiyeva", "Esonaliyev", "Habibullayev", 
            "Hayitov", "Ibrohimov", "Bahromqulova" 
        };
        private string[] LastName = 
        {
            "Ismoil", "Abror", "Marjona", "Oygul",
            "Noila", "Odil","Abdulla",
            "Javohir", "Muhammad", "Dilso'z"

        };
        private int Class;
        private Grade[] Grades = new Grade[10];
        private enum Grade 
        {
            Two = 2,
            Three = 3,  
            Four = 4,
            Five = 5
        }
        public void BindGrade()
        {
           for(int i=0; i < Name.Length; i++)
           {
            Console.Write($"{i+1}) {LastName[i]} {Name[i]}: \t\t\t\t\t\t");
                        // Validating userInput with TryParse
            string userInput = Console.ReadLine();
            bool isValid;
            isValid = Enum.TryParse(userInput, out Grade grade) && (grade <= Grade.Five) && (grade >= Grade.Two);
            if(isValid)
            {
                Grades[i] = grade;
                Id[i] = Guid.NewGuid();
            }
            else
            {
                Console.WriteLine("Error Input. Please Try Again");
                i--;
            }
                          // Validating userInput with TryParse 
           }
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine("\nGUID\t\t\t\t\t\t\tName\t\t\t\t\tGrade");
            for(int i = 0; i < Name.Length; i++)
            System.Console.WriteLine($"{Id[i]}\t\t\t{LastName[i]} {Name[i]}\t\t\t\t{Grades[i]}");
        }
       //Tekislashga urundim lekin ayrim joylarda imkoni bo'lmadi
    }
}