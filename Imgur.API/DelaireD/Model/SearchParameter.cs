using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelaireD.Model
{
    public class SearchParameter : IdParameter
    {
        public bool isSearch { get; set; }
        public bool isForceSearch { get; set; }
        public SearchType SearchType { get; set; }
        public string ExtraParam { get; set; } 
        public bool isChannel { get; set; }


        public SearchParameter()
        {
        }

        public SearchParameter(string searchValue, bool _isSearch, SearchType _searchType = SearchType.Categories, string _ExtraParam = "", bool _isChannel = false, bool _isForceSearch = false)
        {
            Id = searchValue;
            isSearch = _isSearch;
            SearchType = _searchType;
            ExtraParam = _ExtraParam;
            isChannel = _isChannel;
            isForceSearch = _isForceSearch;
        }
    }
}
