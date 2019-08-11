using System;
using System.Collections.Generic;

namespace translatorapp.DomainLayer.Interfaces
{
    public interface ITranslatorLogic
    {
        List<LanguageModel> GetLanguages();
    }

}