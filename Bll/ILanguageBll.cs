using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;

namespace Bll
{
    public interface ILanguageBll
    {
        public List<LanguageTblDto> GetLanguageAllAsync();
        public List<LanguageTblDto> AddLanguageAsync(LanguageTblDto language);
        public void UpdateLanguage(string id, LanguageTblDto language);
        public void DeleteLanguage(string id);
        public LanguageTblDto GetLanguageById(string id);
    }
}









