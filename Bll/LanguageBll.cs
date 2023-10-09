using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
using Entity;
using AutoMapper;

namespace Bll
{
    public class LanguageBll
    {
        ILanguageDal _languageDal;
        private readonly IMapper _mapper;
        public LanguageBll(ILanguageDal languageDal, IMapper mapper)
        {
            this._languageDal = languageDal;
            _mapper = mapper;
        }
        public List<LanguageTblDto> AddLanguageAsync(LanguageTblDto language)
        {
            this._languageDal.AddLanguageAsync(_mapper.Map<LanguageTbl>(language));
            return GetLanguageAllAsync();

        }

        public void DeleteLanguage(string id)
        {
            this._languageDal.DeleteLanguage(id);
        }

        public List<LanguageTblDto> GetLanguageAllAsync()
        {
            return _mapper.Map<List<LanguageTblDto>>(this._languageDal.GetLanguageAllAsync());
        }

        public LanguageTblDto GetLanguageById(string id)
        {
            return _mapper.Map<LanguageTblDto>(this._languageDal.GetLanguageById(id));
        }

        public void UpdateLanguage(string id, LanguageTblDto language)
        {
            this._languageDal.UpdateLanguage(id, _mapper.Map<LanguageTbl>(language));
        }
      
    }
}

