using git_build.Data;

namespace git_build.Logic
{
    public class NumService
    {
        private NumRep repo = new NumRep();

        public int GetProcessedNumber()
        {
            return repo.GetNumber() * 2;
        }
    }
}
