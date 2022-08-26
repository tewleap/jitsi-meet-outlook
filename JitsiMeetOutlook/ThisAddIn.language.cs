using System;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;

namespace JitsiMeetOutlook
{
    public partial class ThisAddIn
    {
        private JsonElement languageJsonRoot;

        private void readLanguageJson()
        {
            try
            {
                byte[] jsonFile = findJson(Properties.Settings.Default.language);
                string jsonString = Encoding.UTF8.GetString(jsonFile);

                JsonDocument document = JsonDocument.Parse(jsonString);
                languageJsonRoot = document.RootElement;
            }
            catch (Exception)
            {
                //Do nothing
            }

        }

        private byte[] findJson(string language)
        {
            var languages = new Dictionary<string, byte[]>(7)
            {
                { "sv", Resources.languages.sv },
                { "en", Resources.languages.en },
                { "de", Resources.languages.de },
                { "fr", Resources.languages.fr },
                { "ru", Resources.languages.ru },
                { "es", Resources.languages.es },
                { "cz", Resources.languages.cz }
            };

            if (languages.ContainsKey(language))
            {
                return languages[language];
            }
            else
            {
                return null;
            }
        }

        public JsonElement getLanguageJsonRoot()
        {
            return languageJsonRoot;
        }

        public string getElementTranslation(string jsonGroup, string jsonElement)
        {
            return languageJsonRoot.GetProperty(jsonGroup).GetProperty(jsonElement).GetString();
        }

    }

}
