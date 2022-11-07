namespace VotingPoint.Services
{
    public interface IDummyMailService
    {
        void SendMesaage(string to, string subject, string body);
    }
}