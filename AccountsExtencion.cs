using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoginForm
{
    public static class AccountsExtencion
    {
        public static void GetAccounts(this List<Account> accounts, string fileName)
        {
            using var reader = new StreamReader(fileName);

            if (reader.ReadToEnd() == "")
            {
                MessageBox.Show("Empty sourse!");
                return;
            }

            if(accounts !=  null) {accounts.Clear();}
            
            string json = reader.ReadToEnd();

            accounts = JsonSerializer.Deserialize<List<Account>>(json);
        }

        public static void SetAccounts(this List<Account> accounts, string fileName)
        {
            using var writer = new StreamWriter(fileName);

            writer.Write(JsonSerializer.Serialize<List<Account>>(accounts));
        }
    }
}
