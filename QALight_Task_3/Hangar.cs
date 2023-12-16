namespace QALight_Task_3
{
    public static class Hangar 
    {
        public static void AddFlyingTransport(IFlyable counter)
        {
            counter.RegisterFlyingTransport();
            
        }
    }
}