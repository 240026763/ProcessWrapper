namespace ProcessWrapper
{
    public class ProcessUtilityFactory
    {
        public virtual IProcessUtility CreateProcessUtility()
        {
            return new ProcessUtility();
        }
    }
}
