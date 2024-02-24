namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class QuizQuestion(string question, List<string> option, string answer)
        {
            public stirng 
        }

        private List<QuizQuestion> quizQuestions;
        private int currentQuestionIndex = 0;
        private List<System.Windows.Forms.RadioButton> radioButtons;

        private void IntializeQuizQuestions()
        {
            quizQuestions = new List<QuizQuestion>
            {
                new QuizQuestion ("What is the capital of France?", new List<string> {"Berlin", "London", "Paris", "Madrid"}, "Paris"),
                new QuizQuestion ("Which city is known as the 'Big Apple'?", new List<string> {"New Belhi", "Los Angeles", "New York", "Sydney"}, "Paris"),
                new QuizQuestion ("What is the capital of Japan?", new List<string> {"Beijing", "Seoul", "Tokyo", "Bangkok"}, "Tokyo")
            };
        }

        private void InitializeRadioButtons ()
        {
            radioButtons = new List<System.Windows.Forms.RadioButton>
            {
                option1RadioButton, option2RadioButton, option3RadioButton, option4RadioButton
            };

            foreach (System.Windows.Forms.RadioButton radioButton in radioButtons)
            {
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
            }
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
