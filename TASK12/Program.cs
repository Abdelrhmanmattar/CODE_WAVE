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
                new Answer(1,"John"),new Answer(2,"ALI"),
                new Answer(1,"25"),new Answer(2,"25"),
                new Answer(1,"USA"),new Answer(2,"EGYPT")
            };
            Dictionary<Question,List<Answer>> exam_solution = new Dictionary<Question, List<Answer>>();
            for (int i = 0; i < questions.Count; i++)
            {
                exam_solution.Add(questions[i], new List<Answer> { answers[2 * i], answers[2 * i + 1] });
            }
            foreach (var item in exam_solution)
            {
                Console.WriteLine(item.Key);
                foreach(var ans in item.Value)
                {
                    Console.WriteLine(ans);
                }
                Console.WriteLine("=================================================================");
            }
            Console.ReadKey();
        }

    }

}