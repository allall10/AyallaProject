using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class LanguageDal 
    {
        WorkContext _context;
        public LanguageDal(WorkContext context)
        {
            this._context = context;
        }
        public List<LanguageTbl> AddBusinessAsync(LanguageTbl language)
        {
            this._context.Language.AddAsync(language);
            this._context.SaveChanges();
            return GetLanguageAllAsync();
        }

        public void DeleteLanguage(string id)
        {
            var language = this._context.Language.First(x => x.LanguageId == id);
            this._context.Language.Remove(language);
            this._context.SaveChanges();
        }

        public List<LanguageTbl> GetLanguageAllAsync()
        {
            return this._context.Language.ToList();
        }

        public LanguageTbl GetLanguageById(string id)
        {
            return this._context.Language.First(x => x.LanguageId == id);
        }

        public void UpdateLanguage(string id, LanguageTbl language)
        {
            var language1 = this._context.Language.FirstOrDefault(x => x.LanguageId != id);
            if (language1 != null)
            {
                language1.Discription = language.Discription;
            }
            this._context.SaveChanges();
        }
        
    }
}
