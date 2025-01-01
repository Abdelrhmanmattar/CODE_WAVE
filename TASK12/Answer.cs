namespace DAY12
{
    public class Answer
    {
        public int num { get; set; }
        public string choiceText { get; set; }
        public Answer(int _num, string _choiceText)
        {
            this.num = _num;
            this.choiceText = _choiceText;
        }
        public override string ToString()
        {
            return $"Answer: {num})\tChoice: {choiceText}";
        }
    }
}
