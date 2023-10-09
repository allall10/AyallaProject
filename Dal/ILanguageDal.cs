using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ILanguageDal
    {
        public List<LanguageTbl> GetLanguageAllAsync();
        public List<LanguageTbl> AddLanguageAsync(LanguageTbl language);
        public void UpdateLanguage(string id, LanguageTbl language);
        public void DeleteLanguage(string id);
        public LanguageTbl GetLanguageById(string id);
    }
}
