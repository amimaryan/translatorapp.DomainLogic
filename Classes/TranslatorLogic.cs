using System;
using System.Collections.Generic;
using translatorapp.DomainLayer.Interfaces;

namespace translatorapp.DomainLayer.Classes
{
    public class TranslatorLogic : ITranslatorLogic
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
