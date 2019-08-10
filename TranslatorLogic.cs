using System;
using System.Collections.Generic;

namespace translatorapp.DomainLayer
{
    public class TranslatorLogic
    {
        public List<LanguageModel> GetLanguages()
        {
            var languageList = new List<LanguageModel>(){
                new LanguageModel {LanguageCode = "ru", Language = "Russian"},
                new LanguageModel {LanguageCode = "en", Language = "English"},
                new LanguageModel {LanguageCode = "eu", Language = "Basque"}
            };

            return languageList;
        }
    }
}
