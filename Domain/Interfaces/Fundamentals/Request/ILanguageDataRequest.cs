namespace Domain.Interfaces.Fundamentals.Request
{
    public interface ILanguageDataRequest<TForeignKeyType>
        where TForeignKeyType : struct
    {
       public TForeignKeyType KeyId { get; set; }
       public int LanguageId { get; set; }
    }
}
