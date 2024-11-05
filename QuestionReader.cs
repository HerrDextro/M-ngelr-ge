namespace Complaintform
{
    public class QuestionReader
    {

        private string[] questions;
        private int index = 0;

        public QuestionReader()
        {
            questions = File.ReadAllLines(@"..\..\Repos\M-ngelr-ge\questions.txt");
        }
        
        public int GetIndex()
        {
            return index;
        }
        public int GetMaxLength()
        {
            return questions.Length;
        }
        
        public string Read()
        {
            index++;
            return questions[index-1];
        }
        
    }
}