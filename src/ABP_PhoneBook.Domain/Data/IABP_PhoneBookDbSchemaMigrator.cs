using System.Threading.Tasks;

namespace ABP_PhoneBook.Data;

public interface IABP_PhoneBookDbSchemaMigrator
{
    Task MigrateAsync();
}
