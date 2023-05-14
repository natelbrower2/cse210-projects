namespace Develop02
{
    ///The responsibility of an Entry is to store a prompt, response and date.
    public class Entry
    {
        public string prompt;
        public string response;
        public string date;
        public string GetPrompt()
        {
            return prompt;
        }

        public string GetResponse()
        {
            return response;
        }

        public string GetDate()
        {
            return date;
        }

        public void StorePrompt(string prompt)
        {

            this.prompt = prompt;
        }

        public void StoreResponse(string response)
        {
            this.response = response;
        }

        public void StoreDate(string date)
        {
            this.date = date;
        }
    }
}