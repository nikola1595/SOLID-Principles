namespace OCPLibary
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IAccounts AccountType { get; set; }
    }
}