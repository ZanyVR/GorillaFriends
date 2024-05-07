using System.IO;
using System.Net.Http;

namespace GorillaFriends
{
    class WebVerified
    {
        public const string m_szURL = "https://github.com/ZanyVR/repo4828333/blob/main/gorilla.verified";
        async public static void LoadListOfVerified()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(m_szURL);
            using (StringReader reader = new StringReader(result))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Main.m_listVerifiedUserIds.Add(line);
                }
            }
            client.Dispose();
        }
    }
}
