namespace Complaintform
{
    public class Program
    {
        static void Main(string[] args)
        {
            // INITIALISING OBJECTS
            
            //UI ui = new UI(); -Neo Code
            //ui.Run();


            QuestionReader Reader = new QuestionReader();

            // DEFINING UTILITY VARIABLES

            string question;

            // MAIN LOOP
            while (Reader.GetIndex() <= Reader.GetMaxLength())
            {
                question = Reader.Read();
            }


        }
    }
}