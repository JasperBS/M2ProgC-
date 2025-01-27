namespace Constructors03
{
    internal class Program
    {
        private void Run()
        { { QuizVraag quizVraag = new QuizVraag("Hoeveel ribben heeft een kubus", "12"); } }
        class QuizVraag
        {
            internal string vraag;
            internal string antwoord;

            internal QuizVraag(string vraag, string antwoord)
            { this.vraag = vraag;
                this.antwoord = antwoord;
            }
        }
        Program program = new Program();
        }
    }

