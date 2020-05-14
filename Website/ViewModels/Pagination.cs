using System;
using System.Web;

namespace Website.ViewModels
{
    public enum PaginationMode { PageNumbers, LoadMore }

    public class Pagination
    {
        public PaginationMode PaginationAs = PaginationMode.PageNumbers;

        public string LoadMoreLabel = "Load More";

        private string _baseUrl;
        private Uri _newUrl;

        /// <summary>
        /// Url to navigate to
        /// </summary>
        public string BaseUrl
        {
            set { _baseUrl = value; }
            get
            {
                return _baseUrl;
            }
        }

        /// <summary>
        /// Number of results per page
        /// </summary>
        public int ResultsPerPage = 3;

        /// <summary>
        /// Current page number
        /// </summary>
        public int CurrentPageNumber = 1;

        /// <summary>
        /// Total number of results
        /// </summary>
        public int TotalResults;

        /// <summary>
        /// Maximum number of results based on total results and number of results per page
        /// </summary>
        public int MaxResults
        {
            get
            {
                return (TotalResults/ResultsPerPage)*ResultsPerPage +
                       ((TotalResults%ResultsPerPage) > 0 ? ResultsPerPage : 0);
            }
        }

        /// <summary>
        /// Whether to use ? or & based on current ur
        /// </summary>
        public char QueryStringToken
        {
            get { return BaseUrl.ToString().LastIndexOf('?') > 0 ? '&' : '?'; }
        }

        private string _queryStringParam;

        public string QueryStringParam
        {
            get { return string.IsNullOrEmpty(_queryStringParam) ? "page" : _queryStringParam; }
            set { _queryStringParam = value; }
        }
    }
}
