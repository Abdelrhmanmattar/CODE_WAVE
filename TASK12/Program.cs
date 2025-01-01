namespace DAY12
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Question> questions = new List<Question>
            {
                new Question("What is your name?", 10),
                new Question("What is your age?", 20),
                new Question("where are you from?", 30),
            };

            List<Answer> answers = new List<Answer>
            {
                new Answer(1,"John"),
                new Answer(3,"25"),
                new Answer(2,"USA"),
            };
            Dictionary<Question,Answer> exam_solution = new Dictionary<Question, Answer>();
            for (int i = 0; i < questions.Count; i++)
            {
                exam_solution.Add(questions[i], answers[i]);
            }
            foreach (var item in exam_solution)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine("=================================================================");
            }
            Console.ReadKey();
        }

    }

}