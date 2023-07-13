namespace Develop05
{
    public class Rank
    {
        //I added this class to exceed the requirements for this assignment.
        //The user can advance in rank from Novice, Padawan Learner, Jedi, Jedi Night,
        //Jedi Master, and finaly Yoda based on how many points they have.
        public string GetRank(int points)
        {
            if (points <= 100)
            {
                return "Novice";
            }
            else if (points <= 200)
            {
                return "Padawan Learner";
            }
            else if (points <= 300)
            {
                return "Jedi";
            }
            else if (points <= 400)
            {
                return "Jedi Night";
            }
            else if (points <= 500)
            {
                return "Jedi Master";
            }
            else
            {
                return "Yoda";
            }
        }

        public void PromotionMessage(int newPoints, int points)
        {
            if (GetRank(newPoints) != GetRank(points))
            {
                Console.WriteLine($"You are now the rank of {GetRank(newPoints)}.");
            }
        }
    }
}