namespace Domain.Interfaces.Fundamentals.Request
{
    public interface IGetsLanguageDataRequest<TForeignKeyType>
        where TForeignKeyType : struct
    {
       public TForeignKeyType? KeyId { get; set; }
       public int? LanguageId { get; set; }
    }
}
