namespace Complaintform
{
    public class Program
    {
        static void Main(string[] args)
        {
            // INITIALISING OBJECTS
            
            UI Ui = new UI(); //-Neo Code
            //ui.Run();


            QuestionReader Reader = new QuestionReader();

            // DEFINING UTILITY VARIABLES

            string question;
            string answer;

            // MAIN LOOP
            while (Reader.GetIndex() <= Reader.GetMaxLength())
            {
                question = Reader.Read();
                answer = Ui.Ask(question); // !!!Neo bitte mach d antwort so

            }


        }
    }
}